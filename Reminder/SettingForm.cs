using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reminder.Controller;

namespace Reminder
{
    public partial class SettingForm : Form
    {
        public Manager manager;

        public SettingForm()
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
            cbxTreeArrangeBy.SelectedItem = Manager.DataList.Settings.TreeViewArrangeBy;
            cbxTreeType.SelectedItem = Manager.DataList.Settings.TreeType;
            cbxSkin.SelectedItem = Manager.DataList.Settings.Skin;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string treeArrangeBy = (string)cbxTreeArrangeBy.SelectedItem;
            string treetype = (string)cbxTreeType.SelectedItem;
            Manager.DataList.Settings.TreeViewArrangeBy = treeArrangeBy == "Date" ? "Date" : "Priority";
            Manager.DataList.Settings.TreeType = treetype == "Ascend" ? "Ascend" : "Descend";
            Manager.DataList.Settings.Skin = (string)cbxSkin.SelectedItem;
            MainForm.instance.displayNotesLeft();
            MainForm.instance.changeSkin((string)cbxSkin.SelectedItem);
            FileManager.writeSettings();
            this.Dispose();
        }
    }
}
