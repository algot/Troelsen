using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_InterfaceHierarchy
{
  interface IAdvancedDraw : IDrawable
  {
    void DrawInBoundingBox(int top, int left, int bottom, int right);
    void DrawUpsideDown();
  }
}
