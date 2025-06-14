private Dictionary<string, string> _cache;

private DataCache()
{
    _cache = new Dictionary<string, string>();
}

public static DataCache Instance
{
    get
    {
        lock (_lock)
        {
            return _instance ??= new DataCache();
        }
    }
}

public void Add(string key, string value)
{
    _cache[key] = value;
}

public string Get(string key)
{
    return _cache.TryGetValue(key, out string value) ? value : "[Not Found]";
}

public void PrintAll()
{
    Console.WriteLine("Поточний вміст кешу:");
    foreach (var pair in _cache)
    {
        Console.WriteLine($"{pair.Key}: {pair.Value}");
    }
}
