using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_DelegateCovariance
{
  class Program
  {
    // public delegate Car ObtainCarDelegate();
    // public delegate SportsCar ObtainSportsCarDelegate();
    public delegate Car ObtainVehicleDelegate();

    static void Main(string[] args)
    {
      Console.WriteLine("***** Delegate Covariance *****\n");
      ObtainVehicleDelegate targetA = new ObtainVehicleDelegate(GetBasicCar);
      ObtainVehicleDelegate targetB = new ObtainVehicleDelegate(GetSportsCar);

      Car c = targetA();
      SportsCar sc = (SportsCar)targetB();
      Console.WriteLine("Obtained a {0}", c);
      Console.WriteLine("Obtained a {0}", sc);
    }

    public static Car GetBasicCar()
    {
      return new Car("Zippy", 100, 55);
    }
    public static SportsCar GetSportsCar()
    {
      return new SportsCar();
    }
  }
}
