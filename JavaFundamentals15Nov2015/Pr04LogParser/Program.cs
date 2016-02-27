namespace Pr04LogParser
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            var allLogCount = new SortedDictionary<string, int>(StringComparer.Ordinal);
            var criticalMap = new SortedDictionary<string, List<string>>(StringComparer.Ordinal);
            var warningMap = new SortedDictionary<string, List<string>>(StringComparer.Ordinal);

            Regex rgx = new Regex("\\[\"(.*)\"\\].+\\[\"(.*)\"\\].+\\[\"(.*)\"\\]");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                Match match = rgx.Match(input);
                string projectName = match.Groups[1].Value;
                string logType = match.Groups[2].Value;
                string message = match.Groups[3].Value;

                if (!allLogCount.ContainsKey(projectName))
                {
                    allLogCount.Add(projectName, 0);
                    criticalMap.Add(projectName, new List<string>());
                    warningMap.Add(projectName, new List<string>());
                }

                allLogCount[projectName]++;
                if (logType == "Critical")
                {
                    criticalMap[projectName].Add(message);
                }
                else // logType == "Warning"
                {
                    warningMap[projectName].Add(message);
                }
            }

            var orderedDict = allLogCount.OrderByDescending(pair => pair.Value);
            foreach (var pair in orderedDict)
            {
                Console.WriteLine("{0}:", pair.Key);
                Console.WriteLine("Total Errors: {0}", pair.Value);

                List<string> criticalList = criticalMap[pair.Key];
                Console.WriteLine("Critical: {0}", criticalList.Count);
                criticalList.Sort();
                criticalList = criticalList.OrderBy(m => m.Length).ToList();

                List<string> warningList = warningMap[pair.Key];
                Console.WriteLine("Warnings: {0}", warningList.Count);
                warningList.Sort();
                warningList = warningList.OrderBy(m => m.Length).ToList();

                Console.WriteLine("Critical Messages:");
                if (criticalList.Count == 0)
                {
                    Console.WriteLine("--->None");
                }
                else
                {
                    foreach (string message in criticalList)
                    {
                        Console.WriteLine("--->{0}", message);
                    }
                }
                Console.WriteLine("Warning Messages:");
                if (warningList.Count == 0)
                {
                    Console.WriteLine("--->None");
                }
                else
                {
                    foreach (string message in warningList)
                    {
                        Console.WriteLine("--->{0}", message);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
