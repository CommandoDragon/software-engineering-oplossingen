namespace Duck_hunt
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
      this.score_tag = new System.Windows.Forms.Label();
      this.ammo_tag = new System.Windows.Forms.Label();
      this.ammo = new System.Windows.Forms.Label();
      this.score = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // score_tag
      // 
      this.score_tag.AutoSize = true;
      this.score_tag.Location = new System.Drawing.Point(13, 13);
      this.score_tag.Name = "score_tag";
      this.score_tag.Size = new System.Drawing.Size(38, 13);
      this.score_tag.TabIndex = 0;
      this.score_tag.Text = "Score:";
      // 
      // ammo_tag
      // 
      this.ammo_tag.AutoSize = true;
      this.ammo_tag.Location = new System.Drawing.Point(527, 13);
      this.ammo_tag.Name = "ammo_tag";
      this.ammo_tag.Size = new System.Drawing.Size(39, 13);
      this.ammo_tag.TabIndex = 1;
      this.ammo_tag.Text = "Ammo:";
      // 
      // ammo
      // 
      this.ammo.AutoSize = true;
      this.ammo.Location = new System.Drawing.Point(573, 13);
      this.ammo.Name = "ammo";
      this.ammo.Size = new System.Drawing.Size(13, 13);
      this.ammo.TabIndex = 2;
      this.ammo.Text = "0";
      // 
      // score
      // 
      this.score.AutoSize = true;
      this.score.Location = new System.Drawing.Point(58, 13);
      this.score.Name = "score";
      this.score.Size = new System.Drawing.Size(13, 13);
      this.score.TabIndex = 3;
      this.score.Text = "0";
      this.score.Click += new System.EventHandler(this.label1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(630, 344);
      this.Controls.Add(this.score);
      this.Controls.Add(this.ammo);
      this.Controls.Add(this.ammo_tag);
      this.Controls.Add(this.score_tag);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label score_tag;
    private System.Windows.Forms.Label ammo_tag;
    private System.Windows.Forms.Label ammo;
    private System.Windows.Forms.Label score;
  }
}

