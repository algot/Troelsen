namespace _01_SimpleClassExample
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;

  public class Radio
  {
    public void Power(bool turnOn)
    {
      Console.WriteLine("Radio on: {0}", turnOn);
    }
  }
}
