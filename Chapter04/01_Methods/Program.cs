using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
  public static int Add(int x, int y)
  {
    int ans = x + y;

    x = 10000;
    y = 88888;
    return ans;
  }
  public static void Add(int x, int y, out int ans)
  {
    ans = x + y;
  }
  public static void FillTheseVals(out int a, out string b, out bool c)
  {
    a = 9;
    b = "Enjoy your string.";
    c = true;
  }
  public static void SwapStrings(ref string s1, ref string s2)
  {
    string tempString = s1;
    s1 = s2;
    s2 = tempString;
  }

  static double CalculateAverage(params double[] values)
  {
    // Вывод количества значений
    Console.WriteLine("You sent me {0} doubles.", values.Length);
    double sum = 0;
    if (values.Length == 0)
    {
      return sum;
    }
    for (int i = 0; i < values.Length; i++)
    {
      sum += values[i];
    }
    return (sum / values.Length);
  }

  static void DisplayFancyMessage(ConsoleColor textColor = ConsoleColor.Blue, ConsoleColor backgroundColor = ConsoleColor.White, string message = "Test Message")
  {
    // Сохранение старых цветов, для восстановления их потом
    ConsoleColor oldTextColor = Console.ForegroundColor;
    ConsoleColor oldBackgroundColor = Console.BackgroundColor;

    // Установка новых цветов и вывод сообщения
    Console.ForegroundColor = textColor;
    Console.BackgroundColor = backgroundColor;

    Console.WriteLine(message);

    // Восстановление предыдущих цветов
    Console.ForegroundColor = oldTextColor;
    Console.BackgroundColor = oldBackgroundColor;
  }

  static void Main()
  {
    Console.WriteLine("***** Fun with Methods *****\n");
    // Передача двух переменных по значению
    int x = 10, y = 9;
    Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);   // до вызова
    Console.WriteLine("Answer is: {0}", Add(x, y));           // ответ
    Console.WriteLine("After call: X: {0}, Y: {1}", x, y);    // после вызова
    Console.WriteLine();

    int ans;
    Add(90, 90, out ans);
    Console.WriteLine("90 + 90 = {0}", ans);
    Console.WriteLine();

    int i;
    string str;
    bool b;

    FillTheseVals(out i, out str, out b);
    Console.WriteLine("int is: {0}", i);
    Console.WriteLine("string is: {0}", str);
    Console.WriteLine("bool is: {0}", b);
    Console.WriteLine();

    string s1 = "Flip";
    string s2 = "Flop";
    Console.WriteLine("Before: {0}, {1}", s1, s2);
    SwapStrings(ref s1, ref s2);
    Console.WriteLine("After: {0}, {1}", s1, s2);
    Console.WriteLine();

    // Передача списка значений, разделенного запятыми
    double average;
    average = CalculateAverage(4.0, 15.0, 66.0, 1.25, 4.02356);
    Console.WriteLine("Average of data is: {0}", average);

    // Передача массива значений
    double[] data = { 4.0, 15.0, 66.0, 1.25, 4.02356 };
    average = CalculateAverage(data);
    Console.WriteLine("Average of data is: {0}", average);

    // Среднее из 0 равно 0
    Console.WriteLine("Average of data is: {0}", CalculateAverage());
    Console.WriteLine();

    // Работа с именованными аргументами
    DisplayFancyMessage(message: "WOW! Very fancy indeed!", textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);
    DisplayFancyMessage(backgroundColor: ConsoleColor.Green, message: "Testing...", textColor: ConsoleColor.DarkBlue);
    Console.WriteLine();

    DisplayFancyMessage(message: "Hello");
    DisplayFancyMessage(backgroundColor: ConsoleColor.Green);
  }
}