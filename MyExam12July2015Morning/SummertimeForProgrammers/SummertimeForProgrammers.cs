using System;
using System.Text;

namespace SummertimeForProgrammers
{
    class SummertimeForProgrammers
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            string topSpace = new string(' ', n / 2);
            string top = new string('*', n + 1);
            StringBuilder sb = new StringBuilder(top);
            Console.WriteLine(topSpace + top);
            sb.Replace('*', ' ', 1, n - 1);
            sb.Insert(0, topSpace);
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine(sb);
            }
            while(sb.Length < 2 * n - 1)
            {
                sb.Remove(0, 1);
                sb.Insert(n / 2, " ", 2);
                Console.WriteLine(sb);
            }
            sb.Clear();
            sb.Append("**");
            sb.Insert(1, ".", 2 * n - 2);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(sb);
            }
            sb.Replace('.', '@');
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(sb);
            }
            string bottom = new string('*', 2 * n);
            Console.WriteLine(bottom);
        }
    }
}