using System;

interface IEditable
{
    void Edit();
}

class Article : IEditable
{
    public void Edit()
    {
        Console.WriteLine("Редагування статті виконується...");
    }
}

class Program
{
    static void Main()
    {
        IEditable article = new Article();
        article.Edit();
    }
}
