using System;

namespace _03_CarDelegateMethodGroupConversion
{
  public class Car
  {
    public int CurrentSpeed { get; set; }
    public int MaxSpeed { get; set; }
    public string PetName { get; set; }

    // Исправен ли автомобиль?
    private bool carIsDead;

    // Конструкторы класса.
    public Car() { MaxSpeed = 100; }

    public Car(string name, int maxSp, int currSp)
    {
      PetName = name;
      MaxSpeed = maxSp;
      CurrentSpeed = currSp;
    }

    // Определить тип делегата
    public delegate void CarEngineHandler(string msgForCaller);
    // Определить переменную-член типа этого делегата.
    private CarEngineHandler listOfHandlers;
  
    // Добавить регистрационную функцию для вызывающего кода.
    public void RegisterWithCarEngine(CarEngineHandler methodToCall)
    {
      listOfHandlers += methodToCall;
    }
    public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
    {
      listOfHandlers -= methodToCall;
    }

    public void Accelerate(int delta)
    {
      // Если автомобиль сломан, отправить сообщение об этом.
      if (carIsDead)
      {
        if (listOfHandlers != null)
          listOfHandlers("Sorry, this car is dead...");
      }
      else
      {
        CurrentSpeed += delta;
        // Автомобиль почти сломан?
        if (10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)
          listOfHandlers("Carefull buddy! Gonna blow");
        if (CurrentSpeed >= MaxSpeed)
          carIsDead = true;
        else
          Console.WriteLine("Current speed is {0}", CurrentSpeed);
      }
    }
  }
}
