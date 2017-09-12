using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpelKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine(p1.fornavn + " " + p1.efternavn + " " + p1.FuldNavn() + p1.Alder());

            Person p2 = new Person("asbjørn","jacobsen",1989);
            Console.WriteLine(p2.fornavn + " " + p2.efternavn + " " + p2.FuldNavn() + p2.Alder());


        }

    }
    class Person
    {
        public string fornavn;
        public string efternavn;
        public int fødselsår;
        public string FuldNavn()
        {
            return $"{ this.fornavn} {this.efternavn}$";
        }
        public int Alder()
        {
            return System.DateTime.Now.Year - this.fødselsår;
        }
        public Person()
        {
            this.fornavn = "";
            this.efternavn = "";
        }
        public Person(string fornavn, string efternavn, int fødselsår)
        {
            this.fornavn = fornavn.ToUpper();
            this.efternavn = efternavn.ToUpper();
            this.fødselsår = fødselsår;
        }
    }
}
