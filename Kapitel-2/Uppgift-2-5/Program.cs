/*
Skapa ett program som frågar användaren vilket år det är därefter ska programmet säga hur många år det är kvar till 2100
*/

using System;

namespace Uppgift_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Läsa in ett årtal.
            int year = 0;
            int yearLeft = 0;
            Console.WriteLine("Vilket år är det?");
            //Räkna ut antal år till 2100
            year = int.Parse(Console.ReadLine());
            yearLeft = 2100 - year;
            //Skriv ut resultatet
            Console.WriteLine
        }
    }
}
