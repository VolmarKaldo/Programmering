using System;

namespace Uppgift_6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett decimaltal");
            double decimaltal = readDouble();
        }
        static double readDouble()
        {
            double decimaltal;
            while (double.TryParse(Console.ReadLine(), out decimaltal) == false)
            {
                System.Console.WriteLine("Du skrev inte in ett giltligt värde, försök igen.");
            }
            return decimaltal;
        }
    }
}

