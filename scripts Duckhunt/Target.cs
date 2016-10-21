using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Target
    {
        private Random randomGen;
        public Rectangle Hitbox { get; set; }
        public Bitmap Image { get; set; }
        public Target(Bitmap resources, int xCoord, int yCoord)
        {
            Hitbox = new Rectangle(xCoord, yCoord, 50, 50);
            randomGen = new Random();
            Image = resources;
        }

        public bool Hit(int xMouseCoord, int yMouseCoord)
        {
            if (Hitbox.Contains(xMouseCoord, yMouseCoord))
            {
                return true;
            }
            return false;
        }

        public void Update(Form1 form)
        {
            int formHeigth = form.Size.Height;
            int formWidth = form.Size.Width;

            Hitbox = new Rectangle(randomGen.Next(0,formWidth-50),randomGen.Next(0,formHeigth-50), 50, 50);
            
        }

        public bool Hit(Point mouseHit)
        {
            if (Hitbox.Contains(mouseHit))
            {
                return true;
            }
            return false;
        }
    }
}
