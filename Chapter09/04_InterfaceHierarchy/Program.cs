using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_InterfaceHierarchy
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Play with Interface Hierarchy *****\n");
      // Вызов на уровне объекта.
      BitmapImage myBitmap = new BitmapImage();
      myBitmap.Draw();
      myBitmap.DrawInBoundingBox(10, 10, 100, 150);
      myBitmap.DrawUpsideDown();

      // Получить IAdvancedDraw явным образом
      IAdvancedDraw iAdvDraw = myBitmap as IAdvancedDraw;
      if (iAdvDraw != null)
      {
        iAdvDraw.DrawUpsideDown();
      }

    }
  }
}
