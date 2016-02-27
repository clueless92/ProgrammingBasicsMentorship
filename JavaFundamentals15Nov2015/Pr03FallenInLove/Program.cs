using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr03FallenInLove
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sideDotsCount = n * 2;
            int midDotsCount = 0;
            int fintifliushkaCount = 0;

            string sideDots = new string('.', sideDotsCount);
            string midDots = new string('.', midDotsCount);
            string fintifliushka = new string('~', fintifliushkaCount);

            for (int i = 0; i <= n; i++)
            {
                if (i != n)
                {
                    Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#", fintifliushka, sideDots, midDots);

                    sideDotsCount -= 2;
                    sideDots = new string('.', sideDotsCount);

                    fintifliushkaCount++;
                    fintifliushka = new string('~', fintifliushkaCount);

                    midDotsCount += 2;
                    midDots = new string('.', midDotsCount);
                }
                else
                {
                    Console.WriteLine(".#{0}#{1}#{0}#.", fintifliushka, midDots);
                }
            }

            sideDotsCount += 3;
            midDotsCount -= 2;
            fintifliushkaCount--;

            sideDots = new string('.', sideDotsCount);
            midDots = new string('.', midDotsCount);
            fintifliushka = new string('~', fintifliushkaCount);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{2}#{0}#{1}#{0}#{2}", fintifliushka, midDots, sideDots);
                if (midDotsCount != 0)
                {
                    sideDotsCount += 2;
                    midDotsCount -= 2;
                    fintifliushkaCount--;
                }

                sideDots = new string('.', sideDotsCount);
                midDots = new string('.', midDotsCount);
                fintifliushka = new string('~', fintifliushkaCount);
            }

            sideDots = new string('.', sideDotsCount + 1);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}##{0}", sideDots);
            }

        }
    }
}
