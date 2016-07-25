using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_CarEvents
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with events *****\n");
      Car c1 = new Car("SlugBug", 100, 10);

      // Зарегистрировать обработчики событий.
      c1.AboutToBlow += CarIsAlmostDoomed;
      c1.AboutToBlow += CarAboutToBlow;
      c1.Exploded += CarExploded;

      Console.WriteLine("***** Speeding up... *****\n");
      for (int i = 0; i < 6; i++)
        c1.Accelerate(20);

      // Удалить метод CarExploded из списка вызовов
      c1.Exploded -= CarExploded;

      Console.WriteLine("\n***** Speeding up *****");
      for (int i = 0; i < 6; i++)
        c1.Accelerate(20);
      Console.ReadLine();
    }


    public static void CarAboutToBlow(object sender, CarEventArgs e)
    { Console.WriteLine("{0} says: {1}", sender, e.msg); }

    public static void CarIsAlmostDoomed(object sender, CarEventArgs e)
    {
      if (sender is Car)
      {
        Car c = (Car)sender;
        Console.WriteLine("=> Critical Message from {0}: {1}", c.PetName, e.msg);
      }
    }
    public static void CarExploded(object sender, CarEventArgs e)
    { Console.WriteLine("{0} says: {1}", sender, e.msg); }
  }
}
