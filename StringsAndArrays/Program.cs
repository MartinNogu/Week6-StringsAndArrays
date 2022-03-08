using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada eesnime
            //programm kuvab kasutaja eesnime pikkust

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            //int firstNameLenght = firstName.Length;
            Console.WriteLine($"Selles eesnimes on {firstName.Length} sümbolit.");

        }
    }
}
