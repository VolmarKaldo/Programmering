using System;

namespace HittaBokstav
{
    class Program
    {
        static void Main(string[] args)
        {
            //Läs in en bokstav
            Console.Write("Skriv in en bokstav: ");
            string bokstav = Console.ReadLine();
            bokstav = bokstav.ToUpper();
            //Skapa en samling för alfabetet.
            string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ ";

            //Hitta bokstavens plats i alfabetet
            int index = alfabetet.IndexOf(bokstav);

            System.Console.WriteLine(index);

            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", ".--", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", " " };

            string morseText = morse[index];

            System.Console.WriteLine(morseText);
        }
    }
}
