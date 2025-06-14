using System;

interface IReportable
{
    void Report();
}

class Employee : IReportable
{
    public virtual void Report()
    {
        Console.WriteLine("Співробітник створює базовий звіт.");
    }
}

class Manager : Employee, IReportable
{
    public override void Report()
    {
        Console.WriteLine("Менеджер створює детальний звіт.");
    }
}

class Program
{
    static void Main()
    {
        IReportable emp = new Employee();
        IReportable mgr = new Manager();

        emp.Report();
        mgr.Report();
    }
}
