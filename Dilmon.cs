namespace Dilmon
{
    public class Dilmon
    {
        public double dilmonName;
        public bool isShiny;
        private static string playerDilmonName = " ";
        public Dilmon()
        {
        }
        
        public static void DisplayStarters()
        {
            Console.Write("These");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.WriteLine("\nThese are called DILMON");
            Thread.Sleep(1000);
            Console.WriteLine("You can choose any of these.");
            Thread.Sleep(1000);
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
                Console.WriteLine("Jeff: Sorry, that was not a provided option. \nPlease enter which Dilmon you want to choose.");
                Thread.Sleep(2000);
                Console.Clear();
                DisplayStarters();
            }
            else if (userDilmonChoice == "1")
            {
                Console.WriteLine("BOX: Swiffy is the mossy swiflet DILMON. \nAre you sure you want to choose Swiffy? Y/N");
                SetPlayerDilmonName("Swiffy");
                ConfirmChoiceForDilmon();
            }
            else if (userDilmonChoice == "2")
            {
                Console.WriteLine("BOX: Dil is the friendly fish DILMON. \nAre you sure you want to choose Dil? Y/N");
                SetPlayerDilmonName("Dil");
                ConfirmChoiceForDilmon();
            }
            else if (userDilmonChoice == "3")
            {
                Console.WriteLine("BOX: Gangu is the firey kangaroo DILMON. \nAre you sure you want to choose Gangu? Y/N");
                SetPlayerDilmonName("Gangu");
                ConfirmChoiceForDilmon();
            }
            else
            {
                Console.WriteLine("Jeff: Sorry, that was not a provided option. \nPlease enter which Dilmon you want to choose.");
                Thread.Sleep(2000);
                Console.Clear();
                DisplayStarters();
            }
        }

        public static void SetPlayerDilmonName(string name)
        {
            playerDilmonName = name;
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
                Console.WriteLine("Great!");
            }
            else
            {
                Console.Clear();
                DisplayStarters();
            }
        }
    }
}