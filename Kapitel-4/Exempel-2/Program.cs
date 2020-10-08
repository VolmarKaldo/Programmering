using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera variabler
            string val = "";
            int tal1 = 0;
            int tal2 = 0;
            int summa = 0;
            int produkt = 0;

            //Presentera en meny som visas tills användaren säger stopp
            while (val != "3")
            {
                System.Console.WriteLine("-------------------------");
                System.Console.WriteLine("Välj något av följande");
                System.Console.WriteLine("1. Addera två tal");
                System.Console.WriteLine("2. Multiplicera två tal");
                System.Console.WriteLine("3. Avsluta");

                val = Console.ReadLine();

                //Om val = 1
                if (val == "1")
                {
                    System.Console.WriteLine("Skriv ett tal");
                    tal1 = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Skriv ett till tal");
                    tal2 = int.Parse(Console.ReadLine());
                    summa = tal1 + tal2;
                    System.Console.WriteLine("Summan av dina tal är " + summa);
                }
                //Om val = 2 
                if (val == "2")
                {
                    System.Console.WriteLine("Skriv ett tal");
                    tal1 = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Skriv ett till tal");
                    tal2 = int.Parse(Console.ReadLine());
                    produkt = tal1 * tal2;
                    System.Console.WriteLine("Produkten av dina tal är " + produkt);
                }
                //Om val = 3 
                if (val == "3")
                {
                    break;
                }
                if (val != "1" && val != "2" && val != "3")
                {
                    System.Console.WriteLine("Vänligen skriv 1, 2 eller 3");
                }
                //Annars

            }
        }
    }
}
