using ExtendedCalculator.BL.Logic;
using ExtendedCalculator.BL.Models;
using ExtendedCalculator.CMD.Helpers;

ConsoleOutput.Greeting();

while (true)
{
    var firstNumber = ConsoleInput.GetNumber("Enter a first number: ");
    var secondNumber = ConsoleInput.GetNumber("Enter a second number: ");

    var mathOperation = ConsoleInput.GetMathOperation();

    var calculator = new Calculator(firstNumber, secondNumber, mathOperation);

    try
    {
        var result = calculator.Calculate();

        ConsoleOutput.Success(calculator.GetResultString(result));
    }
    catch (OperationNotSupportedExcetption)
    {
        ConsoleOutput.Error("Sorry, this operation isn't supported. Please choose correct one");
    }
    catch (DivideByZeroException)
    {
        ConsoleOutput.Error("Sorry, you cannot divide by zero. Try again");
    }

    Console.ReadLine();
}