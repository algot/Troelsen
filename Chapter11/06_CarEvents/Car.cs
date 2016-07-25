using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_CarEvents
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

        // Car может посылать следующие события
    public event EventHandler<CarEventArgs> Exploded;
    public event EventHandler<CarEventArgs> AboutToBlow;

        public void Accelerate(int delta)
    {
      // Если автомобиль сломан, инициировать событие Exploded
      if (carIsDead)
      {
        if (Exploded != null)
          Exploded(this, new CarEventArgs("Sorry, this car is dead..."));
      }
      else
      {
        CurrentSpeed += delta;

        // Почти сломан?
        if (10 == MaxSpeed - CurrentSpeed && AboutToBlow != null)
          AboutToBlow(this, new CarEventArgs("Careful buddy! Gonna blow!"));
        // Все в порядке
        if (CurrentSpeed >= MaxSpeed)
          carIsDead = true;
        else
          Console.WriteLine("Current speed = {0}", CurrentSpeed);
      }
    }
  }
}