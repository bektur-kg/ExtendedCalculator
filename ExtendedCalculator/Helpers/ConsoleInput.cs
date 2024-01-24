using ExtendedCalculator.BL.Models;
using System.Numerics;

namespace ExtendedCalculator.CMD.Helpers;

internal static class ConsoleInput
{
    public static BigInteger GetNumber(string inputName)
    {
        while (true)
        {
            ConsoleOutput.Info(inputName);
            var value = Console.ReadLine();

            if (BigInteger.TryParse(value, out BigInteger parsedNumber))
            {
                return parsedNumber;
            }

            ConsoleOutput.Error("Incorrect number. Please, try again!");
        }
    }

    public static MathOperation GetMathOperation()
    {
        while (true)
        {
            ConsoleOutput.Info(Messages.SupportedOperations);
            var value = Console.ReadLine();

            if (Enum.TryParse(value, out MathOperation parsedValue))
            {
                return parsedValue;
            }

            ConsoleOutput.Error("Incorrect operation. Please, try again!");
        }
    }
}


