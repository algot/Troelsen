using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_SimpleException
{
  class Car
  {
    // Константа определяющая максимальную скорость автомобиля
    public const int MaxSpeed = 100;
    // Свойства автомобиля
    public int CurrentSpeed { get; set; }
    public string PetName { get; set; }

    // Не вышел ли автомобиль из строя?
    private bool carIsDead;

    // В автомобиле есть радиоприемник
    private Radio theMusicbox = new Radio();

    // Конструкторы
    public Car() { }
    public Car(string name, int speed)
    {
      PetName = name;
      CurrentSpeed = speed;
    }

    public void CrankTunes(bool state)
    {
      // Запрос делегата к внутреннему объекту
      theMusicbox.TurnOn(state);
    }
    // Проверка, не перегрелся ли автомобиль
    public void Accelerate(int delta)
    {
      if (carIsDead)
        Console.WriteLine("{0} is out of order...", PetName);
      else
      {
        CurrentSpeed += delta;
        if (CurrentSpeed >= MaxSpeed)
        {
          carIsDead = true;
          CurrentSpeed = 0;
          // Создание локальной переменной перед выдачей
          // объекта Exception для обращения к свойству HelpLink
          Exception ex =
            new Exception(string.Format("{0} is overheated...", PetName));
          ex.HelpLink = "http://www.cars.ru";
          // Вставка дополнительных данных, имеющих отношение к ошибке
          ex.Data.Add("Time Stamp",
            string.Format("The car exploded at {0}", DateTime.Now));    // Дата и время
          ex.Data.Add("Cause", "You have a lead foot.");                // Причина
          throw ex;
        }
        else
          Console.WriteLine("=> Current Speed = {0}", CurrentSpeed);
      }
    }
  }
}
