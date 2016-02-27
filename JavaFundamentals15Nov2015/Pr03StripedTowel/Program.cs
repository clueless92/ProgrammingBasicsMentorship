using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr03StripedTowel
{
    using System.Runtime.InteropServices;

    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = (int)(width * 1.5);

            string pattern = "#..";
            long modifier = 0;
            int index = 0;
            for (int row = 0; row < height; row++)
            {
                for (long col = modifier; col < width + modifier; col++)
                {
                    if (index > 2)
                    {
                        index = 0;
                    }

                    Console.Write(pattern[index]);
                    index++;
                }
                modifier++;
                Console.WriteLine();
            }
        }
    }
}
