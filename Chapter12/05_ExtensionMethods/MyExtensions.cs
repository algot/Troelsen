using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _05_ExtensionMethods
{
	static class MyExtensions
	{
		// Этот метод позволяет любому объекту отобразить
    // сборку, в которой он определен
	  public static void DisplayDefiningAssembly(this Object obj)
	  {
	    Console.WriteLine("{0} lives here: => {1}\n", obj.GetType().Name,
	      Assembly.GetAssembly(obj.GetType()).GetName().Name);
	  }

    // Этот метод позволяет любому целому числу изменить порядок следования
    // десятичных цифр на обратный.
	  public static int ReverseDigits(this int i)
	  {
	    // Транслировать int в string, а затем получить все его символы
	    char[] digits = i.ToString().ToCharArray();

      // Перевернуть массив
      Array.Reverse(digits);

      // Вставить обратно в строку
	    string newDigits = new string(digits);

      // Вернуть строку как int
	    return int.Parse(newDigits);
	  }
	}
}
