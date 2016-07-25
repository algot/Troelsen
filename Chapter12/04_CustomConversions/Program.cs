using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CustomConversions
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Conversions *****\n");

      // Создать Rectangle
      Rectangle r = new Rectangle(15, 4);
      Console.WriteLine(r.ToString());
      r.Draw();
      Console.WriteLine();

      // Преобразовать r в Square на основе высоты r
      Square s = (Square)r;
      Console.WriteLine(s.ToString());
      s.Draw();

      // Преобразовать int в Square
      Square sq2 = (Square)90;
      Console.WriteLine("sq2 = {0}", sq2);
      
      // Преобразовать Square в int
      int side = (int)sq2;
      Console.WriteLine("side = {0}", side);

      // Неявное преобразование работает!
      Square s3 = new Square {Length = 7};
      
      Rectangle rect2 = s3;
      Console.WriteLine("rect2 = {0}", rect2);

      // Явное преобразование тоже работает
      Square s4 = new Square {Length = 3};
      
      Rectangle rect3 = s4;
      Console.WriteLine("rect3 = {0}", rect3);
    }
  }
}
