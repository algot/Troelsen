using System;

namespace _03_OverloadedOps
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with overloaded operators *****\n");
			// Создать 2 точки
			Point ptOne = new Point(100, 100);
			Point ptTwo = new Point(40, 40);
			Console.WriteLine("ptOne: {0}", ptOne);
			Console.WriteLine("ptTwo: {0}", ptTwo);

			// Сложить 2 точки
			Console.WriteLine("ptOne + ptTwo: {0}", ptOne + ptTwo);
			// Вычесть одну точку из другой
			Console.WriteLine("ptOne - ptTwo: {0}", ptOne - ptTwo);
			// Вывести точку со сдвигом
			Point ptOffset = ptOne + 10;
			Console.WriteLine("ptOffset: {0}", ptOffset);

			// Перегрузка операторов сокращенного присваивания
			Point ptThree = new Point(90, 5);
			Console.WriteLine("ptThree: {0}", ptThree);
			Console.WriteLine("ptThree += ptTwo: {0}", ptThree += ptTwo);
			Point ptFour = new Point(0, 500);
			Console.WriteLine("ptFour: {0}", ptFour);
			Console.WriteLine("ptFour -= ptThree: {0}", ptFour -= ptThree);

			// Перегрузка унарных операторов
			Point ptFive = new Point(1, 1);
			Console.WriteLine("++ptFive: {0}", ++ptFive);
			Console.WriteLine("--ptFive: {0}", --ptFive);
			Point ptSix = new Point(20, 20);
			Console.WriteLine("ptSix++: {0}", ptSix++);
			Console.WriteLine("ptSix--: {0}", ptSix--);

			// Перегрузка операторов эквивалентности
			Console.WriteLine("ptOne == ptTwo: {0}", ptOne == ptTwo);
			Console.WriteLine("ptOne != ptTwo: {0}", ptOne != ptTwo);

			// Перегрузка операторов сравнения
			Console.WriteLine("ptOne > ptTwo: {0}", ptOne > ptTwo);
			Console.WriteLine("ptOne < ptTwo: {0}", ptOne < ptTwo);
		}
	}
}
