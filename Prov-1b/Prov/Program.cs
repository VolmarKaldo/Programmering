using System;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarerar variabler
            int bruttolön;
            int nettolön = 0;
            string svar;
            string igen = "";

            //Skriver vad programmet gör
            Console.WriteLine("Detta är ett program som räknar ut nettolönen, det vill säga lönen efter marginalskatten.");

            //Frågar användaren vad den har för bruttolön
            while (true)
            {
                Console.WriteLine("Vänligen skriv din bruttolön (lön innan skatt).");
                svar = Console.ReadLine();
                if (int.TryParse(svar, out bruttolön))
                {
                    if (bruttolön > 0)
                    {
                        if (bruttolön < 10000)
                        {
                            nettolön = bruttolön * 92 / 100;
                        }
                        else if (bruttolön < 145000)
                        {
                            nettolön = bruttolön * 78 / 100;
                        }
                        else if (bruttolön < 515000)
                        {
                            nettolön = bruttolön * 67 / 100;
                        }
                        else
                        {
                            nettolön = bruttolön * 45 / 100;
                        }
                        Console.WriteLine($"Din nettolön är {nettolön}.");
                    }
                    else
                    {
                        System.Console.WriteLine("Bruttolönen måste vara > 0.");
                    }
                    while (igen != "n" && igen != "j")
                    {
                        Console.WriteLine("Vill du göra en ny beräkning? (j/n)");
                        igen = Console.ReadLine();
                        if (igen == "j" || igen == "n")
                        {
                            break;
                        }
                        else
                        {
                            System.Console.WriteLine("Vänligen svara j/n");
                        }
                    }
                    if (igen == "n")
                    {
                        break;
                    }
                    if (igen == "j")
                    {
                        igen = "0";
                    }
                }
                else
                {
                    System.Console.WriteLine("Vänligen skriv ett tal");
                }
            }
        }
    }
}
