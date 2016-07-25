using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LinqUsingEnumerable
{
  class Program
  {
    static void Main(string[] args)
    {
      QueryStringWithOperators();
      Console.WriteLine();

      QueryStringsWithEnumerablesAndLambdas();
      Console.WriteLine();

      QueryStringsWithEnumerablesAndLambdas2();
      Console.WriteLine();

      QueryStringsWithAnonymousMethods();
      Console.WriteLine();

      VeryComplexQueryExpression();
      Console.WriteLine();
    }

    static void QueryStringWithOperators()
    {
      Console.WriteLine("***** Using Query Operators *****");
      string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
      var subset = from game in currentVideoGames where game.Contains(" ") orderby game select game;
      foreach (string s in subset)
        Console.WriteLine("Item: {0}", s);
    }
    static void QueryStringsWithEnumerablesAndLambdas()
    {
      Console.WriteLine("***** Using Enumerables/Lambdas Expressions *****");
      string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
      // Построить выражение запроса с использованием расширяющих методов,
      // предоставленных типу Array через тип Enumerable

      var subset = currentVideoGames.Where(game => game.Contains(" ")).OrderBy(game => game).Select(game => game);

      foreach (var game in subset)
      {
        Console.WriteLine("Item: {0}", game);
      }
    }

    static void QueryStringsWithEnumerablesAndLambdas2()
    {
      Console.WriteLine("***** Using Enumerables/Lambdas Expressions *****");
      string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
      // Разделить на фрагменты

      var gamesWithSpaces = currentVideoGames.Where(game => game.Contains(" "));
      var orderedGames = gamesWithSpaces.OrderBy(game => game);
      var subset = orderedGames.Select(game => game);

      foreach (var game in subset)
      {
        Console.WriteLine("Item: {0}", game);
      }
    }

    static void QueryStringsWithAnonymousMethods()
    {
      Console.WriteLine("***** Using Anonymous methods *****");
      string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
      // Построить необходимые делегаты Func<> с использованием анонимных методов
      Func<string, bool> searchFilter = delegate (string game) { return game.Contains(" "); };
      Func<string, string> itemToProcess = delegate (string s) { return s; };
      // Передать делегаты в методы Enumerable
      var subset = currentVideoGames.Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess);

      // Вывести результаты
      foreach (var game in subset)
        Console.WriteLine("Item: {0}", game);
    }
    static void VeryComplexQueryExpression()
    {
      Console.WriteLine("***** Using RAW Delegates *****");
      string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
      // Построить необходимые делегаты Func<>
      Func<string, bool> searchFilter = new Func<string, bool>(Filter);
      Func<string, string> itemToProcess = new Func<string, string>(ProcessItem);
      // Передать делегаты в методы Enumerable
      var subset = currentVideoGames.Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess);
      // Вывести результаты
      foreach (var game in subset)
        Console.WriteLine("Item: {0}", game);
    }
    // Цели делегатов
    public static bool Filter(string game)
    {
      return game.Contains(" ");
    }

    public static string ProcessItem(string game)
    {
      return game;
    }
  }
}
