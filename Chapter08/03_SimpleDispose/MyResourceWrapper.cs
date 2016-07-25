using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_SimpleDispose
{
  class MyResourceWrapper : IDisposable
  {
    // Используется для определения того, вызывался ли уже метод Dispose()
    private bool _disposed = false;

    public void Dispose()
    {
      // Вызов вспомогательного метода.
      // Значение true указывает, что очистка была инициализирована пользователем объекта.
      CleanUp(true);

      // Подавление финализации.
      GC.SuppressFinalize(this);
    }

    private void CleanUp(bool disposing)
    {
      // Проверка, выполнялась ли очистка.
      if (!_disposed)
      {
        // Если disposing равно true, то должно осуществляться
        // освобождение всех управляемых ресурсов.
        if (disposing)
        {
          // Здесь осуществляется освобождение управляемых ресурсов.
        }
        // Очистка неуправляемых ресурсов.
      }
      _disposed = true;
    }
    ~MyResourceWrapper()
    {
      // Вызов вспомогательного метода.
      // Значение false указывает, что очистка была инициализирована сборщиком мусора.
      CleanUp(false);
    }
  }
}
