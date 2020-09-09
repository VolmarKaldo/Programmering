using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string namn = "";
            string hobby = "";
            string meddelande = "";

            Console.WriteLine("Vad heter du?");
            namn = Console.ReadLine();

            Console.WriteLine("Hej " + namn + "! Vad har du för hobby?");
            hobby = Console.ReadLine();

            meddelande = ("Hej " + namn + "! Du gillar att " + hobby);
            Console.WriteLine(meddelande);
        }
    }
}
