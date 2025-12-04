
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        introTimer();
        Console.Clear();
        beginningThing();
    }
    public static void beginningThing()
    {
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("What would you like to name your character?");
        string userName = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Jeff: Welcome traveler, it appears you have stumbled upon our humbled abode.");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("1. Talk to Jeff       2. Stare at Jeff");
        Console.WriteLine("3. Talk to someone else      4. Leave");
        Console.ForegroundColor = ConsoleColor.Cyan;
        string userInput = Console.ReadLine();
        
        if(userInput == "1")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{userName}: Hello Jeff, what does this place have here?");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Jeff: Ah yes, you would like to know more about this place.");
            Thread.Sleep(2000);
            Console.WriteLine("This beautiful town is home to many people, including monsters.");
            Thread.Sleep(2000);
            Console.WriteLine("Here, I can show you around my house if you would like.");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1. Continue with Jeff        2. Talk to someone else");
            Console.WriteLine("3. Leave");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string userJeff = Console.ReadLine();

            if(userJeff == "1");
            {
                Console.Clear();
                Thread.Sleep(2000);
                doorOpen();
                Thread.Sleep(250);
                Console.Clear();
                doorOpen2();
                Thread.Sleep(250);
                Console.Clear();
                doorOpen3();
                Thread.Sleep(250);
                Console.Clear();
                doorOpen4();
                Thread.Sleep(250);
                Console.Clear();
                doorOpen5();
                Thread.Sleep(250);
                Console.Clear();
                doorOpen6();
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine("HEHE");
            }
        }
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
        dotTimer();
        Thread.Sleep(1000);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("Loading ");
        Console.ForegroundColor = ConsoleColor.Green;
        for(int i = 1; i <=100; i++)
        {
            Console.Write("▅");
            Thread.Sleep(50);
        }
    }
    public static void doorOpen()
    {
        Console.WriteLine("""
         _______________
        |               |
        |               |
        |               |
        |               |
        |               |
        |           -0  |
        |               |
        |               |
        |               |
        |_______________|
        """);
    }
    public static void doorOpen2()
    {
        Console.WriteLine("""
         _______________
        |            |  |
        |            |  |
        |            |  |
        |            |  |
        |            |  |
        |         -o |  |
        |            |  |
        |            |  |
        |            |  |
        |____________|__|
        """);
    }
    public static void doorOpen3()
    {
        Console.WriteLine("""
         _______________
        |          |    |
        |          |    |
        |          |    |
        |          |    |
        |          |    |
        |       -o |    |
        |          |    |
        |          |    |
        |          |    |
        |__________|____|
        """);
    }
    public static void doorOpen4()
    {
        Console.WriteLine("""
         _______________
        |       |       |
        |       |       |
        |       |       |
        |       |       |
        |       |       |
        |    -o |       |
        |       |       |
        |       |       |
        |       |       |
        |_______|_______|
        """);
    }
    public static void doorOpen5()
    {
        Console.WriteLine("""
         _______________
        |  |            |
        |  |            |
        |  |            |
        |  |            |
        |  |            |
        |-o|            |
        |  |            |
        |  |            |
        |  |            |
        |__|____________|
        """);
    }
    public static void doorOpen6()
    {
        Console.WriteLine("""
         _______________
        |               |
        |               |
        |               |
        |               |
        |               |
        |               |
        |               |
        |               |
        |               |
        |_______________|
        """);
    }
    public static void dotTimer()
    {
        for(int dot = 1; dot <=3; dot++)
        {
            Console.Write(" . ");
            Thread.Sleep(1500);
        }
    }
}