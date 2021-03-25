using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar = "";
            while (svar != "4")
            {
                VisaMeny();
                svar = Console.ReadLine();

                switch (svar != "3")
                {
                    case "1":
                        SkrivUtVertikalt();
                        break;
                    case "2":
                        SkrivUtOmvänt();
                        break;
                    case "3":
                        break;
                    default:
                }
            }

        }
        static void VisaMeny()
        {
            Console.WriteLine("Välj ett alternativ:");
            System.Console.WriteLine("1. Skriv ut texten vertikalt");
            System.Console.WriteLine("2. Skriv ut texten omvänt");
            System.Console.WriteLine("3. Avsluta");
        }
        static void SkrivUtVertikalt()
        {

        }
        static void SkrivUtOmvänt()
        {

        }
    }
}
