using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_CustomException
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Custom Exception *****\n");
      Car rusty = new Car("Rusty", 90);
      try
      {
        // Отслеживание исключения
        rusty.Accelerate(50);
      }
      catch (CarIsDeadException e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}
