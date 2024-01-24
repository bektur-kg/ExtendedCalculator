using ExtendedCalculator.BL.Models;

namespace ExtendedCalculator.CMD.Helpers;

internal static class ConsoleOutput
{
    public static void Greeting()
    {
        Info(Messages.Greeting);
    }

    public static void ShowOperations()
    {
        Info(Messages.SupportedOperations);
    }

    public static void Info(string message)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void Success(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
