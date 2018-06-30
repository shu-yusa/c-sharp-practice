using System;

interface IIfc1
{
  void PrintOut(string s);
}

class MyClass : IIfc1
{
  public void PrintOut(string s)
  {
    Console.WriteLine("Calling through: {0}", s);
  }
}

class Program
{
  static void Main()
  {
    MyClass mc = new MyClass();
    mc.PrintOut("object.");
//  IIfc1 ifc = (IIfc1)mc;
    IIfc1 ifc = mc as IIfc1;
    ifc.PrintOut("interface.");
  }
}

