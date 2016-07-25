using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_ICloneableExample
{
	static class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** A first look at the Interfaces *****\n");

			// Все эти классы поддерживают интерфейс ICloneable
			string myString = "Hello";
			OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
			System.Data.SqlClient.SqlConnection sqlCnn = new System.Data.SqlClient.SqlConnection();

			// Поэтому все они могут передаваться методу, принимающему ICloneable в качестве параметра
			CloneMe(myString);
			CloneMe(unixOS);
			CloneMe(sqlCnn);
		}

		private static void CloneMe(ICloneable c)
		{
			// Клонируем любой получаемый тип и выводим его имя в консоли
			object theClone = c.Clone();
			Console.WriteLine("Your clone is a: {0}", theClone.GetType().Name);
		}
	}
}
