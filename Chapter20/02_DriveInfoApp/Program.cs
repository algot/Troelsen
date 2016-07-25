using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DriveInfoApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with DeiveInfo *****\n");
      // Получить информацию обо всех устройствах
      DriveInfo[] myDrives = DriveInfo.GetDrives();
      // Вывести сведения об устройствах
      foreach (DriveInfo d in myDrives)
      {
        Console.WriteLine("Name: {0}", d.Name);
        Console.WriteLine("Type: {0}", d.DriveType);

        // Проверить, смонтировано ли устройство
        if (d.IsReady)
        {
          Console.WriteLine("Free space: {0}", d.TotalFreeSpace);
          Console.WriteLine("Format: {0}", d.DriveFormat);
          Console.WriteLine("Label: {0}", d.VolumeLabel);
        }
        Console.WriteLine();
      }
    }
  }
}
