using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_StreamWriterReaderApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with StreamWriter / StreamReader *****\n");

      // Получить StreamWriter и записать строковые данные
      using (StreamWriter writer = File.CreateText("reminders.txt"))
      {
        writer.WriteLine("Don't forget Mother's Day this year...");
        writer.WriteLine("Don't forget Father's Day this year...");
        writer.WriteLine("Don't forget these numbers:");
        for (int i = 0; i < 10; i++)
        {
          writer.Write(i + " ");
        }

        // Вставить новую строку
        writer.Write(writer.NewLine);
      }

      Console.WriteLine("Created file and wrote some thoughts...");
      
      // Прочитать данные из файла
      Console.WriteLine("Here are your thought:\n");
      using (StreamReader sr = File.OpenText("reminders.txt"))
      {
        string input = null;
        while ((input = sr.ReadLine()) != null)
        {
          Console.WriteLine(input);
        }
      }
    }
  }
}
