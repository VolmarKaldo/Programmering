using System;
using System.IO;

namespace Prov_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string menyVal = "0";
            string[] filmer;
            string filnamn = "movies.tsv";
            int antalFilmer = 50;

            Console.WriteLine("Detta är ett program för att hitta olika filmer.");

            //if (File.Exists(filnamn))
            //{
            filmer = File.ReadAllLines(filnamn);
            //}
            //else
            //{
            //System.Console.WriteLine("Tyvärr saknas filen. Lägg till en fil och starta programmet igen.");
            //menyVal = "3";
            //}

            while (menyVal != "3")
            {
                System.Console.WriteLine("Välj vad du vill göra:");
                System.Console.WriteLine("1. Visa alla filmer");
                System.Console.WriteLine("2. Sök år");
                System.Console.WriteLine("3. Avsluta");
                menyVal = Console.ReadLine();

                string[] delar;
                int svar = 0;
                switch (menyVal)
                {
                    case "1":
                        for (int i = 0; i < antalFilmer; i++)
                        {
                            delar = filmer[i].Split('\t');
                            string namnPaFilm = delar[0];
                            string år = delar[2];
                            System.Console.WriteLine($"{i + 1}: {namnPaFilm} från {år}");
                        }
                        break;
                    case "2":
                        int filmNr = 0;
                        int filmerHittade = 0;
                        System.Console.WriteLine("Vilket år vill du leta efter filmer från?");
                        while (!int.TryParse(Console.ReadLine(), out svar) || svar < 1990 || svar > 2021)
                        {
                            Console.WriteLine("Vänligen ange ett årtal mellan 1990 och 2021");
                        }
                        for (int i = 0; i < antalFilmer; i++)
                        {
                            delar = filmer[i].Split('\t');
                            string namn = delar[0];
                            string år = delar[2];
                            if (svar == int.Parse(år))
                            {
                                filmNr = filmNr + 1;
                                filmerHittade = filmerHittade + 1;
                                System.Console.WriteLine(filmNr + ":" + namn);
                            }


                        }
                        if (filmerHittade == 0)
                        {
                            System.Console.WriteLine("Hittade inga filmer");
                        }
                        else
                        {
                            //För att det inte ska bli "hittade 1 filmer"
                            if (filmerHittade == 1)
                            {
                                System.Console.WriteLine("Hittade 1 film");
                            }
                            else
                            {
                                System.Console.WriteLine($"Hittade {filmerHittade} filmer");
                            }
                        }

                        break;
                    case "3":
                        break;

                    default:
                        Console.WriteLine("Vänligen välj ett giltligt alternativ");
                        break;
                }
            }
        }
    }
}
