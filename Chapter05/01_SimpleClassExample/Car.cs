namespace _01_SimpleClassExample
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;

  class Car
  {
    // Состояние объекта Car
    public string petName;
    public int currSpeed;
    // Конструктор по умолчанию.
    public Car()
    {
      petName = "Chuck";
      currSpeed = 10;
    }
    public Car(string pn)
    {
      petName = pn;
    }
    public Car(string pn, int cs)
    {
      petName = pn;
      currSpeed = cs;
    }
    // Функциональность Car
    public void PrintState()
    {
      Console.WriteLine("{0} is doing {1} mph.", petName, currSpeed);
    }
    public void SpeedUp(int delta)
    {
      currSpeed += delta;
    }
    // Car имеет Radio.
    private Radio myRadio = new Radio();
    public void TurnOnRadio(bool onOff)
    {
      // Делегированный вызов внутреннего объекта.
      myRadio.Power(onOff);
    }
  }
}
