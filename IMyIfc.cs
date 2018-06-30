using System;

interface IMyIfc<T>
{
  T ReturnIt(T inValue);
}

class Simple<S> : IMyIfc<S>
{
  public S ReturnIt(S inValue)
  {
    return inValue;
  }
}

class Program
{
  static void Main()
  {
    var trivInt  = new Simple<int>();
    var trivString  = new Simple<string>();
    Console.WriteLine("{0}", trivInt.ReturnIt(5));
    Console.WriteLine("{0}", trivString.ReturnIt("Hi there!"));
  }
}

