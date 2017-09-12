using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Rekursion(1, 10);
            Rekursion(-1,-10);
        }

        static void Rekursion(int from, int to)
        {   
            Console.WriteLine(from);
            if (from==to)
            {
                return;
            }
            if (from<to)
            {
                from += 1;
                Rekursion(from, to);
            }
            else
            {
                from -= 1;
                Rekursion(from, to);
            }
            
        }
    }
}
