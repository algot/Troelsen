using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_DelegateCovariance
{
  class Program
  {
    // Определение типа делегата, указывающего на методы,
    // которые возвращают объект Car.
    public delegate Car ObtainVehicleDelegate();

    public static Car GetBasicCar()
    { return new Car(); }
    public static SportsCar GetSportsCar()
    { return new SportsCar(); }

    static void Main(string[] args)
    {
      Console.WriteLine("***** Delegate Covariance *****\n");
      ObtainVehicleDelegate targetA = new ObtainVehicleDelegate(GetBasicCar);
      Car c = targetA();
      Console.WriteLine("Obtained a {0}", c);
      // Ковариантность позволяет присваивать цели
      ObtainVehicleDelegate targetB = new ObtainVehicleDelegate(GetSportsCar);
      SportsCar sc = (SportsCar)targetB();
      Console.WriteLine("Obtained a {0}", sc);
    }
  }
}
