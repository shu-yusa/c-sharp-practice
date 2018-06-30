using System;

class DaysTemp
{
    public int High, Low;
    public int Avg()
    {
        return (High + Low) / 2;
    }
}

class Class1
{
    static void Main()
    {
        // DaysTempのインスタンスを2つ作成
        DaysTemp T1 = new DaysTemp();
        DaysTemp T2 = new DaysTemp();

        // それぞれのインスタンスのフィールドに書き込み
        T1.High = 76;   T1.Low = 57;
        T2.High = 75;   T2.Low = 53;

        // それぞれのインスタンスのフィールドから読み出し
        // それぞれのインスタンスのメソッドを呼び出し
        Console.WriteLine("T1: {0}, {1}, {2}", T1.High, T1.Low, T1.Avg());
        Console.WriteLine("T2: {0}, {1}, {2}", T2.High, T2.Low, T2.Avg());
    }
}
