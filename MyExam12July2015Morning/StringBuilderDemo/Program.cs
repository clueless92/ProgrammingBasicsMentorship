using System;
using System.Text;

namespace StringBuilderDemo
{
    class Program
    {
        static int n = 5;
        static void Main(string[] args)
        {
            StringBuilder a = new StringBuilder("a");
            string b = "askdoasjd";
            for (int i = 0; i < 10; i++)
            {
                a.Append("a");
            }
            a[5] = 'b';
            Console.WriteLine(a);
        }
    }
}
