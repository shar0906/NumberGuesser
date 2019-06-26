using System;

//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); //Run GetAppInfo function

            //Ask user's name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...",inputName);

            while (true)
            {
                //Init correct number
                //int correctNumber = 7;

                //Create a new random object
                Random random = new Random();

                //Init correct number
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Ask user to guess a number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    // Get suers input
                    string input = Console.ReadLine();

                    //Make sure the input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Tell user it's not a number
                        Console.WriteLine("Please enter an actual number");

                        //Reset text color
                        Console.ResetColor();

                        //Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Tell user it's the wrong number
                        Console.WriteLine("Wrong number, please try again");

                        //Reset text color
                        Console.ResetColor();

                    }
                }
                //Change text color
                Console.ForegroundColor = ConsoleColor.Yellow;

                //Tell user it's the correct number
                Console.WriteLine("You are CORRECT!!!");

                //Reset text color
                Console.ResetColor();

                //Ask to play again
                Console.WriteLine("Play again?[Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer =="Y") {
                    continue;
                } else if (answer == "N" ) {
                    return; 
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo() {

            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0.";
            string appAuthor = "Shable Harris";

            //Change text color
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();

        }
    }
}
