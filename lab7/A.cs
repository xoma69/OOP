using System;
using System.Collections.Generic;

class HyszhakException : Exception
{
    public HyszhakException(string message) : base(message) { }
}

class NazvaException : Exception
{
    public NazvaException(string nazva)
        : base($"Неможливо створити тварину - не вказано назву: {nazva}") { }
}

class Tvarina
{
    public string Nazva { get; set; }
    public bool Hyszhak { get; set; }

    public Tvarina(string nazva, bool hyszhak)
    {
        if (string.IsNullOrWhiteSpace(nazva))
            throw new NazvaException(nazva);

        Nazva = nazva;
        Hyszhak = hyszhak;
    }

    public virtual void SformuvatyOpys()
    {
        try
        {
            Console.WriteLine($"Тварина: {Nazva}, Хижак: {(Hyszhak ? "Так" : "Ні")}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Помилка при формуванні опису тварини: " + e.Message);
        }
    }
}

class Ryba : Tvarina
{
    public bool Glybokovodna { get; set; }

    public Ryba(string nazva, bool hyszhak, bool glybokovodna)
        : base(nazva, hyszhak)
    {
        Glybokovodna = glybokovodna;
    }

    public override void SformuvatyOpys()
    {
        try
        {
            base.SformuvatyOpys();
            Console.WriteLine($"Глибоководна: {(Glybokovodna ? "Так" : "Ні")}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Помилка при формуванні опису риби: " + e.Message);
        }
    }
}

class Ptakh : Tvarina
{
    public int ShvydkistPolotu { get; set; }

    public Ptakh(string nazva, bool hyszhak, int shvydkist)
        : base(nazva, hyszhak)
    {
        ShvydkistPolotu = shvydkist;
    }

    public override void SformuvatyOpys()
    {
        try
        {
            base.SformuvatyOpys();
            Console.WriteLine($"Швидкість польоту: {ShvydkistPolotu} км/год");
        }
        catch (Exception e)
        {
            Console.WriteLine("Помилка при формуванні опису птаха: " + e.Message);
        }
    }
}

class Zvir : Tvarina
{
    public string SeredovyshcheProzhyvannya { get; set; }

    public Zvir(string nazva, bool hyszhak, string sered)
        : base(nazva, hyszhak)
    {
        SeredovyshcheProzhyvannya = sered;
    }

    public override void SformuvatyOpys()
    {
        try
        {
            base.SformuvatyOpys();
            Console.WriteLine($"Середовище проживання: {SeredovyshcheProzhyvannya}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Помилка при формуванні опису звіра: " + e.Message);
        }
    }
}

class Klytka
{
    public int Nomer { get; set; }
    public int Rozmir { get; set; }
    public int MaxTvaryn { get; set; }
    private List<Tvarina> tvaryny = new List<Tvarina>();

    public void DodatyTvarynu(Tvarina t)
    {
        try
        {
            if (tvaryny.Count > 0)
            {
                bool yeHyszhak = tvaryny.Exists(x => x.Hyszhak);
                if ((yeHyszhak && !t.Hyszhak) || (!yeHyszhak && t.Hyszhak))
                    throw new HyszhakException("Неможливо додати хижака до клітки з не хижаками або навпаки.");
            }

            if (tvaryny.Count >= MaxTvaryn)
                throw new Exception("Перевищено кількість тварин у клітці!");

            tvaryny.Add(t);
            Console.WriteLine("Тварину додано до клітки.");
        }
        catch (HyszhakException ex)
        {
            Console.WriteLine("❌ Хижацький конфлікт: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Помилка при додаванні тварини: " + ex.Message);
        }
    }
}
