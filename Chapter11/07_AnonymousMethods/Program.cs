using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_AnonymousMethods
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Anonymous Methods *****\n");
      Car c1 = new Car("SlugBug", 100, 10);

      // Зарегистрировать обработчики событий в виде анонимных методов
      c1.AboutToBlow += delegate
      {
        Console.WriteLine("Eek! Going too fast!");
      };
      c1.AboutToBlow += delegate (object sender, CarEventArgs e)
      {
        Console.WriteLine("Message from Car: {0}", e.msg);
      };
      c1.Exploded += delegate (object sender, CarEventArgs e)
      {
        Console.WriteLine("Fatal message from Car: {0}", e.msg);
      };

      // Это в конечном итоге инициирует события.
      for (int i = 0; i < 6; i++)
        c1.Accelerate(20);
    }
  }
}
