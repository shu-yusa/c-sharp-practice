using System;

class MyClass
{
    void PrintDateAndTime()
    {
        DateTime dt = DateTime.Now;
        Console.WriteLine("{0}", dt);
    }

    static void Main()
    {
        MyClass mc = new MyClass();
        mc.PrintDateAndTime();
    }
}
