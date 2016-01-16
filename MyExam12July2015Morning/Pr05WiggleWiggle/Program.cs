using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr05WiggleWiggle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < input.Length; i += 2)
            {
                long n1 = long.Parse(input[i]);
                long n2 = long.Parse(input[i + 1]);

                for (int j = 0; j < 63; j += 2)
                {
                    long currBit1 = (n1 >> j) & 1L;
                    long currBit2 = (n2 >> j) & 1L;

                    if (currBit1 != currBit2)
                    {
                        if (currBit1 == 1)
                        {
                            n1 ^= 1L << j;
                            n2 |= currBit1 << j;
                        }
                        else
                        {
                            n2 ^= 1L << j;
                            n1 |= currBit2 << j;
                        }
                    }
                }

                //                Console.WriteLine(n1);
                //                Console.WriteLine(n2);

                n1 = n1 ^ long.MaxValue;
                n2 = n2 ^ long.MaxValue;

                string n1Bin = Convert.ToString(n1, 2).PadLeft(63, '0');
                string n2Bin = Convert.ToString(n2, 2).PadLeft(63, '0');

                Console.WriteLine("{0} {1}", n1, n1Bin);
                Console.WriteLine("{0} {1}", n2, n2Bin);

                
            }
        }
    }
}
