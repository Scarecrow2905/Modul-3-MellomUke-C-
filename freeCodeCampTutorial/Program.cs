using System;

namespace freeCodeCampTutorial // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // METHODS
            SayWallah("Brur", 33);
            SayWallah("Bruh", 45);
            SayWallah("Brun", 50);  // Fungerer som en funksjon

            Console.ReadLine();
        }

        static void SayWallah(string name, int age)
        {
            Console.WriteLine("Wallah " + name + ", du er " + age + " år gammel.");
        }
    }
}



// VARIABLES

//string characterName = "John";
//int characterAge = 35;

//Console.WriteLine("There once was a man named " + characterName);
//Console.WriteLine("He was " + characterAge + " years old");
//Console.WriteLine("He really liked the named " + characterName);
//Console.WriteLine("But didn't like being " + characterAge);

//Console.ReadLine();


// DATA TYPES

//string text = "Wallah Brur";
//char letter = 'A';
//int number = 30;
//double gpa = 3.3;   // float, double, decimal //Mer og mer nøye fra venstre til høyre
//bool isDank = true;

//Console.WriteLine(30);

//Console.ReadLine();


// STRING METHODS

//string phrase = "Wallah Brur";


//Console.WriteLine(phrase.Substring(7, 3)); //Bru
//Console.WriteLine( phrase.IndexOf("Brur") ); //Starts at [7]
//Console.WriteLine(phrase[0]); // W
//Console.WriteLine(phrase.Contains ("Wallah") ); <-true
//Console.WriteLine(phrase.ToUpper());

//Console.ReadLine();


// MATH FUNCTIONS

//int num = 6;
//num++;
//num--; 
//Console.WriteLine(5 % 2); // 5 Divided by 2 and the Remainder is = 1

//Console.WriteLine( Math.Pow(3, 2)); // 3 Raised to the second power = 9
//Console.WriteLine(Math.Sqrt(36)); // SquareRoot
//Console.WriteLine(Math.Max(50, 90)); // Tells what the biggest number is
//Console.WriteLine(Math.Round(4.6)); // Rounds up the number to the closest whole number. In this case = 5

//Console.ReadLine();


// USER INPUT

//Console.Write("Wallah, enter your name: ");
//string name = Console.ReadLine(); // What the user writes will be stored in this variable called: name
//Console.WriteLine("Wallah, enter your age: ");
//string age = Console.ReadLine();
//Console.WriteLine("Wallah " + name + ", you are " + age);

//Console.ReadLine();



// BUILDING A CALCULATOR

//int num = Convert.ToInt32("56");
//Console.WriteLine(num + 6);

//Console.Write("Enter a number: ");
//double num1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter another number: ");
//double num2 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine(num1 + num2);

//Console.ReadLine();



//  MADLIBS

//string color, pluralNoun, celebrity;

//Console.Write("Enter a color: ");
//color = Console.ReadLine();

//Console.Write("Enter a plural noun: ");
//pluralNoun = Console.ReadLine();

//Console.Write("Enter a name of a celebrity: ");
//celebrity = Console.ReadLine();

//Console.WriteLine("Roses are " + color);
//Console.WriteLine(pluralNoun + " are red");
//Console.WriteLine("I love " + celebrity);




// ARRAYS

//int[] luckyNumbers = { 4, 5, 12, 53, 11, 45 };
////luckyNumbers[1] = 90; // Kan endre på en variabel inni et array
//string[] friends = new string[5]; // New string[] er størrelsen på array'et
//friends[0] = "brur";
//friends[1] = "Tjodleif";


//Console.WriteLine(luckyNumbers[1]);

//Console.ReadLine();