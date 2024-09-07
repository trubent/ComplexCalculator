public class Division : IOperation
{
    public Complex Execute(Complex a, Complex b)
    {
        double denominator = b.Real * b.Real + b.Imaginary * b.Imaginary;
        if (denominator == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        double real = (a.Real * b.Real + a.Imaginary * b.Imaginary) / denominator;
        double imaginary = (a.Imaginary * b.Real - a.Real * b.Imaginary) / denominator;
        return new Complex(real, imaginary);
    }
}
