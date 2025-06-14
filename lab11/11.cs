using System.Globalization;

Console.WriteLine("Завдання 1: Заміна 0 ↔ 1 у рядку з заданої позиції");
Console.Write("Введіть рядок (з 0 та 1): ");
string input = Console.ReadLine();

Console.Write("З якої позиції почати заміну (від 0): ");
int pos = int.Parse(Console.ReadLine() ?? "0");

string result = Zaminyty01(input, pos);
Console.WriteLine($"Результат: {result}");

Console.WriteLine("\nЗавдання 2: Кількість днів до дати");
Console.Write("Введіть дату (формат: рррр-мм-дд): ");
string dateStr = Console.ReadLine();
if (DateTime.TryParse(dateStr, out DateTime targetDate))
{
    ObchyslytyDni(targetDate);
}
else
{
    Console.WriteLine("Невірний формат дати.");
}

Console.WriteLine("\nЗавдання 3: Аналіз трьох дат у рядку");
Console.WriteLine("Приклад вхідного рядка: 01.03.2023, 21.06.2022, 14.04.2024");
Console.Write("Введіть рядок з трьома датами (через кому): ");
string dateLine = Console.ReadLine();
AnalizuvatyDatu(dateLine);

Console.ReadLine();
    }

    // Завдання 1
    static string Zaminyty01(string str, int position)
{
    if (position >= str.Length)
        return str;

    char[] chars = str.ToCharArray();

    for (int i = position; i < chars.Length; i++)
    {
        if (chars[i] == '0')
            chars[i] = '1';
        else if (chars[i] == '1')
            chars[i] = '0';
    }

    return new string(chars);
}

// Завдання 2
static void ObchyslytyDni(DateTime target)
{
    DateTime today = DateTime.Today;
    TimeSpan delta = target - today;

    if (delta.Days < 0)
    {
        Console.WriteLine($"Цей день вже минув {Math.Abs(delta.Days)} днів тому.");
    }
    else if (delta.Days == 0)
    {
        Console.WriteLine("Цей день — сьогодні!");
    }
    else
    {
        Console.WriteLine($"До цієї дати залишилось: {delta.Days} днів.");
    }
}

// Завдання 3
static void AnalizuvatyDatu(string input)
{
    string[] parts = input.Split(',');
    if (parts.Length != 3)
    {
        Console.WriteLine("Потрібно ввести рівно три дати.");
        return;
    }

    DateTime[] dates = new DateTime[3];
    bool allParsed = true;
    for (int i = 0; i < 3; i++)
    {
        if (!DateTime.TryParseExact(parts[i].Trim(), "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dates[i]))
        {
            Console.WriteLine($"Помилка парсингу дати: {parts[i]}");
            allParsed = false;
        }
    }

    if (!allParsed) return;

    // Мінімальний рік
    int minYear = dates.Min(d => d.Year);
    Console.WriteLine($"Мінімальний рік: {minYear}");

    // Весняні дати (березень, квітень, травень)
    var vesniani = dates.Where(d => d.Month >= 3 && d.Month <= 5);
    Console.WriteLine("Весняні дати:");
    foreach (var d in vesniani)
        Console.WriteLine($"  {d.ToString("dd.MM.yyyy")}");

    // Найпізніша дата
    DateTime max = dates.Max();
    Console.WriteLine($"Найпізніша дата: {max.ToString("dd.MM.yyyy")}");
}
}
