using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Reminder
{
    public class Manager
    {
        
        private const string filename = @"D:\Coding\C#\Reminder\Reminder\data.txt"; //Please change after finishing the product
        private const int LINES = 7;

        public List<Note> notes = new List<Note>();
        public List<String[]> settings = new List<string[]>();
        public void test()
        {
            MainForm mainForm = MainForm.instance; 

        }

        public void readFile()
        {
            try
            {
                bool isAdded = false, isNotified = false;
                int line = 1, priority = 0;
                string title = null, content = null, s;
                DateTime date = DateTime.Now, alarmDate = DateTime.Now;
                StreamReader reader = new StreamReader(filename);
                while (!reader.EndOfStream)
                {
                    s = reader.ReadLine();
                    if ((line - 1) % LINES == 0)
                    {
                        isAdded = false;
                        date = Convert.ToDateTime(s);
                    }
                    else if ((line - 2) % LINES == 0)
                    {
                        title = s;
                    }
                    else if ((line - 3) % LINES == 0)
                    {
                        content = s;
                        content = content.Replace(";;;", "\r\n");
                    }
                    else if ((line - 4) % LINES == 0)
                    {
                        isNotified = Boolean.Parse(s);
                    }
                    else if ((line - 5) % LINES == 0)
                    {
                        priority = Int16.Parse(s);
                    }
                    else if ((line - 6) % LINES == 0)
                    {
                        alarmDate = Convert.ToDateTime(s);
                    }
                    else if (title != null)
                    {
                        isAdded = true;
                        Note note = new Note(date, title, content, isNotified, priority, alarmDate);
                        note.id = line / LINES - 1;
                        notes.Add(note);
                    }
                    ++line;
                }
                reader.Close();
                if (!isAdded && title != null)
                {
                    Note note = new Note(date, title, content, isNotified, priority, alarmDate);
                    note.id = line;
                    notes.Add(note);
                }
                reader = new StreamReader(@"D:\Coding\C#\Reminder\Reminder\controls.ini");
                while (!reader.EndOfStream)
                {
                    s = reader.ReadLine();
                    char[] spliter = new char[1]; spliter[0] = '=';
                    string[] tmp = s.Split(spliter);
                    string[] result = new string[2]; result[0] = tmp[0].Trim(); result[1] = tmp[1].Trim();
                    this.settings.Add(result);
                }
                reader.Close();
                
                
            }
            catch (FileNotFoundException)
            {
                throw new Exception("File not found");
            }
            catch (FormatException)
            {
                throw new Exception("Date format error!");
            }
        }

        public void writeFile()
        {
            try
            {
                StreamWriter writer = new StreamWriter(filename);
                foreach (Note note in notes)
                {
                    writer.WriteLine(note.toString());
                }
                writer.Close();
            }
            catch (Exception)
            {
                throw new Exception("File writing error!");
            }
        }

        public void writeSettings()
        {
            StreamWriter writer = new StreamWriter(@"D:\Coding\C#\Reminder\Reminder\controls.ini");
            foreach (String[] setting in settings)
            {
                writer.WriteLine(setting[0] + " = " + setting[1]);
            }
            writer.Close();
        }

        public int arrangeNotes()
        {
            return arrangeNotes(settings[1][1] == "Date" ? true : false, settings[2][1] == "Ascend" ? true : false);
        }

        public int arrangeNotes(bool byDate, bool ascend)
        {
            if (byDate && ascend)
            {
                notes.Sort((x, y) => x.date.CompareTo(y.date));
                return 0;
            }
            if (byDate && !ascend)
            {
                notes.Sort((y, x) => x.date.CompareTo(y.date));
                return 1;
            }
            if (!byDate && ascend)
            {
                notes.Sort((x, y) => x.priority.CompareTo(y.priority));
                return 2;
            }
            if (!byDate && !ascend)
            {
                notes.Sort((y, x) => x.priority.CompareTo(y.priority));
                return 3;
            }
            return -1;
        }


    }

}
