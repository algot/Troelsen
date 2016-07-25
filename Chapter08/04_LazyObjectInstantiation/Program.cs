using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_LazyObjectInstantiation
{
  class Program
  {
    static void Main(string[] args)
    {
      MediaPlayer myPlayer = new MediaPlayer();
      myPlayer.Play();

      MediaPlayer yourPlayer = new MediaPlayer();
      AllTracks yourMusic = yourPlayer.GetAllTracks();
    }
  }
}
