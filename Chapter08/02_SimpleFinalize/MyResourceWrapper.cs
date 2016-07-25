using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_SimpleFinalize
{
  class MyResourceWrapper
  {
    ~MyResourceWrapper()
    {
      // Здесь производится очистка неуправляемых ресурсов
      
      // Подача звукового сигнала при уничтожении объекта
      Console.Beep();
    }
  }
}
