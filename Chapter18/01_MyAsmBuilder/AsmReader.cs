using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_MyAsmBuilder
{
  public class AsmReader
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** The Amazing Dynamic Assembly Builder App *****");

      // Получить домен приложения для текущего потока
      AppDomain currAppDomain = Thread.GetDomain();

      // Создать динамическую сборку с помощью нашего вспомогательного метода
      Program.CreateMyAsm(currAppDomain);
      Console.WriteLine("-> Finished creating MyAssembly.dll.");

      // Загрузить новую сборку из файла
      Console.WriteLine("-> Loading MyAssembly.dll from file.");
      Assembly a = Assembly.Load("MyAssembly");

      // Получить тип HelloWorld
      Type hello = a.GetType("MyAssembly.HelloWorld");

      // Создать объект HelloWorld и вызввать корректный коструктор
      Console.WriteLine("-> Enter message to pass HelloWorld class: ");
      string msg = Console.ReadLine();
      object [] ctorArgs = new object[1];
      ctorArgs[0] = msg;
      object obj = Activator.CreateInstance(hello, ctorArgs);

      // Вызвать SayHello и отобразить возвращенную строку
      Console.WriteLine("-> Calling SayHello() via late binding.");
      MethodInfo mi = hello.GetMethod("SayHello");
      mi.Invoke(obj, null);

      // Вызвать метод
      mi = hello.GetMethod("GetMsg");
      Console.WriteLine(mi.Invoke(obj, null));
    }
  }
}
