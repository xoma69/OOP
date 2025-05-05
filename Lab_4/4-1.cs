using System;

class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x = 0, double y = 0)
    {
        X = x;
        Y = y;
    }
}

class Circle
{
    public double Radius { get; set; }

    public Circle(double radius = 1.0)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double GetCircumference()
    {
        return 2 * Math.PI * Radius;
    }
}

class Round
{
    private Point Center;
    private Circle Circle;

    public Round(Point center, double radius)
    {
        Center = center;
        Circle = new Circle(radius);
    }

    public void SetRadius(double radius)
    {
        Circle.Radius = radius;
    }

    public bool ContainsPoint(Point p)
    {
        double dx = p.X - Center.X;
        double dy = p.Y - Center.Y;
        double distanceSquared = dx * dx + dy * dy;
        return distanceSquared <= Circle.Radius * Circle.Radius;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Центр: ({Center.X}, {Center.Y}), Радіус: {Circle.Radius}");
        Console.WriteLine($"Площа: {Circle.GetArea():F2}");
        Console.WriteLine($"Довжина кола: {Circle.GetCircumference():F2}");
    }
}

class Program
{
    static void Main()
    {
        Round myRound = new Round(new Point(0, 0), 5);
        myRound.PrintInfo();

        Point testPoint = new Point(3, 4);
        Console.WriteLine($"Точка (3,4) належить колу: {myRound.ContainsPoint(testPoint)}");
    }
}
