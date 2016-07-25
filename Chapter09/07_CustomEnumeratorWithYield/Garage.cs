using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _07_CustomEnumeratorWithYield
{
  class Garage : IEnumerable
  {
    private Car[] carArray = new Car[4];
    // Заполнение его объектами Car при запуске.
    public Garage()
    {
      carArray[0] = new Car("Rusty", 30);
      carArray[1] = new Car("Clunker", 55);
      carArray[2] = new Car("Zippy", 30);
      carArray[3] = new Car("Fred", 30);
    }

    // Метод итератора
    public IEnumerator GetEnumerator()
    {
      foreach (Car c in carArray)
      {
        yield return c;
      }
    }

    public IEnumerable GetTheCars(bool returnReversed)
    {
      // Возвратить элементы в обратном порядке
      if (returnReversed)
      {
        for (int i = carArray.Length; i != 0; i--)
        {
          yield return carArray[i - 1];
        }
      }
      else
      {
        foreach (Car c in carArray)
        {
          // Возвратить элементы в прямом порядке
          yield return c;
        }
      }
    }
  }
}
