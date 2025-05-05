class Printer
{
    public void Print(string text)
    {
        Console.WriteLine($"Text: {text}");
    }

    public void Print(int number)
    {
        Console.WriteLine($"Integer: {number}");
    }

    public void Print(double number)
    {
        Console.WriteLine($"Double: {number}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Printer printer = new Printer();
        printer.Print("Hello");
        printer.Print(123);
        printer.Print(3.14);
    }
}
