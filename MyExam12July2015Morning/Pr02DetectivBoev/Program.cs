using System;

namespace Pr02DetectivBoev
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = Console.ReadLine();
            string message = Console.ReadLine();

            int key = 0;
            foreach (char c in secretWord)
            {
                key += (int) c;
            }

            while (key > 9)
            {
                string keyString = key.ToString();
                key = 0;
                foreach (char k in keyString)
                {
                    key += (int) char.GetNumericValue(k);
//                    key += (int) (k - '0');
                }
            }

            string messageDecrypted = "";
            for (int i = message.Length - 1; i >= 0; i--) // reversed array
            {
                if (message[i] % key == 0)
                {
                    messageDecrypted += (char)(message[i] + key);
                }
                else
                {
                    messageDecrypted += (char)(message[i] - key);
                }
            }


            Console.WriteLine(messageDecrypted);
        }
    }
}
