using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_SimpleFinalize
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Finalizers. *****\n");
      Console.WriteLine("Hit the Return key to shut down this app.");
      Console.WriteLine("and force the GC to invoke Finalize()");
      Console.ReadLine();
      MyResourceWrapper rw = new MyResourceWrapper();
    }
  }
}
