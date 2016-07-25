namespace _01_SimpleClassExample
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;

  public class Motorcycle
  {
    public int driverIntensity;
    public string driverName;

    // Вернуть конструктор по умолчанию, который будет устанавливать
    // для всех членов данных значения по умолчанию.
    public Motorcycle() 
    {
      Console.WriteLine("In default constructor.");
    }
    // Специальный конструктор.
    public Motorcycle(int intensity)
      : this(intensity, "") 
    {
      Console.WriteLine("In constructor taking int.");
    }
    public Motorcycle(string name)
      : this(0, name) 
    {
      Console.WriteLine("In constructor taking string.");
    }
    // Это ведущий конструктор, выполняющий всю работу.
    public Motorcycle(int intensity, string name)
    {
      Console.WriteLine("In master constructor.");
      if (intensity > 10)
      {
        intensity = 10;
      }
      driverIntensity = intensity;
      driverName = name;
    }

    private void SetIntensity(int intensity)
    {
      if (intensity > 10)
      {
        intensity = 10;
      }
    }
    public void SetDriverName(string name)
    {
      driverName = name;
    }
    public void PopAWheely()
    {
      for (int i = 0; i < driverIntensity; i++)
      {
        Console.WriteLine("Yeeee Haeeewww!");
      }
    }
  }
}
