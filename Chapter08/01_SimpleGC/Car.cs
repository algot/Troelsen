using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_SimpleGC
{
  class Car
  {
    public int CurrentSpeed { get; set; }
    public string PetName { get; set; }

    public Car() { }
    public Car(string name, int speed)
    {
      PetName = name;
      CurrentSpeed = speed;
    }
    public override string ToString()
    {
      return string.Format("{0} is doing {1} MPH", PetName, CurrentSpeed);
    }
  }
}
