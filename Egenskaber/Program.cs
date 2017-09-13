using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant tre = new Trekant(4, 3);
            Console.WriteLine(tre.Areal);

            Vare v1 = new Vare("Køler", 975);

            Vare v2 = new Vare();
            v2.Navn = "Køler";
            v2.Pris = 975.55;
            Console.WriteLine(v2.PrisMedMons());

            Person p1 = new Person();
            p1.Fornavn = "Asbjørn";
            p1.Efternavn = "Jacobsen";
            Console.WriteLine(p1.Fuldnavn());

            Console.WriteLine(ArealBeregninger.BeregnArealFirkant(10, 10));

            Console.WriteLine(ArealBeregninger.BeregnArealCirkel(10));
        }
        class Trekant
        {
            public int Grundlinje { get; private set; }
            public int Højde { get; private set; }
            public Trekant(int Grundlinje, int Højde)
            {
                this.Grundlinje = Grundlinje;
                this.Højde = Højde;
            }
            public double Areal
            {
                get
                {
                   return this.Grundlinje * this.Højde * 0.5;
                }
            }
            
        }
        class Vare
        {
            private string navn;
            public string Navn
            {
                get
                {
                    Console.WriteLine("Nu aflæses navn");
                    return this.navn;
                }
                set
                {
                    Console.WriteLine("Nu tildeles navn");
                    this.navn = value;
                }
            }
            private double pris;
            public double Pris
            {
                get
                {
                    Console.WriteLine("Nu aflæses pris");
                    return this.pris;
                }
                set
                {
                    Console.WriteLine("Nu tildeles pris");
                    this.pris = value;
                }
            }
            public Vare()
            {

            }
            public Vare(string navn, double pris)
            {
                this.navn = navn;
                this.pris = pris;
            }
            public double PrisMedMons()
            {
                return this.pris * 1.25;
            }
        }
        class Person
        {
            public string Fornavn { get; set; }
            private string efternavn;

            public string Efternavn
            {
                get { return efternavn; }
                set
                {
                    if (value.Length >= 3)
                    {
                        efternavn = value;
                    }
                    else
                    {
                        Console.WriteLine("Efternavn for kort, minimum 3 karakterer");
                        efternavn = "";
                    }
                }
            }
            public string Fuldnavn()
            {
                return this.Fornavn + " " + this.efternavn;
            }
            
        }
        static class ArealBeregninger
        {
            static public double BeregnArealFirkant(double højde, double brede)
            {
                return højde * brede;
            }
            static public double BeregnArealCirkel(double radius)
            {
                return Math.PI * radius * radius;
            }
        }
    }
}
