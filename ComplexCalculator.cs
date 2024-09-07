public class ComplexCalculator
{
    private IOperation _operation;

    public ComplexCalculator(IOperation operation)
    {
        _operation = operation;
    }

    public Complex Calculate(Complex a, Complex b)
    {
        Logger.Instance.Log($"Performing operation on {a} and {b}");
        return _operation.Execute(a, b);
    }
}
