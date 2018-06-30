using System;

class Simple
{
  static public void ReverseAndPrint<T>(T[] arr)
  {
    Array.Reverse(arr);
    foreach (T item in arr)
      Console.Write("{0}, ", item.ToString());
    Console.WriteLine("");
  }
}


class Program
{
  static void Main()
  {
    var intArray = new int[] {3,5,7,9,11};
    var stringArray = new string[] {"first", "second", "third"};
    var doubleArray = new double[] {3.567, 7.891, 2.345};

    Simple.ReverseAndPrint<int>(intArray);
    Simple.ReverseAndPrint(intArray);

    Simple.ReverseAndPrint<string>(stringArray);
    Simple.ReverseAndPrint(stringArray);

    Simple.ReverseAndPrint<double>(doubleArray);
    Simple.ReverseAndPrint(doubleArray);
  }
}
