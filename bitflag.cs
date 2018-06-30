using System;

[Flags]
enum CardDeckSettings : uint
{
  SingleDeck    = 0x01,
  LargePictures = 0x02,
  FancyNumbers  = 0x04,
  Animation     = 0x08,
}

class MyClass
{
  bool UseSingleDeck   = false;
  bool UseBigPics      = false;
  bool UseFancyNums = false;
  bool UseAnimation    = false;

  public void SetOptions(CardDeckSettings ops)
  {
    UseSingleDeck = (ops & CardDeckSettings.SingleDeck)
                        == CardDeckSettings.SingleDeck;
    UseBigPics = (ops & CardDeckSettings.LargePictures)
                     == CardDeckSettings.LargePictures;
    UseFancyNums = (ops & CardDeckSettings.FancyNumbers)
                     == CardDeckSettings.FancyNumbers;
    UseAnimation = (ops & CardDeckSettings.Animation)
                     == CardDeckSettings.Animation;
  }

  public void PrintOptions(CardDeckSettings ops)
  {
    Console.WriteLine("Option settings:");
    Console.WriteLine("   Use Single Deck    - {0}", UseSingleDeck);
    Console.WriteLine("   Use Large Pictures - {0}", UseBigPics);
    Console.WriteLine("   Use Fancy Numbers  - {0}", UseFancyNums);
    Console.WriteLine("   Use Animation      - {0}", UseAnimation);
  }
}

class Program
{
  static void Main()
  {
    MyClass mc = new MyClass();
    CardDeckSettings ops = CardDeckSettings.SingleDeck
                         | CardDeckSettings.FancyNumbers
                         | CardDeckSettings.Animation;
    mc.SetOptions(ops);
    mc.PrintOptions(ops);
  }
}

