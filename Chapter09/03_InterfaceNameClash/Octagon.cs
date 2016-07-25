using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_InterfaceNameClash
{
	class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
	{
		// Явно привязать реализацию метода к интерфейсам
		void IDrawToForm.Draw()
		{
			Console.WriteLine("Drawing to form...");
		}

		void IDrawToMemory.Draw()
		{
			Console.WriteLine("Drawing to memory...");
		}

		void IDrawToPrinter.Draw()
		{
			Console.WriteLine("Drawing to printer...");
		}
	}
}
