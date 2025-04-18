using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 6, 9, 12, 15, 18, 21 };
        int count = 0;

        foreach (int num in numbers)
        {
            if (num % 2 != 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Кількість непарних чисел: {count}");
    }
}
