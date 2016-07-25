using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_GenericDelegate
{
  class Program
  {
    // Этот обобщенный делегат может вызывать любой метод, который 
    // возвращает void и принимает единственный параметр типа. 
    public delegate void MyGenericDelegate<T>(T arg);

    static void Main(string[] args)
    {
      Console.WriteLine("***** Generic Delegates *****\n");
      MyGenericDelegate<string> strTarget = 
        new MyGenericDelegate<string>(StringTarget);
      strTarget("Some string data");
      MyGenericDelegate<int> intTarget =
        new MyGenericDelegate<int>(IntTarget);
      intTarget(9);
    }

    static void StringTarget(string arg)
    {
      Console.WriteLine("arg in uppercase is {0}", arg.ToUpper());
    }
    static void IntTarget(int arg)
    {
      Console.WriteLine("++arg is {0}", ++arg);
    }
  }
}
