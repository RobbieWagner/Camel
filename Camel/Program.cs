using System;

namespace Camel
{
    class Program
    {
        public static int Increase_player_sales(int player_sales, Random random, bool crunching)
        {
            //increases the player's sales
            int lower_bounds;
            int upper_bounds;
            int player_new_sales;
            if (crunching)
            {
                lower_bounds = 5;
                upper_bounds = 14;
            }
            else
            {
                lower_bounds = 3;
                upper_bounds = 10;
            }
            player_new_sales = random.Next(lower_bounds, upper_bounds);
            player_sales += player_new_sales;

            Console.WriteLine(" You made " + player_new_sales + " new sales!");
            return player_sales;
        }

        public static int Increase_enemy_sales(int enemy_sales, Random random)
        {
            //increases the enemies sales
            int lower_bounds = 3;
            int upper_bounds = 10;
            enemy_sales += random.Next(lower_bounds, upper_bounds);

            return enemy_sales;
        }

        static void Main(string[] args)
        {
            bool done = false;

            while (!done)
            { 
            // variable initialization
            Random random = new Random();

            int player_sales = 12;
            int enemy_sales = 0;
            int GOAL = 100;

            int supply_orders = 3;
            int supplies = 100;

            int office_morale = 10;

            //game introduction
            Console.WriteLine(" ---------------------------------------------------------\n" +
                " NEW MESSAGE RECIEVED\n\n Hey Girlie! This is your boss here." +
                "\n Hope my favorite fashion designer and her team is enjoying the new office space. It cost quite a pretty penny!\n\n " +
                "Okay Girlie, time for some fashion business realness. You remember Brenda's fashion company \"Are You For Real?!?!?\"?\n " +
                "Well apparently that skank started releasing new fashion lines like crazy,\n and her company is quickly catching up to ours in sales.\n " +
                "(Like we can't let Brenda win, girl. I mean, she called my fiance an Oompa Loompa TO HIS FACE\n at last years fashion conference. Ikr?)." +
                "Look. I need to stay on top. My fiance just put the down payment on our yacht, and it's non-refundable.\n That being said,\n " +
                "I'm gonna need you to ramp up production. Make some bitching lines, and get us some sales!\n " +
                "I believe in you, bitch! <3\n\n Love,\n Your #Girlboss" +
                "\n ---------------------------------------------------------");

            bool gameOver = false;

                while (!gameOver)
                {
                    //prompt the user with possible actions
                    Console.WriteLine();
                    Console.WriteLine(" A. Order Supplies");
                    Console.WriteLine(" B. Design Outfits");
                    Console.WriteLine(" C. Crunch (Work Really Hard)");
                    Console.WriteLine(" D. Have an Office Party");
                    Console.WriteLine(" E. Business Statistics");
                    Console.WriteLine(" F. Quit Game");
                    Console.WriteLine();

                    if (office_morale < 4)
                    {
                        Console.WriteLine(" Your team is getting annoyed with your leadership.");
                    }
                    if(supplies < 20)
                    {
                        Console.WriteLine(" You are running low on supplies.");
                    }
                    Console.WriteLine(" What would you like to do?");
                    string userCommand = Console.ReadLine();
                    Console.WriteLine();

                    //analyze player commands
                    if (userCommand.ToUpper() == "A")
                    {
                        if (supply_orders > 0)
                        {
                            supply_orders--;
                            supplies = 100;
                            enemy_sales = Increase_enemy_sales(enemy_sales, random);
                        }
                        Console.WriteLine(" Supplies Ordered. Should be here by tomorrow.");
                    }
                    else if (userCommand.ToUpper() == "B")
                    {
                        player_sales = Increase_player_sales(player_sales, random, false);
                        enemy_sales = Increase_enemy_sales(enemy_sales, random);

                        supplies -= random.Next(10, 21);
                        office_morale--;
                    }
                    else if (userCommand.ToUpper() == "C")
                    {
                        player_sales = Increase_player_sales(player_sales, random, true);
                        enemy_sales = Increase_enemy_sales(enemy_sales, random);

                        supplies -= random.Next(10, 21);
                        office_morale -= random.Next(1, 4);
                    }
                    else if (userCommand.ToUpper() == "D")
                    {
                        enemy_sales = Increase_enemy_sales(enemy_sales, random);
                        office_morale = 10;
                        Console.WriteLine(" You have a fun office party. Office morale is restored!");
                    }
                    else if (userCommand.ToUpper() == "E")
                    {
                        Console.WriteLine(" Your Sales: " + player_sales
                            + "\n Are You For Real?!?!?'s Sales: " + enemy_sales
                            + "\n Supplies: " + supplies
                            + "\n Supply Shipments Available: " + supply_orders);
                    }
                    else if (userCommand.ToUpper() == "F")
                    {
                        Console.WriteLine(" Thank you for playing");
                        done = true;
                        gameOver = true;
                    }
                    else
                    {
                        Console.WriteLine(" Invalid input. Please try again.");
                    }

                    //check for game ending conditions
                    if (player_sales >= GOAL)
                    {
                        Console.WriteLine("-------------------------------------------------------- -\n" +
                " NEW MESSAGE RECIEVED\n\n Hey Baddie XP!\n\n " +
                "You really are the best!\n Thanks to you, I'm not gonna have to deal with Brenda's stank breath \n" +
                " at next years fashion conference (She couldn't even afford real gold on her yacht teehee).\n Ofc," +
                " because you really saved my skin there, I'm gonna see about getting you that promotion you really wanted!\n " +
                "Can't wait to see you at the holiday party! \n" +
                " Mwah,\n Your #Girlboss" +
                "\n --------------------------------------------------------");
                        gameOver = true;
                    }
                    else if (enemy_sales >= player_sales)
                    {
                        Console.WriteLine(" ---------------------------------------------------------\n" +
                " NEW MESSAGE RECIEVED\n\n Hey Queen!\n\n Looks like you failed to make new outfits." +
                "\n Now Brenda's company is number 1, and we're gonna lose a ton of money!\n " +
                "Worst of all, you and I both know Brenda's gonna lord this over me at the next conference.\n " +
                "So thanks for making my life a living hell.\n\n " +
                "Hate,\n Your #Girlboss\n\n P.S. You're fired, obvs." +
                "\n --------------------------------------------------------");
                        gameOver = true;
                    }
                    else if (supplies <= 0)
                    {
                        Console.WriteLine(" ---------------------------------------------------------\n" +
                " NEW MESSAGE RECIEVED\n\n Hey Gorgeous!\n\n So, um, you definitely forgot to order supplies, and now there's" +
                " not enough fabric for your team to use.\n According to our super long contract that you probably didn't even read,\n " +
                "that is a fireable offense. So yeah, sorry, but imma have to let you go\n " +
                "Good luck on the unemployment line, girlie!\n\n " +
                "XOXO,\n Your #Girlboss" +
                "\n --------------------------------------------------------");
                        gameOver = true;
                    }
                    else if (office_morale <= 0)
                    {
                        Console.WriteLine("---------------------------------------------------------\n " +
                "NEW MESSAGE RECIEVED\n\n Hey Bitch!\n\n WTF is going with your team?\nMany of them are refusing to work, " +
                "they're filing complaints, and I think one of them tried to doxx me.\n Anywho, due to the recent sitch," +
                "we're gonna have to let you go... super unfair, I know.\n But hey, if it makes you feel better, my fiance totally" +
                "bought the wrong wallpaper for the walls in our Yacht's ballroom. Terrible, right?" +
                "\n Anyway good luck out there bestie, hope you don't get doxxed!" +
                "\n\n Tootles!\n " +
                "Your #Girlboss" +
                "\n --------------------------------------------------------");
                        gameOver = true;
                    }
                }

                //check if the user would like to play again
                Console.WriteLine("Would you like to play again (Y/N)? ");
                string userQuit = Console.ReadLine();
                if (userQuit != "Y")
                {
                    done = true;
                }
            }
        }
    }
}
