using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_ConstData
{
  class MyMathClass
  {
    public const double PI = 3.14;
    public readonly double E;

    public MyMathClass()
    {
      E = 2.7;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Constants *****\n");
      Console.WriteLine("The value of PI is {0}: ", MyMathClass.PI);
      MyMathClass myMath = new MyMathClass();
      Console.WriteLine("The value of E is {0}: ", myMath.E);
    }
  }
}
