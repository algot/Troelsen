using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_SimpleMultiThreadApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** The amazing thread app *****\n");
      Console.WriteLine("Do you want [1] or [2] threads? ");
      string threadCount = Console.ReadLine();

      // Назначить имя текущему потоку
      Thread primaryThread = Thread.CurrentThread;
      primaryThread.Name = "Primary";

      // Вывести информацию о потоке.
      Console.WriteLine("-> {0} is executing Main()", Thread.CurrentThread.Name);

      // Создать рабочий класс
      var p = new Printer();
      switch (threadCount)
      {
        case "2":
          // Создать поток
          var backgroundThread =
            new Thread(new ThreadStart(p.PrintNumbers));
          backgroundThread.Name = "Secondary";
          backgroundThread.Start();
          break;
        case "1":
          p.PrintNumbers();
          break;
        default:
          Console.WriteLine("I don't know what you want...you get 1 thread.");
          goto case "1";
      }
      
      // Выполнить некоторую дополнительную работу
      MessageBox.Show("I'm busy!", "Work on main thread...");
    }
  }
}
