using System;

namespace Camel
{
    class Program
    {

        public static int IncreasePlayerSales(int playerSales, Random random, bool crunching)
        {
            //increases the player's sales
            int lowerBound;
            int upperBound;
            int playerNewSales;

            if (crunching)
            {
                lowerBound = 5;
                upperBound = 14;
            }
            else
            {
                lowerBound = 3;
                upperBound = 10;
            }
            playerNewSales = random.Next(lowerBound, upperBound);
            playerSales += playerNewSales;

            Console.WriteLine(" You made " + playerNewSales + " new sales!");
            return playerSales;
        }

        public static int IncreaseEnemySales(int enemySales, Random random)
        {
            //increases the enemies sales
            int lowerBound = 3;
            int upperBound = 10;
            enemySales += random.Next(lowerBound, upperBound);

            return enemySales;
        }

        static void Main(string[] args)
        {
            bool Done = false;

            while (!Done)
            { 
            // variable initialization
            Random random = new Random();

            int PlayerSales = 12;
            int EnemySales = 0;
            int SalesGoal = 100;

            int SupplyOrders = 3;
            int Supplies = 100;

            int OfficeMorale = 10;

                //game introduction
                Console.WriteLine(" ---------------------------------------------------------");
                Console.WriteLine(" NEW MESSAGE RECIEVED");
                Console.WriteLine("\n Hey Girlie! This is your boss here.");
                Console.WriteLine(" Hope my favorite fashion designer and her team is enjoying the new office space. It cost quite a pretty penny!");
                Console.WriteLine("\n Okay Girlie, time for some fashion business realness. You remember Brenda's fashion company \"Are You For Real?!?!?\"?");
                Console.WriteLine(" Well apparently that skank started releasing new fashion lines like crazy,");
                Console.WriteLine(" and her company is quickly catching up to ours in sales.");
                Console.WriteLine(" (Like we can't let Brenda win, girl. I mean, she called my fiance an Oompa Loompa TO HIS FACE ");
                Console.WriteLine(" at last years fashion conference. Ikr?).");
                Console.WriteLine(" Look. I need to stay on top. My fiance just put the down payment on our yacht, and it's non-refundable.\n That being said,\n ");
                Console.WriteLine(" I'm gonna need you to ramp up production. Make some bitching lines, and get us some sales! ");
                Console.WriteLine(" I believe in you, bitch! <3\n\n Love,\n Your #Girlboss");
                Console.WriteLine("---------------------------------------------------------");

            bool GameOver = false;

                while (!GameOver)
                {
                    //prompt the user with possible actions
                    Console.WriteLine();
                    Console.WriteLine(" A. Order Supplies");
                    Console.WriteLine(" B. Design Outfits");
                    Console.WriteLine(" C. Crunch (Work Really Hard)");
                    Console.WriteLine(" D. Have an Office Party");
                    Console.WriteLine(" E. Business Statistics");
                    Console.WriteLine(" Q. Quit Game");
                    Console.WriteLine();

                    if (OfficeMorale < 4)
                    {
                        Console.WriteLine(" Your team is getting annoyed with your leadership.");
                    }
                    if(Supplies < 20)
                    {
                        Console.WriteLine(" You are running low on supplies.");
                    }

                    Console.WriteLine(" What would you like to do?");
                    string userCommand = Console.ReadLine();
                    Console.WriteLine();

                    //analyze player commands
                    if (userCommand.ToUpper().Equals("A"))
                    {
                        if (SupplyOrders > 0)
                        {
                            SupplyOrders--;
                            Supplies = 100;
                            EnemySales = IncreaseEnemySales(EnemySales, random);
                        }
                        Console.WriteLine(" Supplies Ordered. Should be here by tomorrow.");
                    }
                    else if (userCommand.ToUpper().Equals("B"))
                    {
                        PlayerSales = IncreasePlayerSales(PlayerSales, random, false);
                        EnemySales = IncreaseEnemySales(EnemySales, random);

                        Supplies -= random.Next(10, 21);
                        OfficeMorale--;
                    }
                    else if (userCommand.ToUpper().Equals("C"))
                    {
                        PlayerSales = IncreasePlayerSales(PlayerSales, random, true);
                        EnemySales = IncreaseEnemySales(EnemySales, random);

                        Supplies -= random.Next(10, 21);
                        OfficeMorale -= random.Next(1, 4);
                    }
                    else if (userCommand.ToUpper().Equals("D"))
                    {
                        EnemySales = IncreaseEnemySales(EnemySales, random);
                        OfficeMorale = 10;
                        Console.WriteLine(" You have a fun office party. Office morale is restored!");
                    }
                    else if (userCommand.ToUpper().Equals("E"))
                    {
                        Console.WriteLine(" Your Sales: " + PlayerSales);
                        Console.WriteLine(" Are You For Real?!?!?'s Sales: " + EnemySales);
                        Console.WriteLine(" Sales Ahead: " + (PlayerSales - EnemySales));
                        Console.WriteLine();
                        Console.WriteLine(" Current Supplies: " + Supplies);
                        Console.WriteLine(" Supply Shipments Available: " + SupplyOrders);
                    }
                    else if (userCommand.ToUpper().Equals("Q"))
                    {
                        Console.WriteLine(" Thank you for playing.");
                        Done = true;
                        GameOver = true;
                    }
                    else
                    {
                        Console.WriteLine(" Invalid input. Please try again.");
                    }

                    //check for game ending conditions
                    if (PlayerSales >= SalesGoal)
                    {
                        Console.WriteLine(" ---------------------------------------------------------");
                        Console.WriteLine(" NEW MESSAGE RECIEVED\n");
                        Console.WriteLine(" Hey Baddie XP!\n");
                        Console.WriteLine(" You really are the best!");
                        Console.WriteLine(" Thanks to you, I'm not gonna have to deal with Brenda's stank breath");
                        Console.WriteLine(" at next years fashion conference (She couldn't even afford real gold on her yacht teehee).");
                        Console.WriteLine(" Ofc,because you really saved my skin there, I'm gonna see about getting you that promotion you really wanted!");
                        Console.WriteLine(" Can't wait to see you at the holiday party!");
                        Console.WriteLine(" Mwah,\n Your #Girlboss");
                        Console.WriteLine(" --------------------------------------------------------");
                        GameOver = true;
                    }
                    else if (EnemySales >= PlayerSales)
                    {
                        Console.WriteLine(" ---------------------------------------------------------");
                        Console.WriteLine(" NEW MESSAGE RECIEVED\n\n Hey Queen!\n\n Looks like you failed to make new outfits.");
                        Console.WriteLine(" Now Brenda's company is number 1, and we're gonna lose a ton of money!");
                        Console.WriteLine(" Worst of all, you and I both know Brenda's gonna lord this over me at the next conference.");
                        Console.WriteLine(" So thanks for making my life a living hell.\n");
                        Console.WriteLine(" Hate,\n Your #Girlboss\n\n P.S. You're fired, obvs.");
                        Console.WriteLine(" --------------------------------------------------------");
                        GameOver = true;
                    }
                    else if (Supplies <= 0)
                    {
                        Console.WriteLine(" ---------------------------------------------------------");
                        Console.WriteLine(" NEW MESSAGE RECIEVED\n\n Hey Gorgeous!\n\n So, um, you definitely forgot to order supplies, and now there's");
                        Console.WriteLine(" not enough fabric for your team to use.");
                        Console.WriteLine(" According to our super long contract that you probably didn't even read,");
                        Console.WriteLine(" that is a fireable offense. So yeah, sorry, but imma have to let you go");
                        Console.WriteLine(" Good luck on the unemployment line, girlie!\n");
                        Console.WriteLine(" XOXO,\n Your #Girlboss");
                        Console.WriteLine(" --------------------------------------------------------");
                        GameOver = true;
                    }
                    else if (OfficeMorale <= 0)
                    {
                        Console.WriteLine(" ---------------------------------------------------------");
                        Console.WriteLine(" NEW MESSAGE RECIEVED\n\n Hey Bitch!\n\n WTF is going with your team?");
                        Console.WriteLine(" Many of them are refusing to work, they're filing complaints, and I think one of them tried to doxx me.");
                        Console.WriteLine(" Anywho, due to the recent sitch, we're gonna have to let you go... super unfair, I know.");
                        Console.WriteLine(" But hey, if it makes you feel better, my fiance totally");
                        Console.WriteLine(" bought the wrong wallpaper for the walls in our Yacht's ballroom. Terrible, right?");
                        Console.WriteLine(" Anyway good luck out there bestie, hope you don't get doxxed!");
                        Console.WriteLine("\n Tootles!");
                        Console.WriteLine(" Your #Girlboss");
                        Console.WriteLine(" --------------------------------------------------------");
                        GameOver = true;
                    }
                }

                //check if the user would like to play again
                bool Decided = false;
                while (!Decided)
                {
                    Console.WriteLine(" Would you like to play again (Y/N)? ");
                    string UserQuit = Console.ReadLine();
                    if (UserQuit.ToUpper().Equals("Y"))
                    {
                        Console.WriteLine(" Starting New Game");
                        Decided = true;
                    }
                    else if (UserQuit.ToUpper().Equals("N"))
                    {
                        Console.WriteLine(" Thank you for playing.");
                        Done = true;
                        Decided = true;
                    }
                    else if (UserQuit.ToUpper().Equals("EASTER EGG"))
                    {
                        Console.WriteLine(" Nice job! You found the Easter Egg");
                        Console.WriteLine(" That's it. What? You expected a prize or something?");
                        Console.WriteLine(" Fine! I'll give you a prize. Here");
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(" There. Now the text background is pink. Happy?");
                    }
                    else
                    {
                        Console.WriteLine(" Invalid input. Please try again.");
                    }
                }
            }
        }
    }
}
