using System;

namespace Prov_3a
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarera variabler
            string svar = "";
            double ålder;
            double nyÅlder;
            string fortsätt = "";
            //Hälsar välkommen till programmet
            Console.WriteLine("Välkommen!");
            //Ber om ålder
            ålder = ReadDouble();
            //Skriver ut menyn
            while (svar != "8")
            {
                fortsätt = "";
                svar = SkrivMeny();
                switch (svar)
                {
                    //Om man vill räkna ut för Merkurius
                    case "1":
                        nyÅlder = ålder / 0.2408467;
                        System.Console.WriteLine($"På Merkurius hade du varit {nyÅlder} år gammal");
                        break;
                    //Om man vill räkna ut för Venus    
                    case "2":
                        nyÅlder = ålder / 0.61519726;
                        System.Console.WriteLine($"På Venus hade du varit {nyÅlder} år gammal");
                        break;
                    //Om man vill räkna ut för Mars
                    case "3":
                        nyÅlder = ålder / 1.8808158;
                        System.Console.WriteLine($"På Mars hade du varit {nyÅlder} år gammal");
                        break;
                    //Om man vill räkna ut för Jupiter
                    case "4":
                        nyÅlder = ålder / 11.862615;
                        System.Console.WriteLine($"På Jupiter hade du varit {nyÅlder} år gammal");
                        break;
                    //Om man vill räkna ut för Saturnus
                    case "5":
                        nyÅlder = ålder / 29.447498;
                        System.Console.WriteLine($"På Saturnus hade du varit {nyÅlder} år gammal");
                        break;
                    //Om man vill räkna ut för Uranus
                    case "6":
                        nyÅlder = ålder / 84.016846;
                        System.Console.WriteLine($"På Uranus hade du varit {nyÅlder} år gammal");
                        break;
                    //Om man vill räkna ut för Neptunus
                    case "7":
                        nyÅlder = ålder / 164.79132;
                        System.Console.WriteLine($"På Neptunus hade du varit {nyÅlder} år gammal");
                        break;
                    //Om man vill avsluta
                    case "8":
                        break;
                    //Om man matat in fel
                    default:
                        System.Console.WriteLine("Du skrev inte in ett giltligt svar, försök igen");
                        break;
                }
                //Frågar om man vill göra om eller avsluta
                while (fortsätt != "N" && fortsätt != "n" && fortsätt != "j" && fortsätt != "J")
                {
                    if (svar != "8")
                    {
                        System.Console.WriteLine("Vill du testa igen?(J/n)");
                        fortsätt = Console.ReadLine();
                        switch (fortsätt)
                        {
                            case "J":
                                break;
                            case "j":
                                break;
                            case "n":
                                svar = "8";
                                break;
                            case "N":
                                svar = "8";
                                break;
                            default:
                                System.Console.WriteLine("Du skrev inte in ett giltligt svar, försök igen");
                                break;
                        }
                    }

                }
            }
        }
        static string SkrivMeny()
        {
            //Deklarera variabler
            string svar = "";
            //Gör menyn
            System.Console.WriteLine("Detta är ett program för att räkna ut din ålder på en annan planet");
            System.Console.WriteLine("Välj alternativ:");
            System.Console.WriteLine("1. Räkna ut ålder på Merkurius");
            System.Console.WriteLine("2. Räkna ut ålder på Venus");
            System.Console.WriteLine("3. Räkna ut ålder på Mars");
            System.Console.WriteLine("4. Räkna ut ålder på Jupiter");
            System.Console.WriteLine("5. Räkna ut ålder på Saturnus");
            System.Console.WriteLine("6. Räkna ut ålder på Uranus");
            System.Console.WriteLine("7. Räkna ut ålder på Neptunus");
            System.Console.WriteLine("8. Avsluta");
            svar = Console.ReadLine();
            return svar;
        }
        static double ReadDouble()
        {
            //Omvandlar användarens text till ett decimaltal
            System.Console.WriteLine("Skriv in din ålder");
            double ålder = 0;
            while (double.TryParse(Console.ReadLine(), out ålder) == false)
            {
                System.Console.WriteLine("Du skrev inte in ett giltligt värde, försök igen.");
            }
            return ålder;
        }
    }
}