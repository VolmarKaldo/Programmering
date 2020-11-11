using System;

namespace Uppgift_Lyckohjul
{
    class Program
    {
        static void Main(string[] args)
        {
            int gissning;
            int slumptal;
            string input;
            Random slumpTal;

            Console.WriteLine("Gissa ett tal mellan 1 och 10");
            input = Console.ReadLine();
            int.TryParse(input, out gissning);

            slumpTal = new Random();
            slumptal = slumpTal.Next(1, 11);

            System.Console.WriteLine($"Slumptalet blev {slumptal}");

            if (gissning == slumptal)
            {
                System.Console.WriteLine("Du vann! Grattis!");
            }
            else System.Console.WriteLine("Du förlorade. Va synd.");
        }
    }
}
