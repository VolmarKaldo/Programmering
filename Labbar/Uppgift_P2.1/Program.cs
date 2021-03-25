using System;

namespace Uppgift_P2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string klar = "N";
            while (klar != "J")
            {
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Skapa/skriva över en fil");
                Console.WriteLine("2. Läs in en fil");
                string val = Console.ReadLine();

                Console.WriteLine("Skriv in filens namn");
                string filnamn = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        Console.WriteLine("Skriv in en rad som ska skrivas till filen");
                        string rad = Console.ReadLine();
                        File.WriteAllText(filnamn, rad);
                        break;

                    case "2":
                        if (File.Exists(filnamn))
                        {
                            string filinnehåll = File.ReadAllText(filnamn);
                            Console.WriteLine("Filen innehåller:");
                            Console.Write(filinnehåll);
                        }
                        else
                        {
                            Console.WriteLine("Filen hittades inte.");
                        }
                        break;

                    default:
                        break;
                }

                Console.WriteLine("Vill du avsluta programmet? (J/N)");
                klar = Console.ReadLine();
            }
        }
    }
}
