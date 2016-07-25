using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PingPongLesson
{
  class Ponger
  {
    public delegate void EventHandler(string msg);

    public event EventHandler GetPing;
    public event EventHandler SendPong;

    public void GettingPing(string msg)
    {

    }
  }
}
