using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_Simplelndexer
{
  public class Person
  {
    public int Age { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person() { }
    public Person(int age, string fName, string lName)
    {
      Age = age;
      FirstName = fName;
      LastName = lName;
    }
    public override string ToString()
    {
      return string.Format("Name: {0} {1}, Age: {2}", FirstName, LastName, Age);
    }
  }
}
