using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarera variabler
            string namn = "";
            int ålder = 0;
            int ålderÅr2025 = 0;
            string meddelande = "";

            //Läs in namnet
            Console.Write("Vad heter du?");
            namn = Console.ReadLine();

            //Läs in ålder
            Console.Write("Hur gammal är du?");
            ålder = int.Parse(Console.ReadLine());

            ålderÅr2025 = ålder + 5;

            //Sammanställ resultatet
            meddelande = "Hej " + namn + "! Du är " + ålderÅr2025 + " år gammal 2025.";

            Console.WriteLine(meddelande);
        }
    }
}
