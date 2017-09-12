using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();
        }
        class Terning
        {
            public int værdi;
            public bool snyd;
            private static Random rnd = new Random();
            public void Skriv()
            {
                Console.WriteLine(værdi);
            }
            public void Ryst()
            {
                if (this.snyd == false)
                {
                    this.værdi = rnd.Next(1, 7);
                }
                else
                {
                    this.værdi = 6;
                }
            }
            public Terning()
            {
                this.værdi = 1;
                this.snyd = false;
            }
            public Terning(bool snyd)
            {
                this.værdi = 1;
                this.snyd = snyd;
            }
        }
    }
}
