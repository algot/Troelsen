using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_GenericPoint
{
  class MyReadOnlyList<T> : MyList<T> where T : new()
  {
    public override void PrintList(T data) { }
  }
}
