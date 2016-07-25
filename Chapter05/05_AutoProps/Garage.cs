namespace _05_AutoProps
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;

  public class Garage
  {
    // Скрытое поле int установлено в 0
    public int NumberOfCars { get; set; }
    // Скрытое поле Car установлено в null
    public Car MyAuto { get; set; }
    // Для переопределения значений по умолчанию, присвоенных скрытым полям, должны использоваться конструкторы.
    public Garage()
    {
      MyAuto = new Car();
      NumberOfCars = 1;
    }
    public Garage(Car car, int number)
    {
      MyAuto = car;
      NumberOfCars = number;
    }
  }
}
