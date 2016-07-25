namespace _03_StaticData
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;

  static class TimeUtilClass
  {
    public static void PrintTime()
    {
      Console.WriteLine(DateTime.Now.ToShortTimeString());
    }
    public static void PrintDate()
    {
      Console.WriteLine(DateTime.Today.ToShortDateString());
    }
  }
}
