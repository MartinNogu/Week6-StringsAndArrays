using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!"

            Console.WriteLine("Hello World!");
            string userWelcome = "Hello World!".ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < userWelcome.Length; i++)
            {
                if (userWelcome[i] == 'h')
                {
                    hCounter++;
                }
                if (userWelcome[i] == 'o')
                {
                    oCounter++;
                }
                if (userWelcome[i] == 'l')
                {
                    lCounter++;
                }
            }

            Console.WriteLine($"Selles lauses on {hCounter} 'h' täht, {oCounter} 'o' tähte ja {lCounter} 'l' tähte.");
        }
    }
}
