using System;

namespace Exempel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mailadress");
            string email = Console.ReadLine();
            int position = email.IndexOf("@");
            Console.WriteLine(position);
            string namn = email.Substring(0, position);
            Console.WriteLine(namn);
            string domän = email.Substring(position + 1);
            Console.WriteLine(domän);
        }
    }
}
