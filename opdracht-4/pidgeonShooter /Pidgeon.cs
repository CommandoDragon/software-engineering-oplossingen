using doveShooter.Properties;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doveShooter
{
  class Pidgeon : MainView
  {
    private Rectangle pidgeonHotSpot = new Rectangle();

    public Pidgeon()
      : base(Resources.pidgeon2)
    {
      pidgeonHotSpot.X = Left + 20;
      pidgeonHotSpot.Y = Top - 1;
      pidgeonHotSpot.Width = 60;
      pidgeonHotSpot.Height = 60;
    }

    public void Update(int X, int Y)
    {
      Left = X;
      Top = Y;
      pidgeonHotSpot.X = Left;
      pidgeonHotSpot.Y = Top;
    }

    public bool Hit(int X, int Y)
    {
      Rectangle c = new Rectangle(X, Y, 1, 1); // Creates a cursor rectangle - quick way to check for hit
      
      if (pidgeonHotSpot.Contains(c))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

  }
}
