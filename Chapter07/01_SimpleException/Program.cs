using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _01_SimpleException
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Simple Exception *****\n");
      Console.WriteLine("=> Creating a car and stepping on it");
      Car myCar = new Car("Zippy", 20);
      myCar.CrankTunes(true);
      try
      {
        for (int i = 0; i < 10; i++)
          myCar.Accelerate(10);
      }
      catch (Exception e)
      {
        Console.WriteLine("\n*** Error! ***");
        Console.WriteLine("Method: {0}", e.TargetSite);
        Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType);
        Console.WriteLine("Member Type: {0}", e.TargetSite.MemberType);
        Console.WriteLine("Message: {0}", e.Message);
        Console.WriteLine("Source: {0}", e.Source);
        Console.WriteLine("Stack: {0}", e.StackTrace);
        Console.WriteLine("Help: {0}", e.HelpLink);

        Console.WriteLine("\n-> Custom Data:");
        if (e.Data != null)
        {
          foreach (DictionaryEntry de in e.Data)
            Console.WriteLine("-> {0}: {1}", de.Key, de.Value);
        }
      }
      Console.WriteLine("\n*** Out of exception logic. ***");
    }
  }
}
