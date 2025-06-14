// Створення тестового файлу (можеш видалити цей блок, якщо файл уже існує)
if (!File.Exists(fileName))
{
    File.WriteAllText(fileName, "42TestText"); // Можна змінити на свій вміст
    Console.WriteLine("Файл f.txt створено з вмістом: 42TestText");
}

try
{
    using (StreamReader reader = new StreamReader(fileName))
    {
        char[] firstTwo = new char[2];
        int readCount = reader.Read(firstTwo, 0, 2);

        if (readCount < 2)
        {
            Console.WriteLine("У файлі менше двох символів.");
            return;
        }

        if (char.IsDigit(firstTwo[0]) && char.IsDigit(firstTwo[1]))
        {
            int number = int.Parse($"{firstTwo[0]}{firstTwo[1]}");
            Console.WriteLine($"Перші два символи — цифри: {number}");

            if (number % 2 == 0)
            {
                Console.WriteLine("Це число — парне.");
            }
            else
            {
                Console.WriteLine("Це число — непарне.");
            }
        }
        else
        {
            Console.WriteLine("Перші два символи не є обидва цифрами.");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine("Помилка при обробці файлу: " + ex.Message);
}

Console.ReadLine();
    }
}
