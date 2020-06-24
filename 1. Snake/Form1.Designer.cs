namespace Snake
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highscoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.field = new System.Windows.Forms.Panel();
            this.awsdLbl = new System.Windows.Forms.Label();
            this.awsdPic = new System.Windows.Forms.PictureBox();
            this.startLbl = new System.Windows.Forms.Label();
            this.helloLbl = new System.Windows.Forms.Label();
            this.snakePic = new System.Windows.Forms.PictureBox();
            this.createdByLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.currentScoreLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.field.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.awsdPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakePic)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolStripMenuItem,
            this.renewGameToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.highscoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(471, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Enabled = false;
            this.pauseToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // renewGameToolStripMenuItem
            // 
            this.renewGameToolStripMenuItem.Enabled = false;
            this.renewGameToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.renewGameToolStripMenuItem.Name = "renewGameToolStripMenuItem";
            this.renewGameToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.renewGameToolStripMenuItem.Text = "Renew game";
            this.renewGameToolStripMenuItem.Click += new System.EventHandler(this.renewGameToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Enabled = false;
            this.statisticsToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // highscoresToolStripMenuItem
            // 
            this.highscoresToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.highscoresToolStripMenuItem.Name = "highscoresToolStripMenuItem";
            this.highscoresToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.highscoresToolStripMenuItem.Text = "Highscores";
            this.highscoresToolStripMenuItem.Click += new System.EventHandler(this.highscoresToolStripMenuItem_Click);
            // 
            // field
            // 
            this.field.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.field.Controls.Add(this.awsdLbl);
            this.field.Controls.Add(this.awsdPic);
            this.field.Controls.Add(this.startLbl);
            this.field.Controls.Add(this.helloLbl);
            this.field.Controls.Add(this.snakePic);
            this.field.Location = new System.Drawing.Point(12, 27);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(444, 416);
            this.field.TabIndex = 2;
            this.field.Paint += new System.Windows.Forms.PaintEventHandler(this.field_Paint);
            // 
            // awsdLbl
            // 
            this.awsdLbl.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.awsdLbl.Location = new System.Drawing.Point(3, 301);
            this.awsdLbl.Name = "awsdLbl";
            this.awsdLbl.Size = new System.Drawing.Size(134, 21);
            this.awsdLbl.TabIndex = 4;
            this.awsdLbl.Text = "Use me V";
            this.awsdLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // awsdPic
            // 
            this.awsdPic.Image = global::Snake.Properties.Resources.awsd1;
            this.awsdPic.Location = new System.Drawing.Point(3, 313);
            this.awsdPic.Name = "awsdPic";
            this.awsdPic.Size = new System.Drawing.Size(134, 103);
            this.awsdPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.awsdPic.TabIndex = 3;
            this.awsdPic.TabStop = false;
            // 
            // startLbl
            // 
            this.startLbl.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startLbl.ForeColor = System.Drawing.Color.Maroon;
            this.startLbl.Location = new System.Drawing.Point(95, 322);
            this.startLbl.Name = "startLbl";
            this.startLbl.Size = new System.Drawing.Size(262, 43);
            this.startLbl.TabIndex = 3;
            this.startLbl.Text = "START";
            this.startLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startLbl.Click += new System.EventHandler(this.startLabel_Click);
            this.startLbl.MouseEnter += new System.EventHandler(this.startLabel_MouseEnter);
            this.startLbl.MouseLeave += new System.EventHandler(this.startLabel_MouseLeave);
            // 
            // helloLbl
            // 
            this.helloLbl.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helloLbl.Location = new System.Drawing.Point(95, 283);
            this.helloLbl.Name = "helloLbl";
            this.helloLbl.Size = new System.Drawing.Size(262, 39);
            this.helloLbl.TabIndex = 1;
            this.helloLbl.Text = "SNAKE GAME";
            this.helloLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // snakePic
            // 
            this.snakePic.Image = global::Snake.Properties.Resources.Snake_icon;
            this.snakePic.Location = new System.Drawing.Point(95, 36);
            this.snakePic.Name = "snakePic";
            this.snakePic.Size = new System.Drawing.Size(262, 244);
            this.snakePic.TabIndex = 0;
            this.snakePic.TabStop = false;
            // 
            // createdByLbl
            // 
            this.createdByLbl.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createdByLbl.Location = new System.Drawing.Point(236, 446);
            this.createdByLbl.Name = "createdByLbl";
            this.createdByLbl.Size = new System.Drawing.Size(220, 27);
            this.createdByLbl.TabIndex = 2;
            this.createdByLbl.Text = "Created by: Dziobex (Dziobax1)";
            this.createdByLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.nextMovements);
            // 
            // currentScoreLbl
            // 
            this.currentScoreLbl.AutoSize = true;
            this.currentScoreLbl.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentScoreLbl.Location = new System.Drawing.Point(12, 452);
            this.currentScoreLbl.Name = "currentScoreLbl";
            this.currentScoreLbl.Size = new System.Drawing.Size(136, 16);
            this.currentScoreLbl.TabIndex = 3;
            this.currentScoreLbl.Text = "Current score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 474);
            this.Controls.Add(this.currentScoreLbl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.createdByLbl);
            this.Controls.Add(this.field);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(487, 513);
            this.MinimumSize = new System.Drawing.Size(487, 513);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.field.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.awsdPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highscoresToolStripMenuItem;
        private System.Windows.Forms.Panel field;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox snakePic;
        private System.Windows.Forms.Label createdByLbl;
        private System.Windows.Forms.Label helloLbl;
        private System.Windows.Forms.Label startLbl;
        private System.Windows.Forms.PictureBox awsdPic;
        private System.Windows.Forms.Label awsdLbl;
        private System.Windows.Forms.Label currentScoreLbl;
    }
}

