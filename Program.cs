using System;

namespace Deliverable2
{
    //This is a Chat Bot program
    class Program
    {
        static void Main(string[] args)
        { 
            // declaring var so it can be used globally
            string usersInput = "empty";
            string lastInput = "empty";
            // This program is in a 'do while' loop so that the program runs onces, and then con. to run unless they say bye
          do {
            //ask users what they would like to say to the bot
            Console.WriteLine("What would you like to say to the bot?");

            //take in user input, ToLowerCase to account for case sensitive
            usersInput = Console.ReadLine();
            usersInput = usersInput.ToLower();


                //if input is hello, respond hi, good to see you
                if (usersInput == "hello" && usersInput != lastInput)
                    {
                        Console.WriteLine("Hi, good to see you!");
                        lastInput = usersInput;
                    }
                
                //if input is sup, respond I am good
                else if (usersInput == "sup" && usersInput != lastInput)
                    { 
                        Console.WriteLine("I am good");
                        lastInput = usersInput;
                    }
                
                // if input is hello there respond General Kenobi
                else if (usersInput == "hello there" && usersInput != lastInput)
                    { 
                        Console.WriteLine("General Kenobi");
                        lastInput = usersInput;
                    }
                // if input is the same as last input
                else if (usersInput == lastInput)
                    {
                        Console.WriteLine("I'm sorry but you have already said that");
                    }
                else if (usersInput == "bye")
                    { 
                        Console.WriteLine("Good bye!");
                        lastInput = usersInput;
                    }
                
          }
            // runs the program as long as users input is not bye
            while ((usersInput == "hello") || (usersInput == "sup") || (usersInput == "hello there"));
        }
    }
}
