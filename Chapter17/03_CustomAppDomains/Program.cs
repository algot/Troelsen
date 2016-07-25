using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CustomAppDomains
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Custom AppDomains *****\n");

      // Вывести все сборки, загруженные в стандартный домен приложения
      AppDomain defaultAD = AppDomain.CurrentDomain;

      defaultAD.ProcessExit += (o, s) =>
      {
        Console.WriteLine("DefaultAD unloaded!");
      };

      ListAllAssembliesInAppDomain(defaultAD);

      MakeNewAppDomain();
    }


    private static void MakeNewAppDomain()
    {
      // Создать новый домен приложения в текущем процессе
      AppDomain newAD = AppDomain.CreateDomain("SecondAppDomain");

      newAD.DomainUnload += (o, s) =>
      {
        Console.WriteLine("The second AppDomain has been unloaded!");
      };

      try
      {
        // Загрузить CarLibrary в этот новый домен
        newAD.Load("02_CarLibrary");
      }
      catch (FileNotFoundException ex)
      {
        Console.WriteLine(ex.Message);
      }

      ListAllAssembliesInAppDomain(newAD);

      AppDomain.Unload(newAD);
    }

    private static void ListAllAssembliesInAppDomain(AppDomain ad)
    {
      // Получить все сборки, загруженные в стандартный домен приложения
      var loadedAssemblies = from a in ad.GetAssemblies() orderby a.GetName().Name select a;

      Console.WriteLine("***** Here are the assemblies loaded in {0} *****\n", ad.FriendlyName);

      foreach (var a in loadedAssemblies)
      {
        Console.WriteLine("-> Name: {0}", a.GetName().Name);
        Console.WriteLine("-> Version: {0}", a.GetName().Version);
      }
    }
  }
}
