class Car
{
    public int Speed { get; set; }

    public Car()
    {
        Speed = 60; // Значення за замовчуванням
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Console.WriteLine($"Speed: {car.Speed} km/h");
    }
}
