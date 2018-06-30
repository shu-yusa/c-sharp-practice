using System;

class SomeClass
{
  public string Field1 = "Field1 -- In the base class";
}

class OtherClass : SomeClass
{
  new public string Field1 = "Field1 -- In the derived class";

  public void PrintField1()
  {
    Console.WriteLine("{0}", Field1);
    Console.WriteLine("{0}", base.Field1);
  }
}

class Program
{
  static void Main()
  {
    OtherClass oc = new OtherClass();
    oc.PrintField1();
  }
}
