using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user)
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskas rohkem, on mängu võitja
            //täringuid visatakse kolm korda
            //programm kuulutab võitja

            Random rnd = new Random();
            
            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++)
            {
                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas: {cpuRandom}, kasutaja viskas: {userRandom}");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja võitis");
                    userScore++;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti võitis");
                    cpuScore++;
                }
                else
                {
                    Console.WriteLine("Viik");
                }

            }

            if (cpuScore > userScore)
            {
                Console.WriteLine("Mängu võitis arvuti.");
            }
            else if (userScore > cpuScore)
            {
                Console.WriteLine("Mängu võitis kasutaja. Palju õnne!");
            }
            else
            {
                Console.WriteLine("Mäng jäi viiki!");
            }

        }
    }
}
