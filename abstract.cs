using System;

abstract class AbClass
{
  public void IdentifyBase()
  {
    Console.WriteLine("I am AbClass.");
  }

  abstract public void IdentifyDerived();
}

class DerivedClass : AbClass
{
  override public void IdentifyDerived()
  {
    Console.WriteLine("I am DerivedClass.");
  }
}

class Example
{
  static void Main()
  {
    // error : abstract クラスをインスタンス化できない.
    // AbClass a = new AbClass();
    // a.IdentifyDerived();

    // 派生クラスをインスタンス化
    DerivedClass b = new DerivedClass();
    // 継承されたメソッドを呼び出す.
    b.IdentifyBase();
    // abstractメソッドを呼び出す.
    b.IdentifyDerived();
  }
}
    
