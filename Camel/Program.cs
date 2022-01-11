﻿using System;

namespace Camel
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable initialization
            Random random = new Random();

            int player_sales = 10;
            int enemy_sales = 0;
            int GOAL = 100;

            int supply_orders = 3;
            int supplies = 100;

            int office_morale = 10;

            int player_new_sales = 0;
            int enemy_new_sales = 0;

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
                    Console.WriteLine("Supplies Ordered. Should be here by tomorrow.");
                }
                else if (userCommand.ToUpper() == "B")
                {
                    player_new_sales = random.Next(2, 7);
                    player_sales += player_new_sales;
                    Console.WriteLine("you made " + player_new_sales + " new sales!");
                }
                else if (userCommand.ToUpper() == "C")
                {
                    player_new_sales = random.Next(5, 14);
                    player_sales += player_new_sales;
                    Console.WriteLine("you made " + player_new_sales + " new sales!");
                }
                else if (userCommand.ToUpper() == "D")
                {
                    Console.WriteLine("You have a fun office party. Office morale is restored!");
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
                    Console.WriteLine("Bestie Succeeded!");
                }
                else if(enemy_sales >= player_sales)
                {
                    Console.WriteLine("Bestie Failed!");
                }
            }
        }
    }
}
