using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;

namespace CSharpCarClient
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** C# Car Library Client App*****\n");
			// Создание спортивного автомобиля
			SportsCar viper = new SportsCar("Viper", 240, 40);
			viper.TurboBoost();
			// Создание минивена
			MiniVan mv = new MiniVan();
			mv.TurboBoost();
		}
	}
}
