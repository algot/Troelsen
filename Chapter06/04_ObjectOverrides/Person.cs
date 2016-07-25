using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_ObjectOverrides
{
  class Person
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public Person(string fName, string lName, int personAge)
    {
      FirstName = fName;
      LastName = lName;
      Age = personAge;
    }
    public Person() { }

    public override string ToString()
    {
      string myState;
      myState = string.Format("[FirstName: {0}; LastName: {1}; Age: {2}]", FirstName, LastName, Age);
      return myState;
    }
    public override bool Equals(object obj)
    {
      if (obj is Person && obj != null)
      {
        Person temp;
        temp = (Person)obj;
        if (temp.FirstName == this.FirstName
          && temp.LastName == this.LastName
          && temp.Age == this.Age)
        {
          return true;
        }
        else
        {
          return false;
        }
      }
      return false;
    }
    public override int GetHashCode()
    {
      return this.ToString().GetHashCode();
    }
  }
}