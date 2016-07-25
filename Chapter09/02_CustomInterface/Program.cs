using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_CustomInterface
{
	class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with the Interfaces *****\n");

			// DВызов свойства Points, определенного в IPointy
			Hexagon hex = new Hexagon();
			Console.WriteLine("Points: {0}", hex.Points); // вывод числа вершин

			// Перехват возможного исключения InvalidCastException.
			Circle c = new Circle("Lisa");
			IPointy itfPt = null;
			try
			{
				itfPt = (IPointy)c;
				Console.WriteLine(itfPt.Points);
			}
			catch (InvalidCastException e)
			{
				Console.WriteLine(e.Message);
			}

			// Можно ли интерпретировать hex2 как IPointy?
			Hexagon hex2 = new Hexagon("Peter");
			IPointy itfPt2 = hex2 as IPointy;
			if (itfPt2 != null)
			{
				// Вывод числа вершин
				Console.WriteLine("Points: {0}", itfPt2.Points);
			}
			else
			{
				// Это не интерфейс IPointy
				Console.WriteLine("OOPS! Not pointy...");
			}

			// Создание массива типов Shape
			Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("Jojo") };

			for (int i = 0; i < myShapes.Length; i++)
			{
				myShapes[i].Draw();

				// У каких фигур есть вершины?
				if (myShapes[i] is IPointy)
				{
					// Вывод числа вершин
					Console.WriteLine("-> Points: {0}", ((IPointy)myShapes[i]).Points);
				}
				else
				{
					// Это не интерфейс IPointy
					Console.WriteLine("-> {0}\'s not pointy!", myShapes[i].PetName);
				}
				Console.WriteLine();

				// Можно ли нарисовать фигуру в 3 мерном формате?
				if (myShapes[i] is IDraw3D)
				{
					DrawIn3D((IDraw3D)myShapes[i]);
				}
			}

			// Получить первый элемент, имеющий вершины
			IPointy firstIPointyItem = FindFirstPointyShape(myShapes);
			Console.WriteLine("The item has {0} points", firstIPointyItem.Points);

		}

		// Будет рисовать любую фигуру, поддерживающую IDraw3D
		static void DrawIn3D(IDraw3D itf3D)
		{
			Console.WriteLine("-> Drawing IDraw3D compatible type");
			itf3D.Draw3D();
		}

		// Возвращает первый объект в массиве, который реализует IPointy
		private static IPointy FindFirstPointyShape(Shape[] shapes)
		{
			foreach (Shape s in shapes)
			{
				if (s is IPointy)
				{
					return s as IPointy;
				}
			}
			return null;
		}
	}
}