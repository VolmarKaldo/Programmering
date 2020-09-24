using System;

namespace Uppgift_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilka vann fotbolls-VM för damer 2012?");
            string vinnare = Console.ReadLine();
            vinnare = vinnare.ToLower();
            if (vinnare == "usa")
            {
                Console.WriteLine("Rätt svar!");
            }
        }
    }
}
