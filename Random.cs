using System;

class RandomNumberClass
{
    // private スタティックフィールド
    private static Random RandomKey;
    // スタティックコンストラクタ
    static RandomNumberClass()
    {
        RandomKey = new Random();
    }

    public int GetRandomNumber()
    {
        return RandomKey.Next();
    }
}

class Program
{
    static void Main()
    {
      RandomNumberClass a = new RandomNumberClass();
      RandomNumberClass b = new RandomNumberClass();
      Console.WriteLine("Next Random #: {0}", a.GetRandomNumber());
      Console.WriteLine("Next Random #: {0}", b.GetRandomNumber());
    }
}

