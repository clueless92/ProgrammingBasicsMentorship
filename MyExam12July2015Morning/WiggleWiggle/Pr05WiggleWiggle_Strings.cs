using System;
using System.Text;

namespace Pr05WiggleWiggle_Strings
{
    class Pr05WiggleWiggle_Strings
    {
        static void Main()
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

                for (int k = 0; k <= 62; k += 2)
                {
                    char swap = sb1[k];
                    sb1[k] = sb2[k];
                    sb2[k] = swap;
                }

                sb1.Replace('0', 'r');
                sb1.Replace('1', '0');
                sb1.Replace('r', '1');
                sb2.Replace('0', 'r');
                sb2.Replace('1', '0');
                sb2.Replace('r', '1');
//                for (int k = 0; k < 63; k++)
//                {
//                    if (sb1[k].Equals('0'))
//                    {
//                        sb1[k] = '1';
//                    }
//                    else
//                    {
//                        sb1[k] = '0';
//                    }
//                    if (sb2[k].Equals('0'))
//                    {
//                        sb2[k] = '1';
//                    }
//                    else
//                    {
//                        sb2[k] = '0';
//                    }
//                }

                n1Bin = sb1.ToString();
                n2Bin = sb2.ToString();
                long n1Long = Convert.ToInt64(n1Bin, 2);
                long n2Long = Convert.ToInt64(n2Bin, 2);
                Console.WriteLine("{0} {1}", n1Long, n1Bin);
                Console.WriteLine("{0} {1}", n2Long, n2Bin);
            }
        }
    }
}