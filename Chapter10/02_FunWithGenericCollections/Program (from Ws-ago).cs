using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_FunWithGenericCollections
{
  class Program
  {
    private static void UseGenericList()
    {
      // Создать список объектов Person и  заполнить его с помощью
      // синтаксиса инициализации объектов/коллекций.
      var people = new List<Person>()
      {
        new Person {Age=40, FirstName = "Homer", LastName= "Simpson"},
        new Person {Age=38, FirstName = "Marge", LastName="Simpson"},
        new Person {Age=9, FirstName ="Lisa", LastName= "Simpson"},
        new Person {Age=7, FirstName="Bart", LastName= "Simpson"}
      };
      // Вывести на консоль количество элементов в списке
      Console.WriteLine("Items in list: {0}", people.Count);
      // Перечислить список.
      foreach (Person p in people)
      {
        Console.WriteLine(p);
      }
      // Вставить новую персону
      Console.WriteLine("\n->Inserting new person.");
      people.Insert(2, (new Person(2, "Maggie", "Simpson")));

      // Вывести на консоль количество элементов в списке
      Console.WriteLine("Items in list: {0}", people.Count);
      // Перечислить список.
      foreach (Person p in people)
      {
        Console.WriteLine(p);
      }

      // Скопировать данные в новый массив.
      var arrayOfPeople = new Person[5];
      arrayOfPeople = people.ToArray();
      Console.WriteLine();
      for (int i = 0; i < arrayOfPeople.Length; i++)
      {
        Console.WriteLine("First Names: {0}", arrayOfPeople[i].FirstName);
      }
    }
    private static void UseGenericStack()
    {
      var stackOfPeople = new Stack<Person>();
      stackOfPeople.Push(new Person(47, "Homer", "Simpson"));
      stackOfPeople.Push(new Person { Age = 45, FirstName = "Marge", LastName = "Simpson" });
      stackOfPeople.Push(new Person(9, "Lisa", "Simpson"));

      // Просмортеть верхний элемент, вытолкнуть его и просмотреть снова
      Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
      Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
      Console.WriteLine("\nFirst person is: {0}", stackOfPeople.Peek());
      Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
      Console.WriteLine("\nFirst person is: {0}", stackOfPeople.Peek());
      Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
      try
      {
        Console.WriteLine("\nFirst person is: {0}", stackOfPeople.Peek());
        Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
      }
      catch (InvalidOperationException ex)
      {
        Console.WriteLine("\nError! {0}", ex.Message);
      }
    }
    static void GetCoffee(Person p)
    {
      Console.WriteLine("{0} got coffee!", p.FirstName);
    }
    private static void UseGenericQueue()
    {
      // Создать очередь из 3 человек.
      var peopleQ = new Queue<Person>();
      peopleQ.Enqueue(new Person(47, "Homer", "Simpson"));
      peopleQ.Enqueue(new Person { Age = 45, FirstName = "Marge", LastName = "Simpson" });
      peopleQ.Enqueue(new Person { Age = 9, FirstName = "Lisa", LastName = "Simpson" });
      // Кто первый в очереди?
      Console.WriteLine("{0} is first in line!", peopleQ.Peek().FirstName);
      // Извлечь всех из очереди
      while (peopleQ.Count > 0)
      {
        GetCoffee(peopleQ.Dequeue());
      }

      // Попробовать извлечь из пустой очереди.
      try
      {
        GetCoffee(peopleQ.Dequeue());
      }
      catch (InvalidOperationException ex)
      {
        Console.WriteLine("\nError! {0}", ex.Message);
      }
    }
    private static void UseSortedSet()
    {
      // Создать несколько людей разного возраста.
     var setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
      {
        new Person{Age = 47, FirstName = "Homer", LastName = "Simpson"},
        new Person{Age = 45, FirstName = "Marge", LastName = "Simpson"},
        new Person{Age = 9, FirstName = "Lisa", LastName = "Simpson"},
        new Person{Age = 8, FirstName = "Bart", LastName = "Simpson"}
      };
      // Элементы отсортированы по возрасту.
      foreach (Person p in setOfPeople)
      {
        Console.WriteLine(p);
      }
      // Добавить несколько людей разного возраста.
      setOfPeople.Add(new Person(1, "Saku", "Jones"));
      setOfPeople.Add(new Person(32, "Mikko", "Jones"));
      // Элементы отсортированы по возрасту.
      Console.WriteLine();
      foreach (Person p in setOfPeople)
      {
        Console.WriteLine(p);
      }
    }

    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Generic Collections *****\n");
      Console.WriteLine("** Generic List **\n");
      UseGenericList();
      Console.WriteLine("\n** Generic Stack **\n");
      UseGenericStack();
      Console.WriteLine("\n** Generic Queue **\n");
      UseGenericQueue();
      Console.WriteLine("\n** Sorted Set **\n");
      UseSortedSet();
    }
  }
}
