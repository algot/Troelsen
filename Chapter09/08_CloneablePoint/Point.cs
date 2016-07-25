using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_CloneablePoint
{
  internal class Point : ICloneable
  {
    public int X { get; set; }
    public int Y { get; set; }
    public PointDescription Desc = new PointDescription();

    public Point(int xPos, int yPos, string petName)
    {
      X = xPos;
      Y = yPos;
      Desc.PetName = petName;
    }

    public Point(int xPos, int yPos)
    {
      X = xPos;
      Y = yPos;
    }
    public Point() { }

    // Переопределение Object.ToString()
    public override string ToString()
    {
      return string.Format("X={0}; Y={1}; Name = {2};\nID = {3}\n",
        X, Y, Desc.PetName, Desc.PointId);
    }

    // Возврат копии текущего объекта.
    public object Clone()
    {
      Point newPoint = (Point)this.MemberwiseClone();

      PointDescription currentDesc = new PointDescription();
      currentDesc.PetName = this.Desc.PetName;
      newPoint.Desc = currentDesc;
      return newPoint;
    }
  }
}
