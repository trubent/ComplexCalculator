using System;

class Program
{
    static void Main(string[] args)
    {
        Complex a = new Complex(3, 2);
        Complex b = new Complex(1, 7);

        // Сложение
        ComplexCalculator calculator = new ComplexCalculator(new Addition());
        Complex result = calculator.Calculate(a, b);
        Logger.Instance.Log($"Addition result: {result}");

        // Умножение
        calculator = new ComplexCalculator(new Multiplication());
        result = calculator.Calculate(a, b);
        Logger.Instance.Log($"Multiplication result: {result}");

        // Деление
        calculator = new ComplexCalculator(new Division());
        result = calculator.Calculate(a, b);
        Logger.Instance.Log($"Division result: {result}");
    }
}
