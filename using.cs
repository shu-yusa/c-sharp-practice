using System;
using System.IO;

namespace UsingStatemet
{
  class Program
  {
    static void Main()
    {
      // using sentence
      using (TextWriter tw = File.CreateText("Lincoln.txt"))
      {
        tw.WriteLine("Four score and seven years ago, ...");
      }

      // using sentence
      using (TextReader tr = File.OpenText("Lincoln.txt"))
      {
        string InputString;
        while (null != (InputString = tr.ReadLine()))
          Console.WriteLine(InputString);
      }
    }
  }
}

