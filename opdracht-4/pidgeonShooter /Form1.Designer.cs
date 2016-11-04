namespace doveShooter
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.timerGameLoop = new System.Windows.Forms.Timer(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.startBtn = new System.Windows.Forms.Button();
      this.stopBtn = new System.Windows.Forms.Button();
      this.quitBtn = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // timerGameLoop
      // 
      this.timerGameLoop.Interval = 1600;
      this.timerGameLoop.Tick += new System.EventHandler(this.timerGameLoop_Tick);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(554, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(0, 24);
      this.label1.TabIndex = 0;
      // 
      // startBtn
      // 
      this.startBtn.Location = new System.Drawing.Point(355, 9);
      this.startBtn.Name = "startBtn";
      this.startBtn.Size = new System.Drawing.Size(75, 23);
      this.startBtn.TabIndex = 1;
      this.startBtn.Text = "Start";
      this.startBtn.UseVisualStyleBackColor = true;
      this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
      // 
      // stopBtn
      // 
      this.stopBtn.Location = new System.Drawing.Point(446, 9);
      this.stopBtn.Name = "stopBtn";
      this.stopBtn.Size = new System.Drawing.Size(75, 23);
      this.stopBtn.TabIndex = 2;
      this.stopBtn.Text = "Stop";
      this.stopBtn.UseVisualStyleBackColor = true;
      this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
      // 
      // quitBtn
      // 
      this.quitBtn.Location = new System.Drawing.Point(537, 9);
      this.quitBtn.Name = "quitBtn";
      this.quitBtn.Size = new System.Drawing.Size(75, 23);
      this.quitBtn.TabIndex = 3;
      this.quitBtn.Text = "Quit";
      this.quitBtn.UseVisualStyleBackColor = true;
      this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.BackgroundImage = global::doveShooter.Properties.Resources.sky_background;
      this.ClientSize = new System.Drawing.Size(624, 321);
      this.Controls.Add(this.quitBtn);
      this.Controls.Add(this.stopBtn);
      this.Controls.Add(this.startBtn);
      this.Controls.Add(this.label1);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.Name = "Form1";
      this.Text = "Pidgeon Shooter";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer timerGameLoop;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button startBtn;
    private System.Windows.Forms.Button stopBtn;
    private System.Windows.Forms.Button quitBtn;
  }
}

