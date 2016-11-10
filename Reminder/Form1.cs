using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder
{
    public partial class MainForm : Form
    {

        private TreeNode currentNode;
        private List<Note> notifications;
        private Notification notification;
        private bool isShowingNoti = false;

        public bool isChanged = false;
        public static MainForm instance;
        public Manager manager;

        public MainForm()
        {
            InitializeComponent();
            instance = this;
            manager = new Manager();
            manager.readFile();
            displayNotesLeft();
            iconTray.Icon = new Icon("icon.ico");
            iconTray.Text = "Reminder";
            addContextMenu();
            notifications = new List<Note>();
            notification = new Notification();
            changeSkin(manager.settings[3][1]);
        }

        public void displayNotesLeft()
        {
            tree1.Nodes.Clear();
            int arrange = manager.arrangeNotes();
            if (manager.notes.Count != 0)
            {
                if (arrange == 1 || arrange == 0)
                {
                    DateTime start = manager.notes[0].date;
                    TreeNode node;
                    if (start.CompareTo(new DateTime(1970, 1, 1)) == 0)
                    {
                        node = tree1.Nodes.Add("No time needed");
                    } else
                    node = tree1.Nodes.Add(manager.notes[0].date.Month + " - " + manager.notes[0].date.Year);
                    foreach (Note note in manager.notes)
                    {
                        if (note.date.Month == start.Month && note.date.Year == start.Year)
                        {
                            TreeNode childNode = node.Nodes.Add(note.title);
                            childNode.Tag = note;
                        } else
                        {
                            if (note.date.CompareTo(new DateTime(1970, 1, 1)) == 0)
                            {
                                node = tree1.Nodes.Add("No time needed");
                            }
                            else
                                node = tree1.Nodes.Add(note.date.Month + " - " + note.date.Year);
                            TreeNode childNode = node.Nodes.Add(note.title);
                            childNode.Tag = note;
                            start = note.date;
                        }
                    }
                }
                else if (arrange == 2 || arrange == 3)
                {
                    int start = manager.notes[0].priority;
                    TreeNode node;
                    node = tree1.Nodes.Add(manager.notes[0].priority + "");
                    foreach (Note note in manager.notes)
                    {
                        if (note.priority == start)
                        {
                            TreeNode childNode = node.Nodes.Add(note.title);
                            childNode.Tag = note;
                        }
                        else
                        {
                            node = tree1.Nodes.Add(note.priority + "");
                            TreeNode childNode = node.Nodes.Add(note.title);
                            childNode.Tag = note;
                            start = note.priority;
                        }
                    }
                }
            }
        }

        private void printContent()
        {
            Note note = (Note)currentNode.Tag;
            if (note != null)
            {
                txtContent.Clear();
                txtTitle.Text = note.title;
                txtContent.Text = note.content + "\n";
                timer1_Tick(null, new EventArgs());
            }
        }

        public void addOK()
        {
            isChanged = true;
            lbStatus.Text = "Added!";
        }

        public void addContextMenu()
        {
            MenuItem[] menu = new MenuItem[1];
            menu[0] = new MenuItem("Add");
            menu[0].Click += new System.EventHandler(menuAdd_Click);
            iconTray.ContextMenu = new ContextMenu(menu);
        }

        public void changeSkin(string name)
        {
            ColorConverter convert = new ColorConverter();
            if (name == "Dark")
            {
                this.BackColor = lbStatus.BackColor = (Color)convert.ConvertFromString("#404040");
                txtContent.BackColor = txtTitle.BackColor = tree1.BackColor = (Color)convert.ConvertFromString("#232323");
                txtContent.ForeColor = txtTitle.ForeColor = tree1.ForeColor = Color.White;
                btnAdd.ForeColor = btnRemove.ForeColor = 
                    btnSettings.ForeColor = lbTimeLeft.ForeColor = lbStatus.ForeColor = Color.White;
            }
            else if (name == "Normal")
            {
                this.BackColor = Color.White;
                txtContent.BackColor = txtTitle.BackColor = tree1.BackColor = lbStatus.BackColor = Color.White;
                txtContent.ForeColor = txtTitle.ForeColor = tree1.ForeColor = Color.Black;
                btnAdd.ForeColor = btnRemove.ForeColor =
                    btnSettings.ForeColor = lbTimeLeft.ForeColor = Color.Black;
                lbStatus.ForeColor = Color.Red;
            }
        }

        //Events

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.manager = this.manager;
            addForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.manager = this.manager;
            addForm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentNode != null)
            {
                Note note = (Note)currentNode.Tag;
                if (note.content != txtContent.Text)
                {
                    note.content = txtContent.Text;
                }
                if (note.title != txtTitle.Text)
                {
                    note.title = txtTitle.Text;
                }
            }
            try
            {
                manager.writeFile();
                isChanged = false;
                lbStatus.Text = "Saved!";
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }

        private void tree1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.GetNodeCount(false) == 0)
            {
                btnSettings.Enabled = true;
                settingsToolStripMenuItem.Enabled = true;
                currentNode = e.Node;
                printContent();
            } else
            {
                settingsToolStripMenuItem.Enabled = false;
                btnSettings.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentNode != null && currentNode.GetNodeCount(false) == 0)
            {
                Note currentNote = (Note)currentNode.Tag;
                if (currentNote.date.CompareTo(new DateTime(1970, 1, 1)) > 0)
                {
                    TimeSpan timeleft = currentNote.date - DateTime.Now;
                    if (DateTime.Now.CompareTo(currentNote.date) >= 0)
                    {
                        txtTimeLeft.Text = "Overdue " + timeleft.Days + " Days " + -timeleft.Hours + " hours " + -timeleft.Minutes + " minutes " + -timeleft.Seconds;
                    } else
                    txtTimeLeft.Text = timeleft.Days + " Days " + timeleft.Hours + " hours " + timeleft.Minutes + " minutes " + timeleft.Seconds;
                } else
                {
                    txtTimeLeft.Clear();
                }
            }
            foreach (Note note in manager.notes)
            {
                if (!note.isNotified && DateTime.Now.CompareTo(note.alarmDate) >= 0 && note.date.CompareTo(new DateTime(1970, 1, 1)) > 0)
                {
                    notifications.Add(note);
                    note.isNotified = true;
                }
                
            }
            if (notifications.Count != 0 && !isShowingNoti)
            {
                iconTray.BalloonTipText = "You have incoming events: \n";
                foreach (Note note2 in notifications)
                {
                    iconTray.BalloonTipText += note2.title + "\n";
                }
                iconTray.ShowBalloonTip(500);
                iconTray.BalloonTipClicked += new EventHandler(notifier_Click);
                isShowingNoti = true;
            }
        }

        private void notifier_Click(object sender, EventArgs e)
        {
            notification.show(notifications);
            notification.Show();
            manager.writeFile();
            manager.notes.Clear();
            manager.readFile();
            notifications.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (currentNode != null)
            {
                TreeNode parentNode = currentNode.Parent;
                manager.notes.Remove((Note)currentNode.Tag);
                tree1.Nodes.Remove(currentNode);
                currentNode = tree1.Nodes[0];
                txtContent.Clear(); txtTimeLeft.Clear();
                lbStatus.Text = "Removed!";
                if (parentNode.GetNodeCount(false) == 0)
                {
                    tree1.Nodes.Remove(parentNode);
                }
                isChanged = true;
            } else
            {
                lbStatus.Text = "Nothing to remove!";
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isChanged)
            {
                DialogResult res = MessageBox.Show("Save changes", "Save change", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    manager.writeFile();
                }
                else if (res == DialogResult.No)
                {
                    e.Cancel = false;
                } else
                {
                    e.Cancel = true;
                }
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                iconTray.Visible = true;
                this.Hide();
            }
        }

        private void iconTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void iconTray_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                iconTray.ContextMenu.Show(null, new Point(0, 0));
            } 
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            addToolStripMenuItem_Click(sender, e);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settingsToolStripMenuItem_Click(sender, e);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentNode != null)
            {
                Note note = (Note)currentNode.Tag;
                SettingNode settingNode = new SettingNode();
                settingNode.manager = this.manager;
                settingNode.setText(note);
                settingNode.Show();
            }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.manager = this.manager;
            setting.setUp();
            setting.Show();
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeSkin("Dark");
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeSkin("Normal");
        }
    }
}
