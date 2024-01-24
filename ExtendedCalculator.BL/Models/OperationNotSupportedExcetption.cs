namespace ExtendedCalculator.BL.Models;

public class OperationNotSupportedExcetption : Exception
{
    public OperationNotSupportedExcetption() : base() { }
    public OperationNotSupportedExcetption(string message) : base(message) { }

}
