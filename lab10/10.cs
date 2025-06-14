using System.Runtime.InteropServices;
using System.Xml.Linq;

public CharSet()
{
    elements = new HashSet<char>();
}

// Конструктор з масиву
public CharSet(IEnumerable<char> chars)
{
    elements = new HashSet<char>(chars);
}

// Додати елемент (перевантаження +)
public static CharSet operator +(CharSet set, char ch)
{
    var result = new CharSet(set.elements);
    result.elements.Add(ch);
    return result;
}

// Перетин множин (перевантаження *)
public static CharSet operator *(CharSet a, CharSet b)
{
    var result = new CharSet();
    foreach (var ch in a.elements)
    {
        if (b.elements.Contains(ch))
            result.elements.Add(ch);
    }
    return result;
}

// Потужність множини (перевантаження int)
public static explicit operator int(CharSet set)
{
    return set.elements.Count;
}

// Для красивого виводу
public override string ToString()
{
    return "{" + string.Join(", ", elements) + "}";
}
}

class Program
{
    static void Main()
    {
        CharSet A = new CharSet(new[] { 'a', 'b', 'c', 'd' });
        CharSet B = new CharSet(new[] { 'b', 'c', 'e' });

        Console.WriteLine("Множина A: " + A);
        Console.WriteLine("Множина B: " + B);

        // Додати елемент до A
        A = A + 'e';
        Console.WriteLine("A після A + 'e': " + A);

        // Перетин A та B
        CharSet C = A * B;
        Console.WriteLine("Перетин A * B: " + C);

        // Потужність множини
        Console.WriteLine("Потужність множини A: " + (int)A);
        Console.WriteLine("Потужність множини C: " + (int)C);

        Console.ReadLine();
    }
}
