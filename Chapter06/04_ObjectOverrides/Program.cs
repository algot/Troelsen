using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_ObjectOverrides
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with System.Object *****\n");

      Person p1 = new Person("Homer", "Simpson", 50);
      Person p2 = new Person("Homer", "Simpson", 50);
      // Получить строковые версии объектов
      Console.WriteLine("p1.ToString() = {0}", p1.ToString());
      Console.WriteLine("p2.ToString() = {0}", p2.ToString());
      // Проверить переопределенный метод Equals
      Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));
      // Проверить хеш-коды
      Console.WriteLine("Same hash-codes?: {0}", p1.GetHashCode() == p2.GetHashCode());
      Console.WriteLine();
      // Изменить возраст p2 и проверить снова.
      p2.Age = 45;
      Console.WriteLine("p1.ToString() = {0}", p1.ToString());
      Console.WriteLine("p2.ToString() = {0}", p2.ToString());
      Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));
      Console.WriteLine("Same hash-codes?: {0}", p1.GetHashCode() == p2.GetHashCode());
      Console.WriteLine();
    }
  }
}
