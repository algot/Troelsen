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
class PointRef
{
  public int X;
  public int Y;

  public PointRef(int XPos, int YPos)
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
class ShapeInfo
{
  public string infoString;
  public ShapeInfo(string info)
  {
    infoString = info;
  }
}
struct Rectangle
{
  // Структура Rectangle содержит в себе член ссылочного типа.
  public ShapeInfo rectInfo;
  public int rectTop, rectLeft, rectBottom, rectRight;

  public Rectangle(string info, int top, int left, int bottom, int right)
  {
    rectInfo = new ShapeInfo(info);
    rectTop = top; rectBottom = bottom;
    rectLeft = left; rectRight = right;
  }

  public void Display()
  {
    Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, Left = {3}, Right = {4}", rectInfo.infoString, rectTop, rectBottom, rectLeft, rectRight);
  }
}

class Program
{
  static void ValueTypeContainingRefType()
  {
  // Создание первой переменной Rectangle.
    Console.WriteLine("\n-> Creating r1");
    Rectangle r1 = new Rectangle("First Rectangle", 10, 10, 50, 50);
    // Присваивание второй переменной ссылки на r1.
    Console.WriteLine("-> Assigning r2 to r1");
    Rectangle r2 = r1;
    // Изменение некоторых значений в r2.
    Console.WriteLine("-> Changing some values of r2.");
    r2.rectInfo.infoString = "This is new info";
    r2.rectBottom = 4444;
    // Вывод обеих переменных.
    r1.Display();
    r2.Display();
  }
  
  static void Main()
  {
    Console.WriteLine("\nAssigning value types.\n");
    Point p1 = new Point(10, 10);
    Point p2 = p1;

    // Вывод обеих переменных Point.
    p1.Display();
    p2.Display();
    // Изменение значения p1.X и вывод
    p1.X = 110;
    Console.WriteLine("\n=> Changed p1.X\n");
    p1.Display();
    p2.Display();

    Console.WriteLine("Assigning reference types.\n");
    PointRef pr1 = new PointRef(10, 10);
    PointRef pr2 = pr1;
    // Вывод обеих переменных PointRef.
    pr1.Display();
    pr2.Display();
    // Изменение значения pr1.X и вывод
    pr1.X = 110;
    Console.WriteLine("\n=> Changed pr1.X\n");
    pr1.Display();
    pr2.Display();

    ValueTypeContainingRefType();
  }
}

