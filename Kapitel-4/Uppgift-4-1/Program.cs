using System;

namespace Uppgift_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket är världens folkrikaste land?");
            string svar = Console.ReadLine();
            while (svar != "Kina")
            {
                Console.WriteLine("Fel svar. Gissa igen!");
                svar = Console.ReadLine();
            }
            System.Console.WriteLine("Rätt svar!");
        }
    }
}
