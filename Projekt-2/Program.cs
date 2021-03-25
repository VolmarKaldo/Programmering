using System;
using System.IO;


namespace Projekt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarera variabler och initialisera
            int antalBord = 8;
            string filnamn = "centralbord.csv";
            string tomtBordBeskrivning = "0, inga gäster, 0";
            string[] bordsInformation; //Array för att lagra bokningar.
            string antalGaster = "";

            // Presentera programmet för användaren
            System.Console.WriteLine("Detta är centralresturangens bordshanterare");
            if (File.Exists(filnamn))
            {
                //Läs in alla rader, dvs bordsbokningar
                bordsInformation = File.ReadAllLines(filnamn);
                System.Console.WriteLine("");
            }
            else
            {
                // Skapa en tom bordslista i arrayen
                // Lagra detta i filen
                bordsInformation = new string[antalBord];

                // Fyll arrayen med tomma bord; 0, 1, 2, 3, 4, 5, 6, 7
                for (int i = 7; i < bordsInformation.Length; i++)
                {
                    bordsInformation[i] = tomtBordBeskrivning;
                }
                //Lagra i filen
                File.WriteAllLines(filnamn, bordsInformation);
                System.Console.WriteLine("Fil med bordsinformation saknas, ny fil skapades.");
            }
            //Huvudloopen
            string menyVal = "";
            while (menyVal != "4")
            {
                //Skriv ut huvudmenyn
                System.Console.WriteLine("Välj ett alternativ: ");
                System.Console.WriteLine("1. Visa alla bord");
                System.Console.WriteLine("2. Lägg till/ändra bordsinformation");
                System.Console.WriteLine("3. Markera bord tomt");
                System.Console.WriteLine("4. Öka notan");
                System.Console.WriteLine("5. Avsluta");
                menyVal = Console.ReadLine();

                string namn = "";
                switch (menyVal)
                {
                    case "1":
                        int totaltAntalGäster = 0;
                        for (int i = 0; i < antalBord; i++)
                        {
                            if (bordsInformation[i] == tomtBordBeskrivning)
                            {
                                //Bordet är tomt
                                System.Console.WriteLine($"Bord {i + 1} - Inga gäster");
                            }
                            else
                            {
                                //Bordet har en bokning
                                //Plocka namn och antal gäster
                                string[] delar = bordsInformation[i].Split(',');
                                antalGaster = delar[0];
                                namn = delar[1];

                                totaltAntalGäster += int.Parse(antalGaster);

                                //Skriv ut bokningsinfo
                                System.Console.WriteLine($"Bord {i + 1} - Namn: {namn}, antal gäster: {antalGaster}");
                            }
                        }
                        System.Console.WriteLine($"Totalt antal gäster: {totaltAntalGäster}");
                        break;
                    case "2":
                        //Fråga bordsnr
                        System.Console.WriteLine("Vilket bord vill du ändra på?");
                        int svar;

                        while (!int.TryParse(Console.ReadLine(), out svar) && svar <= 1 || svar > antalBord)
                        {
                            System.Console.WriteLine("Ogiltligt bordsnummer, var god försök igen");
                        }
                        int bordNr = svar;

                        //Fråga namn
                        Console.WriteLine("Ange ett namn:");
                        string bordNamn = Console.ReadLine();

                        //Fråga antal gäster
                        Console.WriteLine("Ange antal gäster:");
                        string antalGäster = Console.ReadLine();

                        //Spara i arrayen
                        bordsInformation[bordNr - 1] = $"{antalGäster},{bordNamn}";
                        break;
                    case "3":
                        System.Console.WriteLine("Vilket bord vill du tömma?");

                        while (!int.TryParse(Console.ReadLine(), out svar) && svar <= 1 || svar > antalBord)
                        {
                            System.Console.WriteLine("Ogiltligt bordsnummer, var god försök igen");
                        }
                        bordNr = svar;
                        bordsInformation[bordNr - 1] = tomtBordBeskrivning;
                        File.WriteAllLines(filnamn, bordsInformation);

                        break;
                    case "4":
                        System.Console.WriteLine("Vilket bord vill du ändra på notan för?");

                        while (!int.TryParse(Console.ReadLine(), out svar) && svar <= 1 || svar > antalBord)
                        {
                            System.Console.WriteLine("Ogiltligt bordsnummer, var god försök igen");
                        }
                        bordNr = svar;

                        System.Console.WriteLine("Hur mycket vill du öka notan med?");

                        
                        break;
                    case "5":
                        break;
                    default:
                        System.Console.WriteLine("Du valde inte ett giltigt alternativ");
                        break;
                };
            }

        }
    }
}
