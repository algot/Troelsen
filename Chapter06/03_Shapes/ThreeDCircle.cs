using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Shapes
{
  class ThreeDCircle : Circle
  {
    // Скрыть любую реализацию Draw выше в иерархии
    public new void Draw()
    {
      Console.WriteLine("Drawing a 3D Circle");
    }
  }
}
