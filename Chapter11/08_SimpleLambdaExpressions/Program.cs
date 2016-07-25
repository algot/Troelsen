using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_SimpleLambdaExpressions
{
  class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Lambdas *****\n");
      TraditionalDelegateSyntax();
      AnonymousMethodSyntax();
      LambdaExpressionSyntax();
    }

    static void TraditionalDelegateSyntax()
    {
      // Создать список целых чисел
      List<int> list = new List<int>();
      list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

      // Вызов FindAll() с использованием традиционного синтаксиса делегатов
      Predicate<int> callback = new Predicate<int>(IsEvenNumber);
      List<int> evenNumbers = list.FindAll(callback);

      Console.WriteLine("Here are your even numbers:");
      foreach (int evenNumber in evenNumbers)
      {
        Console.Write("{0}\t", evenNumber);
      }
      Console.WriteLine();
    }

    static void AnonymousMethodSyntax()
    {
      // Создать список целых
      List<int> list = new List<int>();
      list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

      // Теперь используем анонимный метод
      List<int> evenNumbers = list.FindAll(delegate (int i) { return (i % 2) == 0; });

      // Вывод четных чисел
      Console.WriteLine("Here are your even numbers:");
      foreach (int evenNumber in evenNumbers)
      {
        Console.Write("{0}\t", evenNumber);
      }
      Console.WriteLine();
    }

    static void LambdaExpressionSyntax()
    {
      // Создать список целых
      List<int> list = new List<int>();
      list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });


      // Обработать каждый аргумент в группе операторов кода
      List<int> evenNumbers = list.FindAll(i =>
      {
        Console.WriteLine("value of i is currently: {0}", i);
        bool isEven = ((i % 2) == 0);
        return isEven;
      });

      // Вывод четных чисел
      Console.WriteLine("Here are your even numbers:");
      foreach (int evenNumber in evenNumbers)
      {
        Console.Write("{0}\t", evenNumber);
      }
      Console.WriteLine();
    }

    // Цель для делегата Predicate<>
    static bool IsEvenNumber(int i)
    {
      // Это четное число?
      return (i % 2) == 0;
    }
  }
}
