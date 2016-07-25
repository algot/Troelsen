using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_PrimAndProperCarEvents
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
    public Car() { MaxSpeed = 100; }
    public Car(string name, int maxSp, int currSpeed)
    {
      PetName = name;
      MaxSpeed = maxSp;
      CurrentSpeed = currSpeed;
    }

    // Определить тип делегата
    // Этот делегат работает в сочетании с событиями Car
    public delegate void CarEngineHandler(object sender, CarEventArgs e);
    // Car может посылать следующие события
    public event CarEngineHandler Exploded;
    public event CarEngineHandler AboutToBlow;



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