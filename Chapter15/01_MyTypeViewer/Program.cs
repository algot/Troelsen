using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.InteropServices;

namespace _01_MyTypeViewer
{
  class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("***** Welcome to my Type Viewer *****\n");
      string typeName = "";

      do
      {
        Console.WriteLine("\nEnter a type name to evaluate");
        Console.WriteLine("or enter Q to quit: ");
        // Получение имени типа
        typeName = Console.ReadLine();

        // Пользователь желает выйти?
        if (typeName.ToUpper() == "Q")
        {
          break;
        }
        // Отобразить информацию о типе
        try
        {
          Type t = Type.GetType(typeName);
          Console.WriteLine("");
          ListVariousStats(t);
          ListFields(t);
          ListProperties(t);
          ListMethods(t);
          ListInterfaces(t);
        }
        catch
        {
          Console.WriteLine("Sorry, can't find type");
        }
      } while (true);
    }

    // Отображение имен методов типа
    static void ListMethods(Type t)
    {
      Console.WriteLine("***** Methods *****");
      MethodInfo[] mi = t.GetMethods();
      foreach (MethodInfo info in mi)
      {
        // Получение информации о возвращаемом типе
        string retVal = info.ReturnType.FullName;
        string paramInfo = "( ";
        
        // Получение информации о принимаемых параметрах
        foreach (ParameterInfo parameterInfo in info.GetParameters())
        {
          paramInfo += string.Format("{0} {1} ", retVal, parameterInfo.Name);
        }
        paramInfo += " )";
        // Отображение базовой сигнатуры метода
        Console.WriteLine("->{0} {1} {2}", retVal, info.Name, paramInfo);
      }
      Console.WriteLine();
    }

    // Отображение имен полей типа
    static void ListFields(Type t)
    {
      Console.WriteLine("***** Fields *****");
      var fieldNames = from fieldInfo in t.GetFields() select fieldInfo.Name;
      foreach (var name in fieldNames)
      {
        Console.WriteLine("->{0}", name);
      }
    }

    // Отображение имен свойств типа
    static void ListProperties(Type t)
    {
      Console.WriteLine("***** Properties *****");
      var propNames = from propertyInfo in t.GetProperties() select propertyInfo.Name;

      foreach (var name in propNames)
      {
        Console.WriteLine("->{0}", name);
      }
    }

    // Отображение имен реализуемых типом интерфейсов
    static void ListInterfaces(Type t)
    {
      Console.WriteLine("***** Interfaces *****");
      var ifaces = from i in t.GetInterfaces() select i;

      foreach (Type i in ifaces)
      {
        Console.WriteLine("->{0}", i.Name);
      }
    }

    static void ListVariousStats(Type t)
    {
      Console.WriteLine("***** Various Statistics *****");
      Console.WriteLine("Base class is: {0}", t.BaseType);
      Console.WriteLine("Is type abstract? {0}", t.IsAbstract);
      Console.WriteLine("Is type sealed? {0}", t.IsSealed);
      Console.WriteLine("Is type generic? {0}", t.IsGenericType);
      Console.WriteLine("Is type a class type? {0}", t.IsClass);
      Console.WriteLine();
    }
  }
}