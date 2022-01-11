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

            int batteries = 3;
            int battery_level = 100;

            int turns_since_rest = 0;

            //game introduction
            Console.WriteLine("The year is 1995. You are a park ranger in Southern Montana working at night. " +
                "During one of your rounds surveying the park, you recieve a call on the emergency radio. " +
                "\nHello?\nIs anyone there?\nThank God.\nLook. I need some help.");

            bool done = false;

            while(!done)
            {
                //prompt the user with possible actions
                Console.WriteLine();
                Console.WriteLine("A. Change Batteries");
                Console.WriteLine("B. Move ahead");
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
                else if (userCommand.ToUpper() == "B")
                {
                    Console.WriteLine("You walk at a brisk pace.");
                }
                else if (userCommand.ToUpper() == "C")
                {
                    Console.WriteLine("You charge ahead, pushing yourself to move as fast as you can");
                }
                else if (userCommand.ToUpper() == "D")
                {
                    Console.WriteLine("You pause for a minute, holding your head, catching your breath, and slowing your heartrate");
                }
                else if (userCommand.ToUpper() == "E")
                {
                    Console.WriteLine("Your Position: " + player_pos
                        + "\nIts Position: " + enemy_pos
                        + "\nBatteries: " + batteries);
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

                if(player_pos >= GOAL)
                {
                    Console.WriteLine("The Voice enters your head once more.\n\n\"It's okay. You're safe now.\"");
                }
            }
        }
    }
}
