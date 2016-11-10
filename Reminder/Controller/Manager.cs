using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Reminder.Config;
using System.Runtime.Serialization.Formatters.Binary;
using Reminder.Model;

namespace Reminder
{
    public class Manager
    {
        
        private const int LINES = 7;

        public static ReminderDataList DataList = new ReminderDataList();

        public int arrangeNotes()
        {
            return arrangeNotes(Manager.DataList.Settings.TreeViewArrangeBy == "Date" ? true : false, Manager.DataList.Settings.TreeType == "Ascend" ? true : false);
        }

        public int arrangeNotes(bool byDate, bool ascend)
        {
            if (byDate && ascend)
            {
                Manager.DataList.Data.Sort((x, y) => x.CreateDate.CompareTo(y.CreateDate));
                return 0;
            }
            if (byDate && !ascend)
            {
                Manager.DataList.Data.Sort((y, x) => x.CreateDate.CompareTo(y.CreateDate));
                return 1;
            }
            if (!byDate && ascend)
            {
                Manager.DataList.Data.Sort((x, y) => x.Priority.CompareTo(y.Priority));
                return 2;
            }
            if (!byDate && !ascend)
            {
                Manager.DataList.Data.Sort((y, x) => x.Priority.CompareTo(y.Priority));
                return 3;
            }
            return -1;
        }


    }

}
