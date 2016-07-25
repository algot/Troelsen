using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PingPongLesson
{
  class Pinger
  {
    // Delegate
    public delegate void EventHandler(string msg);
    // Events
    public event EventHandler SendingPing;

    public void SendPing()
    {
      SendingPing("Ping!");
    }
  }
}
