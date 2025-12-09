namespace Dilmon;

public class BattleScene
{
    public static void treeThing()
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
    public static void houseThing()
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