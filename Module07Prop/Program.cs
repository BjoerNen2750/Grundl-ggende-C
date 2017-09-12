using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07Prop
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine(p1.getAlder());
            p1.setAlder(30);
            Console.WriteLine(p1.getAlder());

            Person2 p2 = new Person2();
            Console.WriteLine(p2.Alder);
            p2.Alder = 30;
            Console.WriteLine(p2.Alder);
        }
    }
    class Person
    {
        private int alder;
        public int getAlder()
        {
            return this.alder;
        }
        public void setAlder(int alder)
        {
            this.alder = alder;
        }

    }
    class Person2
    {
        private int alder;
        public int Alder
        {
            get
            {
                return this.alder;
            }
            set
            {
                this.alder = value; 
            }

        }

    }
}
