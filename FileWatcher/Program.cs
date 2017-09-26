using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp","*.txt");
            w.EnableRaisingEvents = true;
            w.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.Size;
            w.Changed += (s,e) => Console.WriteLine(e.Name + " " + DateTime.Now);
            do
            {

            } while (true);

        }

    }
}
