using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09_ComparableCar
{
  class Car : IComparable
  {
    // Константа определяющая максимальную скорость автомобиля
    public const int MaxSpeed = 100;
    // Свойства автомобиля
    public int CurrentSpeed { get; set; }
    public string PetName { get; set; }
    public int CarId { get; set; }

    // Конструкторы
    public Car() { }
    public Car(string name, int currSpeed, int id)
    {
      PetName = name;
      CurrentSpeed = currSpeed;
      CarId = id;
    }

    // Реализация IComparable
    int IComparable.CompareTo(object obj)
    {
      Car temp = obj as Car;
      if (temp != null)
        return this.CarId.CompareTo(temp.CarId);
      else
        throw new ArgumentException("Parameter is not a Car!");
    }

    // Свойство, возвращающее компаратор SortByPetName.
    public static IComparer SortByPetName
    {
      get
      {
        return (IComparer)new PetNameComparer();
      }
    }
  }
}
