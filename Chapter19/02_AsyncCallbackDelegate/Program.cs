using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_AsyncCallbackDelegate
{
  public delegate int BinaryOp(int x, int y);

  class Program
  {
    private static bool isDone = false;

    static void Main(string[] args)
    {
      Console.WriteLine("***** AsyncCallbackDelegate Example *****");
      Console.WriteLine("Main() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);

      BinaryOp b = new BinaryOp(Add);
      IAsyncResult iftAR = b.BeginInvoke(10, 10, AddComplete, "Main() thanks you for adding these numbers.");

      // Здесь выполняется какая-то другая работа
      while (!isDone)
      {
        Thread.Sleep(1000);
        Console.WriteLine("Working...");
      }
    }

    private static int Add(int x, int y)
    {
      Console.WriteLine("Add() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);
      Thread.Sleep(5000);
      return x + y;
    }

    private static void AddComplete(IAsyncResult itfAR)
    {
      Console.WriteLine("AddComplete() invoked on thread {0}.", Thread.CurrentThread.ManagedThreadId);
      Console.WriteLine("Your addition is complete");

      // Получить результат
      AsyncResult ar = (AsyncResult)itfAR;
      BinaryOp b = (BinaryOp)ar.AsyncDelegate;
      Console.WriteLine("10 + 10 is {0}.", b.EndInvoke(itfAR));

      // Получить информационный объект и привести его к string
      string msg = (string) itfAR.AsyncState;
      Console.WriteLine(msg);

      isDone = true;
    }
  }
}
