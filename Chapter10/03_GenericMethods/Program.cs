using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_GenericMethods
{
  class Program
  {
    static void Swap<T>(ref T a, ref T b)
    {
      var temp = a;
      a = b;
      b = temp;
    }

    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Custom Generics Methods *****\n");
      // Обмен 2 значений int
      int a = 10, b = 90;
      Console.WriteLine("Before swap: {0} {1}", a, b);
      Swap<int>(ref a, ref b);
      Console.WriteLine("After swap: {0} {1}", a, b);
      // Обмен 2 значений string
      string s1 = "Hello", s2 = "World";
      Console.WriteLine("Before swap: {0} {1}", s1, s2);
      Swap<string>(ref s1, ref s2);
      Console.WriteLine("After swap: {0} {1}", s1, s2);
      // Обмен 2 значений bool
      bool b1 = true, b2 = false;
      Console.WriteLine("Before swap: {0} {1}", b1, b2);
      Swap(ref b1, ref b2);
      Console.WriteLine("After swap: {0} {1}", b1, b2);
    }
  }
}
