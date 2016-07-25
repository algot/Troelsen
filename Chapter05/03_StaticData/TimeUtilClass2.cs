namespace _03_StaticData
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;

  class TimeUtilClass2
  {
    // Переопределение конструктора по умолчанию как private для предотвращения создания экземпляров
    private TimeUtilClass2(){ }

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
