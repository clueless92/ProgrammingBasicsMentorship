using System;

namespace Pr03OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var examStartHour = int.Parse(Console.ReadLine());
            var examStartMins = int.Parse(Console.ReadLine());
            var arrivalHour = int.Parse(Console.ReadLine());
            var arrivalMins = int.Parse(Console.ReadLine());

            var totalStartMins = examStartMins + examStartHour * 60;
            var totalArrivalMins = arrivalMins + arrivalHour * 60;

            var diff = totalStartMins - totalArrivalMins;
            var diffMins = diff % 60;
            var diffHour = diff / 60;

            if (diff > 30)
            {
                Console.WriteLine("Early");
                if (diffHour > 0)
                {
                    Console.WriteLine("{0}:{1:00} hours before the start", diffHour, diffMins);
                }
                else
                {
                    Console.WriteLine("{0} minutes before the start", diffMins);
                }
            }
            else if (diff < 0)
            {
                diffHour = -diffHour;
                diffMins = -diffMins;
                Console.WriteLine("Late");
                if (diffHour > 0)
                {
                    Console.WriteLine("{0}:{1:00} hours after the start", diffHour, diffMins);
                }
                else
                {
                    Console.WriteLine("{0} minutes after the start", diffMins);
                }
            }
            else
            {
                Console.WriteLine("On time");
                if (diffHour > 0)
                {
                    Console.WriteLine("{0}:{1:00} hours before the start", diffHour, diffMins);
                }
                else
                {
                    Console.WriteLine("{0} minutes before the start", diffMins);
                }
            }
        }
    }
}
