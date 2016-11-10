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
    public partial class Setting : Form
    {
        public Manager manager;

        public Setting()
        {
            InitializeComponent();
            addTreeDateTimeFormat();
            addTreeType();
            addSkin();
        }

        private void addTreeDateTimeFormat()
        {
            cbxTreeArrangeBy.Items.Add("Date");
            cbxTreeArrangeBy.Items.Add("Priority");
        }

        private void addTreeType()
        {
            cbxTreeType.Items.Add("Ascend");
            cbxTreeType.Items.Add("Descend");
        }

        private void addSkin()
        {
            cbxSkin.Items.Add("Normal");
            cbxSkin.Items.Add("Dark");
        }

        public void setUp()
        {
            foreach (String[] setting in manager.settings)
            {
                if (setting[0] == "TreeViewArrangeBy")
                {
                    string tmp = setting[1];
                    cbxTreeArrangeBy.SelectedItem = tmp;
                }
                else if (setting[0] == "TreeType")
                {
                    string tmp = setting[1];
                    cbxTreeType.SelectedItem = tmp;
                }
                else if (setting[0] == "Skin")
                {
                    cbxSkin.SelectedItem = setting[1];
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string treeArrangeBy = (string)cbxTreeArrangeBy.SelectedItem;
            string treetype = (string)cbxTreeType.SelectedItem;
            manager.settings[1][1] = treeArrangeBy == "Date" ? "Date" : "Priority";
            manager.settings[2][1] = treetype == "Ascend" ? "Ascend" : "Descend";
            manager.settings[3][1] = (string)cbxSkin.SelectedItem;
            MainForm.instance.displayNotesLeft();
            MainForm.instance.changeSkin((string)cbxSkin.SelectedItem);
            manager.writeSettings();
            this.Dispose();
        }
    }
}
