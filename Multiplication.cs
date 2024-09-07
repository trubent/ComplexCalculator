public class Multiplication : IOperation
{
    public Complex Execute(Complex a, Complex b)
    {
        double real = a.Real * b.Real - a.Imaginary * b.Imaginary;
        double imaginary = a.Real * b.Imaginary + a.Imaginary * b.Real;
        return new Complex(real, imaginary);
    }
}
