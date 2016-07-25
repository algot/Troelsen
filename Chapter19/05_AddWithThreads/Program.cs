﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05_AddWithThreads
{
  class Program
  {
    private static AutoResetEvent waitHandle = new AutoResetEvent(false);
    static void Main(string[] args)
    {
      Console.WriteLine("***** Adding with Thread objects *****");
      Console.WriteLine("ID of thread in Main(): {0}", Thread.CurrentThread.ManagedThreadId);

      // Создать объект AddParams для передачи вторичному потоку
      var ap = new AddParams(10, 10);
      var t = new Thread(new ParameterizedThreadStart(Add));
      t.Start(ap);
      // Подождать пока не поступит уведомление
      waitHandle.WaitOne();
      Console.WriteLine("Other thread is done!");
    }

    static void Add(object data)
    {
      if (data is AddParams)
      {
        Console.WriteLine("ID of thread in Add(): {0}", Thread.CurrentThread.ManagedThreadId);
        AddParams ap = (AddParams)data;
        Console.WriteLine("{0} + {1} is {2}", ap.A, ap.B, ap.A + ap.B);

        // Сообщить другому потоку о завершении работы
        waitHandle.Set();
      }
    }
  }
}