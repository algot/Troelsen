using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_LazyObjectInstantiation
{
  // Представляет все композиции в проигрывателе.
  class AllTracks
  {
    private Song[] allSongs = new Song[10000];

    // В проигрывателе может содержаться до 10000 композиций.
    public AllTracks()
    {
      // Предполагается, что здесь происходит заполнение массива объектов Song.
      Console.WriteLine("Filling up the songs!");
    }
  }
}
