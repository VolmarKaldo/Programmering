using System;

namespace Exempel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Slumpa fram ett tal
            Random tärning = new Random();
            int slumptal = tärning.Next(1, 7);

            int gissning = 0;

            while (gissning != slumptal)
            {
                Console.WriteLine("Gissa ett tal (1-6).");

                string input = Console.ReadLine();

                if (int.TryParse(input, out gissning))
                {
                    Console.WriteLine("Vad bra att du skrev ett tal!");

                    if (gissning != slumptal)
                    {
                        Console.WriteLine("Fel svar! Försök igen");
                    }
                }
            }
        }
    }
}
