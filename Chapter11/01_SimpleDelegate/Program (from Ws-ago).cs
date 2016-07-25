using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SimpleDelegate
{
  // Этот делегат может указывать на любой метод,
  // принимающий 2 целых и возвращающий целое
  public delegate int BinaryOp(int x, int y);

  // Этот класс содержит методы, на которые будет указывать BinaryOp
  public class SimpleMath
  {
    public int Add(int x, int y)
    {
      return x + y;
    }
    public int Substract(int x, int y)
    {
      return x - y;
    }
  }

  class Program
  {
    static void DisplayDelegateInfo(Delegate delObj)
    {
      // Вывести на консоль имена всех членов из списка вызовов делегата
      foreach (Delegate d in delObj.GetInvocationList())
      {
        Console.WriteLine("Method name: {0}", d.Method);  // имя метода
        Console.WriteLine("Type name: {0}", d.Target);    // имя типа
      }
    }

    static void Main(string[] args)
    {
      Console.WriteLine("***** Simple delegate example. *****\n");
      // Создать объект делегата BinaryOp, "указывающий" на SimpleMath.Add()
      SimpleMath m = new SimpleMath();
      BinaryOp b = new BinaryOp(m.Add);
      // Вызвать SimpleMath.Add с использованием делегата
      Console.WriteLine("10 + 10 is {0}", b(10, 10));

      DisplayDelegateInfo(b);
    }
  }
}
