using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Beregn(1, 2));
            Console.WriteLine(Beregn(1, 2, 3));
            Console.WriteLine(Beregn(1, 2, 3, 4));
        }

        static int Beregn(int a, int b)
        {
            return a + b;
        }
        static int Beregn(int a, int b, int c)
        {
            return Beregn(a, b) + c;
        }
        static int Beregn (int a, int b, int c, int d)
        {
            return Beregn(a, b, c) + d;
        }
    }
}
