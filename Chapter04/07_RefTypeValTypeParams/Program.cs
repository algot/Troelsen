using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Person
{
  public string personName;
  public int personAge;

  public Person(string name, int age)
  {
    personName = name;
    personAge = age;
  }
  public Person() { }
  public void Display()
  {
    Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
  }
}

class Program
{
  static void SendPersonByValue(Person p)
  {
    // Изменение возраста в p
    p.personAge = 99;
    // Увидит ли вызывающий код это изменение?
    p = new Person("Nikki", 99);
  }
  static void SendPersonByRef(ref Person p)
  {
    // Изменение некоторых данных в p
    p.personAge = 555;
    // Теперь p указывает на новый объект в куче.
    p = new Person("Nikki", 222);
  }

  static void Main()
  {
    // Передача ссылочных типов по значению.
    Console.WriteLine("***** Passing Person object by value *****");
    Person fred = new Person("Fred", 12);
    Console.WriteLine("\nBefore by value call, Person is:");
    fred.Display();
    SendPersonByValue(fred);
    Console.WriteLine("\nAfter by value call, Person is:");
    fred.Display();

    // Передача ссылочных типов по ссылке.
    Console.WriteLine("***** Passing Person object by reference *****");
    Person mel = new Person("Mel", 23);
    Console.WriteLine("\nBefore by ref call, Person is:");
    mel.Display();
    SendPersonByRef(ref mel);
    Console.WriteLine("\nAfter by ref call, Person is:");
    mel.Display();
  }
}

