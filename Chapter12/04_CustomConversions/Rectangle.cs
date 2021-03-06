﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CustomConversions
{
  public struct Rectangle
  {
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int w, int h) : this()
    {
      Width = w;
      Height = h;
    }

    public void Draw()
    {
      for (int i = 0; i < Height; i++)
      {
        for (int j = 0; j < Width; j++)
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }
    }

    public override string ToString()
    {
      return string.Format("[Width = {0}; Height = {1}]", Width, Height);
    }
  }
}