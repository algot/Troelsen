using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BinaryWriterReader
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Binary Writers / Readers *****\n");

      // Открыть средство двоичной записи в файл
      FileInfo f = new FileInfo("BinFile.dat");

      using (BinaryWriter bw = new BinaryWriter(f.OpenWrite()))
      {
        // Вывести на консоль тип BaseStream
        // (System.IO.FileStream в данном случае)
        Console.WriteLine("BaseStream is: {0}", bw.BaseStream);

        // Создать некоторіе данніе для сохранения в файле
        double aDouble = 1234.67;
        int anInt = 34567;
        string aString = "A, B, C";

        // Записать данные
        bw.Write(aDouble);
        bw.Write(anInt);
        bw.Write(aString);
      }

      Console.WriteLine("Done!");

      // Читать двоичные данные из потока
      using (BinaryReader br = new BinaryReader(f.OpenRead()))
      {
        Console.WriteLine(br.ReadDouble());
        Console.WriteLine(br.ReadInt32());
        Console.WriteLine(br.ReadString());
      }
    }
  }
}
