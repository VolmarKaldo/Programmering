using System;

namespace Tilemap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] labyrint = {
                {1,1,1,1,1},
                {0,0,0,0,1},
                {1,0,1,0,1},
                {1,0,1,0,0},
                {1,0,1,1,1}
            };

            Console.OutputEncoding = System.Text.Encoding.Default;

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (labyrint[y, x] == 1)
                    {
                        Console.Write('\u2B1C');
                    }
                    else
                    {
                        System.Console.Write('\u2B1B');
                    }
                }

                System.Console.WriteLine();
            }
        }
    }
}
