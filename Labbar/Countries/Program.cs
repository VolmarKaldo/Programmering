using System;

namespace Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Presentera programmet
            Console.WriteLine("Program för att hitta länder matchande sökterm");
            System.Console.WriteLine("Programmet listar land och landskod");

            if (File.Exists("countries.csv"))
            {
                string[] rader = File.ReadAllLines("countries.csv");

                System.Console.WriteLine("Ange sökterm (avsluta med return): ");
                string sökterm = Console.ReadLine();
                foreach (var rad in rader)
                {
                    // Console.WriteLine(rad);
                    string[] delar = rad.Split(",");
                }
            }
            else
            {
                System.Console.WriteLine("Filen fanns inte.");
            }
        }
    }
}
