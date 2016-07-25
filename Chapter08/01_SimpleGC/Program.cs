using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_SimpleGC
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** GC Basics *****");

      // Вывод подсчитанного количества байтов в куче
      Console.WriteLine("Estimated bytes on heap: {0}", GC.GetTotalMemory(false));
      // Отсчет для MaxGeneration начинается с нуля, поэтому для удобства добавляется единица
      Console.WriteLine("This OS has {0} object generations. \n", (GC.MaxGeneration + 1));

      // Создание нового объекта Car в управляемой куче
      // Возвращается ссылка на этот объект.
      Car refToMyCar = new Car("Zippy", 50);
      Console.WriteLine(refToMyCar.ToString());

      // Вывод информации о поколении объекта refToMyCar.
      Console.WriteLine("Generation of refToMyCar is: {0}", GC.GetGeneration(refToMyCar));

      // Создание большого количества объектов
      object[] tonsOfObjects = new object[50000];
      for (int i = 0; i < 50000; i++)
      {
        tonsOfObjects[i] = new object();
      }

      // Выполнение сборки мусора в отношении объектов только 0 поколения
      GC.Collect(0, GCCollectionMode.Forced);
      GC.WaitForPendingFinalizers();

      // Вывод информации о поколении объекта refToMyCar.
      Console.WriteLine("Generation of refToMyCar is: {0}", GC.GetGeneration(refToMyCar));

      // Проверка, удалось ли уцелеть tonsOfObjects[9000] после сборки мусора.
      if (tonsOfObjects[9000] != null)
      {
        // Вывод поколения tonsOfObjects[9000]
        Console.WriteLine("Generation of tonsOfObjects[9000] is: {0}", GC.GetGeneration(tonsOfObjects[9000]));
      }
      else
      {
        Console.WriteLine("tonsOfObjects[9000] is no longer alive");
      }
    }
  }
}
