using System;

namespace Uppgift_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            int[] talen = new int[5] { 23, 45, 34, 22, 12 };
            foreach (var tal in talen)
            {
                summa += tal;
            }
            System.Console.WriteLine(summa);
        }
    }
}
