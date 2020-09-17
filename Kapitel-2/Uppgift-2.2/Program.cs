using System;

namespace Uppgift_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int årNu = "0";
            int år20 = "0";

            Console.Write("Vilket år är det?");
            årNu = int.Parse(Console.ReadLine());
            år20 = årNu + 20;
            Console.WriteLine("Om 20 år är det " + år20);
        }
    }
}
