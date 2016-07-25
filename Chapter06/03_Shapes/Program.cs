using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Shapes
{
  class Program
  {
    static void Main(string[] args)
    {
      // Создать массив совместимых с Shape объектов
      Shape[] myShapes = { new Hexagon(), new Circle(), 
                           new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda") };
      // Пройтись по массиву и взаимодействовать с полиморфным интерфейсом
      foreach (Shape s in myShapes)
      {
        s.Draw();
      }

      // Здесь вызывается метод Draw() из класса ThreeDCircle
      ThreeDCircle o = new ThreeDCircle();
      o.Draw();

      // Здесь вызывается родительский метод
      ((Circle)o).Draw();
    }
  }
}
