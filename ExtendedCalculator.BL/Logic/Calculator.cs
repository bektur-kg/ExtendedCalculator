using ExtendedCalculator.BL.Models;
using System.Numerics;

namespace ExtendedCalculator.BL.Logic;

public class Calculator
{
    public BigInteger FirstNumber { get; private set; }
    public BigInteger SecondNumber { get; private set; }
    public MathOperation MathOperation { get; set; }

    public Calculator(BigInteger firstNumber, BigInteger secondNumber, MathOperation mathOperation)
    {
        FirstNumber = firstNumber;
        SecondNumber = secondNumber;
        MathOperation = mathOperation;
    }

    public BigInteger Calculate()
    {
        switch (MathOperation)
        {
            case MathOperation.Add:
                return FirstNumber + SecondNumber;
            case MathOperation.Subtract:
                return FirstNumber - SecondNumber;
            case MathOperation.Multiply:
                return FirstNumber * SecondNumber;
            case MathOperation.Divide:
                if (SecondNumber == 0) throw new DivideByZeroException();
                return FirstNumber / SecondNumber;
            default:
                throw new OperationNotSupportedExcetption();
        }
    }

    public string GetResultString(BigInteger result)
    {
        switch (MathOperation)
        {
            case MathOperation.Add:
                return $"{FirstNumber} + {SecondNumber} = {result}";
            case MathOperation.Subtract:
                return $"{FirstNumber} - {SecondNumber} = {result}";
            case MathOperation.Multiply:
                return $"{FirstNumber} * {SecondNumber} = {result}";
            case MathOperation.Divide:
                if (SecondNumber == 0) throw new DivideByZeroException();
                return $"{FirstNumber} / {SecondNumber} = {result}";
            default:
                throw new OperationNotSupportedExcetption();
        }
    }
}
