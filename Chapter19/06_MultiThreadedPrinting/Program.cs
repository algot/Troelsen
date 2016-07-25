using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06_MultiThreadedPrinting
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Synchronizing Threads *****\n");

      var p = new Printer();

      // Создать 10 потоков, которые указывают на один и тот же метод того же самого объекта
      var threads = new Thread[10];
      for (int i = 0; i < 10; i++)
      {
        threads[i] = new Thread(new ThreadStart(p.PrintNumbers));
        threads[i].Name = string.Format("Worker thread #{0}", i);
      }
      // Теперь запустить их все
      foreach (Thread t in threads)
      {
        t.Start();
      }
      Console.ReadLine();
    }
  }
}