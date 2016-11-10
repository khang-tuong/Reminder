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
            addYear(); addMonth(); addDay(); addHour(); addMinute(); addPriority();
            addBeforeDays(); addBeforeHours(); addBeforeMinutes();
        }

        public void addYear()
        {
            cbxYear.Items.Add("- Year - ");
            int cur = DateTime.Now.Year;
            for (int i = cur; i < cur + 20; i++)
            {
                cbxYear.Items.Add(i + "");
            }
            cbxYear.SelectedIndex = 0;
        }

        public void addMonth()
        {
            cbxMonth.Items.Add("- Month -");
            for (int i = 1; i <= 12; i++)
            {
                cbxMonth.Items.Add(i + "");
            }
            cbxMonth.SelectedIndex = 0;
        }

        public void addDay()
        {
            cbxDay.Items.Add("- Day - ");
            for (int i = 1; i <= 31; i++)
            {
                cbxDay.Items.Add(i + "");
            }
            cbxDay.SelectedIndex = 0;
        }

        public void addHour()
        {
            cbxHour.Items.Add("- Hour -");
            for (int i = 0; i < 24; i++)
            {
                cbxHour.Items.Add(i + "");
            }
            cbxHour.SelectedIndex = 0;
        }

        public void addMinute()
        {
            cbxMinute.Items.Add("- Minute -");
            for (int i = 0; i < 60; i++)
            {
                cbxMinute.Items.Add(i + "");
            }
            cbxMinute.SelectedIndex = 0;
        }

        public void addPriority()
        {
            cbxPriority.Items.Add("- Priority - (1 is max)");
            for (int i = 1; i <= 10; i++)
            {
                cbxPriority.Items.Add(i + "");
            }
        }

        public void refreshDay()
        {
            string month = (string)cbxMonth.SelectedItem;
            string yearStr = (string)cbxYear.SelectedItem;
            int top;
            switch (month)
            {
                case "4": case "6": case "9": case "11": top = 30; break;
                case "2":
                    {
                        top = 28;
                        int year = Int16.Parse(yearStr);
                        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                        {
                            top = 29;
                        }
                    }
                    break;
                default: top = 31; break;
            }
            while (cbxDay.Items.Count > top)
            {
                cbxDay.Items.RemoveAt(cbxDay.Items.Count - 1);
            }
            while (cbxDay.Items.Count < top)
            {
                for (int i = cbxDay.Items.Count + 1; i <= top; i++)
                {
                    cbxDay.Items.Add(i + "");
                }
            }
        }

        public bool checkDate()
        {
            string year = (string)cbxYear.SelectedItem;
            string month = (string)cbxMonth.SelectedItem;
            string day = (string)cbxDay.SelectedItem;
            string hour = (string)cbxHour.SelectedItem;
            string minute = (string)cbxMinute.SelectedItem;
            int priority = cbxPriority.SelectedIndex;

            if ((year == "- Year -" || month == "- Month - " || day == "- Day -" || hour == "- Hour -" || minute == "- Minute -") && isTimeNeeded)
            {
                lbTime.Text = "Please choose a specific time!\n";
            }

            if (txtTitle.Text == "Title")
            {
                lbTitle.Text = "Please enter a title!\n";
            }
            if (txtContent.Text == "Content")
            {
                lbContent.Text = "Please enter the content!\n";
            }
            if (priority == 0)
            {
                lbPriority.Text = "Please select priority";
            }

            return lbContent.Text == "" && lbTime.Text == "" && lbTitle.Text == "" && lbPriority.Text == "";
        }

        private void addBeforeDays()
        {
            for (int i = 0; i < 31; i++)
            {
                this.cbxBeforeDays.Items.Add(i);
            }
            this.cbxBeforeDays.SelectedIndex = 0;
        }

        private void addBeforeHours()
        {
            for (int i = 0; i < 25; i++)
            {
                this.cbxBeforeHours.Items.Add(i);
            }
            this.cbxBeforeHours.SelectedIndex = 1;
        }

        private void addBeforeMinutes()
        {
            for (int i = 0; i < 61; i++)
            {
                this.cbxBeforeMinutes.Items.Add(i);
            }
            this.cbxBeforeMinutes.SelectedIndex = 0;
        }

        public void setText(ReminderData note)
        {
            currentNote = note;
            txtTitle.Text = note.Title;
            txtContent.Text = note.Content;
            cbxPriority.SelectedIndex = note.Priority;
            if (note.CreateDate.CompareTo(new DateTime(1970, 1, 1)) != 0)
            {
                TimeSpan tmp = note.CreateDate.Subtract(note.AlarmDate);
                isTimeNeeded = true;
                cbxYear.SelectedIndex = note.CreateDate.Year - DateTime.Now.Year + 1;
                cbxMonth.SelectedIndex = note.CreateDate.Month;
                cbxDay.SelectedIndex = note.CreateDate.Day;
                cbxHour.SelectedIndex = note.CreateDate.Hour + 1;
                cbxMinute.SelectedIndex = note.CreateDate.Minute + 1;
                cbxBeforeDays.SelectedIndex = tmp.Days;
                cbxBeforeHours.SelectedIndex = tmp.Hours + 1;
                cbxBeforeMinutes.SelectedIndex = tmp.Minutes + 1;
            } else
            {
                btnDontNeedTime_Click(null, null);
            }
        }

        //Events

        private void btnDontNeedTime_Click(object sender, EventArgs e)
        {
            if (btnDontNeedTime.Text == "Don't need time")
            {
                isTimeNeeded = false;
                cbxDay.Enabled = false; cbxMonth.Enabled = false; cbxYear.Enabled = false; cbxHour.Enabled = false; cbxMinute.Enabled = false;
                btnDontNeedTime.Text = "Need time";
            }
            else
            {
                cbxDay.Enabled = true; cbxMonth.Enabled = true; cbxYear.Enabled = true; cbxHour.Enabled = true; cbxMinute.Enabled = true;
                isTimeNeeded = true;
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
            lbTitle.Text = ""; lbTime.Text = ""; lbContent.Text = ""; lbPriority.Text = "";
            if (checkDate())
            {
                DateTime date = new DateTime(1970, 1, 1);
                DateTime alarmDate = new DateTime(1970, 1, 1);
                if (isTimeNeeded)
                {
                    string dateStr = (string)cbxDay.SelectedItem + "/" + (string)cbxMonth.SelectedItem + "/" + (string)cbxYear.SelectedItem + " " + (string)cbxHour.SelectedItem + ":" + (string)cbxMinute.SelectedItem;
                    date = Convert.ToDateTime(dateStr);
                    alarmDate = new DateTime(date.Year, date.Month, date.Day);

                    alarmDate.AddDays(-(int)cbxBeforeDays.SelectedItem);
                    alarmDate.AddHours(-(int)cbxBeforeHours.SelectedItem);
                    alarmDate.AddMinutes(-(int)cbxBeforeMinutes.SelectedItem);
                }
                string title = txtTitle.Text;
                string content = txtContent.Text;
                int priority = cbxPriority.SelectedIndex;
                Manager.DataList.Data.Remove(currentNote);
                currentNote = new ReminderData(title, content, date, alarmDate, isTimeNeeded, priority);
                Manager.DataList.Data.Add(currentNote);
                MainForm.instance.displayNotesLeft();
                MainForm.instance.addOK();
                this.Dispose();
            }
        }

        private void cbxDay_MouseClick(object sender, MouseEventArgs e)
        {
            refreshDay();
        }
    }
}
