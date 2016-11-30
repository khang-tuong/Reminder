using Reminder.Config;
using Reminder.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Reminder.Controller
{
    public class FileManager
    {
        public static void readData()
        {
            FileStream stream = null;
            try
            {
                stream = File.Open(Configuration.DATA_FILE_PATH, FileMode.OpenOrCreate, FileAccess.Read);
                if (stream.Length > 0)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Manager.DataList.Data = (List<ReminderData>)formatter.Deserialize(stream);
                }
            }
            catch (Exception e)
            {
                throw e;
            } finally
            {
                stream.Dispose();
                stream.Close();
            }

           
        }

        public static void ReadSettings()
        {
            FileStream stream = null;
            try
            {
                stream = File.Open(Configuration.SETTING_FILE_PATH, FileMode.OpenOrCreate, FileAccess.Read);
                if (stream.Length > 0)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Manager.DataList.Settings = (Setting)formatter.Deserialize(stream);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                stream.Dispose();
                stream.Close();
            }


        }

        public static void writeData(List<ReminderData> list)
        {
            try
            {
                FileStream stream = File.Open(Configuration.DATA_FILE_PATH, FileMode.Create, FileAccess.Write);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, list);
                stream.Dispose();
                stream.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
           
        }

        public static void writeSettings()
        {
            try
            {
                FileStream stream = File.Open(Configuration.SETTING_FILE_PATH, FileMode.Create, FileAccess.Write);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, Manager.DataList.Settings);
                stream.Dispose();
                stream.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
