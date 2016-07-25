using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LinqOverArray
{
  class Program
  {
    static void QueryOverString()
    {
      // Предположим, что имеется массив строк
      string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System shock 2" };

      // Запрос для вывода только строк, содержащих пробелы
      var subset = from game in currentVideoGames where game.Contains(" ") orderby game select game;

      // Вывести на консоль результаты
      foreach (var s in subset)
      {
        Console.WriteLine("Item: {0}", s);
      }

      ReflectOverQueryResults(subset);
    }

    static void ReflectOverQueryResults(object resultSet)
    {
      Console.WriteLine("***** Info about your query *****");
      Console.WriteLine("resultSet is of type: {0}", resultSet.GetType().Name);
      Console.WriteLine("resultSet location: {0}",
        resultSet.GetType().Assembly.GetName().Name);
    }

    static void QueryOverInts()
    {
      int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
      // Вывести только элементы меньше 10.
      var subset = from i in numbers where i < 10 select i;

      foreach (var i in subset)
      {
        Console.WriteLine("Item: {0}", i);
      }
      ReflectOverQueryResults(subset);
    }

    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with LINQ to Objects *****\n");
      QueryOverString();
      QueryOverInts();
      ImmediateExecution();
    }

    static void ImmediateExecution()
    {
      int[] numbers = {10, 20, 30, 40, 1, 2, 3, 8};

      // Получить данные немедленно как int[].
      int[] subsetAsIntArray = (from i in numbers where i < 10 select i).ToArray<int>();

      // Получить данные немедленно как List<int>.
      List<int> subsetAsListOfInts = (from i in numbers where i < 10 select i).ToList<int>();
    }
  }
}
