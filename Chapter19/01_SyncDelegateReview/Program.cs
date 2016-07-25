using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_SyncDelegateReview
{
  class Program
  {
    public delegate int BinaryOp(int x, int y);

    static void Main(string[] args)
    {
      Console.WriteLine("***** Async delegate invocation *****");

      // Вывести идентификатор выполняющегося потока
      Console.WriteLine("Main() invoked on thread{0}.", Thread.CurrentThread.ManagedThreadId);

      // Вызвать Add() во вторичном потоке
      BinaryOp b = Add;

      IAsyncResult iftAR = b.BeginInvoke(10, 10, null, null);

      // Выводить сообщение пока не будет завершен Add()
      while (!iftAR.IsCompleted)
      {
        Console.WriteLine("Doing more work in Main()!");
        Thread.Sleep(1000);
      }
      
      // Получить результат по готовности
      int answer = b.EndInvoke(iftAR);

      Console.WriteLine("10 + 10 is {0}.", answer);
    }

    static int Add(int x, int y)
    {
      // Вывести идентификатор выполняющегося потока
      Console.WriteLine("Add() invoked on thread {0}.", Thread.CurrentThread.ManagedThreadId);

      // Организовать паузу для моделирования длительной операции
      Thread.Sleep(5000);
      return x + y;
    }
  }
}
