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
using Reminder.Controller;
using Reminder.Config;

namespace Reminder
{
    public partial class SettingNode : Form
    {
        public bool isTimeNeeded;
        public Manager manager = null;
        private ReminderData currentNote;

        public SettingNode()
        {
            InitializeComponent();
            this.ActiveControl = txtTitle;
            lbContent.ForeColor = Color.Red;
            lbTime.ForeColor = Color.Red;
            lbTitle.ForeColor = Color.Red;
            addPriority();
        }


        public void addPriority()
        {
            cbxPriority.Items.Add("- Priority - (1 is max)");
            for (int i = 1; i <= 10; i++)
            {
                cbxPriority.Items.Add(i + "");
            }
        }


        public bool checkDate()
        {
            int priority = cbxPriority.SelectedIndex;

            if (txtTitle.Text == "Title")
            {
                lbNotification.Text = "Please enter a title!\n";
            }
            if (priority == 0)
            {
                lbNotification.Text = "Please select priority";
            }

            return lbNotification.Text == "";
        }


        public void setText(ReminderData note)
        {
            currentNote = note;
            txtTitle.Text = note.Title;
            txtContent.Text = note.Content;
            cbxPriority.SelectedIndex = note.Priority;
            this.isTimeNeeded = note.TimeNeed;
            if (note.AlarmDate.CompareTo(new DateTime(1970, 1, 1)) != 0)
            {
                this.dateTimePicker.Value = note.AlarmDate;
                this.cbxSnoozeNeed.Checked = note.SnoozeNeed;
                this.txtSnoozeTime.Text = note.SnoozeTime.Minutes.ToString();
            } else
            {
                btnDontNeedTime_Click(null, null);
            }
        }

        private void needTime(bool value)
        {
            this.dateTimePicker.Enabled = value;
            this.txtSnoozeTime.Enabled = value;
            this.cbxSnoozeNeed.Checked = false;
        }

        //Events

        private void btnDontNeedTime_Click(object sender, EventArgs e)
        {
            if (btnDontNeedTime.Text == "Don't need time")
            {
                isTimeNeeded = false;
                needTime(false);
                btnDontNeedTime.Text = "Need time";
            }
            else
            {
                isTimeNeeded = true;
                needTime(true);
                btnDontNeedTime.Text = "Don't need time";
            }
        }

        private void txtContent_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtContent.Text == "Content")
            {
                txtContent.Clear();
            }
        }

        private void txtTitle_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtTitle.Text == "")
            {
                txtTitle.Text = "Title";
            }
        }

        private void txtTitle_MouseLeave(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                txtTitle.Text = "Title";
            }
        }

        private void txtContent_MouseLeave(object sender, EventArgs e)
        {
            if (txtContent.Text == "")
            {
                txtContent.Text = "Content";
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.lbNotification.Text = "";
            if (checkDate())
            {
                TimeSpan snoozeTime = new TimeSpan(0, 0, 0);
                DateTime alarmDate = new DateTime(1970, 1, 1);
                bool snoozeNeed = false;
                if (isTimeNeeded)
                {
                    snoozeNeed = this.cbxSnoozeNeed.Checked;
                    alarmDate = this.dateTimePicker.Value;
                    alarmDate = alarmDate.AddSeconds(-alarmDate.Second);
                    snoozeTime = new TimeSpan(0, int.Parse(txtSnoozeTime.Text), 0);
                }
                string title = txtTitle.Text;
                string content = txtContent.Text;
                int priority = cbxPriority.SelectedIndex;
                ReminderData data = new ReminderData(title, content, alarmDate, isTimeNeeded, priority, snoozeNeed, snoozeTime);
                data.Id = currentNote.Id;
                data.AlarmStatus = (int)AlarmStatusEnum.New;
                Manager.EditData(data);
                MainForm.instance.displayNotesLeft();
                MainForm.instance.addOK();
                this.Dispose();
            }
        }

        private void cbxSnoozeNeed_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbxSnoozeNeed.Checked)
            {
                this.txtSnoozeTime.Enabled = true;
            }
            else
            {
                this.txtSnoozeTime.Enabled = false;
            }
        }

        private void txtSnoozeTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
