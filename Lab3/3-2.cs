using System;

class BaseClass
{
    public void ShowMessage()
    {
        Console.WriteLine("Message from BaseClass");
    }
}

class DerivedClass : BaseClass
{
    public new void ShowMessage()
    {
        Console.WriteLine("Message from DerivedClass");
    }
}

class Program2
{
    static void Main()
    {
        BaseClass baseObj = new DerivedClass();
        DerivedClass derivedObj = new DerivedClass();

        baseObj.ShowMessage();     // Виведе повідомлення з BaseClass
        derivedObj.ShowMessage();  // Виведе повідомлення з DerivedClass
    }
}
