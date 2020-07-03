namespace PuzzleGame
{
    partial class StartWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.lvl1 = new System.Windows.Forms.Button();
            this.lvl2 = new System.Windows.Forms.Button();
            this.lvl3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(271, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose your level:";
            // 
            // lvl1
            // 
            this.lvl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvl1.Location = new System.Drawing.Point(313, 129);
            this.lvl1.Name = "lvl1";
            this.lvl1.Size = new System.Drawing.Size(203, 40);
            this.lvl1.TabIndex = 2;
            this.lvl1.Text = "Easy";
            this.lvl1.UseVisualStyleBackColor = true;
            this.lvl1.Click += new System.EventHandler(this.lvl1_Click);
            // 
            // lvl2
            // 
            this.lvl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvl2.Location = new System.Drawing.Point(282, 175);
            this.lvl2.Name = "lvl2";
            this.lvl2.Size = new System.Drawing.Size(267, 40);
            this.lvl2.TabIndex = 3;
            this.lvl2.Text = "Medium";
            this.lvl2.UseVisualStyleBackColor = true;
            this.lvl2.Click += new System.EventHandler(this.lvl2_Click);
            // 
            // lvl3
            // 
            this.lvl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvl3.Location = new System.Drawing.Point(248, 221);
            this.lvl3.Name = "lvl3";
            this.lvl3.Size = new System.Drawing.Size(338, 39);
            this.lvl3.TabIndex = 4;
            this.lvl3.Text = "Hard";
            this.lvl3.UseVisualStyleBackColor = true;
            this.lvl3.Click += new System.EventHandler(this.lvl3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(31, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 303);
            this.Controls.Add(this.lvl3);
            this.Controls.Add(this.lvl2);
            this.Controls.Add(this.lvl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(645, 342);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(645, 342);
            this.Name = "StartWindow";
            this.Text = "Start Window";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lvl1;
        private System.Windows.Forms.Button lvl2;
        private System.Windows.Forms.Button lvl3;
    }
}