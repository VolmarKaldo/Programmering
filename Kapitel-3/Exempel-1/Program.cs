using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Läs in ålder
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            // Om ålder = 18 skriv myndig
            if (ålder >= 18)
            {
                Console.WriteLine("Du är myndig. Du får ta körkort");
            }
            //Om ålder = 15 eller högre
            if (ålder >= 15)
            {
                Console.WriteLine("Du får köra moped.");
            }
            if (ålder < 15)
            {
                Console.WriteLine("Du är för ung.");
            }
            //Läs in text
            Console.WriteLine("Vem var statsminister i Sverige 1970?");
            string statsminister = Console.ReadLine();
            //if (statsminister == "palme"||statsminister == "olof palme")
            //{
            //    Console.WriteLine("Rätt svar");
            //}
            //Sanera inmatningen
            statsminister = statsminister.ToLower();
            if (statsminister == "palme")
            {
                System.Console.WriteLine("Rätt svar");
            }
            else
            {
                System.Console.WriteLine("Fel svar");
            }
        }
    }
}
