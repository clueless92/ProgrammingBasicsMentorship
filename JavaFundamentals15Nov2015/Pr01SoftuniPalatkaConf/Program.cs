using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr01SoftuniPalatkaConf
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int linesCount = int.Parse(Console.ReadLine());
            int meals = 0;
            int beds = 0;
            for (int i = 0; i < linesCount; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                string item = line[0];
                int quantity = int.Parse(line[1]);
                string type = line[2];
                if (item == "tents")
                {
                    if (type == "normal")
                    {
                        beds += 2 * quantity;
                    }
                    else // "firstClass"
                    {
                        beds += 3 * quantity;
                    }
                }
                else if (item == "food")
                {
                    if (type == "musaka")
                    {
                        meals += 2 * quantity;
                    }
                }
                else // "rooms"
                {
                    if (type == "single")
                    {
                        beds += quantity;
                    }
                    else if (type == "double")
                    {
                        beds += 2 * quantity;
                    }
                    else // "triple"
                    {
                        beds += 3 * quantity;
                    }
                }
            }

            if (beds >= people)
            {
                Console.WriteLine(
                    "Everyone is happy and sleeping well. Beds left: {0}",
                    beds - people);
            }
            else
            {
                Console.WriteLine(
                    "Some people are freezing cold. Beds needed: {0}",
                    people - beds);
            }

            if (meals >= people)
            {
                Console.WriteLine(
                    "Nobody left hungry. Meals left: {0}",
                    meals - people);
            }
            else
            {
                Console.WriteLine(
                    "People are starving. Meals needed: {0}",
                    people - meals);
            }

        }
    }
}
