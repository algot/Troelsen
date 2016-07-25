using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_CustomInterface
{
  abstract class Shape
  {
    public Shape(string name = "NoName")
    { PetName = name; }

    public string PetName { get; set; }

    // Единственный виртуальный метод
    public abstract void Draw();
  }
}
