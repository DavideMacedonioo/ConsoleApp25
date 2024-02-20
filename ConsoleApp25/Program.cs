using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(4,7);
            Vector b = new Vector(5,6);
            Vector somma = a + b;
            Console.WriteLine("vettore somma: a + b di componenti {0} {1}",somma.x, somma.y);
            //Vector differenza = a - b;
            //Console.WriteLine("vettore differenza: a - b di componenti {0} {1}", differenza.x, differenza.y);
            Console.WriteLine("vettore differenza: a - b ({0}) ",(a - b).ToString());
            Console.WriteLine("vettore +a : ({0})",(+a).ToString());
            Console.WriteLine("vettore -b : ({0})",(-b).ToString());
            Console.WriteLine("il prodotto scalare tra il vettore a e il vettore b è : {0}", (a * b).ToString());
            double z=4;
            Console.WriteLine("prodotto tra vettore a e scalare z : ({0})", (a * z).ToString());
            Console.WriteLine("prodotto tra scalare a e vettore z : ({0})", (z * b).ToString());
            Console.WriteLine("divisione tra vettore a e scalare z : ({0})", (a / z).ToString());

            Console.ReadLine();
        }
    }
}
