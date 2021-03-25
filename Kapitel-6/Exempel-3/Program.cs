using System;

namespace Exempel_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = Summera(118, 92);

            string omväntText = VändText("Programmering");
        }
        static int Summera(int x, int y)
        {
            int z = x + y;
            return z;
        }
        static string VändText()
        {
            string resultat = "";
            return resultat;
        }
    }
}
