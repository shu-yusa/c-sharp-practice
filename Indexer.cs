using System;

class Class1
{
    int Temp0;
    int Temp1;

    public int this [int index]
    {
        get
        {
            return (0 == index) ? Temp0 : Temp1;
        }
        set
        {
            if (0 == index)
                Temp0 = value;
            else
                Temp1 = value;
        }
    }
}

class Example
{
    static void Main()
    {
        Class1 a = new Class1();
        Console.WriteLine("Value -- T0: {0}, T1: {1}", a[0], a[1]);
        a[0] = 15;
        a[1] = 20;
        Console.WriteLine("Value -- T0: {0}, T1: {1}", a[0], a[1]);
    }
}
