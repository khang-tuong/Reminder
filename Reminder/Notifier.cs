using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reminder.Model;

namespace Reminder
{
    public partial class Notifier : UserControl
    {
        public Notifier()
        {
            InitializeComponent();
        }

        public void createMes(List<ReminderData> notes)
        {
            int y = 0;
            foreach (ReminderData note in notes)
            {
                Panel panel = new Panel(); panel.Location = new Point(0, y);
                TextBox txtTitle = new TextBox(); txtTitle.Text = note.Title; txtTitle.Location = new Point(0, 0);
                TextBox txtContent = new TextBox(); txtContent.Text = note.Content; txtContent.Location = new Point(0, 30);
                panel.Controls.Add(txtTitle); panel.Controls.Add(txtContent);
                panelMain.Controls.Add(panel);
                y += 100;
            }
        }
    }
}
