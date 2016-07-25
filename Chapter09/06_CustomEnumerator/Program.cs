using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _06_CustomEnumerator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with IEnumerator *****\n");
      Garage carLot = new Garage();
      // Проход по всем объектам Car в коллекции
      foreach (Car c in carLot)
      {
        Console.WriteLine("{0} is going {1} MPH", 
          c.PetName, c.CurrentSpeed);
      }

      // Работа напрямую с IEnumerator
      //IEnumerator i = carLot.GetEnumerator();
      //i.MoveNext();
      //Car myCar = (Car)i.Current;
      //Console.WriteLine("{0} is going {1} MPH", myCar.PetName, myCar.CurrentSpeed);
    }
  }
}
