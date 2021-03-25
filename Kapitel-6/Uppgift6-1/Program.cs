using System;

namespace Kapitel_6
{
    class Program
    {
        static void Main(string[] args)
        {
            TalIKvadrat(3);
            TalIKvadrat(4);
            TalIKvadrat(5);
        }
        static void TalIKvadrat(int tal)
        {
            System.Console.WriteLine($"Talet {tal} i kvadrat är {tal * tal}");
        }
    }
}
