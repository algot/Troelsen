using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CustomConversions
{
  public struct Square
  {
    public int Length { get; set; }

    public Square(int l)
      : this()
    {
      Length = l;
    }

    public void Draw()
    {
      for (int i = 0; i < Length; i++)
      {
        for (int j = 0; j < Length; j++)
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }
    }

    public override string ToString()
    {
      return string.Format("[Length = {0}]", Length);
    }

    public static explicit operator Square(Rectangle r)
    {
      var s = new Square { Length = r.Height };
      return s;
    }

    public static explicit operator Square(int sideLength)
    {
      var newSq = new Square { Length = sideLength };
      return newSq;
    }

    public static explicit operator int(Square s)
    { return s.Length; }

    public static implicit operator Rectangle(Square s)
    {
      Rectangle r = new Rectangle();
      r.Height = s.Length;

      // Предположим, что длина нового Rectangle
      // будет равна (Length * 2)
      r.Width = s.Length * 2;

      return r;
    }
  }
}
