using System.Collections;

namespace _01_Simplelndexer
{
  public class PeopleCollection : IEnumerable
  {
    private readonly ArrayList _arPeople = new ArrayList();
    // Custom indexer for this class.
    public Person this[int index]
    {
      get { return (Person)_arPeople[index]; }
      set { _arPeople.Insert(index, value); }
    }

    // Cast for caller.
    public Person GetPerson(int pos)
    { return (Person)_arPeople[pos]; }

    // Only insert Person types.
    public void AddPerson(Person p)
    { _arPeople.Add(p); }

    public void ClearPeople()
    { _arPeople.Clear(); }

    public int Count
    { get { return _arPeople.Count; } }

    // Foreach enumeration support. 
    IEnumerator IEnumerable.GetEnumerator()
    { return _arPeople.GetEnumerator(); }
  }
}
