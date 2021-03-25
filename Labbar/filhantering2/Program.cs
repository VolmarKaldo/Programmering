using System;

namespace filhantering2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filnamn = ".animals.txt";
            string [] rader = File.ReadAllLines(filnamn);

            Console.WriteLine("Ange sökterm (första bokstaven): ")
            string sökterm= Console.ReadLine();

            int radNr = 1;
            foreach (var rad in rader)
            {
                
            }
        }
    }
}
