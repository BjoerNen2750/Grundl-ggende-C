using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseEksempler
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = null;
            p1 = new Person("Mikkel",14);
            Console.WriteLine(p1.ToString());
            p1.Udskriv();
            Dyr d1 = new Dyr("Fido", 4);
            Dyr d2 = new Dyr();

            Terning t = new Terning();
            t.Skriv();

            Terning t2 = new Terning(6);
            t2.Skriv();

            Bæger bæger = new Bæger();
        }
        public class Person
        {
            private string name;
            private int age;

            public Person()
            {
                name = "";
                age = 1;
            }
            public Person(string name, int age=1)
            {
                this.name = name;
                this.age = age;
            }
            public void Udskriv()
            {
                Console.WriteLine(name + " er " + age);
            } 

        }
        class Dyr
        {
            private string navn;
            private int antalBen;
            public Dyr(string navn, int antalBen)
            {
                this.navn = navn;
                this.antalBen = antalBen;
            }
            public Dyr() : this("",4)
            {

            }
        }
        public class Terning
        {
            private int værdi;
            private Random rnd = new Random();
            public Terning()
            {
                this.værdi = 1;
            }
            public Terning(int værdi)
            {   
                if (værdi>= 1 && værdi <=6)
                {
                    this.værdi = værdi;
                }
                else
                {   
                    this.værdi = 1;
                }
              
            }
            public void Skriv()
            {
                Console.Write("[" + this.værdi + "]");
            }
        }
        public class Bæger
        {
            private Terning[] terninger;
            public Bæger()
            {
                terninger = new Terning[5];
                for (int i = 0; i < 5; i++)
                {
                    terninger[i] = new Terning();
                }
            }
            public void Skriv()
            {
                foreach (var item in terninger)
                {
                    item.Skriv();
                }
            }

        }
    }
}
