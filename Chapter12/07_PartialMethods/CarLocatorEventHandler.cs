using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_PartialMethods
{
	partial class CarLocator
	{
		//public bool CarAvailableInZipCode(string zipCode)
		//{
		//	OnZipCodeLookup(zipCode);
		//	return true;
		//}
		// Обработчик легковесного события
		partial void OnZipCodeLookup(string make);
	}
}
