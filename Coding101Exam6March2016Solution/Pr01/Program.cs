using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr01
{
    class Program
    {
        static void Main(string[] args)
        {
            // values are in meters, so we convert them to cm
            var height = double.Parse(Console.ReadLine()) * 100;
            var width = double.Parse(Console.ReadLine()) * 100 - 100;

            var desksCountForWidth = (int) width / 70;
            var desksCountForHeight = (int) height / 120;

            Console.WriteLine(desksCountForWidth * desksCountForHeight - 3);
        }
    }
}
