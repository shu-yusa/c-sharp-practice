using System;

class MyClass
{
  public static void PringArg(string arg)
  {
    try {
      try {
        if (arg == null)
        {
          ArgumentNullException myEx = new ArgumentNullException("arg");
          throw myEx;
        }
        Console.WriteLine(arg);
      }
      catch (ArgumentNullException e)
      {
        Console.WriteLine("Message: {0}", e.Message);
        throw;
      }
    }
    catch
    {
      Console.WriteLine("Outer Catch: Handling an Exception.");
    }
  }
}

class Program
{
  static void Main()
  {
    string s = null;
    MyClass.PringArg(s);
//  MyClass.PringArg("hi, there!");
  }
}
