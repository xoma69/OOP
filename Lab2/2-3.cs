class Counter
{
    private static int count = 0;

    public static void Increment()
    {
        count++;
        Console.WriteLine($"Counter: {count}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Counter.Increment(); // Counter: 1
        Counter.Increment(); // Counter: 2
        Counter.Increment(); // Counter: 3
    }
}
