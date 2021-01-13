using System;

namespace expert10000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du träna per dag?");
            string svar = Console.ReadLine();
            double timmarPerdag = 0;
            double timmarPerdag = (double)svar;

            
            while (!double.TryParse(svar, out timmarPerdag))
            {
                Console.WriteLine("Ogiltlig input, var god försök igen! ");
                svar=Console.ReadLine();
            }

            DateTime datumklar= DateTime.Today.AddDays(10000/timmarPerdag);
            TimeSpan hurLångTid = datumklar - DateTime.Today;

            int antalÅr= hurLångTid/365;

            System.Console.WriteLine($"Du måste träna i {antalÅr} år");
        }
    }
}
