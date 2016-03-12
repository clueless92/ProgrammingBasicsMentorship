using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr02TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceInKm = int.Parse(Console.ReadLine());
            var timeOfDay = Console.ReadLine();

            if (distanceInKm >= 100)
            {
                Console.WriteLine("{0:f2}", distanceInKm * 0.06);
            }
            else if (distanceInKm >= 20)
            {
                Console.WriteLine("{0:f2}", distanceInKm * 0.09);
            }
            else
            {
                if (timeOfDay == "day")
                {
                    Console.WriteLine("{0:f2}", distanceInKm * 0.79 + 0.70);
                }
                else
                {
                    Console.WriteLine("{0:f2}", distanceInKm * 0.90 + 0.70);
                }
            }
        }
    }
}
