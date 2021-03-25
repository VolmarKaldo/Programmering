using System;

namespace Uppgift6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Längst("Hej", "Hejsan"));
        }
        static string Längst(string text1, string text2)
        {
            string längstText;
            if (text1.Length > text2.Length)
            {
                längstText = text1;
            }
            else if (text1.Length < text2.Length)
            {
                längstText = text2;
            }
            else
            {
                längstText = "Texterna är lika långa";
            }
            return längstText;
        }
    }
}
