using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04_SimpleMultiThreadApp
{
  public class Printer
  {
    public void PrintNumbers()
    {
      // Вывести информацию о потоке
      Console.WriteLine("-> {0} is executing PrintNumbers()", Thread.CurrentThread.Name);
      // Вывести числа
      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine("{0}, ", i);
        Thread.Sleep(2000);
        Console.WriteLine();
      }
    }
  }
}
