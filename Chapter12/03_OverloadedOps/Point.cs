using System;

namespace _03_OverloadedOps
{
  public class Point
  {
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int xPos, int yPos)
    {
      X = xPos;
      Y = yPos;
    }

    public override string ToString()
    { return string.Format("[{0}, {1}]", this.X, this.Y); }

    // Перегрузка оператора +
    public static Point operator + (Point p1, Point p2)
    { return new Point(p1.X + p2.X, p1.Y + p2.Y); }

    // Перегрузка оператора -
    public static Point operator - (Point p1, Point p2)
    { return new Point(p1.X - p2.X, p1.Y - p2.Y); }


    // Оператор сдвига точки
    public static Point operator + (Point p1, int offset)
    { return new Point(p1.X + offset, p1.Y + offset); }

    // Оператор ++
    public static Point operator ++ (Point p1)
    { return new Point(p1.X + 1, p1.Y + 1); }
    // Оператор --
    public static Point operator -- (Point p1)
    { return new Point(p1.X - 1, p1.Y - 1); }

    public override bool Equals(object obj)
    {
      return obj.ToString() == this.ToString();
    }

    // Перегрузка операторов == и !=
    public static bool operator ==(Point p1, Point p2)
    { return p1.Equals(p2); }
    public static bool operator !=(Point p1, Point p2)
    { return !p1.Equals(p2); }

    // Перегрузка операторов > и <
    public int CompareTo(object obj)
    {
      if (obj is Point)
      {
        Point p = (Point)obj;
        if (this.X > p.X && this.Y > p.Y)
          return 1;
        if (this.X < p.X && this.Y < p.Y)
          return -1;
        return 0;
      }
      throw new ArgumentException();
    }

    public static bool operator <(Point p1, Point p2)
    { return (p1.CompareTo(p2) < 0); }
    public static bool operator >(Point p1, Point p2)
    { return (p1.CompareTo(p2) > 0); }
    public static bool operator <=(Point p1, Point p2)
    { return (p1.CompareTo(p2) <= 0); }
    public static bool operator >=(Point p1, Point p2)
    { return (p1.CompareTo(p2) >= 0); }
  }
}
