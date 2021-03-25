using System;

namespace Uppgift6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiplicera(4.5, 5.5));
            Console.WriteLine(Dividera(68.9, 5.2));
        }
        static double Multiplicera(double tal1, double tal2)
        {
            double produkt = tal1 * tal2;
            return produkt;
        }
        static double Dividera(double tal1, double tal2)
        {
            double kvot = tal1 / tal2;
            return kvot;
        }
    }
}
