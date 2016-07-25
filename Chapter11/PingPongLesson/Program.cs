using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PingPongLesson
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Ping-Pong events *****\n");
      Pinger p1 = new Pinger();
      Ponger p2 = new Ponger();

      p1.SendingPing += PingWasSent;
      p2.GetPing += PingWasSent;
      p1.SendPing();
  }
    static void PingWasSent(string msg)
    { Console.WriteLine(msg); }
  }
}
