using Syst = System;
using SC = System.Console;

namespace MyNameSpace
{
  class SomeClass 
  {
    static void Main()
    {
      Syst.Console.WriteLine("Using the namespace alias.");
      System.Console.WriteLine("Using fully qualified name.");
      SC.WriteLine("Using the type alias.");
    }
  }
}

