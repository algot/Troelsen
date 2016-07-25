using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _03_ProcessMultipleException
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Handling multiple exceptions *****\n");
      Car myCar = new Car("Rusty", 90);

      try
      {
        // Отслеживание исключения ArgumentOutOfRangeException
        myCar.Accelerate(-10);
      }
      catch (CarIsDeadException e)
      {
        Console.WriteLine(e.Message);
        FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
      }
      catch (ArgumentOutOfRangeException e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}
