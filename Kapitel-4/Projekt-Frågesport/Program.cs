using System;

namespace Projekt_Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            int svar;
            string namn;
            string spela;
            while (true)
            {


                int poäng = 0;
                int fråga = 1;

                Console.WriteLine("Hej och välkomna till dagens frågesport! Idag så kommer ni att få tre stycken frågor, som ni får välja alternativet 1, 2 eller 3 på.");

                System.Console.WriteLine("Men först vill vi veta vad du heter. Vänligen skriv ditt namn!");

                namn = Console.ReadLine();
                System.Console.WriteLine($"Hej och välkommen {namn}.");

                while (fråga == 1)
                {
                    System.Console.WriteLine("Den första frågan lyder:____________________?");
                    System.Console.WriteLine("1. _____________.");
                    System.Console.WriteLine("2. _____________.");
                    System.Console.WriteLine("3. _____________.");

                    int.TryParse(Console.ReadLine(), out svar);

                    if (svar == 2)
                    {
                        System.Console.WriteLine("Det är rätt svar!");
                        poäng = poäng + 1;
                        fråga = fråga + 1;
                    }
                    if (svar == 1 || svar == 3)
                    {
                        System.Console.WriteLine("Tyvärr är det fel svar.");
                        fråga = fråga + 1;
                    }
                    else
                    {
                        System.Console.WriteLine("Vänligen svara 1-3");
                    }
                }
                while (fråga == 2)
                {
                    System.Console.WriteLine("Andra frågan är _________________________.");
                    System.Console.WriteLine("1.__________");
                    System.Console.WriteLine("2.__________");
                    System.Console.WriteLine("2.__________");
                    int.TryParse(Console.ReadLine(), out svar);

                    if (svar == 3)
                    {
                        System.Console.WriteLine("Det är rätt svar!");
                        poäng = poäng + 1;
                        fråga = fråga + 1;
                    }
                    if (svar == 1 || svar == 2)
                    {
                        System.Console.WriteLine("Tyvärr är det fel svar.");
                        fråga = fråga + 1;
                    }
                    else
                    {
                        System.Console.WriteLine("Vänligen svara 1-3");
                    }
                }
                while (fråga == 3)
                {
                    System.Console.WriteLine("Tredje frågan är _________________________.");
                    System.Console.WriteLine("1.__________");
                    System.Console.WriteLine("2.__________");
                    System.Console.WriteLine("2.__________");
                    int.TryParse(Console.ReadLine(), out svar);

                    if (svar == 1)
                    {
                        System.Console.WriteLine("Det är rätt svar!");
                        poäng = poäng + 1;
                        fråga = fråga + 1;
                    }
                    if (svar == 2 || svar == 3)
                    {
                        System.Console.WriteLine("Tyvärr är det fel svar.");
                        fråga = fråga + 1;
                    }
                    else
                    {
                        System.Console.WriteLine("Vänligen svara 1-3");
                    }
                }
                System.Console.WriteLine("Tack för att du deltagit i våran frågesport.");
                System.Console.WriteLine($"Du fick totalt {poäng} poäng.");

                System.Console.WriteLine("Vill du spela igen?(J/N)");

                spela = Console.ReadLine();
                if (spela == "N")
                {
                    break;
                }
                if (spela != "N" || spela != "J")
                {
                    System.Console.WriteLine("Vänligen svara J för ja eller N för nej.");
                }
            }
        }
    }
}