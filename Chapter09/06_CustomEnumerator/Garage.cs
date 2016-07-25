using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _06_CustomEnumerator 
{
  class Garage : IEnumerable
  {
    private readonly Car[] carArray = new Car[4];
    // Заполнение его объектами Car при запуске.
    public Garage()
    {
      carArray[0] = new Car("Rusty", 30);
      carArray[1] = new Car("Clunker", 55);
      carArray[2] = new Car("Zippy", 30);
      carArray[3] = new Car("Fred", 30);
    }

    public IEnumerator GetEnumerator()
    {
      return carArray.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return carArray.GetEnumerator();
    }
  }
}
