using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange en text: ");
            string text = Console.ReadLine();
            string[] orden = text.Split(" ");

            // for (int i = 0; i < orden.Length; i++)
            //{
            //  System.Console.WriteLine($"Ord {i + 1}: {orden[i]}");
            //}

            foreach (var ord in orden)
            {
                System.Console.WriteLine(ord);
            }
        }
    }
}
