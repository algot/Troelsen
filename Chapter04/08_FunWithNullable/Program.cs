using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DatabaseReader
{
  // Нулевые поля данных.
  public int? numericValue = null;
  public bool? boolValue = true;

  public int? GetIntFromDatabase()
  {
    return numericValue;
  }
  public bool? GetBoolFromDatabase()
  {
    return boolValue;
  }
}
class Program
{
  static void LocalNullableVariables()
  {
    // Определение локальных переменных с нулевыми типами.
    int? nullableInt = 10;
    double? nullableDouble = 3.14;
    bool? nullableBool = null;
    char? nullableChar = 'a';
    int?[] arrayOfNullableInts = new int?[10];
  }
  //static void LocalNullableVariablesUsingNullable()
  //{
  //  // Определение нескольких nullable типов за счет использования Nullable<T>.
  //  Nullable<int> nullableInt = 10;
  //  Nullable<double> nullableDouble = 3.14;
  //  Nullable<bool> nullableBool = null;
  //  Nullable<char> nullableChar = 'a';
  //  Nullable<int>[] arrayOfNullableInts = new int?[10];
  //}

  static void Main(string[] args)
  {
    Console.WriteLine("***** Fun with Nullable Data *****\n");
    DatabaseReader dr = new DatabaseReader();

    // Получение значения int из базы данных
    int? i = dr.GetIntFromDatabase();
    if (i.HasValue)
    {
      Console.WriteLine("Value of i is: {0}", i.Value);
    }
    else
    {
      // значение i не определено.
      Console.WriteLine("Value of i undefined.");
    }
    // Получение значения bool из базы данных
    bool? b = dr.GetBoolFromDatabase();
    if (b != null)
    {
      Console.WriteLine("Value of b is: {0}", b.Value);
    }
    else
    {
      Console.WriteLine("Value of b is undefined.");
    }
    // В случае возврата GetIntFromDatabase()
    // значения null локальной переменной должно
    // присваиваться значение 100.
    int myData = dr.GetIntFromDatabase() ?? 100;
    Console.WriteLine("Value of myData is {0}", myData);
  }
}
