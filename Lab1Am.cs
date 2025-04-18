using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть номер дня тижня (1–7): ");
        int day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Понеділок");
                break;
            case 2:
                Console.WriteLine("Вівторок");
                break;
            case 3:
                Console.WriteLine("Середа");
                break;
            case 4:
                Console.WriteLine("Четвер");
                break;
            case 5:
                Console.WriteLine("П’ятниця");
                break;
            case 6:
                Console.WriteLine("Субота");
                break;
            case 7:
                Console.WriteLine("Неділя");
                break;
            default:
                Console.WriteLine("Невірне число. Введіть від 1 до 7.");
                break;
        }
    }
}
