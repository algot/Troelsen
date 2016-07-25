using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_ObjectInitializers
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Object Init Syntax *****\n");
      // Создать объект Point с установкой каждого свойства вручную.
      Point firstPoint = new Point();
      firstPoint.X = 10;
      firstPoint.Y = 15;
      firstPoint.DisplayStats();

      // Создать объект Point с использованием специального констуктора
      Point secondPoint = new Point(20, 25);
      secondPoint.DisplayStats();

      // Создать объект Point с использованием синтаксиса инициализатора объекта
      Point thirdPoint = new Point { X = 30, Y = 35 };
      thirdPoint.DisplayStats();

      // Вызов более интересного конструктора с синтаксисом инициализации
      Point fourthPoint = new Point(PointColor.Gold) { X = 40, Y = 45 };
      fourthPoint.DisplayStats();


      // Создать и инициализировать треугольник и установить внутренние переменные
      Rectangle rect = new Rectangle
      {
        TopLeft = new Point { X = 10, Y = 10 },
        BottomRight = new Point { X = 200, Y = 200 }
      };
      rect.DisplayStats();
    }
  }
}
