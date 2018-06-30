using System;
using System.Threading;

public class MyTCEventArgs : EventArgs
{
  public string Message;
  public MyTCEventArgs(string s) {
    Message = s;
  }
}

public class MyTimerClass
{
  // event declaration
  public event EventHandler<MyTCEventArgs> Elapsed;

  private void OnOneSecond(object source, EventArgs args)
  {
    if (Elapsed != null)
    {
      MyTCEventArgs mtcea = new MyTCEventArgs("Message from OnOneSecond");
      Elapsed(source, mtcea);
    }
  }

  // private timer 
  private System.Timers.Timer MyPrivateTimer;

  public MyTimerClass()
  {
    MyPrivateTimer = new System.Timers.Timer();

    MyPrivateTimer.Elapsed += OnOneSecond;

    MyPrivateTimer.Interval = 1000;

    MyPrivateTimer.Enabled = true;
  }

}

class ClassA
{
  // Event Handler
  public void TimerHandlerA(object obj, MyTCEventArgs e)
  {
    Console.WriteLine("Class A handler called");
  }

}

class ClassB
{
  // static method
  public static void TimerHandlerB(object obj, MyTCEventArgs e)
  {
    Console.WriteLine("Class B handler called");
  }

}

class Program
{
  static void Main()
  {
    // creation of class object
    ClassA ca = new ClassA();
    // creation of timer object
    MyTimerClass mc = new MyTimerClass();
    mc.Elapsed += new EventHandler<MyTCEventArgs>(ca.TimerHandlerA);
    // register event handler A
    mc.Elapsed += ca.TimerHandlerA;
//  // register event handler B
    mc.Elapsed += ClassB.TimerHandlerB;
    Thread.Sleep(2250);
  }
}

