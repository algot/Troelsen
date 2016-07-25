using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
  static int Add(int x, int y)
  {
    return x + y;
  }
  static double Add(double x, double y)
  {
    return x + y;
  }
  static long Add(long x, long y)
  {
    return x + y;
  }

  static void Main()
  {
    Console.WriteLine(Add(10, 15));
    Console.WriteLine(Add(100000000, 5000000000));
    Console.WriteLine(Add(5.6, 2.8));
  }
}

