using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Terning t1 = new Terning(5);
            //Console.WriteLine(t1.Værdi);
            //t1.Ryst();
            //Console.WriteLine(t1.Værdi);

            //LudoTerning t2 = new LudoTerning();
            ////Console.WriteLine(t2.Værdi + " " + t2.ErGlobus() + " " + t2.ErStjerne());
            ////t2.Ryst();
            ////Console.WriteLine(t2.Værdi + " " + t2.ErGlobus() + " " + t2.ErStjerne());
            //t2.Ryst();
            //Console.WriteLine(t2.Værdi + " " + t2.ErGlobus() + " " + t2.ErStjerne());
            //t2.Ryst();
            //Console.WriteLine(t2.Værdi + " " + t2.ErGlobus() + " " + t2.ErStjerne());
            //t2.Ryst();
            //Console.WriteLine(t2.Værdi + " " + t2.ErGlobus() + " " + t2.ErStjerne());

            LudoTerning l = new LudoTerning();
            l.Skriv();

            Terning[] terninger = new Terning[4];
            terninger[0] = new Terning();
            terninger[1] = new LudoTerning();
            terninger[2] = new LudoTerning();
            terninger[3] = new Terning();
            foreach (var item in terninger)
            {
                item.Skriv();
            }
        }
    }
    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }
    }
    class Elev : Person
    {
        public string KlasseLokale { get; set; }
    }
    class Instruktør : Person
    {
        public int NøgleId { get; set; }
    }
    class Udvidetrandom : Random
    {
        public bool NextBool()
        {
            return this.Next(1, 1001) <= 500;
        }
    }
    class Terning
    {
        private int værdi;
        public int Værdi
        {
            get
            {
                //Console.WriteLine("Terning aflæses som " + this.værdi);
                return this.værdi;
            }
            set
            {
                if (1<= value && 6>= value)
                {
                    //Console.WriteLine("Terning tildeles værdien "+ value);
                    this.værdi = value;
                }
                else
                {
                    //Console.WriteLine("Terning tildeles værdien " + 1);
                    this.værdi = 1;
                }
                
            }
        }
        private static Random rnd = new Random();
        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }
        public virtual void Skriv()
        {
            Console.Write("[" + this.værdi + "]");
        }
        public Terning()
        {
            this.Ryst();
        }
        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }
    }
    class LudoTerning : Terning
    {
        public bool ErGlobus()
        {
            return this.Værdi == 3;
        }
        public bool ErStjerne()
        {
            return this.Værdi == 5;
        }
        public LudoTerning()
        {

        }
        public LudoTerning(int værdi) :base(værdi)
        {
            this.Værdi = værdi;
        }
        public override void Skriv()
        {
            if (ErStjerne())
            {
                Console.Write("[S]");
            }
            else if (ErGlobus())
            {
                Console.Write("[G]");
            }
            else
            {
                base.Skriv();
            }
            
        }
    }
}
