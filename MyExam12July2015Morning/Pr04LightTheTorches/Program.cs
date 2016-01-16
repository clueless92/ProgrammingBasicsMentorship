using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr04LightTheTorches
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRooms = int.Parse(Console.ReadLine());
            string pattern = Console.ReadLine();
            char[] basement = new char[numOfRooms];

//            int patternIndex = 0; // we fill the basement
            for (int i = 0; i < numOfRooms; i++)
            {
//                if (patternIndex == pattern.Length)
//                {
//                    patternIndex = 0;
//                }
                int patternIndex = i % pattern.Length; // !!!
                basement[i] = pattern[patternIndex];
            }

            int previosPos = numOfRooms / 2; // not -1
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                string[] commandParts = command
                    .Split(new char[] {' '}, 
                    StringSplitOptions.RemoveEmptyEntries);
                string direction = commandParts[0].ToUpperInvariant();
                int steps = int.Parse(commandParts[1]) + 1; // !!!

                if (direction == "LEFT")
                {
                    steps = steps * -1;
                }

                int currentPos = previosPos + steps;

                // check for array constraints
                if (currentPos < 0)
                {
                    currentPos = 0;
                }
                if (currentPos > basement.Length - 1)
                {
                    currentPos = basement.Length - 1;
                }

                // check if we have changed possition
                if (currentPos != previosPos)
                {
                    if (basement[currentPos] == 'L')
                    {
                        basement[currentPos] = 'D';
                    }
                    else
                    {
                        basement[currentPos] = 'L';
                    }
                }

                previosPos = currentPos;
            }

            int count = 0;
            foreach (char c in basement)
            {
                if (c == 'D')
                {
                    count += 'D';
                }
            }

            Console.WriteLine(count);
        }
    }
}
