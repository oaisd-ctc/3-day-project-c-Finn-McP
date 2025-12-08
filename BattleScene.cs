namespace Dilmon;

public class BattleScene
{
    public static void treeLeaves()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("""
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
        """);
    }
    public static void treeBark()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("""
                |     |
                |     |
                |_____|
        """);
    }
}