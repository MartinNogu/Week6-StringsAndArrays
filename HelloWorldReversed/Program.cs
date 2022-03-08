using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World!" tagurpidi

            Console.WriteLine("Hello, World!");
            string userWelcome = "Hello, World!";

            for (int i = userWelcome.Length - 1; i >= 0; i--)
            {
                Console.Write(userWelcome[i]);
            }

        }
    }
}
