using System;

namespace Övningsprov_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int x;
                Console.WriteLine("Lös ekvationen X*6=42");
                System.Console.WriteLine();
                string input = Console.ReadLine();
                if (int.TryParse(input, out x))
                {
                    if (x == 7)
                    {
                        System.Console.WriteLine("Rätt svar!");
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Fel svar!");
                        break;
                    }
                }
                else
                {
                    System.Console.WriteLine("Vänligen skriv ett tal.");
                }
            }
        }
    }
}
