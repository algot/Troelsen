using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_CustomEnumeratorWithYield
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with the Yield Keyword. *****\n");
      Garage carLot = new Garage();

      // Получить элементы, используя GetEnumerator().
      foreach (Car c in carLot)
      {
        Console.WriteLine("{0} is going {1} MPH",
          c.PetName, c.CurrentSpeed);
      }
      Console.WriteLine();

      // Получить элементы (в обратном порядке!), используя именованый итератор.
      foreach (Car c in carLot.GetTheCars(true))
      {
        Console.WriteLine("{0} is going {1} MPH",
          c.PetName, c.CurrentSpeed);
      }
    }
  }
}
