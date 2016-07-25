using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomNamespace
{
	public class Program
	{
		private static void Main(string[] args)
		{
			MyShapes.Hexagon h = new MyShapes.Hexagon();
			MyShapes.Circle c = new MyShapes.Circle();
			MyShapes.Square s = new MyShapes.Square();
		}
	}

}