using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_PrimAndProperCarEventsGeneric
{
  static class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Prim and proper events *****\n");

      // Создать объект Car
      Car c1 = new Car("SlugBug", 100, 10);

      // Зарегистрировать обработчики событий
      c1.AboutToBlow += (sender, e) => { Console.WriteLine(e.msg); };
      c1.Exploded += (sender, e) => { Console.WriteLine(e.msg); };

      Console.WriteLine("***** Speeding up *****");
      for (var i = 0; i < 6; i++)
        c1.Accelerate(20);

      c1.Exploded -= CarExploded;

      Console.WriteLine("\n***** Speeding up *****");
      for (var i = 0; i < 6; i++)
        c1.Accelerate(20);
    }

    public static void CarAboutToBlow(object sender, CarEventArgs e)
    {
      if (sender is Car)
      {
        Car c = (Car)sender;
        Console.WriteLine("Critical message from {0}: {1}", c.PetName, e.msg);
      }
    }
    public static void CarExploded(object sender, CarEventArgs e)
    { Console.WriteLine(e.msg); }
  }
}
