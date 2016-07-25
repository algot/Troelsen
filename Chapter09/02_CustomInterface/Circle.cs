using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_CustomInterface
{
  // Circle не переопределяет Draw()
  class Circle : Shape, IDraw3D
  {
    public Circle() { }
    public Circle(string name) : base(name) { }

    public override void Draw()
    {
      Console.WriteLine("Drawing {0} the Circle", PetName);
    }

    public void Draw3D()
    {
      Console.WriteLine("Drawing Circle in 3D.");
    }
  }
}
