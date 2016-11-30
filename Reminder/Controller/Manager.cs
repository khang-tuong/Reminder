using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Reminder.Config;
using System.Runtime.Serialization.Formatters.Binary;
using Reminder.Model;
using Reminder.Controller;

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
                Manager.DataList.Data.Sort((x, y) => x.AlarmDate.CompareTo(y.AlarmDate));
                return 0;
            }
            if (byDate && !ascend)
            {
                Manager.DataList.Data.Sort((y, x) => x.AlarmDate.CompareTo(y.AlarmDate));
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

        public static void AddData(ReminderData data)
        {
            data.Id = DataList.Data.Count + 1;
            DataList.Data.Add(data);
            FileManager.writeData(DataList.Data);
        }

        public static void EditData(ReminderData data)
        {
            int length = DataList.Data.Count;
            for (int i = 0; i < length; i++)
            {
                if (DataList.Data[i].Id == data.Id) DataList.Data[i] = data;
            }
            FileManager.writeData(DataList.Data);
        }

        public static void DeleteData(ReminderData data)
        {
            ReminderData d = DataList.Data.SingleOrDefault(q => q.Id == data.Id);
            int id = d.Id;
            DataList.Data.Remove(d);
            for (int i = id - 1; i < DataList.Data.Count; i++)
            {
                --DataList.Data[i].Id;
            }
            FileManager.writeData(DataList.Data);
        }

    }

}
