using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DynamicKeyword
{
  class Program
  {
    static void Main(string[] args)
    {
      PrintThreeStrings();
      ChangeDynamicDataType();
      InvokeMembersOnDynamicData();
    }

    static void ImplicitlyTypedVariable()
    {
      // Переменная имеет тип List<int>
      var a = new List<int>();
      a.Add(90);

      //a = "Hello";
    }
    static void PrintThreeStrings()
    {
      var s1 = "Greetings";
      object s2 = "From";
      dynamic s3 = "Minneapolis";

      Console.WriteLine("s1 is of type: {0}", s1.GetType());
      Console.WriteLine("s2 is of type: {0}", s2.GetType());
      Console.WriteLine("s3 is of type: {0}", s3.GetType());
      
    }
    static void ChangeDynamicDataType()
    {
      // Объявить одиночный элемент данных dynamic по имени t
      dynamic t = "Hello!";
      Console.WriteLine("t is of type: {0}", t.GetType());

      t = false;
      Console.WriteLine("t is of type: {0}", t.GetType());

      t = new List<int>();
      Console.WriteLine("t is of type: {0}", t.GetType());
    }
    static void InvokeMembersOnDynamicData()
    {
      dynamic textData1 = "Hello";
      Console.WriteLine(textData1.ToUpper());

      Console.WriteLine(textData1.toupper());
      Console.WriteLine(textData1.Foo(10, "ee", DateTime.Now));
    }
  }
}
