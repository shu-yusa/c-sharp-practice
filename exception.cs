using System;

class Program
{
  public static void Main()
  {
    int x = 10;
    try {
      int y=0;
      x /= y;
    } catch (DivideByZeroException e) {
      Console.WriteLine("Message: {0}", e.Message);
      Console.WriteLine("Source : {0}", e.Source);
      Console.WriteLine("Stack  : {0}", e.StackTrace);
      return ;
    } catch {
      Console.WriteLine("Handling all exception - Keep on Running");
    } finally {
      Console.WriteLine("In finally statement");
    }
  }
}
