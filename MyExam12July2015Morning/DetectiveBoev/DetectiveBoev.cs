using System;
using System.Text;

namespace DetectiveBoev
{
    class DetectiveBoev
    {
        static void Main(string[] args)
        {
            string secretWord = Console.ReadLine();
            string encrMSG = Console.ReadLine();
            StringBuilder sb = new StringBuilder(encrMSG);
            short mask = 0;
            for (int i = 0; i < secretWord.Length; i++)
            {
                mask += (short) secretWord[i];
            }
            string maskString = mask.ToString();
            while (mask > 9)
            {
                mask = 0;
                for (int i = 0; i < maskString.Length; i++)
                {
                    mask += short.Parse(maskString[i].ToString());
                }
                maskString = mask.ToString();
            }
            //Console.WriteLine(mask); // TEST
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] % mask == 0)
                {
                    sb[i] += (char) mask;
                } else
                {
                    sb[i] -= (char) mask;
                }
            }
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                Console.Write(sb[i]);
            }
            Console.WriteLine();
        }
    }
}