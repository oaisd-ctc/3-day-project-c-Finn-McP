namespace Dilmon
{
    public class Dilmon
    {
        public double dilmonName;
        public bool isShiny;
        private string playerDilmonName = " ";
        public Dilmon()
        {
        }
        
        public static void DisplayStarters()
        {
            Console.WriteLine("Here are the three starts.");
            Thread.Sleep(1000);
            Console.WriteLine("Number one is our grass starter, ____."); //the mossy swiftlet dilmon
            Thread.Sleep(1000);
            Console.WriteLine("Number two, the water starter, Dil."); //the friendly fish dilmon
            Thread.Sleep(1000);
            Console.WriteLine("And last but not least the fire starter, ____."); //the kangaoo dilmon
            Thread.Sleep(1000);
            Console.WriteLine($"So? Which one will it be ?\nType 1 2 or 3");
            string userDilmonChoice = Console.ReadLine();
            
        }

        public void SetPlayerDilmonName(string name)
        {
            playerDilmonName = name;
        }

        public string GetPlayerDilmonName()
        {
            return playerDilmonName;
        }
    }
}