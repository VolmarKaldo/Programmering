using System;

namespace Uppgift_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            doublenumber1 = 0;
            double number2 = 0;
            double summa = 0;
            double produkt = 0;

            Console.WriteLine("Skriv ett tal");
            number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Skriv ytterligare ett nummer");
            number2 = double.Parse(Console.ReadLine());

            summa = number1 + number2;
            produkt = number1 * number2;

            Console.WriteLine("Summan av dina tal är " + summa + ". Produkten är " + produkt + ".");
        }
    }
}
