using System;

namespace Uppgift_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening med två ord.");
            string mening = Console.ReadLine();
            int position = mening.IndexOf(" ");
            string ord1 = mening.Substring(0, position);
            string ord2 = mening.Substring(position + 1);
            Console.WriteLine(ord2 + " " + ord1);
        }
    }
}
