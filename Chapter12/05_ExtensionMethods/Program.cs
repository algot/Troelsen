using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _05_ExtensionMethods
{
	class Program
	{
		static void Main(string[] args)
		{
		  Console.WriteLine("**** Fun with Extension Methods ****\n");

      // В int воявилась новая идентичность
		  int myInt = 12345678;
      myInt.DisplayDefiningAssembly();

      // То же и у DataSet
      DataSet d = new DataSet();
      d.DisplayDefiningAssembly();

      // Использовать новую функциональность int
		  Console.WriteLine("Value of myInt: {0}", myInt);
		  Console.WriteLine("Reverse digits of myInt: {0}", myInt.ReverseDigits());
		}
	}
}
