using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_LazyObjectInstantiation
{
  // Класс включает в себя объект AllTracks
  class MediaPlayer
  {
    public void Play() { }
    public void Pause() { }
    public void Stop() { }

    private Lazy<AllTracks> allSongs = new Lazy<AllTracks>(() =>
    {
      Console.WriteLine("Creating AllTracks object!");
      return new AllTracks();
    }
    );

    public AllTracks GetAllTracks()
    {
      // Возвращаем все композиции
      return allSongs.Value;
    }
  }
}
