using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reminder.Config;

namespace Reminder.Model
{
    [Serializable]
    public class ReminderData
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime AlarmDate { get; set; }
        public bool TimeNeed { get; set; }
        public int Priority { get; set; }
        public bool SnoozeNeed { get; set; }
        public TimeSpan SnoozeTime { get; set; }
        public int AlarmStatus { get; set; }

        public ReminderData(string title, string content, DateTime alarmDate, bool timeNeed, int priority, bool snoozeNeed, TimeSpan snoozeTime)
        {
            this.Title = title;
            this.Content = content;
            this.AlarmDate = alarmDate;
            this.TimeNeed = timeNeed;
            this.Priority = priority;
            this.SnoozeNeed = snoozeNeed;
            this.SnoozeTime = snoozeTime;
            this.AlarmStatus = (int) AlarmStatusEnum.New;
        }
    }
}
