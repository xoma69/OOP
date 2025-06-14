using System.Text.Json;
using System.Xml;

Console.WriteLine("Завдання 1: XML + XPath — Вивести книги певного автора");

// Шлях до XML-файлу
string xmlFile = "books.xml";

// Створимо books.xml, якщо його нема
if (!File.Exists(xmlFile))
{
    CreateSampleBooks(xmlFile);
    Console.WriteLine("Створено тестовий файл books.xml\n");
}

Console.Write("Введіть ім’я автора для пошуку: ");
string authorToSearch = Console.ReadLine();

ShowBooksByAuthor(xmlFile, authorToSearch);

Console.WriteLine("\nЗавдання 2: JSON — Десеріалізація користувача");

string json = @"{
            ""Name"": ""Олег"",
            ""Age"": 25,
            ""Hobbies"": [""Читання"", ""Гра на гітарі"", ""Плавання""]
        }";

Console.WriteLine("JSON-рядок:");
Console.WriteLine(json);

User user = JsonSerializer.Deserialize<User>(json);

Console.WriteLine($"\nІм’я користувача: {user.Name}");
Console.WriteLine($"Перше хобі: {user.Hobbies?[0]}");

Console.ReadLine();
    }

    // Завдання 1 — вибір книг за автором через XPath
    static void ShowBooksByAuthor(string filePath, string authorName)
{
    XmlDocument doc = new XmlDocument();
    doc.Load(filePath);

    string xpath = $"/books/book[author='{authorName}']/title";
    XmlNodeList nodes = doc.SelectNodes(xpath);

    if (nodes.Count == 0)
    {
        Console.WriteLine("Книг з таким автором не знайдено.");
    }
    else
    {
        Console.WriteLine($"Знайдено книги автора \"{authorName}\":");
        foreach (XmlNode node in nodes)
        {
            Console.WriteLine($"- {node.InnerText}");
        }
    }
}

// Створення базового books.xml
static void CreateSampleBooks(string filePath)
{
    var booksXml = @"<?xml version=""1.0"" encoding=""utf-8""?>
