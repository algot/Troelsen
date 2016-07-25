using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FunWithLINQExpressions
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("***** Fun with Query Expressions *****\n");
      // Этот массив будет основой для тестирования
      ProductInfo[] itemsInStock =
      {
        new ProductInfo {Name = "Mac's Coffee", Description = "Coffee with TEETH", NumberInStock = 24},
        new ProductInfo {Name = "Milk Maid Milk", Description = "Milk cow's love", NumberInStock = 100},
        new ProductInfo {Name = "Pure Silk Tofu", Description = "Bland as Possible", NumberInStock = 120},
        new ProductInfo {Name = "Cruchy Pops", Description = "Cheezy, peppery goodness", NumberInStock = 2},
        new ProductInfo {Name = "RipOff water", Description = "From the tap to your wallet", NumberInStock = 100},
        new ProductInfo {Name = "Classic Valpo Pizza", Description = "Everyone loves pizza!", NumberInStock = 73}
      };

      SelectEverything(itemsInStock);
      SelectProductNames(itemsInStock);
      GetOverstock(itemsInStock);
      GetNamesAndDescriptions(itemsInStock);
      GetCountFromQuery();
      ReverseEverything(itemsInStock);
      AlphabetizeProductNames(itemsInStock);
      DisplayDiff();
      DisplayIntersection();
      DisplayUnion();
      DisplayConcat();
      DisplayConcatNoDup();
      AggregateOpps();
    }

    static void SelectEverything(ProductInfo[] products)
    {
      // Получить всё
      Console.WriteLine("All product details:\n");

      var allProducts = from p in products select p;

      foreach (var product in allProducts)
      {
        Console.WriteLine(product.ToString());
      }
      Console.WriteLine();
    }

    static void SelectProductNames(ProductInfo[] products)
    {
      // Получить имена продуктов
      Console.WriteLine("Product names:\n");

      var productNames = from p in products select p.Name;

      foreach (var productName in productNames)
      {
        Console.WriteLine("Name: {0}", productName);
      }

      Console.WriteLine();
    }

    private static void GetOverstock(ProductInfo[] products)
    {
      Console.WriteLine("The overstock items!");
      // Получить только те товары. которых на складе больше 25
      var overstock = from p in products where p.NumberInStock > 25 select p;

      foreach (var c in overstock)
      {
        Console.WriteLine(c.ToString());
      }
    }

    static void GetNamesAndDescriptions(ProductInfo[] products)
    {
      // Получить имена и описания
      Console.WriteLine("Product Names and Descriptions:\n");

      var productNamesDesc = from p in products select new { p.Name, p.Description };
      foreach (var item in productNamesDesc)
      {
        Console.WriteLine(item.ToString());
      }
    }
    static void GetCountFromQuery()
    {
      string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
      // Получить количество из запроса
      int numb =
        (from g in currentVideoGames where g.Length > 6 select g).Count<string>();
      // Вывести на консоль количество элементов
      Console.WriteLine("{0} items honor the LINQ query.", numb);
      Console.WriteLine();
    }
    static void ReverseEverything(ProductInfo[] products)
    {
      Console.WriteLine("Products in reverse order:\n");
      var allProducts = from p in products select p;
      foreach (var prod in allProducts.Reverse())
      {
        Console.WriteLine(prod.ToString());
      }
      Console.WriteLine();
    }
    static void AlphabetizeProductNames(ProductInfo[] products)
    {
      // Получить названия товаров в алфавитном порядке
      var subset = from p in products orderby p.Name select p;
      Console.WriteLine("Ordered by Name:\n");
      foreach (var p in subset)
      {
        Console.WriteLine(p.ToString());
      }
      Console.WriteLine();
    }
    static void DisplayDiff()
    {
      List<string> myCars = new List<string>() { "Yugo", "Aztec", "BMW" };
      List<string> yourCars = new List<string>() { "BMW", "Saab", "Aztec" };

      var carDiff = (from c in myCars select c).Except(from c2 in yourCars select c2);
      Console.WriteLine("Here is what you don't have, but I do: ");
      foreach (string s in carDiff)
      {
        Console.WriteLine(s);
      }

      Console.WriteLine();
    }
    static void DisplayIntersection()
    {
      List<string> myCars = new List<string>() { "Yugo", "Aztec", "BMW" };
      List<string> yourCars = new List<string>() { "BMW", "Saab", "Aztec" };
      // Получить общие члены
      var carIntersect = (from c in myCars select c).Intersect(from c2 in yourCars select c2);

      Console.WriteLine("Here is what we have in common: ");
      foreach (var s in carIntersect)
        Console.WriteLine(s);
      Console.WriteLine();
    }
    static void DisplayUnion()
    {
      List<string> myCars = new List<string>() { "Yugo", "Aztec", "BMW" };
      List<string> yourCars = new List<string>() { "BMW", "Saab", "Aztec" };
      // Получить общие члены
      var carIntersect = (from c in myCars select c).Union(from c2 in yourCars select c2);
      foreach (var s in carIntersect)
        Console.WriteLine(s);
      Console.WriteLine();
    }
    static void DisplayConcat()
    {
      List<string> myCars = new List<string>() { "Yugo", "Aztec", "BMW" };
      List<string> yourCars = new List<string>() { "BMW", "Saab", "Aztec" };
      // Получить общие члены
      var carIntersect = (from c in myCars select c).Concat(from c2 in yourCars select c2);
      foreach (var s in carIntersect)
        Console.WriteLine(s);
      Console.WriteLine();
    }
    static void DisplayConcatNoDup()
    {
      List<string> myCars = new List<string>() { "Yugo", "Aztec", "BMW" };
      List<string> yourCars = new List<string>() { "BMW", "Saab", "Aztec" };
      // Получить общие члены
      var carIntersect = (from c in myCars select c).Concat(from c2 in yourCars select c2);
      foreach (var s in carIntersect.Distinct())
        Console.WriteLine(s);
      Console.WriteLine();
    }
    static void AggregateOpps()
    {
      double[] winterTemps = { 2.0, -21.3, 8, -4, 0, 8.2 };
      // Различные примеры агрегации
      Console.WriteLine("Max temp: {0}", (from t in winterTemps select t).Max());
      Console.WriteLine("Min temp: {0}", (from t in winterTemps select t).Min());
      Console.WriteLine("Average temp: {0}", (from t in winterTemps select t).Average());
      Console.WriteLine("Sum of temps: {0}", (from t in winterTemps select t).Sum());
    }
  }
}