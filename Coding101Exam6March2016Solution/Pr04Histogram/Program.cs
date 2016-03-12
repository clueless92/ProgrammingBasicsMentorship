using System;

namespace Pr04Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0d;
            var p2 = 0d;
            var p3 = 0d;
            var p4 = 0d;
            var p5 = 0d;


            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1++;
                }
                else if (num < 400)
                {
                    p2++;
                }
                else if (num < 600)
                {
                    p3++;
                }
                else if(num < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            Console.WriteLine("{0:f2}%", p1 / n * 100);
            Console.WriteLine("{0:f2}%", p2 / n * 100);
            Console.WriteLine("{0:f2}%", p3 / n * 100);
            Console.WriteLine("{0:f2}%", p4 / n * 100);
            Console.WriteLine("{0:f2}%", p5 / n * 100);
        }
    }
}
