
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        introTimer();
    }
    public static void beginningThing()
    {
        
    }
    public static void introTimer()
    {
        Console.Write("""
        |    /\    |   _______       _      _
        |   /  \   |  |_|     |     |_|   _| |_
        |  /    \  |    ______|      _   |_   _|
        | /      \ |   /     _|     | |    | |
        |/        \|   \____/ |_|   |_|    |_|
        """);
        Thread.Sleep(4000);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("Loading ");
        Console.ForegroundColor = ConsoleColor.Green;
        for(int i = 1; i <=45; i++)
        {
            Console.Write("▅");
            Thread.Sleep(50);
        }
    }
}