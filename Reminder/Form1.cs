using Reminder.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reminder.Model;
using Reminder.Config;

namespace Reminder
{
    public partial class MainForm : Form
    {

        private TreeNode currentNode;
        private List<ReminderData> notifications;
        private Notification notification;
        private bool isShowing = false;

        public bool isChanged = false;
        public static MainForm instance;
        public Manager manager;

        public MainForm()
        {
            InitializeComponent();
            instance = this;
            manager = new Manager();
            FileManager.readData();
            FileManager.ReadSettings();
            displayNotesLeft();
            iconTray.Icon = new Icon("icon.ico");
            iconTray.Text = "Reminder";
            addContextMenu();
            notifications = new List<ReminderData>();
            notification = new Notification();
            changeSkin(Manager.DataList.Settings.Skin);
        }

        public void displayNotesLeft()
        {
            tree1.Nodes.Clear();
            int arrange = manager.arrangeNotes();
            if (Manager.DataList.Data.Count > 0)
            {
                if (arrange == 1 || arrange == 0)
                {
                    DateTime start = Manager.DataList.Data[0].AlarmDate;
                    TreeNode node;
                    if (start.CompareTo(new DateTime(1970, 1, 1)) == 0)
                    {
                        node = tree1.Nodes.Add("No time needed");
                    } else
                    node = tree1.Nodes.Add(Manager.DataList.Data[0].AlarmDate.Month + " - " + Manager.DataList.Data[0].AlarmDate.Year);
                    foreach (ReminderData note in Manager.DataList.Data)
                    {
                        if (note.AlarmDate.Month == start.Month && note.AlarmDate.Year == start.Year)
                        {
                            TreeNode childNode = node.Nodes.Add(note.Title);
                            childNode.Tag = note;
                        } else
                        {
                            if (note.AlarmDate.CompareTo(new DateTime(1970, 1, 1)) == 0)
                            {
                                node = tree1.Nodes.Add("No time needed");
                            }
                            else
                                node = tree1.Nodes.Add(note.AlarmDate.Month + " - " + note.AlarmDate.Year);
                            TreeNode childNode = node.Nodes.Add(note.Title);
                            childNode.Tag = note;
                            start = note.AlarmDate;
                        }
                    }
                }
                else if (arrange == 2 || arrange == 3)
                {
                    int start = Manager.DataList.Data[0].Priority;
                    TreeNode node;
                    node = tree1.Nodes.Add(Manager.DataList.Data[0].Priority + "");
                    foreach (ReminderData note in Manager.DataList.Data)
                    {
                        if (note.Priority == start)
                        {
                            TreeNode childNode = node.Nodes.Add(note.Title);
                            childNode.Tag = note;
                        }
                        else
                        {
                            node = tree1.Nodes.Add(note.Priority + "");
                            TreeNode childNode = node.Nodes.Add(note.Title);
                            childNode.Tag = note;
                            start = note.Priority;
                        }
                    }
                }
            }
        }

        private void printContent()
        {
            ReminderData note = (ReminderData)currentNode.Tag;
            if (note != null)
            {
                txtContent.Clear();
                txtTitle.Text = note.Title;
                txtContent.Text = note.Content + "\n";
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
                ReminderData note = (ReminderData)currentNode.Tag;
                if (note.Content != txtContent.Text)
                {
                    note.Content = txtContent.Text;
                }
                if (note.Title != txtTitle.Text)
                {
                    note.Title = txtTitle.Text;
                }
            }
            try
            {
                FileManager.writeData(Manager.DataList.Data);
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
                ReminderData currentNote = (ReminderData)currentNode.Tag;
                if (currentNote.AlarmDate.CompareTo(new DateTime(1970, 1, 1)) > 0)
                {
                    TimeSpan timeleft = currentNote.AlarmDate - DateTime.Now;
                    if (DateTime.Now.CompareTo(currentNote.AlarmDate) >= 0)
                    {
                        txtTimeLeft.Text = "Overdue " + timeleft.Days + " Days " + -timeleft.Hours + " hours " + -timeleft.Minutes + " minutes " + -timeleft.Seconds;
                    } else
                    txtTimeLeft.Text = timeleft.Days + " Days " + timeleft.Hours + " hours " + timeleft.Minutes + " minutes " + timeleft.Seconds;
                } else
                {
                    txtTimeLeft.Clear();
                }
            }
            foreach (ReminderData note in Manager.DataList.Data)
            {
                DateTime now = DateTime.Now;
                now = now.AddTicks(-(now.Ticks % TimeSpan.TicksPerSecond));
                if (note.TimeNeed && now.CompareTo(note.AlarmDate) >= 0 && !isShowing)
                {
                    if (note.AlarmStatus == (int) AlarmStatusEnum.Alarmed)
                    {
                        if (!note.SnoozeNeed || (now.Ticks - note.AlarmDate.Ticks) % note.SnoozeTime.Ticks == 0)
                            notifications.Add(note);
                    }
                    else if (note.AlarmStatus == (int)AlarmStatusEnum.New)
                    {
                        notifications.Add(note);
                        if (note.SnoozeNeed)
                        {
                            note.AlarmStatus = (int) AlarmStatusEnum.Alarmed;
                        } else
                        {
                            note.AlarmStatus = (int)AlarmStatusEnum.Showed;
                        }
                    }
                }
                
            }
            if (notifications.Count != 0 && !isShowing)
            {
                iconTray.BalloonTipText = "You have incoming events: \n";
                foreach (ReminderData note2 in notifications)
                {
                    iconTray.BalloonTipText += note2.Title + "\n";
                }
                iconTray.ShowBalloonTip(500);
                iconTray.BalloonTipClicked += new EventHandler(notifier_Click);
                iconTray.BalloonTipClosed += IconTray_BalloonTipClosed;
                isShowing = true;
            }
        }

        private void IconTray_BalloonTipClosed(object sender, EventArgs e)
        {
            this.isShowing = false;
            notifications.Clear();
        }

        private void notifier_Click(object sender, EventArgs e)
        {
            notification.show(notifications);
            notification.Show();
            foreach (var item in notifications)
            {
                item.AlarmStatus = (int)AlarmStatusEnum.Showed;
            }
            FileManager.writeData(Manager.DataList.Data);
            Manager.DataList.Data.Clear();
            FileManager.readData();
            notifications.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure want to delete this note?", "Confirm delete", MessageBoxButtons.YesNo);
            if (r == DialogResult.OK)
            {
                if (currentNode != null)
                {
                    TreeNode parentNode = currentNode.Parent;
                    Manager.DeleteData((ReminderData)currentNode.Tag);
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
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isChanged)
            {
                DialogResult res = MessageBox.Show("Save changes?", "Save change", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    FileManager.writeData(Manager.DataList.Data);
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
                ReminderData note = (ReminderData)currentNode.Tag;
                SettingNode settingNode = new SettingNode();
                settingNode.manager = this.manager;
                settingNode.setText(note);
                settingNode.Show();
            }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm setting = new SettingForm();
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
