public class Addition : IOperation
{
    public Complex Execute(Complex a, Complex b)
    {
        return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
    }
}
