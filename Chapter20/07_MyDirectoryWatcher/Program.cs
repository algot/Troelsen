using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_MyDirectoryWatcher
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** The amazing file watcher app *****\n");

      // Установить путь к каталогу
      FileSystemWatcher watcher = new FileSystemWatcher();
      try
      {
        watcher.Path = @"C:\Users\algot\MyFolder";
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine(ex.Message);
        return;
      }

      // Указать цели наблюдения
      watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite |
                             NotifyFilters.FileName | NotifyFilters.DirectoryName;
      // Следить только за текстовыми файлами
      watcher.Filter = "*.txt";

      // Добавить обработчики событий
      watcher.Changed += new FileSystemEventHandler(OnChanged);
      watcher.Created += new FileSystemEventHandler(OnChanged);
      watcher.Deleted += new FileSystemEventHandler(OnChanged);
      watcher.Renamed += new RenamedEventHandler(OnRenamed);

      // Начать наблюдение
      watcher.EnableRaisingEvents = true;

      // Ожидать команды пользователя на закрытие программы
      Console.WriteLine(@"Press 'q' to quit...");
      while (Console.Read() != 'q') { }
    }

    private static void OnChanged(object source, FileSystemEventArgs e)
    {
      // Показать, что сделано, если файл изменен, создан или удален
      Console.WriteLine("File: {0} {1}!", e.FullPath, e.ChangeType);
    }

    private static void OnRenamed(object source, RenamedEventArgs e)
    {
      // Показать, что файл был переименован
      Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
    }
  }
}