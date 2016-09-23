using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_satsen
{
    class Program
    {
        static void Main(string[] args)
        { //Övning 1
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            //Övning 2
            for (int x = 20; x >= 1; x=x-1)
            {
                Console.WriteLine(x);
            }
            //Övning 3
            for (int y = 0; y <= 50; y=y+2)
            {
                Console.WriteLine(y);
            }
            //Övning 2.1
            
            Console.WriteLine("Mata in start:");
            string in1 = Console.ReadLine();
            int start = int.Parse(in1);
            Console.WriteLine("Mata in stop:");
            string in2 = Console.ReadLine();
            int stop = int.Parse(in2);
            Console.WriteLine("Mata in steg");
            string in3 = Console.ReadLine();
            int steg = int.Parse(in3);

            var q = start;
            var w = stop;
            var e = steg;

            for ( q = 0; q < w; q=q + e)
            {
                Console.WriteLine(q);
            }
            //Övning 2.3


        }
    }
}
