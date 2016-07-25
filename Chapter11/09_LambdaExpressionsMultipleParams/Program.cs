using System;

namespace _09_LambdaExpressionsMultipleParams
{
  class Program
  {
    static void Main(string[] args)
    {
      // Регистрация делегата, как лямбда-выражения
      SimpleMath m = new SimpleMath();
      m.SetMathHandler((msg, result) =>
     { Console.WriteLine("Message: {0}, Result: {1}", msg, result); });

      // Это приведет к выполнению лямбда выражения
      m.Add(10, 10);
    }
  }
}
