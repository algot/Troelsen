using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace _01_IssuesWithNongenericCollections
{
  class PersonCollection : IEnumerable
  {
    private readonly ArrayList arPeople = new ArrayList();
    // Приведение для вызывающего кода.
    public Person GetPerson(int pos)
    { return (Person)arPeople[pos]; }

    // Вставка только объектов Person.
    public void AddPerson(Person p)
    { arPeople.Add(p); }

    public void ClearPeople()
    { arPeople.Clear(); }

    public int Count
    { get { return arPeople.Count; } }

    // Поддержка перечисления  с помощью foreach
    IEnumerator IEnumerable.GetEnumerator()
    { return arPeople.GetEnumerator(); }
  }
}