using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_BasicInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Basic Inheritance *****\n");
      // Создать экземпляр класса Car и установить максимальную скорость
      Car car1 = new Car(70);
      // Установить текущую скорость и вывести ее на экран
      car1.Speed = 50;
      Console.WriteLine("car1 is going {0} km/h", car1.Speed);

      // Создать объект MiniVan
      MiniVan miniVan1 = new MiniVan();
      miniVan1.Speed = 10;
      Console.WriteLine("miniVan1 is going {0} km/h", miniVan1.Speed);
      // miniVan1.currSpeed = 55;   // ERROR!!!

    }
  }
}
