using System;
using System.Collections.Generic;

abstract class TPrism
{
    public double Height { get; protected set; }
    public double BaseArea { get; protected set; }

    public TPrism(double baseArea, double height)
    {
        BaseArea = baseArea;
        Height = height;
    }

    public abstract double GetVolume();
    public abstract double GetSurfaceArea();
}

class TPrism3 : TPrism
{
    public TPrism3(double baseArea, double height) : base(baseArea, height) { }

    public override double GetVolume()
    {
        return BaseArea * Height;
    }

    public override double GetSurfaceArea()
    {
        return 3 * Height * Math.Sqrt(BaseArea) + 2 * BaseArea;
    }
}

class TPrism4 : TPrism
{
    public TPrism4(double baseArea, double height) : base(baseArea, height) { }

    public override double GetVolume()
    {
        return BaseArea * Height;
    }

    public override double GetSurfaceArea()
    {
        return 4 * Height * Math.Sqrt(BaseArea) + 2 * BaseArea;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введіть площу основи трикутної призми: ");
        double base3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть висоту трикутної призми: ");
        double h3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть площу основи чотирикутної призми: ");
        double base4 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть висоту чотирикутної призми: ");
        double h4 = Convert.ToDouble(Console.ReadLine());

        int m = 4;
        List<TPrism> prisms = new List<TPrism>();

        double volume = new TPrism3(base3, h3).GetVolume();
        for (int i = 0; i < m; i++)
        {
            if (i % 2 == 0)
            {
                prisms.Add(new TPrism3(base3, volume / base3));
            }
            else
            {
                prisms.Add(new TPrism4(base4, volume / base4));
            }
            volume += 5;
        }

        double triangleVolumeSum = 0;
        double quadSurfaceSum = 0;

        foreach (var p in prisms)
        {
            if (p is TPrism3)
                triangleVolumeSum += p.GetVolume();
            else if (p is TPrism4)
                quadSurfaceSum += p.GetSurfaceArea();
        }

        Console.WriteLine($"\nСума об'ємів трикутних призм: {triangleVolumeSum:F2}");
        Console.WriteLine($"Сума площ поверхонь чотирикутних призм: {quadSurfaceSum:F2}");
    }
}
