using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder
{
    public class Note
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public bool isNotified;
        public int priority;
        public DateTime alarmDate;

        public Note(DateTime date, string title, string content, bool isNotified, int priority, DateTime alarmDate)
        {
            this.date = date;
            this.title = title;
            this.content = content;
            this.isNotified = isNotified;
            this.priority = priority;
            this.alarmDate = alarmDate;
        }

        public string toString()
        {
            string dateStr = date.Day + "/" + date.Month + "/" + date.Year + " " + date.Hour + ":" + date.Minute;
            string alarmDateStr = alarmDate.Day + "/" + alarmDate.Month + "/" + alarmDate.Year + " " + alarmDate.Hour + ":" + alarmDate.Minute;
            content = content.Replace("\r", "");
            content = content.Replace("\n", ";;;");
            return dateStr + "\n" + title + "\n" + content + "\n" + isNotified.ToString() + "\n" + priority + "\n" + alarmDateStr + "\n";
        }

    }
}
