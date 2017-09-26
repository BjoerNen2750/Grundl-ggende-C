using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            double res = Beregn(7.5, 2.5, Gange);
            Console.WriteLine(res);
            //Log logger = new Log(AppendLog);
            Action<string> logger = delegate (string txt) { System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n"); };
            logger += Console.WriteLine;
            logger.Invoke("min egen delegate");

            Maskine m = new Maskine();
            //m.logger = delegate (string txt) { System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n"); };
            m.logger = txt => System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
            m.logger += Console.WriteLine;
            m.Start();
            m.Slut();
        }

        public delegate void Log(string txt);
        //static void AppendLog(string txt)
        //{
        //    System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
        //}
        public delegate double MathOp(double a, double b);
        public static double Beregn(double a, double b, MathOp funktion)
        {
            return (funktion(a, b));
        }
        public static double Plus(double a, double b)
        {
            return a + b;
        }
        public static double Minus(double a, double b)
        {
            return a - b;
        }
        public static double Gange(double a, double b)
        {
            return a * b;
        }
        public static double Divider(double a, double b)
        {
            return a / b;
        }
        class Maskine
                    {
            public Action<string> logger { get; set; }
       
            public void Start()
            {
                logger("Maskinen starter... " + DateTime.Now);
                            }
            public void Slut()
            {
                logger("Maskinen slutter... " + DateTime.Now);
            }

        }
    
    }

      
 
  
}
