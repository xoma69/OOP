using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            Tvarina t1 = new Ryba("Сом", false, true);
            Tvarina t2 = new Ptakh("Сокіл", true, 120);
            Tvarina t3 = new Zvir("", true, "Ліс"); // Помилка: пусте ім’я

            t1.SformuvatyOpys();
            t2.SformuvatyOpys();
            t3.SformuvatyOpys();
        }
        catch (NazvaException ex)
        {
            Console.WriteLine("❗Виняток при створенні тварини: " + ex.Message);
        }

        Console.WriteLine("\n--- Перевірка додавання в клітку ---");
        Klytka k = new Klytka { Nomer = 1, Rozmir = 50, MaxTvaryn = 2 };
        k.DodatyTvarynu(new Zvir("Лис", true, "Ліс"));
        k.DodatyTvarynu(new Ptakh("Гуска", false, 30)); // Хижак + не хижак => виняток

        Console.ReadLine();
    }
}
