using System;

namespace Uppgift_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många poäng fick du?");
            int poäng = int.Parse(Console.ReadLine());
            string betyg = "";

            if (poäng >= 55)
            {
                betyg = "A";
            }
            else if (poäng >= 46)
            {
                betyg = "B";
            }
            else if (poäng >= 35)
            {
                betyg = "C";
            }
            else if (poäng >= 27)
            {
                betyg = "D";
            }
            else if (poäng >= 18)
            {
                betyg = "E";
            }
            else
            {
                betyg = "F";
            }
            Console.WriteLine($"Ditt betyg är {betyg}.");
        }
    }
}

