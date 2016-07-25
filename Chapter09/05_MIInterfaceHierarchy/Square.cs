using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_MIInterfaceHierarchy
{
  class Square : IShape
  {
    void IPrintable.Draw()
    {
      // Рисование на принтере.
    }
    void IDrawable.Draw()
    {
      // Рисование на экране.
    }
    public void Print()
    {
      // Печать.
    }
    public int GetNumberOfSides()
    { return 4; }
  }
}
