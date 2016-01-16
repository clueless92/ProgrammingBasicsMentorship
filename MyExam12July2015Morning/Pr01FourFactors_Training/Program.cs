using System;

namespace Pr01FourFactors_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            double fg = double.Parse(Console.ReadLine()); // 3351
            double fga = double.Parse(Console.ReadLine()); // 7018
            double treeP = double.Parse(Console.ReadLine()); // 796
            double tov = double.Parse(Console.ReadLine()); // 1125
            double orb = double.Parse(Console.ReadLine()); // 967
            double oppDrb = double.Parse(Console.ReadLine()); // 2550
            double ft = double.Parse(Console.ReadLine()); // 1556
            double fta = double.Parse(Console.ReadLine()); // 2080

            double efg = (fg + 0.5d * treeP) / fga;
            double tovPrc = tov / (fga + 0.44d * fta + tov);
            double orbPrc = orb / (orb + oppDrb);
            double ftPrc = ft / fga;

            Console.WriteLine("eFG% {0:f3}", efg);
            Console.WriteLine("TOV% {0:f3}", tovPrc);
            Console.WriteLine("ORB% {0:f3}", orbPrc);
            Console.WriteLine("FT% {0:f3}", ftPrc);
        }
    }
}
