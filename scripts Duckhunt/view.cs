using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private int mouseCoordX = 0;
        private int mouseCoordY = 0;
        private bool hit = false;

        private int ammo = 6;
        private int hits = 0;
        private int misses = 0;

        

        Target target;

        public Form1()
        {
            InitializeComponent();
            target = new Pidgeon(targetPB.Location.X, targetPB.Location.Y);

            /* using (var stream = new MemoryStream(Resources.crosshair3))
             {
                 this.Cursor = new Cursor(stream);
             }
             */

            hitLbl.Visible = false;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseCoordX = e.X;
            mouseCoordY = e.Y;

            xCoordLbl.Text = String.Format("xcoord: {0}",mouseCoordX.ToString());
            yCoordLbl.Text = String.Format("ycoord: {0}",mouseCoordY.ToString());

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;

            //gfx.DrawRectangle(Pens.Green, target.Hitbox);

            base.OnPaint(e);

            if (hit)
            {
                //gfx.FillRectangle(Brushes.Red, target.Hitbox);
                gfx.DrawImage(Resources.bloodSplatter2, target.Hitbox);
            }
            else
            {
                //gfx.FillRectangle(Brushes.Green, target.Hitbox);
                gfx.DrawImage(target.Image, target.Hitbox);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (ammo > 0)
            {
                hit = target.Hit(e.Location);
                hitLbl.Text = hit.ToString();
                if (hit)
                {
                    hits++;
                    this.Refresh();
                    hit = false;
                    if (gametimer.Interval != 0)
                    {
                        gametimer.Interval -= 100;
                    }
                }
                else
                    misses++;
                SoundPlayer sp = new SoundPlayer(Resources._380_gunshot_single_mike_koenig);
                sp.Play();

                ammo--;
                ammoLbl.Text = String.Format("ammo: {0}", ammo.ToString());
                hitsLbl.Text = String.Format("hits: {0}", hits.ToString());
                hitPercentageLbl.Text = String.Format("hitpercentage: {0}%", CalculatePercentage().ToString("0.00"));
                
            }
            
            
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            target.Update(this);
            this.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                ammo = 6;
                ammoLbl.Text = String.Format("ammo: {0}", ammo.ToString());
            }
        }

        public float CalculatePercentage()
        {
            float hitPercentage = ((float)hits / (float)(hits + misses)) * 100;
            return hitPercentage;
        }
    }
}
