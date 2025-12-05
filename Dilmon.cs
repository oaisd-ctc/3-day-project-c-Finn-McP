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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Number two, the water option, Dil."); //the friendly fish dilmon
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("And last but not least the fire option, Gangu."); //the firey kangaoo dilmon
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"So? Which one will it be ?\nType 1 2 or 3");
            string userDilmonChoice = Console.ReadLine();
            int num =1;
            if(!int.TryParse(userDilmonChoice, out num))
            {
                Console.WriteLine("Jeff: Sorry, that was not a provided option.");
                Thread.Sleep(2000);
                Console.Clear();
                DisplayStarters();
            }
            else if (userDilmonChoice == "1")
            {
                Console.WriteLine("BOX: Swiffy is the mossy swiflet DILMON. \nAre you sure you want to choose Swiffy? Y/N");
                SetPlayerDilmonName("Swiffy");
                ConfirmChoiceForDilmon();
                SetRivalDilmonName(playerDilmonName);
            }
            else if (userDilmonChoice == "2")
            {
                Console.WriteLine("BOX: Dil is the friendly fish DILMON. \nAre you sure you want to choose Dil? Y/N");
                SetPlayerDilmonName("Dil");
                ConfirmChoiceForDilmon();
                SetRivalDilmonName(playerDilmonName);
            }
            else if (userDilmonChoice == "3")
            {
                Console.WriteLine("BOX: Gangu is the firey kangaroo DILMON. \nAre you sure you want to choose Gangu? Y/N");
                SetPlayerDilmonName("Gangu");
                ConfirmChoiceForDilmon();
                SetRivalDilmonName(playerDilmonName);
            }
            else
            {
                Console.WriteLine("Jeff: Sorry, that was not a provided option. \nPlease enter which Dilmon you want to choose.");
                Thread.Sleep(2000);
                Console.Clear();
                DisplayStarters();
            }
        }
        public static void RenameDilmon()
        {
            Console.WriteLine("BOX: Do you want to rename your DILMON? Y/N");
            string yesNoForRename = Console.ReadLine();
            if (yesNoForRename == "y")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("What would you like to rename your DILMON to?\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                playersMonNameToDiplay = Console.ReadLine();
                Console.WriteLine($"Are you sure you want to rename {playerDilmonName} to {playersMonNameToDiplay}? Y/N");
                string yesNoForNewName = Console.ReadLine();
                if (yesNoForNewName == "y")
                {
                    Console.WriteLine($"Great choice! Your {playerDilmonName} has been renamed to {playersMonNameToDiplay}!");
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
    }
}