using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.CSharp.RuntimeBinder;

namespace _02_LateBindingWithDynamic
{
  class Program
  {
    static void Main(string[] args)
    {
      AddWithReflection();
      AddWithDynamic();
    }

    private static void AddWithReflection()
    {
      Assembly asm = Assembly.Load("MathLibrary");

      try
      {
        // Получить метаданные типа SimpleMath
        Type math = asm.GetType("MathLibrary.SimpleMath");

        // Создать объект SimpleMath на лету
        object obj = Activator.CreateInstance(math);

        // Получить информацию по методу Add
        MethodInfo mi = math.GetMethod("Add");

        // Вызвать метод с параметрами
        object[] args = { 10, 70 };
        Console.WriteLine("Result is: {0}", mi.Invoke(obj, args));
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    private static void AddWithDynamic()
    {
      Assembly asm = Assembly.Load("MathLibrary");

      try
      {
        // Получить метаданные для типа SimpleMath
        Type math = asm.GetType("MathLibrary.SimpleMath");

        // Создать объект SimpleMath на лету и вызвать метод
        dynamic obj = Activator.CreateInstance(math);
        Console.WriteLine("Result is: {0}", obj.Add(10, 70));
      }
      catch (RuntimeBinderException ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
