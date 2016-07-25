using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CarDelegateMethodGroupConversion
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Method Group Conversion *****\n");
      var c1 = new Car();

      // Зарегистрировать простое имя метода
      c1.RegisterWithCarEngine(CallMeHere);

      Console.WriteLine("***** Speeding up *****");
      for (int i = 0; i < 6; i++)
        c1.Accelerate(20);

      // Отменить регистрацию простого имени метода
      c1.UnRegisterWithCarEngine(CallMeHere);

      // Теперь сообщения не поступают
      for (int i = 0; i < 6; i++)
        c1.Accelerate(20);
    }

    static void CallMeHere(string msg)
    {
      Console.WriteLine("=> Message from Car: {0}", msg);
    }
  }
}
