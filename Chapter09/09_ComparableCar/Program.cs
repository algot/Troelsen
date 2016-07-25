using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09_ComparableCar
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with object sorting *****\n");
      // Создание массива объектов Car.
      Car[] myAutos = new Car[5];
      myAutos[0] = new Car("Rusty", 80, 1);
      myAutos[1] = new Car("Mary", 40, 234);
      myAutos[2] = new Car("Viper", 40, 34);
      myAutos[3] = new Car("Mel", 40, 4);
      myAutos[4] = new Car("Chucky", 40, 5);

      // Отображение текущего массива.
      Console.WriteLine("This is unordered set of Cars.");
      foreach (Car c in myAutos)
        Console.WriteLine("{0}{1}{2}", c.CarId, "\t", c.PetName);
      Console.WriteLine();

      // Сортировка массива с использованием интерфейса IComparable.
      Array.Sort(myAutos);

      // Отображение отсортированного массива.
      Console.WriteLine("This is ordered set of Cars.");
      foreach (Car c in myAutos)
        Console.WriteLine("{0}{1}{2}", c.CarId, "\t", c.PetName);
      Console.WriteLine();

      // Сортировка по дружественному названию.
      Array.Sort(myAutos, Car.SortByPetName);

      // Отображение отсортированного массива.
      Console.WriteLine("This is ordered set of Cars.");
      foreach (Car c in myAutos)
        Console.WriteLine("{0}{1}{2}", c.CarId, "\t", c.PetName);

    }
  }
}
