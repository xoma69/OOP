using System;

class Program
{
    enum Season { Зима, Весна, Літо, Осінь }

    static void Main()
    {
        Console.Write("Введіть номер місяця (1–12): ");
        int month = int.Parse(Console.ReadLine());
        Season season;

        if (month == 12 || month == 1 || month == 2)
            season = Season.Зима;
        else if (month >= 3 && month <= 5)
            season = Season.Весна;
        else if (month >= 6 && month <= 8)
            season = Season.Літо;
        else if (month >= 9 && month <= 11)
            season = Season.Осінь;
        else
        {
            Console.WriteLine("Невірний номер місяця.");
            return;
        }

        Console.WriteLine($"Пора року: {season}");
    }
}
