using System;

namespace Projekt_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int svar = 0;
            int story = 0;
            Console.WriteLine("Du vaknar som vanligt en vanlig torsdagsmorgon av att ditt larm ringer. Du sträcker dig för att stänga av larmet.");
            Console.WriteLine("1. Du väljer att stänga av larmet och gå upp.");
            Console.WriteLine("2. Du väljer att snooza larmet i tio minuter.");
            svar = int.Parse(Console.ReadLine());
            if (svar == 1)
            {
                story = 1;
            }
            if (svar == 2)
            {
                story = 2;
            }
            if (story == 1)
            {
                Console.WriteLine("Som vanligt så äter du frukost och borstar tänderna, och inser sedan att du har 5 minuter extra innan du måste gå.");
                Console.WriteLine("1. Du väljer att gå direkt till skolan.");
                Console.WriteLine("2. Du väljer att istället ta 5 minuter extra att plugga en sista gång inför provet.");
                svar = int.Parse(Console.ReadLine());
                if (svar == 1)
                {
                    story = 3;
                }
                if (svar == 2)
                {
                    story = 4;
                }
            }
            if (story == 2)
            {
                System.Console.WriteLine("När du vaknar igen så känner du dig mycket mer utvilad och redo inför provet. Snart så blir du dock väldigt stressad, då du inser att du måste gå till skolan nu för att hinna i tid.");
                System.Console.WriteLine("1. Du väljer att gå till skolan direkt, och inte äta frukost i hopp om att inte bli försenad.");
                System.Console.WriteLine("2. Du väljer att äta frukost, då du tror att du kommer prestera sämre på provet om du inte gör det.");
                svar = int.Parse(Console.ReadLine());
                if (svar == 1)
                {
                    story = 3;
                }
                if (svar == 2)
                {
                    story = 5;
                }
            }
            if (story == 3)
            {
                Console.WriteLine("När du kommer fram till tunnelbanestationen ser du att allting verkar vara 10 minuter föresenat. Du kommer knappt på ett proppfullt tåg. När du kommer fram springer du sista biten till skolan, och kommer fram precis när läraren stänger dörren.");
                Console.WriteLine("Under provet inser du dock att det är en massa saker du har missat att repetera, och under hela tiden känns det som att det bara går sämre och sämre.");
                Console.WriteLine("När du sedan får tillbaka provet en vecka senare, så bekräftas dina rädslor. Mer eller mindre allt ser fel ut.");
            }
            if (story == 4)
            {
                Console.WriteLine("Ditt pluggande gör att du tappar bort tiden, och tyvärr så innebär detta att du går hemifrån 5 minuter för sent.");
                Console.WriteLine("Du försöker gå lite snabbare för att ta igen tiden, men trots det så missar du det tåg du behövde ta. Nästa går om 30 minuter.");
                Console.WriteLine("När du kommer fram så har provet redan börjat. Du bankar på dörren för att få komma in, men läraren verkar inte höra det. Du missar provet, och under omprovsdagen är du sjuk. Du kan inte låta bli att tänka vad som hade hänt om du bara hade gått hemifrån lite tidigare.");
            }
            if (story == 5)
            {
                Console.WriteLine("Du äter frukost snabbare än någonsin förut, och slänger sedan på dig jackan innan du springer mot skolan. För en gångs skull är bussen till och med i tid, och du hinner på precis när dörrarna stängts.");
                Console.WriteLine("Du pustar ut, samtidigt som bussen börjar åka. Men sen inträffar det fasansfulla: bilkö. Du sitter och kollar konstant på klockan medans tiden går, och du inser att du inte kommer att hinna i tid.");
                Console.WriteLine("När du kommer fram är du 15 minuter försenad. Alla sitter redan och skriver på sina prov. Du bankar på dörren och läraren kommer till sist och öppnar. Du pustar ut över att du hann i tid, och börjar skriva. Du blir precis klar med sista frågan innan tiden är slut.");
                Console.WriteLine("Du får tillbaka provet en tid senare. Inte alla rätt, men fortfarande inte dåligt för att ha 15 minuter mindre att skriva.");
            }
        }
    }
}