using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ListOverCollections
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** LINQ over Generic Collections *****\n");
      // Создать список List<> объектов Car
      List<Car> myCars = new List<Car>
      {
          new Car {PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
          new Car {PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
          new Car {PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
          new Car {PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
          new Car {PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
        };

      GetFastCars(myCars);
      GetFastBMW(myCars);
      LINQOverArrayList();
      OfTypeAsFilter();

    }
    static void GetFastCars(List<Car> myCars)
    {
      // Найти в контейнере List<> объекты Car, у которых Speed > 55
      var fastCars = from c in myCars where c.Speed > 55 select c;
      foreach (var car in fastCars)
      {
        Console.WriteLine("{0} is going too fast!", car.PetName);
      }
    }
    static void GetFastBMW(List<Car> myCars)
    {
      // Найти в List<> объекты Car, у которых Speed > 90 и производитель - BMW
      var fastCars = from c in myCars where c.Speed > 90 && c.Make == "BMW" select c;

      foreach (var car in fastCars)
      {
        Console.WriteLine("{0} is going too fast!", car.PetName);
      }
    }
    static void LINQOverArrayList()
    {
      Console.WriteLine("***** LINQ over ArrayList *****\n");
      // Необобщенная коллекция автомобилей
      ArrayList myCars = new ArrayList
      {
        new Car{PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
        new Car{PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
        new Car{PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
        new Car{PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
        new Car{PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
      };

      // Трансформировать ArrayList в тип, совместимый с IEnumerable<T>.
      var myCarsEnum = myCars.OfType<Car>();

      // Создать запрос, нацеленный на совместимый с IEnumerable<T> тип.
      var fastCars = from c in myCarsEnum where c.Speed > 55 select c;

      foreach (var car in fastCars)
      {
        Console.WriteLine("{0} is going too fast!", car.PetName);
      }
    }
    static void OfTypeAsFilter()
    {
      // Извлечение целых из ArrayList
      ArrayList myStuff = new ArrayList();

      myStuff.AddRange(new object[] { 10, 400, 8, false, new Car(), "string data" });

      var myInts = myStuff.OfType<int>();

      foreach (int i in myInts)
      {
        Console.WriteLine("Int value: {0}", i);
      }
    }
  }
}
