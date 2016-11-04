using doveShooter.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace doveShooter
{
  public partial class Form1 : Form 
  {
    int splatTime = 0;

    int ammo = 6;
    int hits = 0;
    int misses = 0;
    int totalShots = 0;
    double averageHits = 0;

    bool isSplat = false;

    Pidgeon pidgeon;
    BloodSplat splat;

    Random rnd = new Random();

    public Form1()
    {
      InitializeComponent();

      //Create scope site
      Bitmap b = new Bitmap(Resources.crosshair_scaled);
      this.Cursor = CustomCursor.CreateCursor(b, b.Height / 10, b.Width / 10);

      pidgeon = new Pidgeon() { Left = 300, Top = 100 };
      splat = new BloodSplat();

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      
    }

    private void timerGameLoop_Tick(object sender, EventArgs e)
    {
      
        UpdatePidgeon();
      

      if (isSplat)
      { 
        if(splatTime >= 3)
        {
          isSplat = false;
          splatTime = 0;
          UpdatePidgeon();

        }
        splatTime++;
      }


      this.Refresh();
    }

    private void UpdatePidgeon()
    { 
      pidgeon.Update(
        rnd.Next(Resources.pidgeon2.Width, this.Width - Resources.pidgeon2.Width),
        rnd.Next(this.Height / 2, this.Height - Resources.pidgeon2.Height * 2)
        );
    }

    

    protected override void OnPaint(PaintEventArgs e) 
    {
      Graphics dc = e.Graphics;

      if (isSplat == true)
      {
        splat.DrawImage(dc);
      }
      else
      {
        pidgeon.DrawImage(dc);
      }

      TextFormatFlags flags = TextFormatFlags.Left;
      Font font = new System.Drawing.Font("Stencil", 12, FontStyle.Regular);
      TextRenderer.DrawText(e.Graphics, "Ammo: " + ammo.ToString() + " (Space = Reload)", font, new Rectangle(30, 12, 200, 30), SystemColors.ControlText, flags);
      TextRenderer.DrawText(e.Graphics, "Shots: " + totalShots.ToString(), font, new Rectangle(30, 32, 120, 30), SystemColors.ControlText, flags);
      TextRenderer.DrawText(e.Graphics, "Hits: " + hits.ToString(), font, new Rectangle(30, 52, 120, 30), SystemColors.ControlText, flags);
      TextRenderer.DrawText(e.Graphics, "Misses: " + misses.ToString(), font, new Rectangle(30, 72, 120, 30), SystemColors.ControlText, flags);
      TextRenderer.DrawText(e.Graphics, "Avg: " + averageHits.ToString("F0") + "%", font, new Rectangle(30, 92, 120, 30), SystemColors.ControlText, flags);

      base.OnPaint(e);
    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {

      this.Refresh();

    }

    private void Form1_MouseClick(object sender, MouseEventArgs e)
    {
      if (ammo > 0 && timerGameLoop.Enabled == true)
      { 
        averageHits = (double)hits / (double)totalShots * 100;
        
        FireGun();

        if (pidgeon.Hit(e.X, e.Y))
        {
          isSplat = true;
          splat.Left = pidgeon.Left - Resources.bloodSplatter2.Width / 3;
          splat.Top = pidgeon.Top - Resources.bloodSplatter2.Width / 3;
          hits++;

          timerGameLoop.Interval -= 100;
         
        }
        else 
        {
            misses++;
        }

        totalShots = hits + misses;

        ammo--;
      }
    }

    private void Reload()
    {
      ammo = 6;
    }

    

    private void FireGun()
    {
      SoundPlayer audio = new SoundPlayer(Resources.shotgun_edited);

      audio.Play();
    }

    private void startBtn_Click(object sender, EventArgs e)
    {
      timerGameLoop.Start();
    }

    private void stopBtn_Click(object sender, EventArgs e)
    {
      timerGameLoop.Stop();
    }

    private void quitBtn_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Space)
      {
        Reload();
      }
    }
  }
}
