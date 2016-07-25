using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_AnonymousTypes
{
	class Program
	{
	  static void BuildAnonType(string make, string color, int currSp)
	  {
	    // Построить анонимный тип, используя входные аргументы
	    var car = new {Make = make, Color = color, Speed = currSp};

      // Теперь тип можно использовать для получения данных свойств
	    Console.WriteLine("You have a {0} {1} doing {2} MPH",
        car.Color, car.Make, car.Speed);

      // Анонимные типы имеют специальные реализации каждого виртуального метода System.Object
	    Console.WriteLine("ToString() = {0}", car);
	  }

	  private static void Main(string[] args)
	  {
	    Console.WriteLine("***** Fun with Anonymous Types *****\n");

      // Создать анонимный тип, представляющий автомобиль
	    var myCar = new {Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55};

      // Вывести на консоль цвет и производителя
	    Console.WriteLine("My car is a {0} {1}.", myCar.Color, myCar.Make);

      BuildAnonType("BMW", "Black", 90);

      ReflectOverAnonymousType(myCar);
	  }

	  static void ReflectOverAnonymousType(object obj)
	  {
	    Console.WriteLine("obj is an instance of: {0}", obj.GetType().Name);
	    Console.WriteLine("Base class of {0} is {1}",
	      obj.GetType().Name,
	      obj.GetType().BaseType);

	    Console.WriteLine("obj.ToString() == {0}", obj.ToString());
	    Console.WriteLine("obj.GetHashCode() == {0}", obj.GetHashCode());
	    Console.WriteLine();
	  }
	}
}
