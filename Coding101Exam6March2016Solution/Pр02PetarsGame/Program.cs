using System;

namespace Pр02PetarsGame
{
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            ulong startNum = ulong.Parse(Console.ReadLine());
            ulong endNum = ulong.Parse(Console.ReadLine());
            string replacementString = Console.ReadLine();

            BigInteger sum = 0;
            for (ulong i = startNum; i < endNum; i++)
            {
                if (i % 5 == 0)
                {
                    sum += i;
                }
                else
                {
                    sum += i % 5;
                }
            }

            string sumAsString = sum.ToString();
            if (sum % 2 == 0)
            {
                char firstDigit = sumAsString[0];
                sumAsString = sumAsString.Replace(firstDigit.ToString(), replacementString);
            }
            else
            {
                char lastDigit = sumAsString[sumAsString.Length - 1];
                sumAsString = sumAsString.Replace(lastDigit.ToString(), replacementString);
            }

            Console.WriteLine(sumAsString);
        }
    }
}
