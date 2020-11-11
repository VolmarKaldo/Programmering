using System;

namespace CaesarKrypto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange en text: ");
            string text = Console.ReadLine();

            int textLängd = text.Length;
            Console.WriteLine($"Texten är {textLängd} tecken lång");

            System.Console.WriteLine("Hur många tecken åt höger vill du kryptera?");
            int kryptera = int.Parse(Console.ReadLine());

            for (int i = 0; i < textLängd; i++)
            {
                System.Console.WriteLine($"Loop nr {i}");

                char bokstav = text[i];
                System.Console.WriteLine($"Bokstaven på position {i} är {bokstav}");

                int ascii = (int)bokstav;
                System.Console.WriteLine($"Bokstav {bokstav} har ASCII-värdet {ascii}");

                ascii -= kryptera;

                char krypteradbokstav = (char)ascii;
                System.Console.WriteLine($"Bokstaven {bokstav} krypteras till {krypteradbokstav}");

                string krypteradText += krypteradbokstav.ToString();
            }
            System.Console.WriteLine($"Det krypterade meddelandet är: {KrypteradText}");
        }
    }
}
