using System;

namespace PrTedo
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());
            int lastDigit = input / 1000;


            if (lastDigit % 2 == 1)
            {
                string result = input.ToString();
                result.Replace((char)(lastDigit + '0'), 'a');

                Console.WriteLine(result);
            }

            string inputString = Console.ReadLine();
            char lastChar = inputString[inputString.Length - 1];

            if ((lastChar - '0') % 2 == 1)
            {
                inputString = inputString.Replace(lastChar, 'a');
            }

            Console.WriteLine(inputString);

        }
    }
}
