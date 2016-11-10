using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder.Model
{
    [Serializable]
    public class ReminderDataList
    {
        public List<ReminderData> Data = new List<ReminderData>();
        public Setting Settings = new Setting();

        public void AddData(ReminderData data)
        {
            this.Data.Add(data);
        }
    }
}
