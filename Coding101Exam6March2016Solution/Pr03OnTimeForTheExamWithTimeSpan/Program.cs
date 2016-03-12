using System;

namespace Pr03OnTimeForTheExamWithTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            var examStartHour = int.Parse(Console.ReadLine());
            var examStartMins = int.Parse(Console.ReadLine());
            var arrivalHour = int.Parse(Console.ReadLine());
            var arrivalMins = int.Parse(Console.ReadLine());

            var examStartTime = new TimeSpan(examStartHour, examStartMins, 0);
            var arrivalTime = new TimeSpan(arrivalHour, arrivalMins, 0);

            var result = examStartTime - arrivalTime;
        }
    }
}
