using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_FileStreamApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with FileStreams *****\n");

      // Получить объект FileStreams
      using (FileStream fStream = File.Open(@".\myMessage.dat", FileMode.Create))
      {
        // Закодировать строку в виде массива байт
        string msg = "Hello!";
        byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);
        // Записать массив в файл
        fStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);
        // Сбросить внутреннюю позицию потока
        fStream.Position = 0;
        // Прочитать типы из файла и вывести на консоль
        Console.Write("Your message as an array of bytes: ");
        byte[] bytesFromFile = new byte[msgAsByteArray.Length];
        for (int i = 0; i < msgAsByteArray.Length; i++)
        {
          bytesFromFile[i] = (byte) fStream.ReadByte();
          Console.Write(bytesFromFile[i]);
        }

        // Вывести декодированные сообщения
        Console.Write("\nDecoded Message: ");
        Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
      }
    }
  }
}
