using System;

class C1
{
    private int _testValue = 10;
    public int TestValue
    {
        set { this._testValue = value; }
        get { return _testValue; }
    }
}

class Program
{
    static void Main()
    {
        C1 c = new C1();
        Console.WriteLine("TestValue: {0}", c.TestValue);
        c.TestValue = 20;
        Console.WriteLine("TestValue: {0}", c.TestValue);
    }
}

