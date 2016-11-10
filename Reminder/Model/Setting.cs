using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder.Model
{
    [Serializable]
    public class Setting
    {
        public string DateTimeFormat { get; set; }
        public string TreeViewArrangeBy { get; set; } 
        public string TreeType { get; set; }
        public string Skin { get; set; }
    }
}
