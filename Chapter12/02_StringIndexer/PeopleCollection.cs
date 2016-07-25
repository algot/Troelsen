using System.Collections;
using System.Collections.Generic;

namespace _02_StringIndexer
{
  public class PeopleCollection : IEnumerable
  {
    private Dictionary<string, Person> listPeople = new Dictionary<string, Person>();

    // Этот индексатор возвращает персону по строковому индексу
    public Person this[string name]
    {
      get { return (Person)listPeople[name]; }
      set { listPeople[name] = value; }
    }

    public void ClearPeople()
    {
      listPeople.Clear();
    }

    public int Count
    {
      get { return listPeople.Count; }
    }

    // Foreach enumeration support. 
    IEnumerator IEnumerable.GetEnumerator()
    { return listPeople.GetEnumerator(); }
  }
}
