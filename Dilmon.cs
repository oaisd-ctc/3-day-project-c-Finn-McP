namespace Dilmon
{
    public class Dilmon
    {
        public double dilmonName;
        public bool isShiny;
        private static string playerDilmonName = " ";
        private static string rivalDilmonName = " ";
        public static string playersMonNameToDiplay = " ";
        public Dilmon()
        {
        }
        public static void DisplayStarters()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Number one is our grass option, Swiffy."); //the mossy swiftlet dilmon
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Number two, the water option, Dil."); //the friendly fish dilmon
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("And last but not least the fire option, Gangu."); //the firey kangaoo dilmon
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"So? Which one will it be ?\nType 1 2 or 3");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string userDilmonChoice = Console.ReadLine();
            int num = 1;
            if (!int.TryParse(userDilmonChoice, out num))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Jeff: Sorry, that was not a provided option.");
                Thread.Sleep(2000);
                Console.Clear();
                DisplayStarters();
            }
            else if (userDilmonChoice == "1")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("BOX: Swiffy is the mossy swiflet DILMON. \nAre you sure you want to choose Swiffy? Y/N"); // evolves into Swiftler then Swifton
                Console.ForegroundColor = ConsoleColor.Green;
                SetPlayerDilmonName("Swiffy");
                ConfirmChoiceForDilmon();
                SetRivalDilmonName(playerDilmonName);
            }
            else if (userDilmonChoice == "2")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("BOX: Dil is the friendly fish DILMON. \nAre you sure you want to choose Dil? Y/N"); // evolves into Dilbert then Dilboretor
                Console.WriteLine("Here is Dil.");
                Program.dilEvolution1();
                Console.ForegroundColor = ConsoleColor.Blue;
                SetPlayerDilmonName("Dil");
                ConfirmChoiceForDilmon();
                SetRivalDilmonName(playerDilmonName);
            }
            else if (userDilmonChoice == "3")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("BOX: Gangu is the firey kangaroo DILMON. \nAre you sure you want to choose Gangu? Y/N"); // evolves into Gangubud then Gangunade
                Console.ForegroundColor = ConsoleColor.Red;
                SetPlayerDilmonName("Gangu");
                ConfirmChoiceForDilmon();
                SetRivalDilmonName(playerDilmonName);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Jeff: Sorry, that was not a provided option. \nPlease enter which Dilmon you want to choose.");
                Thread.Sleep(2000);
                Console.Clear();
                DisplayStarters();
            }
        }
        public static void RenameDilmon()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("BOX: Do you want to rename your DILMON? Y/N");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string yesNoForRename = Console.ReadLine();
            if (yesNoForRename == "y")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("What would you like to rename your DILMON to?\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                playersMonNameToDiplay = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Are you sure you want to rename {playerDilmonName} to {playersMonNameToDiplay}? Y/N");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string yesNoForNewName = Console.ReadLine();
                if (yesNoForNewName == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Jeff: Great choice! Your {playerDilmonName} has been renamed to {playersMonNameToDiplay}!");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"BOX: Great! \n{playersMonNameToDiplay} has joined your party!");
                }
                else
                {
                    RenameDilmon();
                }
            }
            else
            {
                playersMonNameToDiplay = playerDilmonName;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"BOX: Great! \n{playersMonNameToDiplay} has joined your party!");
            }
        }
        public static void SetPlayerDilmonName(string name)
        {
            playerDilmonName = name;
        }
        public static void SetRivalDilmonName(string name)
        {
            if (playerDilmonName == "Swiffy")
            {
                rivalDilmonName = "Dil";
            }
            else if (playerDilmonName == "Dil")
            {
                rivalDilmonName = "Gangu";
            }
            else if (playerDilmonName == "Gangu")
            {
                rivalDilmonName = "Swiffy";
            }
        }
        public string GetPlayerDilmonName()
        {
            return playerDilmonName;
        }
        private static void ConfirmChoiceForDilmon()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string yesNoAnswer = Console.ReadLine();
            if (yesNoAnswer == "yes" || yesNoAnswer == "y" || yesNoAnswer == "Y")
            {
                Console.WriteLine("Great choice!");
            }
            else
            {
                Console.Clear();
                DisplayStarters();
            }
        }
        public static void DisplayDilmonMoves()
        {
            string playerDilmonMove1 = "";
            string playerDilmonMove2 = "";
            string playerDilmonMove3 = "";
            string playerDilmonMove4 = "";
            if (playerDilmonName == "Swiffy")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                playerDilmonMove1 = "Swift Sweep"; //normal type airial attack 
                playerDilmonMove2 = "Leach Claw"; //grass type move that does damage and heals the user 
                playerDilmonMove3 = "Tackle"; //basic normal type move
                playerDilmonMove4 = "Photosynthesis"; //grass type move - takes a turn to heal (cannot do damage)
            }
            else if (playerDilmonName == "Dil")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                playerDilmonMove1 = "Tackle"; //basic normal type move
                playerDilmonMove2 = "Rainy Skies"; //water type move - sets the weather to rainy and gives all water type moves a boost
                playerDilmonMove3 = "Flop"; //water type move (no type other than water DILMON can learn this move) - raises user's defense and atack at the risk of falling asleep
                playerDilmonMove4 = "Coral Rain"; //water type move - like stelth rock - any time a new DILMON enters they take damage (unavoidable but lasts for 4 turns)
            }
            else if (playerDilmonName == "Gangu")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                playerDilmonMove1 = "Tackle"; //basic normal type move
                playerDilmonMove2 = "Flaming Boxer"; //Fire type move that boosts the user's fire type attacks
                playerDilmonMove3 = "Meteor Punch"; //Fire type move (high crit chance but cannot be used twice in a row)
                playerDilmonMove4 = "Ash Construct"; // Fire type move that boosts atk pwr but decreases speed
            }
            Console.WriteLine($""" 
            Moves:
            1. {playerDilmonMove1}  2. {playerDilmonMove2}
            3. {playerDilmonMove3}  4. {playerDilmonMove4}
            """);
        }
    }
}