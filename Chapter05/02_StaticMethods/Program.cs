using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_StaticMethods
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Class Types *****");
      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine(Teenager.Complain());
      }
    }
  }
}
