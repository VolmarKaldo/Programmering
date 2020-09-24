using System;

namespace Uppgift_2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en addition");
            string addition = Console.ReadLine();
            int position = addition.IndexOf("+");
            int tal1 = int.Parse(addition.Substring(0, position));
            int tal2 = int.Parse(addition.Substring(position + 1));
            int summa = tal1 + tal2;
            Console.WriteLine(addition + "=" + summa);
        }
    }
}
