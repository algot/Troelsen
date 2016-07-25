using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_InterfaceNameClash
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with Interface Name Clashes *****\n");
			// Во всех случаях вызывается один и тот же метод Draw()
			Octagon oct = new Octagon();

			((IDrawToForm)oct).Draw();
			((IDrawToPrinter) oct).Draw();
			((IDrawToMemory) oct).Draw();
		}
	}
}
