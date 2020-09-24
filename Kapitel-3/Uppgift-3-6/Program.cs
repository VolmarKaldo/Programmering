using System;

namespace Uppgift_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder <= 18 && ålder >= 10 || ålder >= 65)
            {
                System.Console.WriteLine("Du får extrapriset!");
            }
            else
            {
                System.Console.WriteLine("Du får inte extrapriset");
            }
        }
    }
}
