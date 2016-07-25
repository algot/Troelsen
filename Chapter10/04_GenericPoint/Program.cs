using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_GenericPoint
{
  class Program
  {
    // Обобщенная структура Point
    public struct Point<T>
    {
      // Обобщенные данные состояния
      private T xPos;
      private T yPos;

      // Обобщенный конструктор
      public Point(T xVal, T yVal)
      {
        xPos = xVal;
        yPos = yVal;
      }
      // Обобщенные свойства
      public T X
      {
        get { return xPos; }
        set { xPos = value; }
      }

      public T Y
      {
        get { return yPos; }
        set { yPos = value; }
      }

      public override string ToString()
      {
        return string.Format("[{0}, {1}]", xPos, yPos);
      }

      // Сброс полей в значения по умолчанию
      public void ResetPoint()
      {
        xPos = default (T);
        yPos = default (T);
      }


    }

    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Generic Structures *****\n");
      // Объект Point, в котором используются int

      // Объект Point, в котором используются double

    }
  }
}
