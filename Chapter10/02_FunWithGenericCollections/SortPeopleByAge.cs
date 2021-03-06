﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_FunWithGenericCollections
{
  class SortPeopleByAge : IComparer<Person>
  {
    public int Compare(Person firstPerson, Person secondPerson)
    {
      if (firstPerson.Age > secondPerson.Age)
        return 1;
      if (firstPerson.Age < secondPerson.Age)
        return -1;
      else
        return 0;
    }
  }
}
