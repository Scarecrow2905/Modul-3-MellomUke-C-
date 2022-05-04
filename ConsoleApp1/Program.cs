namespace consoleApp1
{
    class Program
    {
        // VARIABEL OPPGAVE 1: FERDIG
        //Lag 8 variabler og til-ordne dem en verdi.
        //Det skal være en variabel per hver type: int, long, float, decimal, double, string, char og bool.

        //INT tall = 1; //Et Integer (Hel tall)
        //LONG nummer = 0L; //64-bit signed integer -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        //FLOAT floatNummer = 1.01f; // "f" Står for Float
        //DECIMAL decimalNummer = 1.2m; // Decimal nummer
        //DOUBLE doubleNummer = 114511.555d; // 64-bit double-precision floating point type
        //STRING strBokstaver = "Wallah brur"; // Doble snutter i strings
        //CHAR chrEnBokstav = 'A'; // Husk single snutter!!
        //BOOL santUsant = false; // True or False

        //double x;
        //double y;
        //double result;

        //Console.WriteLine("Enter in number 1: ");
        //    x = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine("Enter in number 2: ");
        //    y = Convert.ToDouble(Console.ReadLine());

        //    result = Multiply(x, y);

        //Console.WriteLine(result);

        //    Console.ReadKey();

        //----------------------------------------------------------------------------------------------------------

        //VARIABEL OPPGAVE 2: FERDIG
        // Lag en konsoll-applikasjon som lager 3 variabler.De kan hete a, b og sum.

        //a skal være en int
        //b skal være en decimal. 
        //Verdiene variablene skal ha er:


        //a = 5
        //b = 3.0
        //sum er a + b.
        //Hva slags type variabel må sum være?

        //static void Main(string[] args)
        //{
        //    // return = returns data back to the place where the method is invoked
        //    int a = 5;
        //    decimal b = 3.0m;
        //    double sum;
        //    sum = Multiply(a, b);
        //    Console.WriteLine(sum);
        //}
        //static double Multiply(int a, decimal b)
        //{
        //    double sum = (double)(a + b);
        //    return sum;
        //}

        // --------------------------------------------------------------------------------------------------------

        //OPPGAVER OM RETURVERDIER
        // Oppgave 1: Lag en metode som tar inn og returnerer summen av to tall
        // Oppgave 2: Lag en metode som returner "Denne metoden returnerer ingenting!" Why though?

        //        static void Main(string[] args)
        //        {
        //            // return = returns data back to the place where the method is invoked
        //            int a = 5;
        //            decimal b = 3.0m;
        //            double sum;
        //            sum = Multiply(a, b);
        //            Console.WriteLine(sum);
        //            Console.WriteLine("Denne metoden returnerer ingenting!");
        //        }
        //        static double Multiply(int a, decimal b)
        //        {
        //            double sum = (double)(a + b);
        //            return sum;
        //        }
        //    }
        //}

        // ----------------------------------------------------------------------------------------------------------
        // OPPGAVER OM WRITELINE OG READLINE:
        // Oppgave 1:
        // Lag en konsoll-app som skriver til brukeren "Hei, hva heter du?",
        // deretter leser inn input fra bruker og til slutt printer ut "Velkommen + det brukeren skrev"


        static void Main(string[] args)
        {
            Console.WriteLine("Hei, hva heter du?");
            String name = Console.ReadLine();

            Console.WriteLine("Hvor gammel er du?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Velkommen " + name + "!");
            Console.WriteLine("Du er " + age + " år gammel.");

            Console.ReadKey();
            
        }
      
    }
}
