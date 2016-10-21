namespace WindowsFormsApplication1
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
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.xCoordLbl = new System.Windows.Forms.Label();
            this.yCoordLbl = new System.Windows.Forms.Label();
            this.targetPB = new System.Windows.Forms.PictureBox();
            this.hitLbl = new System.Windows.Forms.Label();
            this.ammoLbl = new System.Windows.Forms.Label();
            this.hitPercentageLbl = new System.Windows.Forms.Label();
            this.hitsLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.targetPB)).BeginInit();
            this.SuspendLayout();
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 2000;
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // xCoordLbl
            // 
            this.xCoordLbl.AutoSize = true;
            this.xCoordLbl.BackColor = System.Drawing.Color.Transparent;
            this.xCoordLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xCoordLbl.Location = new System.Drawing.Point(12, 9);
            this.xCoordLbl.Name = "xCoordLbl";
            this.xCoordLbl.Size = new System.Drawing.Size(20, 23);
            this.xCoordLbl.TabIndex = 0;
            this.xCoordLbl.Text = "0";
            this.xCoordLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // yCoordLbl
            // 
            this.yCoordLbl.AutoSize = true;
            this.yCoordLbl.BackColor = System.Drawing.Color.Transparent;
            this.yCoordLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yCoordLbl.Location = new System.Drawing.Point(13, 46);
            this.yCoordLbl.Name = "yCoordLbl";
            this.yCoordLbl.Size = new System.Drawing.Size(20, 23);
            this.yCoordLbl.TabIndex = 1;
            this.yCoordLbl.Text = "0";
            // 
            // targetPB
            // 
            this.targetPB.Image = global::WindowsFormsApplication1.Properties.Resources.pidgeon2;
            this.targetPB.Location = new System.Drawing.Point(406, 128);
            this.targetPB.Name = "targetPB";
            this.targetPB.Size = new System.Drawing.Size(50, 50);
            this.targetPB.TabIndex = 2;
            this.targetPB.TabStop = false;
            this.targetPB.Visible = false;
            // 
            // hitLbl
            // 
            this.hitLbl.AutoSize = true;
            this.hitLbl.Location = new System.Drawing.Point(15, 75);
            this.hitLbl.Name = "hitLbl";
            this.hitLbl.Size = new System.Drawing.Size(0, 13);
            this.hitLbl.TabIndex = 3;
            // 
            // ammoLbl
            // 
            this.ammoLbl.AutoSize = true;
            this.ammoLbl.BackColor = System.Drawing.Color.Transparent;
            this.ammoLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammoLbl.Location = new System.Drawing.Point(696, 9);
            this.ammoLbl.Name = "ammoLbl";
            this.ammoLbl.Size = new System.Drawing.Size(82, 23);
            this.ammoLbl.TabIndex = 4;
            this.ammoLbl.Text = "ammo: 6 ";
            // 
            // hitPercentageLbl
            // 
            this.hitPercentageLbl.AutoSize = true;
            this.hitPercentageLbl.BackColor = System.Drawing.Color.Transparent;
            this.hitPercentageLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitPercentageLbl.Location = new System.Drawing.Point(700, 46);
            this.hitPercentageLbl.Name = "hitPercentageLbl";
            this.hitPercentageLbl.Size = new System.Drawing.Size(62, 23);
            this.hitPercentageLbl.TabIndex = 5;
            this.hitPercentageLbl.Text = "no hits";
            // 
            // hitsLbl
            // 
            this.hitsLbl.AutoSize = true;
            this.hitsLbl.BackColor = System.Drawing.Color.Transparent;
            this.hitsLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitsLbl.Location = new System.Drawing.Point(700, 75);
            this.hitsLbl.Name = "hitsLbl";
            this.hitsLbl.Size = new System.Drawing.Size(62, 23);
            this.hitsLbl.TabIndex = 6;
            this.hitsLbl.Text = "no hits";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.sky;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 398);
            this.Controls.Add(this.hitsLbl);
            this.Controls.Add(this.hitPercentageLbl);
            this.Controls.Add(this.ammoLbl);
            this.Controls.Add(this.hitLbl);
            this.Controls.Add(this.targetPB);
            this.Controls.Add(this.yCoordLbl);
            this.Controls.Add(this.xCoordLbl);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "shootergame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.targetPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label xCoordLbl;
        private System.Windows.Forms.Label yCoordLbl;
        private System.Windows.Forms.PictureBox targetPB;
        private System.Windows.Forms.Label hitLbl;
        private System.Windows.Forms.Label ammoLbl;
        private System.Windows.Forms.Label hitPercentageLbl;
        private System.Windows.Forms.Label hitsLbl;
    }
}

