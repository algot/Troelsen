using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_PartialMethods
{
	partial class CarLocator
	{
		// Этот член всегда будет частью класса CarLocator
		public bool CarAvailableInZipCode(string zipCode)
		{
			// Этот вызов может быть частью реализации данного метода
			VerifyDuplicates(zipCode);
			// Некоторая логика взаимодействия с базой данных
			return true;
		}
		// Этот член может быть частью класса CarLocator
		partial void VerifyDuplicates(string make);
	}
}
