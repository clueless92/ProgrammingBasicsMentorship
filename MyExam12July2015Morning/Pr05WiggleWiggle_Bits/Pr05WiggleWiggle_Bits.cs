using System;

namespace Pr05WiggleWiggle_Bits
{
    class Pr05WiggleWiggle_Bits
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < input.Length; i += 2)
            {
                long numFirst = long.Parse(input[i]);
                long numSecond = long.Parse(input[i + 1]);

                for (int bitI = 0; bitI < 63; bitI += 2)
                {
                    long currentBitFirst = (numFirst >> bitI) & 1L;
                    long currentBitSecond = (numSecond >> bitI) & 1L;

                    if (currentBitFirst == currentBitSecond)
                    {
                        continue;
                    }

                    long mask = 1L << bitI;
                    numFirst ^= mask;
                    numSecond ^= mask;
                }

//                const long maskOdd = 0x2AAAAAAAAAAAAAAAL;
//                const long maskEven = 0x5555555555555555L;
//
//                long numFirstOdd = numFirst & maskOdd;
//                long numFirstEven = numFirst & maskEven;
//                long numSecondOdd = numSecond & maskOdd;
//                long numSecondEven = numSecond & maskEven;
//
//                numFirst = numFirstOdd | numSecondEven;
//                numSecond = numSecondOdd | numFirstEven;

                numFirst ^= long.MaxValue;
                numSecond ^= long.MaxValue;

                string numFirstBin = Convert.ToString(numFirst, 2).PadLeft(63, '0');
                string numSecondBin = Convert.ToString(numSecond, 2).PadLeft(63, '0');

                Console.WriteLine("{0} {1}", numFirst, numFirstBin);
                Console.WriteLine("{0} {1}", numSecond, numSecondBin);
            }
        }
    }
}
