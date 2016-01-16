using System;

namespace Pr03SummerTimeForProgrammers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int outAirSize = n / 2;
            string outAir = new string(' ', outAirSize);
            string cap = new string('*', n + 1);
            Console.WriteLine("{0}{1}", outAir, cap);

            int innerAirSize = n - 1;
            string innerAir = new string(' ', innerAirSize);
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine("{0}*{1}*", outAir, innerAir);
            }

            for (int i = 0; i < n / 2 - 1; i++)
            {
                innerAirSize += 2;
                outAirSize--;
                outAir = new string(' ', outAirSize);
                innerAir = new string(' ', innerAirSize);
                Console.WriteLine("{0}*{1}*", outAir, innerAir);
            }

            string foam = new string('.', n * 2 - 2);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("*{0}*", foam);
            }

            string beer = new string('@', n * 2 - 2);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("*{0}*", beer);
            }

            string bottom = new string('*', n * 2);
            Console.WriteLine(bottom);
        }
    }
}
