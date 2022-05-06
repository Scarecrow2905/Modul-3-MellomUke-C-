using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Trykk en knapp for å kaste terningen.");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7); // Alt mellom 1 og 7 vil bli generert her, altså: 1,2,3,4,5 eller 6. Minimum(1) blir inkludert mens Maximum(7) blir ekskludert.
                Console.WriteLine("Du kastet: " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000); // Dette gjør at programmet "sover" i ett sekund før neste linje blir executed.

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Motstander kastet: " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Du vant denne runden!");
                }
                else if(playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Motstander vant denne runden!");
                }
                else
                {
                    Console.WriteLine("Uavgjort!");
                }

                Console.WriteLine("Dine poeng: " + playerPoints + ", Motstander AI sine poeng: " + enemyPoints);
                Console.WriteLine("--------------------------------");
            }

            if(playerPoints > enemyPoints)
            {
                Console.WriteLine("Spillet er over, du vant!");
            }
            else if(enemyPoints > playerPoints)
            {
                Console.WriteLine("Spillet er over, du tapte!");
            }
            else
            {
                Console.WriteLine("Spillet er over, det ble uavgjort!");
            }

            Console.WriteLine();
        }
    }
}
