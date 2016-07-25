using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_AnonymousMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Anonimous methods *****\n");
			var c1 = new Car("SlugBug", 100, 10);

			// Зарегистрировать обработчики событий в виде анонимных методов
			c1.AboutToBlow += delegate{
				Console.WriteLine("Eek! Going too fast!");
			};
			c1.AboutToBlow += delegate(object sender, CarEventArgs e){
				Console.WriteLine("Message from car: {0}", e.msg);
			};

			c1.Exploded += delegate(object sender, CarEventArgs e){
				Console.WriteLine("Fatal message from car: {0}", e.msg);
			};

			// Инициализация событий
			for (var i = 0; i < 6; i++)
				c1.Accelerate(20);
		}
	}
}
