using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string eesnimi = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi:");
            string perekonnanimi = Console.ReadLine();

            Console.WriteLine($"Tere {eesnimi.ToUpper()[0]}. {perekonnanimi.ToUpper()[0]}.!");
        }
    }
}
