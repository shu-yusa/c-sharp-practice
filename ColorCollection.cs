using System;
using System.Collections.Generic;

namespace ColorCollectionIterator
{
  class ColorCollection
  {
    string[] Colors = {"Red", "Orange", "Yellow", "Green", "Blue", "Purple"};

    // 列挙可能型反復子
    public IEnumerable<string> Forward()
    {
      for (int i=0; i<Colors.Length; i++)
        yield return Colors[i];
    }

    public IEnumerable<string> Reverse()
    {
      for (int i=Colors.Length-1; i>=0; i--)
        yield return Colors[i];
    }

  }

  class Program
  {
    static void Main()
    {
      ColorCollection cc = new ColorCollection();

      foreach (string color in cc.Forward())
        Console.Write("{0} ", color);
      Console.WriteLine("");

      foreach (string color in cc.Reverse())
      {
        Console.Write("{0} ", color);
      }
      Console.WriteLine("");

      IEnumerable<string> ieable = cc.Reverse();
      IEnumerator<string> ieator = ieable.GetEnumerator();

      while (ieator.MoveNext())
        Console.Write("{0} ", ieator.Current);
      Console.WriteLine("");
    }
  }
}
