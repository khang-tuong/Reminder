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
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
        }

        public void show(List<Note> notes)
        {
            int y = 0;
            foreach (Note note in notes)
            {
                Panel panel = new Panel(); panel.BorderStyle = BorderStyle.FixedSingle; panel.Width = 506; panel.BackColor = Color.White;
                Label lbTitle = new Label(); lbTitle.Text = note.title; lbTitle.Location = new Point(0, 0); lbTitle.ForeColor = Color.Red;
                Label lbContent = new Label(); lbContent.Text = note.content; lbContent.Location = new Point(30, 30); lbContent.ForeColor = Color.Blue;
                y += 100;

                panel.Controls.Add(lbTitle);
                panel.Controls.Add(lbContent);

                panelMain.Controls.Add(panel);

            }
        }

    }
}
