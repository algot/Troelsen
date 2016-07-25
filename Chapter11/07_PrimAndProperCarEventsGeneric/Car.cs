using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_PrimAndProperCarEventsGeneric
{
  public class Car
  {
    // Данные состояния
    public int CurrentSpeed { get; set; }
    public int MaxSpeed { get; set; }
    public string PetName { get; set; }
    // Исправен ли автомобиль?
    private bool carIsDead;

    // Конструкторы класса
    public Car(string name, int maxSp, int currSp)
    {
      CurrentSpeed = currSp;
      MaxSpeed = maxSp;
      PetName = name;
    }

    // Car может посылать следующие события
    public event EventHandler<CarEventArgs> Exploded;
    public event EventHandler<CarEventArgs> AboutToBlow;

    public void Accelerate(int delta)
    {
      // Если автомобиль сломан, инициировать событие Exploded
      if (carIsDead)
      {
        if (Exploded != null)
          Exploded(this, new CarEventArgs("Sorry car is dead..."));
      }
      else
      {
        CurrentSpeed += delta;
        // Почти сломан?
        if (10 == MaxSpeed - CurrentSpeed
          && AboutToBlow != null)
        {
          AboutToBlow(this, new CarEventArgs("Carefull buddy!, Gonna blow!"));
        }
        if (CurrentSpeed >= MaxSpeed)
          carIsDead = true;
        else
          Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
      }
    }
  }
}