using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder.Model
{
    [Serializable]
    public class ReminderData
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime AlarmDate { get; set; }
        public bool TimeNeed { get; set; }
        public int Priority { get; set; }

        public ReminderData(string title, string content, DateTime createDate, DateTime alarmDate, bool timeNeed, int priority)
        {
            this.Title = title;
            this.Content = content;
            this.CreateDate = createDate;
            this.AlarmDate = alarmDate;
            this.TimeNeed = timeNeed;
            this.Priority = priority;
        }
    }
}
