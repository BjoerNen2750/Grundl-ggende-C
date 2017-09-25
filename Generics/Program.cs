using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personer = new List<Person>();
            personer.Add(new Person() { Id = 1, Navn = "Berrit" });
            personer.Add(new Person() { Id = 2, Navn = "Andreas" });
            personer.Add(new Person() { Id = 1, Navn = "Asbjørn" });
            foreach (var item in personer)
            {
                Console.WriteLine(item.Navn);
            }

            Bunke b = new Bunke();
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });
            b.Vis();

            var k = b.FjernKort();
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();
            b.Vis();

            int a = 10;
            int c = 20;
            Swap<int>(ref a, ref c);


        }

        class Person
        {
            public int Id { get; set; }
            public string Navn { get; set; }
        }
        public class Kort
        {
            public string Kulør { get; set; }
            public int Værdi { get; set; }
            public override string ToString()
            {
                return this.Kulør + " " + this.Værdi;
            }
        }
        class Bunke
        {
            private Stack<Kort> bunke = new Stack<Kort>();
            public Kort FjernKort() { 
             if (bunke.Count > 0)
                    return bunke.Pop();
                return null;
                            }
            public void TilføjKort(Kort kort)
            {
                this.bunke.Push(kort);
            }
            public void Vis()
            {
                foreach (var item in bunke)
                {
                    Console.WriteLine(item.ToString());
                }
            }
           

        }
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;

        }
    }
}
