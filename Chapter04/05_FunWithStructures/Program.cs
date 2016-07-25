using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

struct Point
{
  // Поля структуры
  public int X;
  public int Y;

  public Point(int XPos, int YPos)
  {
    X = XPos;
    Y = YPos;
  }

  // Добавление 1 к позиции (X, Y)
  public void Increment()
  {
    X++; Y++;
  }

  // Вычитание 1 из позиции (X, Y)
  public void Decrement()
  {
    X--; Y--;
  }

  // Отображение текущей позиции
  public void Display()
  {
    Console.WriteLine("X = {0}, Y = {1}", X, Y);
  }
}

class Program
{
  static void Main()
  {
    Console.WriteLine("***** A First Look at the Structures *****");
    // Создание Point с начальными значениями X и Y
    Point myPoint;
    myPoint.X = 349;
    myPoint.Y = 76;
    myPoint.Display();
    myPoint.Increment();
    myPoint.Display();

    Point p1 = new Point(10, 11);
    p1.Display();
  }
}
