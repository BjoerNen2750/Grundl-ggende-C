using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSettings
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = GetAppSetting("ip", "127.0.0.1");
            Console.WriteLine(ip);
            int maxrecord = GetAppSettingGeneric<int>("maxrecords", 100);
            Console.WriteLine(maxrecord.ToString());
        }
        static string GetAppSetting(string key, string defaultValue)
        {
            if (System.Configuration.ConfigurationManager.AppSettings[key].Length > 0)
                return System.Configuration.ConfigurationManager.AppSettings[key];
            return defaultValue;
        }
        static T GetAppSettingGeneric<T>(string key, T defaultValue)
        {
            string v = System.Configuration.ConfigurationManager.AppSettings[key];
            if (v.Length > 0)
                return (T)Convert.ChangeType(v, typeof(T));
            return defaultValue;
        }
    }

}
