using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
  // Представляет состояние двигателя
  public enum EngineState
  {
    engineAlive,
    engineDead
  }
  // Абстрактный базовый класс в иерархии
  public abstract class Car
  {
    public string PetName { get; set; }
    public int CurrentSpeed { get; set; }
    public int MaxSpeed { get; set; }

    protected EngineState EngState = EngineState.engineAlive;
    public EngineState EngineState
    {
      get { return EngState; }
    }

    public abstract void TurboBoost();

    public Car() { }
    public Car(string name, int maxSpd, int currSpd)
    {
      PetName = name;
      MaxSpeed = maxSpd;
      CurrentSpeed = currSpd;
    }
  }
}
