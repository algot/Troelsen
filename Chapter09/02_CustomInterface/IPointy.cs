using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_CustomInterface
{
  // Интерфейс определяет наличие вершин
  public interface IPointy
  {
    byte Points { get; }
  }
}
