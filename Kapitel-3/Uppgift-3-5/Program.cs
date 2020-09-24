using System;

namespace Uppgift_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång är du i meter?");
            double längd = double.Parse(Console.ReadLine());

            if (längd >= 1.5 && längd <= 1.9) ;
            {
                Console.WriteLine("Du får åka!");
            }
            if (längd < 1.5)
            {
                Console.WriteLine("Du får tyvärr inte åka, du är för kort.");
            }
            if (längd > 1.9)
            {
                Console.WriteLine("Du får tyvärr inte åka, du är för lång.");
            }
        }
    }
}
