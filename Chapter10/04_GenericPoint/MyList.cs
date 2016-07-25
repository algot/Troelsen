using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_GenericPoint
{
  // Обобщенный класс с виртуальным методом
  public class MyList<T> where T : new()
  {
    private List<T> listOfData = new List<T>();
    public virtual void PrintList(T data) { }
  }
}
