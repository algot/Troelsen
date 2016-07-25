using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_AnonymousMethods
{
  class Car
  {
    // Данные состояния
    public int CurrSpeed { get; set; }
    public int MaxSpeed { get; set; }
    public string PetName { get; set; }
    // Исправен ли автомобиль?
    private bool carIsDead;

    // Конструкторы класса
    public Car() { MaxSpeed = 100; }
    public Car(string name, int maxSp, int currSpeed)
    {
      PetName = name;
      MaxSpeed = maxSp;
      CurrSpeed = currSpeed;
    }

    // Car может посылать следующие события.
    public event EventHandler<CarEventArgs> Exploded;
    public event EventHandler<CarEventArgs> AboutToBlow;

    public void Accelerate(int delta)
    {
      // Если автомобиль сломан, инициализировать событие Exploded.
      if (carIsDead)
      {
        if (Exploded != null)
          Exploded(this, new CarEventArgs("Sorry, car is dead"));
      }
      else
      {
        CurrSpeed += delta;
        // Автомобиль почти сломан?
        if (10 == (MaxSpeed - CurrSpeed) && AboutToBlow != null)
        {
          AboutToBlow(this, new CarEventArgs("Careful buddy. Gonna blow!"));
        }
        if (CurrSpeed >= MaxSpeed)
          carIsDead = true;
        else
          Console.WriteLine("Current Speed = {0}", CurrSpeed);
      }
    }
  }
}