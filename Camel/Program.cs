using System;

namespace Camel
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable initialization
            int player_sales = 10;
            int enemy_sales = 0;
            int GOAL = 100;

            int supply_orders = 3;
            int supplies = 100;

            int turns_since_office_party = 0;

            //game introduction
            Console.WriteLine("---------------------------------------------------------\n" +
                "NEW MESSAGE RECIEVED\n\nHey Girlie! This is your boss here." +
                " Hope my favorite fashion designer and her team is enjoying the new office space. It cost quite a pretty penny.\n\n" +
                "Okay Girlie, time for some fashion business realness. You remember Brenda's fashion company \"Are You For Real?!?!?\"?\n" +
                "Well apparently that skank started releasing new fashion lines like crazy, and her company is quickly catching up to ours in sales.\n" +
                "(Like we can't let Brenda win, girl. I mean, she called my fiance an Oompa Loompa TO HIS FACE at last years fashion conference. Ikr?)." +
                "Look. I need to stay on top. My fiance just put the down payment on our yacht, and it's non-refundable. That being said,\n" +
                "I'm gonna need you to ramp up production. Make some bitching lines, and get us some sales!\n\n" +
                "I believe in you, bitch!\nYour #Girlboss" +
                "---------------------------------------------------------");

            bool done = false;

            while(!done)
            {
                //prompt the user with possible actions
                Console.WriteLine();
                Console.WriteLine("A. Order Supplies");
                Console.WriteLine("B. Design Outfits");
                Console.WriteLine("C. Crunch (Work Really Hard)");
                Console.WriteLine("D. Have an Office Party");
                Console.WriteLine("E. Business Statistics");
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
                    Console.WriteLine("Your Sales: " + player_sales
                        + "\nAre You For Real?!?!?'s Sales" + enemy_sales
                        + "\nSupply Shipments Available: " + supply_orders);
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

                if(player_sales >= GOAL)
                {
                    Console.WriteLine("The Voice enters your head once more.\n\n\"It's okay. You're safe now.\"");
                }
            }
        }
    }
}
