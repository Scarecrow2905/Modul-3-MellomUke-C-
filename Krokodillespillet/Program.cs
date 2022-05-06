using System;

namespace Krokodillespillet
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int points = 0;
            bool gameIsRunning = true;
            int RandomNum;
            int RandomNum2;
            Random random = new Random();

            while (gameIsRunning)
            {
                Console.WriteLine("Press <, > or = ");

                string userInput = Console.ReadLine();
                if (userInput != "<" && userInput != ">" && userInput != "=")
                {
                    Console.WriteLine("Wallah, ugyldig tegn!");
                    gameIsRunning = false;
                }
                else
                {
                    Console.WriteLine();
                    RandomNum = random.Next(0, 12);
                    RandomNum2 = random.Next(0, 12);

                    Console.WriteLine(RandomNum + userInput + RandomNum2);

                    // Skal sjekke hvilket tall som er størst
                    // Skal printe ut score 

                    if (RandomNum > RandomNum2 && userInput == ">") points++;
                    if (RandomNum > RandomNum2 && userInput == "<") points--;
                    if (RandomNum > RandomNum2 && userInput == "=") points--;

                    if (RandomNum < RandomNum2 && userInput == ">") points--;
                    if (RandomNum < RandomNum2 && userInput == "<") points++;
                    if (RandomNum < RandomNum2 && userInput == "=") points--;

                    if (RandomNum == RandomNum2 && userInput == ">") points--;
                    if (RandomNum == RandomNum2 && userInput == "<") points--;
                    if (RandomNum == RandomNum2 && userInput == "=") points++;

                    Console.WriteLine("Points: " + points);
                }
            }

        }
    }
}
