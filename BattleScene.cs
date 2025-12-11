namespace Dilmon;

public class BattleScene
{
    public static void TreeThing()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("""
                  /\                          
                /    \                        
              /_      _\                      
                /     \                       
              /         \                     
            /_           _\                   
              /         \                     
            /             \                   
          /                 \                 
        /_____________________\               
                |     |                       
                |     |                       
                |_____|                       
        """);
    }
    public static void HouseThing()
    {
        Console.WriteLine("""
                     ___
                   /     \
                 /         \
          _____/             \_____
              |               |
              |               |
              |               |
              |______| |______|
        """);
    }
}
