using System;
using System.Text;

namespace LightTheTorches
{
    class LightTheTorches
    {
        static void Main()
        {
            int darkRooms = 0;
            int result = 0;
            byte numberOfRooms = byte.Parse(Console.ReadLine());
            string isLit = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int index = 0;
            for (int i = 0; i < numberOfRooms; i++)
            {
                sb.Append(isLit[index]);
                if (index == isLit.Length - 1)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
            }
            // Console.WriteLine(sb); // TEST
            string[] values = new string[2];
            string newDirection = "";
            string oldDirection = "";
            int distance = 0;
            string move = "";
            int priestPosition = numberOfRooms / 2;
            while (true)
            {
            
                move = Console.ReadLine();
                if (move.Equals("END"))
                {
                    break;
                }
                values = move.Split(' ');
                newDirection = values[0];
                if (numberOfRooms == 1)
                {
                    if (sb[0].Equals('D'))
                    {
                        result = 68;
                    }
                    else
                    {
                        result = 0;
                    }
                    if (move.Equals("END"))
                    {
                        break;
                    }
                }
                if (newDirection.Equals(oldDirection) && newDirection.Equals("LEFT"))
                {
                    if (priestPosition == 0)
                    {
                        // Console.WriteLine(sb); // TEST
                        continue;
                    }
                }
                else if (newDirection.Equals(oldDirection) && newDirection.Equals("RIGHT"))
                {
                    if (priestPosition == sb.Length - 1)
                    {
                        // Console.WriteLine(sb); // TEST
                        continue;
                    }
                }
                distance = int.Parse(values[1]);
                if (newDirection.Equals("LEFT"))
                {
                    priestPosition -= (distance + 1);
                    if (priestPosition < 0)
                    {
                        priestPosition = 0;
                    }
                }
                else
                {
                    priestPosition += (distance + 1);
                    if (priestPosition > sb.Length - 1)
                    {
                        priestPosition = sb.Length - 1;
                    }
                }
                if (sb[priestPosition].Equals('L'))
                {
                    sb[priestPosition] = 'D';
                }
                else
                {
                    sb[priestPosition] = 'L';
                }
                oldDirection = newDirection;
                // Console.WriteLine(sb); // TEST
            }
            // Console.WriteLine(sb); // TEST
            darkRooms = 0;
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i].Equals('D'))
                {
                    darkRooms++;
                }
            }
            if (numberOfRooms > 1)
            {
                result = darkRooms * 68;
            }
            Console.WriteLine(result);
        }
    }
}