using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CarDelegate
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Delegates as event enablers *****\n");

      // Создаем объект Car
      var c1 = new Car("SlugBug", 100, 10);

      // Зарегистрировать несколько обработчиков событий
      c1.RegisterWithCarEngine(new Car.CarEngineHandlerDelegate(OnCarEngineEvent));

      Car.CarEngineHandlerDelegate hanler2 = new Car.CarEngineHandlerDelegate(OnCarEngineEvent2);
      c1.RegisterWithCarEngine(hanler2);

      // Ускорим, это инициирует события
      Console.WriteLine("***** Speeding up *****");
      for (int i = 0; i < 6; i++)
        c1.Accelerate(20);

      // Отменим регистрацию второго обработчика
      c1.UnRegisterWithCarEngine(hanler2);

      // Сообщения в верхнем регистре больше не выводятся
      Console.WriteLine("***** Speeding up *****");
      for (int i = 0; i < 6; i++)
        c1.Accelerate(20);

    }
    // Цель для входящих сообщений
    public static void OnCarEngineEvent(string msg)
    {
      Console.WriteLine("\n***** Message from Car Object");
      Console.WriteLine("=> {0}", msg);
      Console.WriteLine("*****************************\n");
    }

    public static void OnCarEngineEvent2(string msg)
    {
      Console.WriteLine("=> {0}", msg.ToUpper());
    }
  }
}
