using System;

namespace GameOfBits
{
    class GameOfBits
    {
        static void Main()
        {
            uint input = uint.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "Game Over!")
            {
                // вместо да правиш всичко в тези if-ове по-добре само настрой различното и после си пляскай for-a
                int modifier = 0;
                if (command == "Odd")
                {
                    modifier = 1;
                }
                uint bitsValues = 0;
                uint bits = 0;
                for (int i = 31; i >= 0; i -= 2)
                {
                    bitsValues = 1 & (input >> (i - modifier));
                    bits |= bitsValues << (i / 2);
                }
                input = bits;
                command = Console.ReadLine();
            }
            int count = 0;
            // няма смисъл да правиш char array, той стринга реално си е нещо като char[]
            string bitValues = Convert.ToString(input, 2);
            for (int i = 0; i < bitValues.Length; i++)
            {
                if (bitValues[i] == '1')
                {
                    count++;
                }
            }
            Console.WriteLine("{0} -> {1}", input, count);
        }
    }
}