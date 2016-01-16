using System;

namespace IzboriTest
{
    class IzboriTest
    {
        static void Main()
        {
            int partys = int.Parse(Console.ReadLine());
            while (partys > 0)
            {
                int[] votesPerParty = new int[partys];
                string[] votesInput = Console.ReadLine().Split(' ');
                int votesAll = 0;
                int votesTrue = 0;
                int president = 240;
                for (int i = 0; i < partys; i++)
                {
                    votesPerParty[i] = int.Parse(votesInput[i]);
                    votesAll += votesPerParty[i];
                }
                for (int i = 0; i < partys; i++)
                {
                    double percentAll = (double)votesPerParty[i] / votesAll;
                    if (percentAll > 0.04)
                    {
                        votesTrue += votesPerParty[i];
                    }
                    else
                    {
                        votesPerParty[i] = 0;
                    }
                }
                bool isFirstPrint = true;
                for (int i = 0; i < partys; i++)
                {
                    if (votesPerParty[i] > 0)
                    {
                        double percentTrue = (double)votesPerParty[i] / votesTrue;
                        int seats = 0;
                        if (percentTrue > 0.04)
                        {
                            seats = (int)(percentTrue * 240);
                            president -= seats;
                            if (isFirstPrint)
                            {
                                Console.Write("{0}:{1}", i + 1, seats);
                                isFirstPrint = false;
                            }
                            else
                            {
                                Console.Write(" {0}:{1}", i + 1, seats);
                            }
                        }
                    }
                }
                if (president > 0)
                {
                    if (isFirstPrint)
                    {
                        Console.Write("Pesho President!");
                    }
                    else
                    {
                        Console.Write(" president:{0}", president);
                    }
                }
                Console.WriteLine();
                partys = int.Parse(Console.ReadLine());
            }
        }
    }
}