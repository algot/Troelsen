using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StringIndexer
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("*****  with indexers *****\n");
			var myPeople = new PeopleCollection();
			myPeople["Homer"] = new Person(40, "Homer", "Simpson");
			myPeople["Marge"] = new Person(38, "Marge", "Simpson");

			// Получить Homer и вывести на консоль
			var homer = myPeople["Homer"];
			Console.WriteLine(homer.ToString());
		}
	}
}
