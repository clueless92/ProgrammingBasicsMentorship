using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr05WiggleWiggle_JohnString
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
                string n1Bin = Convert.ToString(n1, 2).PadLeft(63, '0');
                string n2Bin = Convert.ToString(n2, 2).PadLeft(63, '0');
                StringBuilder sb1 = new StringBuilder(n1Bin);
                StringBuilder sb2 = new StringBuilder(n2Bin);

                for (int j = 0; j < 63; j+=2)
                {
                    if (sb1[j] != sb2[j])
                    {
                        char c = sb1[j];
                        sb1[j] = sb2[j];
                        sb2[j] = c;
                    }
                }

//                sb1.Replace('1', 'r');
//                sb1.Replace('0', '1');
//                sb1.Replace('r', '0');
//                sb1.Replace('1', 'r');
//                sb1.Replace('0', '1');
//                sb1.Replace('r', '0');

                for (int j = 0; j < 63; j++)
                {
                    if (sb1[j] == '1')
                    {
                        sb1[j] = '0';
                    }
                    else
                    {
                        sb1[j] = '1';
                    }

                    if (sb2[j] == '1')
                    {
                        sb2[j] = '0';
                    }
                    else
                    {
                        sb2[j] = '1';
                    }
                }

                n1 = Convert.ToInt64(sb1.ToString(), 2);
                n2 = Convert.ToInt64(sb2.ToString(), 2);

                Console.WriteLine("{0} {1}", n1, sb1);
                Console.WriteLine("{0} {1}", n2, sb2);
            }
        }
    }
}
