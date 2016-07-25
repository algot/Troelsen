using System;

namespace _02_CarDelegate
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
    public delegate void CarEngineHandlerDelegate(string msgForCaller);

    // Определить переменную-член типа этого делегата.
    private CarEngineHandlerDelegate listOfHandlersDelegate;

    // Добавление поддержки группового вызова
    public void RegisterWithCarEngine(CarEngineHandlerDelegate methodToCall)
    {
      listOfHandlersDelegate += methodToCall;
    }

    // Удаление цели из списка вызовов делегата
    public void UnRegisterWithCarEngine(CarEngineHandlerDelegate methodToCall)
    {
      listOfHandlersDelegate -= methodToCall;
    }

    public void Accelerate(int delta)
    {
      // Если автомобиль сломан, отправить сообщение об этом.
      if (carIsDead)
      {
        if (listOfHandlersDelegate != null)
          listOfHandlersDelegate("Sorry, this car is dead...");
      }
      else
      {
        CurrentSpeed += delta;
        // Автомобиль почти сломан?
        if ((MaxSpeed - CurrentSpeed) == 10
          && listOfHandlersDelegate != null)
        {
          listOfHandlersDelegate("Careful buddy! Gonna blow!");
        }
        if (CurrentSpeed >= MaxSpeed)
          carIsDead = true;
        else
          Console.WriteLine("Current Speed = {0}", CurrentSpeed);
      }
    }
  }
}
