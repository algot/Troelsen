using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_AutoProps
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with automatic properties *****");
      Car myCar1 = new Car();
      myCar1.PetName = "Frank";
      myCar1.Speed = 100;
      myCar1.Color = "Blue";
      myCar1.DisplayStats();

      // Поместить автомобиль в гараж.
      Garage g = new Garage();
      g.MyAuto = myCar1;

      // Вывод количества автомобилей в гараже.
      Console.WriteLine("Number of cars in garage is {0}.", g.NumberOfCars);
      // Вывод названия автомобиля.
      Console.WriteLine("Your car is named: {0}", myCar1.PetName);
    }
  }
}
