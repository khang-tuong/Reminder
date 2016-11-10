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
    public partial class TaskbarNotifier : Form
    {
        public TaskbarNotifier()
        {
            InitializeComponent();
        }
        
        public void createMes(List<Note> notes)
        {
            int y = 0;
            foreach (Note note in notes)
            {
                Panel panel = new Panel(); panel.Location = new Point(0, y);
                TextBox txtTitle = new TextBox(); txtTitle.Text = note.title; txtTitle.Location = new Point(0, 0);
                TextBox txtContent = new TextBox(); txtContent.Text = note.content; txtContent.Location = new Point(0, 30);
                panel.Controls.Add(txtTitle); panel.Controls.Add(txtContent);
                panelMain.Controls.Add(panel);
                y += 100;
            }
        }

    }
}
