using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_CloneablePoint
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with the object cloning. *****\n");
      //// Две ссылки на один и тот же объект.
      //Point p1 = new Point(50, 50);
      //Point p2 = p1;
      //p2.X = 0;
      //Console.WriteLine(p1);
      //Console.WriteLine(p2);

      Point p3 = new Point(100, 100, "Jane");
      Point p4 = (Point)p3.Clone();

      Console.WriteLine("Before Modification:");
      Console.WriteLine("p3: {0}", p3);
      Console.WriteLine("p4: {0}", p4);
      p4.Desc.PetName = "My new Point";
      p4.X = 9;

      Console.WriteLine("After Modification:");
      Console.WriteLine("p3: {0}", p3);
      Console.WriteLine("p4: {0}", p4);
    }
  }
}