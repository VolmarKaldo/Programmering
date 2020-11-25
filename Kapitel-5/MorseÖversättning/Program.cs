using System;

namespace MorseÖversättning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detta är ett program för att översätta en text till morse.");
            System.Console.WriteLine("Vad vill du översätta?");
            string meddelande = Console.ReadLine().ToUpper();

            for (int i = 0; i < meddelande.Length; i++)
            {

                string tecken = meddelande[i].ToString();
                string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ ,.";
                int index = alfabetet.IndexOf(tecken);
                string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", ".--", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", "/", ",", "." };
                string morseTecken = morse[index];
                Console.Write(morseTecken + " ");
            }
        }
    }
}
