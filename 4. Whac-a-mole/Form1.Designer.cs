namespace HitTheMolev2._0
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.timesShown = new System.Windows.Forms.Label();
            this.boomImg = new System.Windows.Forms.PictureBox();
            this.moleControl7 = new HitTheMolev2._0.MoleControl();
            this.moleControl6 = new HitTheMolev2._0.MoleControl();
            this.moleControl5 = new HitTheMolev2._0.MoleControl();
            this.moleControl4 = new HitTheMolev2._0.MoleControl();
            this.moleControl3 = new HitTheMolev2._0.MoleControl();
            this.moleControl2 = new HitTheMolev2._0.MoleControl();
            this.moleControl1 = new HitTheMolev2._0.MoleControl();
            ((System.ComponentModel.ISupportInitialize)(this.boomImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moleControl7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moleControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moleControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moleControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moleControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moleControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moleControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 1400;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score.Location = new System.Drawing.Point(571, 339);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(115, 43);
            this.score.TabIndex = 7;
            this.score.Text = "Score: 0";
            // 
            // timesShown
            // 
            this.timesShown.AutoSize = true;
            this.timesShown.BackColor = System.Drawing.Color.Transparent;
            this.timesShown.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timesShown.Location = new System.Drawing.Point(12, 9);
            this.timesShown.Name = "timesShown";
            this.timesShown.Size = new System.Drawing.Size(97, 18);
            this.timesShown.TabIndex = 8;
            this.timesShown.Text = "Times shown: 0";
            // 
            // boomImg
            // 
            this.boomImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.boomImg.Image = global::HitTheMolev2._0.Properties.Resources.boom;
            this.boomImg.Location = new System.Drawing.Point(86, 93);
            this.boomImg.Name = "boomImg";
            this.boomImg.Size = new System.Drawing.Size(57, 45);
            this.boomImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boomImg.TabIndex = 9;
            this.boomImg.TabStop = false;
            this.boomImg.Visible = false;
            // 
            // moleControl7
            // 
            this.moleControl7.BackColor = System.Drawing.Color.Transparent;
            this.moleControl7.CurrentMole = false;
            this.moleControl7.Image = ((System.Drawing.Image)(resources.GetObject("moleControl7.Image")));
            this.moleControl7.Location = new System.Drawing.Point(479, 204);
            this.moleControl7.Name = "moleControl7";
            this.moleControl7.Size = new System.Drawing.Size(140, 130);
            this.moleControl7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moleControl7.TabIndex = 6;
            this.moleControl7.TabStop = false;
            this.moleControl7.Click += new System.EventHandler(this.mole_Smacked);
            // 
            // moleControl6
            // 
            this.moleControl6.BackColor = System.Drawing.Color.Transparent;
            this.moleControl6.CurrentMole = false;
            this.moleControl6.Image = ((System.Drawing.Image)(resources.GetObject("moleControl6.Image")));
            this.moleControl6.Location = new System.Drawing.Point(302, 204);
            this.moleControl6.Name = "moleControl6";
            this.moleControl6.Size = new System.Drawing.Size(140, 130);
            this.moleControl6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moleControl6.TabIndex = 5;
            this.moleControl6.TabStop = false;
            this.moleControl6.Click += new System.EventHandler(this.mole_Smacked);
            // 
            // moleControl5
            // 
            this.moleControl5.BackColor = System.Drawing.Color.Transparent;
            this.moleControl5.CurrentMole = false;
            this.moleControl5.Image = ((System.Drawing.Image)(resources.GetObject("moleControl5.Image")));
            this.moleControl5.Location = new System.Drawing.Point(120, 204);
            this.moleControl5.Name = "moleControl5";
            this.moleControl5.Size = new System.Drawing.Size(140, 130);
            this.moleControl5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moleControl5.TabIndex = 4;
            this.moleControl5.TabStop = false;
            this.moleControl5.Click += new System.EventHandler(this.mole_Smacked);
            // 
            // moleControl4
            // 
            this.moleControl4.BackColor = System.Drawing.Color.Transparent;
            this.moleControl4.CurrentMole = false;
            this.moleControl4.Image = ((System.Drawing.Image)(resources.GetObject("moleControl4.Image")));
            this.moleControl4.Location = new System.Drawing.Point(559, 53);
            this.moleControl4.Name = "moleControl4";
            this.moleControl4.Size = new System.Drawing.Size(140, 130);
            this.moleControl4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moleControl4.TabIndex = 3;
            this.moleControl4.TabStop = false;
            this.moleControl4.Click += new System.EventHandler(this.mole_Smacked);
            // 
            // moleControl3
            // 
            this.moleControl3.BackColor = System.Drawing.Color.Transparent;
            this.moleControl3.CurrentMole = false;
            this.moleControl3.Image = ((System.Drawing.Image)(resources.GetObject("moleControl3.Image")));
            this.moleControl3.Location = new System.Drawing.Point(392, 53);
            this.moleControl3.Name = "moleControl3";
            this.moleControl3.Size = new System.Drawing.Size(140, 130);
            this.moleControl3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moleControl3.TabIndex = 2;
            this.moleControl3.TabStop = false;
            this.moleControl3.Click += new System.EventHandler(this.mole_Smacked);
            // 
            // moleControl2
            // 
            this.moleControl2.BackColor = System.Drawing.Color.Transparent;
            this.moleControl2.CurrentMole = false;
            this.moleControl2.Image = ((System.Drawing.Image)(resources.GetObject("moleControl2.Image")));
            this.moleControl2.Location = new System.Drawing.Point(223, 53);
            this.moleControl2.Name = "moleControl2";
            this.moleControl2.Size = new System.Drawing.Size(140, 130);
            this.moleControl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moleControl2.TabIndex = 1;
            this.moleControl2.TabStop = false;
            this.moleControl2.Click += new System.EventHandler(this.mole_Smacked);
            // 
            // moleControl1
            // 
            this.moleControl1.BackColor = System.Drawing.Color.Transparent;
            this.moleControl1.CurrentMole = false;
            this.moleControl1.Image = ((System.Drawing.Image)(resources.GetObject("moleControl1.Image")));
            this.moleControl1.Location = new System.Drawing.Point(52, 53);
            this.moleControl1.Name = "moleControl1";
            this.moleControl1.Size = new System.Drawing.Size(140, 130);
            this.moleControl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moleControl1.TabIndex = 0;
            this.moleControl1.TabStop = false;
            this.moleControl1.Click += new System.EventHandler(this.mole_Smacked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HitTheMolev2._0.Properties.Resources.background_scene___drawing;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 391);
            this.Controls.Add(this.boomImg);
            this.Controls.Add(this.timesShown);
            this.Controls.Add(this.score);
            this.Controls.Add(this.moleControl7);
            this.Controls.Add(this.moleControl6);
            this.Controls.Add(this.moleControl5);
            this.Controls.Add(this.moleControl4);
            this.Controls.Add(this.moleControl3);
            this.Controls.Add(this.moleControl2);
            this.Controls.Add(this.moleControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(765, 430);
            this.MinimumSize = new System.Drawing.Size(765, 430);
            this.Name = "Form1";
            this.Text = "Whac-a-mole";
            ((System.ComponentModel.ISupportInitialize)(this.boomImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moleControl7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moleControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moleControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moleControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moleControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moleControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moleControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer mainTimer;
        private MoleControl moleControl1;
        private MoleControl moleControl2;
        private MoleControl moleControl3;
        private MoleControl moleControl4;
        private MoleControl moleControl5;
        private MoleControl moleControl6;
        private MoleControl moleControl7;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label timesShown;
        private System.Windows.Forms.PictureBox boomImg;
    }
}

