using System;

partial class MyClass
{
  partial void PrintSum(int x, int y);

  public void Add(int x, int y)
  {
    PrintSum(x, y);
  }
}

partial class MyClass
{
  partial void PrintSum(int x, int y)
  {
    Console.WriteLine("Sum is {0}", x+y);
  }
}

class Program
{
  static void Main()
  {
    var mc = new MyClass();
    mc.Add(5,6);
  }
}
