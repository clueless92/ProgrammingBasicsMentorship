using System;

namespace Pr01FourFactors
{
    class Pr01FourFactors
    {
        static void Main()
        {
            int fieldGoals = int.Parse(Console.ReadLine()); // 3351
            int fieldGoalAttempts = int.Parse(Console.ReadLine()); // 7018
            int threePoint = int.Parse(Console.ReadLine()); // 796
            int turnovers = int.Parse(Console.ReadLine()); // 1125
            int offensiveRebounds = int.Parse(Console.ReadLine()); // 967
            int oppDRB = int.Parse(Console.ReadLine()); // 2550
            int freeThrows = int.Parse(Console.ReadLine()); // 1556
            int freeThrowAttempts = int.Parse(Console.ReadLine()); // 2080

            double eFG = (fieldGoals + 0.5d * threePoint) / fieldGoalAttempts;
            double tOV = turnovers / (fieldGoalAttempts + 0.44d * freeThrowAttempts + turnovers);
            double oRB = 1.0d * offensiveRebounds / (offensiveRebounds + oppDRB);
            double fT = 1.0d * freeThrows / fieldGoalAttempts;

            Console.WriteLine("eFG% {0:f3}", eFG);
            Console.WriteLine("TOV% {0:f3}", tOV);
            Console.WriteLine("ORB% {0:f3}", oRB);
            Console.WriteLine("FT% {0:f3}", fT);

//            int a = 10;
//            int b = 100;
//            double result = a / b;
//            Console.WriteLine("{0:F5}", result);
        }
    }
}