using System;

namespace Camel
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable initialization
            int player_pos = 10;
            int enemy_pos = 0;
            int GOAL = 100;

            //game introduction
            Console.WriteLine("Welcome to Camel");

            bool done = false;

            while(!done)
            {
                //prompt the user with possible actions
                Console.WriteLine();
                Console.WriteLine("A. Change Batteries");
                Console.WriteLine("B. Move ahead slowly");
                Console.WriteLine("C. Run");
                Console.WriteLine("D. Rest");
                Console.WriteLine("E. Check Info");
                Console.WriteLine("F. Quit Game");

                Console.WriteLine("What would you like to do?");
                string userCommand = Console.ReadLine();
                Console.WriteLine();

                //analyze player commands
                if (userCommand.ToUpper() == "A")
                {
                    Console.WriteLine("Batteries changed.");
                }
                else if (userCommand.ToUpper() == "B"){

                }
                else if (userCommand.ToUpper() == "C")
                {

                }
                else if (userCommand.ToUpper() == "D")
                {

                }
                else if (userCommand.ToUpper() == "E")
                {

                }
                else if (userCommand.ToUpper() == "F")
                {
                    Console.WriteLine("Thank you for playing");
                    done = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }
    }
}
