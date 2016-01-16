using System;

namespace Pr04LightTheTorches_New
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRooms = int.Parse(Console.ReadLine());
            string pattern = Console.ReadLine();
            char[] basement = new char[numberOfRooms];
            for (int i = 0; i < numberOfRooms; i++)
            {
                char c = pattern[i % pattern.Length];
                basement[i] = c;
            }

//            Console.WriteLine(string.Join("", basement));
            int possition = numberOfRooms / 2;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                string[] commandParts = command.Split();
                string direction = commandParts[0];
                int moves = int.Parse(commandParts[1]) + 1;
                if (direction == "LEFT")
                {
                    moves *= -1;
                }
                int newPossition = possition + moves;
                if (newPossition < 0)
                {
                    newPossition = 0;
                }
                if (newPossition >= numberOfRooms)
                {
                    newPossition = numberOfRooms - 1;
                }

                if (newPossition != possition)
                {
                    if (basement[newPossition] == 'L')
                    {
                        basement[newPossition] = 'D';
                    }
                    else
                    {
                        basement[newPossition] = 'L';
                    }
                }
                possition = newPossition;
//                Console.WriteLine(string.Join("", basement));
            }

//            Console.WriteLine(string.Join("", basement));
            int sumD = 0;
            foreach (char b in basement)
            {
                if (b == 'D')
                {
                    sumD += 'D';
                }
            }

            Console.WriteLine(sumD);
        }
    }
}
