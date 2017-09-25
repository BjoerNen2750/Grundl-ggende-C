using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgetInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] array = new IDbFunktioner[4];
            array[0] = new Hund();
            array[1] = new Ubåd();
            array[2] = new Ubåd();
            array[3] = new Hund();
            foreach (var item in array)
            {
                item.Gem();
            }
        }
    }
    class Hund :IDbFunktioner
    {
        public string Navn { get; set; }
        public void Gem()
        {
            Console.WriteLine("Gemmer hund...");
        }
    }
    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double   Tubine { get; set; }
        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd...");
        }

            }
    interface IDbFunktioner
    {
        void Gem();
    }
}
