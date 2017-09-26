using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde k = new Kunde() { KreditMax = -500 };
            k.KreditOverskredet += (s, e) => { Console.WriteLine("Kredit overskredet med {0}", k.KreditMax - k.Saldo); };
            k.Køb(100);
            k.Køb(500);
            //Console.WriteLine("Kredet overskredet med {0}",KreditMax-this.Saldo)
            ;
        }
        class Kunde
        {
            public event EventHandler KreditOverskredet;

            public string Navn { get; set; }
            public int Saldo { get; set; }
            public int KreditMax { get; set; }
            public void Køb(int værdi)
            {
                Console.WriteLine("Kunder {0} køber for {1}", Navn, værdi);
                this.Saldo -= værdi;
                if (this.Saldo < KreditMax)
                {
                    if (KreditOverskredet != null)
                    {
                        KreditOverskredet(this, new EventArgs());
                    }
                }
            }
        }
    }
}
