using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_IssuesWithNongenericCollections
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Custom Person Collection *****\n");
      PersonCollection myPeople = new PersonCollection();
      myPeople.AddPerson(new Person(40, "Homer", "Simpson"));
      myPeople.AddPerson(new Person(38, "Marge", "Simpson"));
      myPeople.AddPerson(new Person(9, "Lisa", "Simpson"));
      myPeople.AddPerson(new Person(7, "Bart", "Simpson"));
      myPeople.AddPerson(new Person(2, "Maggie", "Simpson"));

      foreach (Person p in myPeople)
      {
        Console.WriteLine(p);
      }
    }
    static void UseGenericList()
    {
      Console.WriteLine("***** Fun with Generics *****\n");
      // Этот List<> может хранить только объекты Person
      List<Person> morePeople = new List<Person>();
      morePeople.Add(new Person(50, "Frank", "Black"));
      Console.WriteLine(morePeople[0]);
      // Этот List<> может хранить только объекты int
      List<int> moreInts = new List<int>();
      moreInts.Add(10);
      moreInts.Add(2);
      int sum = moreInts[0] + moreInts[1];
    }
  }
}