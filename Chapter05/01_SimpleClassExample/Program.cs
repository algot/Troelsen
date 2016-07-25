using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_SimpleClassExample
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Class Types *****\n");
      // Разместить в памяти и сконфигурировать объект Car.
      Car myCar = new Car();
      myCar.petName = "Trinaha";
      myCar.currSpeed = 10;
      // Повысить скорость автомобиля несколько раз и вывести новое значение.
      for (int i = 0; i < 10; i++)
      {
        myCar.SpeedUp(5);
        myCar.PrintState();
      }
      // Вызов конструктора по умолчанию.
      Car chuck = new Car();
      chuck.PrintState();
      Car mary = new Car("Mary");
      mary.PrintState();
      Car daisy = new Car("Daisy", 30);
      daisy.PrintState();

      Motorcycle c = new Motorcycle(5);
      c.SetDriverName("Tiny");
      c.PopAWheely();
      Console.WriteLine("Rider name is {0}.", c.driverName);

      Car viper = new Car();
      viper.TurnOnRadio(false);
    }
  }
}
