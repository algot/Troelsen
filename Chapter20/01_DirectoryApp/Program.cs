using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DirectoryApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Directory(Info) *****\n");
      ShowWindowsDirectoryInfo();
      DisplayImageFiles();
      FunWithDirectoryType();
    }

    private static void ShowWindowsDirectoryInfo()
    {
      DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");
      Console.WriteLine("***** Directory info *****");
      Console.WriteLine("FullName: {0}", dir.FullName);
      Console.WriteLine("Name: {0}", dir.Name);
      Console.WriteLine("Parent: {0}", dir.Parent);
      Console.WriteLine("Creation: {0}", dir.CreationTime);
      Console.WriteLine("Attributes: {0}", dir.Attributes);
      Console.WriteLine("Root: {0}", dir.Root);
      Console.WriteLine("******************\n");
    }
    private static void DisplayImageFiles()
    {
      DirectoryInfo dir = new DirectoryInfo(@"C:\Windows\Web\Wallpaper");

      // Получить все jpeg
      FileInfo[] imageFiles = dir.GetFiles("*.jpg", SearchOption.AllDirectories);

      // Сколько файлов найдено?
      Console.WriteLine("Found {0} *.jpg files\n", imageFiles.Length);

      // Вывести информацию о каждом файле
      foreach (FileInfo fileInfo in imageFiles)
      {
        Console.WriteLine("***************");
        Console.WriteLine("File name: {0}", fileInfo.Name);
        Console.WriteLine("File size: {0}", fileInfo.Length);
        Console.WriteLine("Creation: {0}", fileInfo.CreationTime);
        Console.WriteLine("Attributes: {0}", fileInfo.Attributes);
        Console.WriteLine("**************\n");
      }
    }

    private static void FunWithDirectoryType()
    {
      // Вывести список всех дисковых устройст
      string[] drives = Directory.GetLogicalDrives();
      Console.WriteLine("Here are your drives:");
      foreach (var s in drives)
      {
        Console.WriteLine("--> {0}", s);
      }
    }
  }
}
