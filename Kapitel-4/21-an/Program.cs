using System;

namespace _21_an
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till 21:an!");

            Random slump= new Random();
            string senasteVinnaren = "Ingen har vunnit än"
            string menyVal = "0";
            while (menyVal != "4")
            {
                System.Console.WriteLine("Välj ett alternativ");
                System.Console.WriteLine("1. Spela 21:an");
                System.Console.WriteLine("2. Visa senaste vinnaren");
                System.Console.WriteLine("3. Spelets regler");
                System.Console.WriteLine("4. Avsluta programmet.");
                menyVal= Console.ReadLine();
                System.Console.WriteLine();

                switch (menyVal)
                {
                    case "1":
                    
                    break;
                    
                    case "2":
                    System.Console.WriteLine($"Senaste vinnaren: {senasteVinnaren}");
                    break;

                    case "3":
                    System.Console.WriteLine("Ditt mål är att tvinga datorn att få mer än 21 poäng.");
                    System.Console.WriteLine("Du får poäng genom att dra kort, varje kort har 1-10 poäng.");
                    System.Console.WriteLine("Om du får mer än 21 poäng har du förlorat");
                    System.Console.WriteLine("Både du och datorna får två kort i början. Därefter får du dra fler kort tills du är nöjd eller får över 21.");
                    System.Console.WriteLine("När du är färdig drar datorn kort tills den har mer poäng än dig eller över 21 poäng."); 
                    break;

                    case "4":
                    break;

                    default:
                    System.Console.WriteLine("Du valde inte ett giltigt alternativ");
                    break;
                }
                System.Console.WriteLine();
            }
        }
    }
}
