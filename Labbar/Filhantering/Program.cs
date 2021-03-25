using System;
using System.IO;

namespace Filhantering
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("fill.txt", "Nu snöar det igen! Kul!");

            string allText = File.ReadAllText("./Filhantering.csproj");

            System.Console.WriteLine($"Innehållet: \n{allText}");

            System.Console.Write("Ange filnamn: ");
            string filnamn= Console.ReadLine();
            if (File.exists(filnamn))
            {
                string texten = file.ReadAllText(filnamn)
                System.Console.WriteLine(texten);
            }
            else
            {
                System.Console.WriteLine($"Hittade inte filen\"{filnamn}\"");
            }

        }
    }
}
