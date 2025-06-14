// Клас для чисельного обчислення інтегралу за формулою лівих прямокутників
using static System.Runtime.InteropServices.JavaScript.JSType;

public static class Integrator
{
    public static double LeftRectangle(Function f, double a, double b, int n)
    {
        double h = (b - a) / n;
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            double x = a + i * h;
            sum += f(x);
        }

        return sum * h;
    }
}

class Program
{
    // Деякі прикладні функції
    public static double F1(double x) => Math.Sin(x);
    public static double F2(double x) => x * x;
    public static double F3(double x) => Math.Exp(-x * x); // Гаус

    static void Main()
    {
        Console.WriteLine("Обчислення визначених інтегралів методом лівих прямокутників:\n");

        double a = 0, b = Math.PI;
        int n = 1000;

        Console.WriteLine($"Інтеграл sin(x) від {a} до {b} = {Integrator.LeftRectangle(F1, a, b, n)}");
        Console.WriteLine($"Інтеграл x^2 від 0 до 3 = {Integrator.LeftRectangle(F2, 0, 3, n)}");
        Console.WriteLine($"Інтеграл e^(-x^2) від -2 до 2 ≈ {Integrator.LeftRectangle(F3, -2, 2, n)}");

        Console.ReadLine();
    }
}
