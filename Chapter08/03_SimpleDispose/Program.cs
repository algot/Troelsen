using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_SimpleDispose
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Dispose *****\n");
      MyResourceWrapper rw = new MyResourceWrapper();
      if (rw is IDisposable)
      {
        rw.Dispose();  
      }
    }
  }
}
