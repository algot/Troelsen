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
      List<Person> people = new List<Person>()
      {
        new Person {FirstName = "Homer", LastName = "Simpson", Age = 47},
        new Person {FirstName = "Marge", LastName = "Simpson", Age = 45},
        new Person {FirstName = "Lisa", LastName = "Simpson", Age = 9},
        new Person {FirstName = "Bart", LastName = "Simpson", Age = 8}
      };

      // Вывести на консоль количество элементов в списке
      Console.WriteLine("Items in list: {0}", people.Count);

      // Перечислить список.
      foreach (Person p in people)
        Console.WriteLine(p);

      // Вставить новую персону
      Console.WriteLine("\n->Inserting new person.");
      people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });

      // Вывести на консоль количество элементов в списке
      Console.WriteLine("Items in list: {0}", people.Count);

      // Перечислить список.

      // Скопировать данные в новый массив.
      Person[] arrayOfPeople = people.ToArray();
      for (int i = 0; i < arrayOfPeople.Length; i++)
      {
        Console.WriteLine("First Names: {0}", arrayOfPeople[i].FirstName);
      }
    }
    private static void UseGenericStack()
    {
      Stack<Person> stackOfPeople = new Stack<Person>();
      stackOfPeople.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
      stackOfPeople.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
      stackOfPeople.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

      // Просмортеть верхний элемент, вытолкнуть его и просмотреть снова
      Console.WriteLine("First element is: {0}", stackOfPeople.Peek());
      Console.WriteLine("Popped element is: {0}", stackOfPeople.Pop());
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
    private static void GetCoffee(Person p)
    {
      Console.WriteLine("{0} got coffee!", p.FirstName);
    }
    private static void UseGenericQueue()
    {
      // Создать очередь из 3 человек.
      Queue<Person> peopleQ = new Queue<Person>();
      peopleQ.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
      peopleQ.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
      peopleQ.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

      // Кто первый в очереди?
      Console.WriteLine("{0} is the first in line!", peopleQ.Peek().FirstName);

      // Извлечь всех из очереди
      GetCoffee(peopleQ.Dequeue());
      GetCoffee(peopleQ.Dequeue());
      GetCoffee(peopleQ.Dequeue());

      // Попробовать извлечь из пустой очереди.
      try
      {
        GetCoffee(peopleQ.Dequeue());
      }
      catch (InvalidOperationException e)
      {
        Console.WriteLine("Error! {0}", e.Message);
      }
    }
    private static void UseSortedSet()
    {
      // Создать несколько людей разного возраста.
      SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
      {
        new Person {FirstName = "Homer", LastName = "Simpson", Age = 47},
        new Person {FirstName = "Marge", LastName = "Simpson", Age = 45},
        new Person {FirstName = "Lisa", LastName = "Simpson", Age = 9},
        new Person {FirstName = "Bart", LastName = "Simpson", Age = 8}
      };

      // Элементы отсортированы по возрасту.
      foreach (Person p in setOfPeople)
      {
        Console.WriteLine(p);
      }
      Console.WriteLine();

      // Добавить несколько людей разного возраста.
      setOfPeople.Add(new Person { FirstName = "Saku", LastName = "Jones", Age = 1 });
      setOfPeople.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 1 });
      // Элементы отсортированы по возрасту.
      foreach (Person p in setOfPeople)
      {
        Console.WriteLine(p);
      }
    }

    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Generic Collections *****\n");

      UseGenericList();
      UseGenericStack();
      UseGenericQueue();
      UseSortedSet();
    }
  }
}
