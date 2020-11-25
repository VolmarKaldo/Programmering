using System;

namespace Uppgift_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nummer = { 3, 5, 23123, 23879, 23878, 13512, 1242, 8 };
            int störstaTal = 0;

            for (int i = 0; i < 8; i++)
            {
                System.Console.Write($"{nummer[i]} ");
                if (nummer[i] > störstaTal)
                {
                    störstaTal = nummer[i];
                }
            }
            Console.WriteLine($"Det största talet är {störstaTal}");
        }
    }
}
