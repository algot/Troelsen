using System;
using System.Reflection;

namespace VehicleDescriptionAttributeReaderLateBinding
{
  internal static class Program
  {
    private static void Main()
    {
      Console.WriteLine("***** Value of VehicleDescriptionAttribute. *****\n");
      ReflectAttributesUsingLateBinding();
    }

    private static void ReflectAttributesUsingLateBinding()
    {
      try
      {
        // Загрузка локальной копии сборки AttributedCarLibrary
        Assembly asm = Assembly.Load("05_AttributedCarLibrary");

        // Получение информации о типе VehicleDescriptionAttribute
        Type vehicleDescription = asm.GetType("AttributedCarLibrary.VehicleDescriptionAttribute");

        // Получение информации о типе Description
        PropertyInfo propDesc = vehicleDescription.GetProperty("Description");

        // Получение всех типов из сборки
        Type[] types = asm.GetTypes();

        // Проход по типам с получением аттрибутов VehicleDescriptionAttribute
        foreach (Type type in types)
        {
          object[] objs = type.GetCustomAttributes(vehicleDescription, false);


          // Проход по аттрибутам VehicleDescriptionAttribute и 
          // вывод описаний с использованием позднего связывания
          foreach (object o in objs)
          {
            Console.WriteLine("-> {0}: {1}\n", type.Name, propDesc.GetValue(o, null));
          }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}