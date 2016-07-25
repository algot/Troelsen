using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("*****Fun with Arrays*****");

    SimpleArrays();
    DeclareImplicitArrays();
    ArrayOfObjects();
    RectMultidimensionalArray();
    JaggedMultidimensionalArray();
    PassAndReceiveArrays();
    SystemArrayFunctionality();
  }

  static void SimpleArrays()
  {
    Console.WriteLine("=> Simple Array Creation.");
    // Создание массива с тремя элементами
    int[] myInt = new int[3];
    // Заполнение массива
    myInt[0] = 100;
    myInt[1] = 200;
    myInt[2] = 300;
    // Вывод массива
    foreach (int i in myInt)
    {
      Console.WriteLine(i);
    }

    // Инициализация массива со 100 элементами
    string[] booksOnDotNet = new string[100];
    Console.WriteLine();

    Console.WriteLine("=> Array initialization.");

    // Синтаксис инициализации массива с помощью ключевого слова new
    string[] arrayString = new string[] { "one", "two", "three" };
    Console.WriteLine("String array has {0} elements", arrayString.Length);

    // Синтаксис инициализации массива без ключевого слова new
    bool[] arrayBool = { false, true, false };
    Console.WriteLine("Bool array has {0} elements", arrayBool.Length);

    // Синтаксис инициализации массива с указанием ключевого слова new и желаемого размера массива
    int[] arrayInt = new int[4] { 4, 7, 1, 4 };
    Console.WriteLine("Int array has {0} elements", arrayInt.Length);

    Console.WriteLine();
  }
  static void DeclareImplicitArrays()
  {
    Console.WriteLine("=> Implicit Arrays initialization.");
    // В действительности a - массив типа int[].
    var a = new[] { 1, 10, 100, 1000 };
    Console.WriteLine("a is a: {0}", a.ToString());
    // В действительности b - массив типа double[].
    var b = new[] { 1, 1.5, 2, 2.5 };
    Console.WriteLine("b is a: {0}", b.ToString());
    // В действительности с - массив типа string[].
    var c = new[] { "hello", null, "world" };
    Console.WriteLine("c is a: {0}", c.ToString());
  }
  static void ArrayOfObjects()
  {
    Console.WriteLine("=> Array of Objects.");

    // В массиве могут находиться объекты любого типа.
    object[] arrayObject = new object[4];
    arrayObject[0] = 10;
    arrayObject[1] = false;
    arrayObject[2] = new DateTime(1969, 3, 24);
    arrayObject[3] = "Form & Void";

    foreach (object obj in arrayObject)
    {
      Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
    }
    Console.WriteLine();
  }
  static void RectMultidimensionalArray()
  {
    Console.WriteLine("=> Rectangular multidimensional array");
    // Прямоугольный многомерный массив
    int[,] myMatrix;
    myMatrix = new int[6, 6];
    // Заполнение массива
    for (int i = 0; i < 6; i++)
    {
      for (int j = 0; j < 6; j++)
      {
        myMatrix[i, j] = i * j;
      }
    }
    // Вывод массива
    for (int i = 0; i < 6; i++)
    {
      for (int j = 0; j < 6; j++)
      {
        Console.Write(myMatrix[i, j] + "\t");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
  static void JaggedMultidimensionalArray()
  {
    Console.WriteLine("=> Jagged Multidimensional Array.");
    // Зубчатый многомерный массив.
    int[][] myJagArray = new int[5][];

    // Создание зубчатого массива
    for (int i = 0; i < myJagArray.Length; i++)
    {
      myJagArray[i] = new int[i + 7];
    }
    // Вывод массива
    for (int i = 0; i < 5; i++)
    {
      for (int j = 0; j < myJagArray[i].Length; j++)
      {
        Console.Write(myJagArray[i][j] + " ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }

  static void PrintArray(int[] myInts)
  {
    for (int i = 0; i < myInts.Length; i++)
    {
      Console.WriteLine("Item {0} is {1}", i, myInts[i]);
    }
  }
  static string[] GetStringArray()
  {
    string[] theStrings = { "Hello", "from", "GetStringArray" };
    return theStrings;
  }
  static void PassAndReceiveArrays()
  {
    Console.WriteLine("=> Arrays as params and return values.");
    // Передача массива в качестве параметра.
    int[] ages = { 20, 22, 23, 0 };
    PrintArray(ages);

    // Получение массива в качестве возвращаемого значения.
    string[] strs = GetStringArray();
    foreach (string s in strs)
    {
      Console.WriteLine(s);
    }
    Console.WriteLine();
  }

  static void SystemArrayFunctionality()
  {
    Console.WriteLine("=> Working with System.Array.");
    // Инициализация элементов при запуске.
    string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };
    // Вывод элементов в прямом порядке.
    Console.WriteLine("-> Here is the array:");
    for (int i = 0; i < gothicBands.Length; i++)
    {
      Console.WriteLine(gothicBands[i] + ", ");
    }
    Console.WriteLine("\n");
    // Изменение порядка членов
    Array.Reverse(gothicBands);
    Console.WriteLine("-> The reverse array:");
    // ... и их вывод.
    for (int i = 0; i < gothicBands.Length; i++)
    {
      Console.WriteLine(gothicBands[i] + ", ");
    }
    Console.WriteLine("\n");
    // Удаление всех элементов, кроме одного.
    Console.WriteLine("=> Cleared out all but one...");
    Array.Clear(gothicBands, 1, 2);
    for (int i = 0; i < gothicBands.Length; i++)
    {
      Console.WriteLine(gothicBands[i] + ", ");
    }
    Console.WriteLine();
  }
}