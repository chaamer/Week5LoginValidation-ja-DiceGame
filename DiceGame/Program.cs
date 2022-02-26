using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Osaleb kaks mängijat
            //Mõlemad viskavad täringut
            //Kontrollitakse kumb viskas rohkem, suurem nr võidab
            //Täringuid visatakse kolm korda
            for (int i = 0; i < 3; i++)
            { 
            Random rnd = new Random();
            //arvuti vise
            int cpuRandom = rnd.Next(1, 7);
            //Kasutaja vise
            int userRandom = rnd.Next(1, 7);

            int cpuScore = 0;
            int userScore = 0;

            

            

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

            if (cpuRandom < userRandom)
            {
                Console.WriteLine("Kasutaja võitis!");
                userScore = userScore + 1; 

            }

            else if(cpuRandom > userRandom)
            {
                Console.WriteLine("Arvuti võitis!");
                cpuScore = cpuScore + 1;
            }
            else
            {
                Console.WriteLine("Viik");
            }
            }
        }
    }
}
