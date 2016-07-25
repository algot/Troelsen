using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pset1
{
  class Program
  {
    static void Main(string[] args)
    {
      int spaces = 7;
      int sharps = 2;

      Console.WriteLine("{0}", spaces);  // debug
      Console.WriteLine("{0}", sharps);// debug

      for (; spaces <= 0; spaces--)
      {
        Console.WriteLine("{0}", spaces);
      }
    }
  }
}
