using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    class Pidgeon : Target
    {
        public Pidgeon(int xCoord, int yCoord) : base(Resources.pidgeon2, xCoord, yCoord)
        {

        }
    }
}
