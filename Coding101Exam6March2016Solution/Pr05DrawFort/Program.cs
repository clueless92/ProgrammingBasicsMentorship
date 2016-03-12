using System;

namespace Pr05DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var towerCount = n / 2;
            var castleCount = n * 2;
            var lowerCount = castleCount - 2 * towerCount - 4;

            var xors = new string('^', towerCount);
            var lowers = new string('_', lowerCount);
            Console.WriteLine(@"/{0}\{1}/{0}\", xors, lowers);

            var spaceCount = 2 * n - 2;
            var spaces = new string(' ', spaceCount);
            for (int i = 1; i < n - 2; i++)
            {
                Console.WriteLine("|{0}|", spaces);
            }

            spaceCount = towerCount + 1;
            spaces = new string(' ', spaceCount);
            Console.WriteLine("|{0}{1}{0}|", spaces, lowers);
            spaceCount = lowerCount;
            spaces = new string(' ', spaceCount);
            lowerCount = n / 2;
            lowers = new string('_', lowerCount);
            Console.WriteLine(@"\{0}/{1}\{0}/", lowers, spaces);
        }
    }
}
