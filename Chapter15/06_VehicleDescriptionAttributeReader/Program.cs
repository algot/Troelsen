using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AttributedCarLibrary;

namespace VehicleDescriptionAttributeReader
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Value of VehicleDescriptionAttribute *****\n");
			ReflectOnAttributesUsingEarlyBindings();
		}

		private static void ReflectOnAttributesUsingEarlyBindings()
		{
			// Получение типа, представляющего Winnebago
			Type t = typeof (Winnebago);
			
			// Получение всех аттрибутов Winnebago
			object[] customAtts = t.GetCustomAttributes(false);

			// Вывод описания
			foreach (VehicleDescriptionAttribute v in customAtts)
			{
				Console.WriteLine("-> {0}\n", v.Description);
			}
		}
	}
}
