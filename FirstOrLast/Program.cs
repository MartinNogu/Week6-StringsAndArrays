using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Selles eesnimes on {firstName.Length} sümbolit.");

            Console.WriteLine($"Selles perekonnanimes on {lastName.Length} sümbolit.");

            if(firstName.Length > lastName.Length)
            {
                Console.WriteLine("Eesnimes on rohkem sümboleid kui perekonnanimes.");
            }
            else if(firstName.Length < lastName.Length)
            {
                Console.WriteLine("Perekonnanimes on rohkem sümboleid kui eesnimes.");
            }
            else
            {
                Console.WriteLine("Mõlemas nimes on sama palju sümboleid.");
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
