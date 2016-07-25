using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05b_ActionAndFuncDelegates
{
  class Program
  {
    // Цель для делегата Action<>
    static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
    {
      // Установить цвет текста консоли
      ConsoleColor previous = Console.ForegroundColor;
      Console.ForegroundColor = txtColor;

      for (int i = 0; i < printCount; i++)
      {
        Console.WriteLine(msg);
      }
      // Восстановить цвет
      Console.ForegroundColor = previous;
    }
    // Цель для делегата Func<>
    static int Add(int x, int y)
    {
      return x + y;
    }


    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Action and Func *****");

      // Использовать Action<> для указания на DisplayMessage
      Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);

      actionTarget("Action Message!", ConsoleColor.Yellow, 5);

      // Использовать Func<>
      Func<int, int, int> funcTarget = new Func<int, int, int>(Add);

      int result = funcTarget(40, 40);
      Console.WriteLine(result);
    }
  }
}
