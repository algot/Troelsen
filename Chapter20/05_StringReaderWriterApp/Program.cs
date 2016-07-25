using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_StringReaderWriterApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with StringWriter / StringReader *****\n");
      // Созать StringWriter и записать символьные данные в память
      using (StringWriter strWriter = new StringWriter())
      {
        strWriter.WriteLine("Don't forget Mother's Day this year...");
        // Получить копию содержимого, хранящегося в строке и вывести на консоль
        Console.WriteLine("Contents of StringWriter:\n{0}", strWriter);

        // Получить внутренний StringBuilder
        StringBuilder sb = strWriter.GetStringBuilder();
        sb.Insert(0, "Hey!! ");
        Console.WriteLine("-> {0}", sb);
        sb.Remove(0, "Hey!! ".Length);
        Console.WriteLine("-> {0}", sb);
      }
    }
  }
}