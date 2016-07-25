using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_DelegateCovariance
{
  public class Car
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

    // Определить тип делегата
    public delegate void CarEngineHandler(string msgForCaller);

    // Определить переменную-член типа этого делегата
    private CarEngineHandler listOfHandlers;

    // Добавить регистрационную функцию для вызывающего кода.
    public void RegisterWithCarEngine(CarEngineHandler methodToCall)
    {
      listOfHandlers += methodToCall;
    }
    // Добавить исключающую регистрацию функцию для вызывающего кода.
    public void UnregisterWithCarEngine(CarEngineHandler methodToCall)
    {
      listOfHandlers -= methodToCall;
    }

    public void Accelerate(int delta)
    {
      // Если автомобиль сломан, отправить сообщение об этом.
      if (carIsDead)
      {
        if (listOfHandlers != null)
          listOfHandlers("Sorry, car is dead");
      }
      else
      {
        CurrSpeed += delta;
        // Автомобиль почти сломан?
        if (10 == (MaxSpeed - CurrSpeed) && listOfHandlers != null)
        {
          listOfHandlers("Careful buddy. Gonna blow!");
        }
        if (CurrSpeed >= MaxSpeed)
          carIsDead = true;
        else
          Console.WriteLine("Current Speed = {0}", CurrSpeed);
      }
    }
  }
}