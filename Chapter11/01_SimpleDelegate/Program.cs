using System;

namespace _01_SimpleDelegate
{
  // Этот делегат может указывать на любой метод, 
  // принимающий 2 целых и возвращающий целое.
  public delegate int BinaryOp(int x, int y);

  // Этот класс содержит методы, на которые будет ссылаться делегат
  public class SimpleMath
  {
    public static int Add(int x, int y)
    { return x + y; }
    public static int Subtract(int x, int y)
    { return x - y; }
  }

  class Program
  {
    static void DisplayDelegateInfo(Delegate delObj)
    {
      // Вывести в консоль  имена каждого члена списка вызовов делегата.
      foreach (Delegate d in delObj.GetInvocationList())
      {
        Console.WriteLine("Method name: {0}", d.Method);
        Console.WriteLine("Type name: {0}", d.Target);
      }
    }

    static void Main()
    {
      Console.WriteLine("***** Simple delegate example *****\n");

      // Создать объект делегата, указывающий на Add()
      BinaryOp b = new BinaryOp(SimpleMath.Add);
      // Вызвать Add с помощью делегата.
      Console.WriteLine("10 + 10 is {0}", b(10, 10));

      DisplayDelegateInfo(b);
    }

  }
}
