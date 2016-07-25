using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06_MultiThreadedPrinting
{
  [Synchronization]
  public class Printer : ContextBoundObject
  {
    public void PrintNumbers()
    {
      // Вывести информацию о потоке
      Console.WriteLine("-> {0} is executing PrintNumbers()", Thread.CurrentThread.Name);

      // Вывести числа
      for (int i = 0; i < 10; i++)
      {
        // Приостановить поток на случайный период времени
        var r = new Random();
        Thread.Sleep(1000 * r.Next(5));
        Console.Write("{0}, ", i);
      }
      Console.WriteLine();
    }
  }
}