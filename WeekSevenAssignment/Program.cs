using System;

namespace WeekSevenAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Login Validation

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Kasutajanimi:");
                string nimi = Console.ReadLine();

                Console.WriteLine("Password:");
                string parool = Console.ReadLine();

                Console.WriteLine("PIN:");
                string pin = Console.ReadLine();

                if (nimi == "user1" && parool == "password1" && pin == "1532")
                {
                    break;
                }
                else if (nimi == "user1" && parool == "password1" && pin != "1532")
                {
                    Console.WriteLine("Vale PIN proovi uuesti");
                    i = i + 1;
                }
                else
                {
                    Console.WriteLine("Midagi läks valesti proovi uuesti");
                    i = i + 1;
                }
            }
            if (i < 3)
            {
                Console.WriteLine("Tere Tulemast");
            }
            else
            {
                Console.WriteLine("Midagi läks valesti. Proovi uuesti.");
            }
        }
    }
}
