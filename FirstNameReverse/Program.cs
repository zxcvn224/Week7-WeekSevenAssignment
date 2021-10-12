using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string nimi = Console.ReadLine();

            if (nimi.Length >= 5)
            {
                for (int i = nimi.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine($"{nimi[i]}");
                }
            }
            else
            {
                Console.WriteLine($"{nimi}");
            }
        }
    }
}
