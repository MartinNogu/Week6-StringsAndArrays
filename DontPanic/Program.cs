using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Dont Panic" nulliga -0
            //programm asendab kõik 'a' tähed lauses "Dont Panic" neljaga -4

            string dontP = "Dont Panic";

            dontP = dontP.Replace('o', '0');
            dontP = dontP.Replace('a', '4');
            Console.WriteLine(dontP);
        }
    }
}
