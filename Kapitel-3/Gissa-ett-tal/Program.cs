using System;

namespace Gissa_ett_tal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett tal (1-6)!");
            string gissning = Console.ReadLine();

            if (gissning == 3)
            {
                Console.WriteLine("Rätt svar");
            }
        }
    }
}
