namespace Pac_Man
{
    partial class WelcomeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.startLbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.infoLbl = new System.Windows.Forms.Label();
            this.awsdPic = new System.Windows.Forms.PictureBox();
            this.useLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awsdPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(466, 669);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Made by: Dziobax1 (dziobex)";
            // 
            // startLbl
            // 
            this.startLbl.AutoSize = true;
            this.startLbl.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.startLbl.Location = new System.Drawing.Point(308, 263);
            this.startLbl.Name = "startLbl";
            this.startLbl.Size = new System.Drawing.Size(128, 56);
            this.startLbl.TabIndex = 2;
            this.startLbl.Text = "Play";
            this.startLbl.Click += new System.EventHandler(this.startLbl_Click);
            this.startLbl.MouseLeave += new System.EventHandler(this.startLbl_MouseLeave);
            this.startLbl.MouseHover += new System.EventHandler(this.startLbl_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pac_Man.Properties.Resources.pacman_gif;
            this.pictureBox2.Location = new System.Drawing.Point(207, 420);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(311, 189);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pac_Man.Properties.Resources.pacman_logo;
            this.pictureBox1.Location = new System.Drawing.Point(52, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(641, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.infoLbl.Location = new System.Drawing.Point(167, 335);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(414, 56);
            this.infoLbl.TabIndex = 3;
            this.infoLbl.Text = "How can I play?";
            this.infoLbl.Click += new System.EventHandler(this.infoLbl_Click);
            this.infoLbl.MouseLeave += new System.EventHandler(this.infoLbl_MouseLeave);
            this.infoLbl.MouseHover += new System.EventHandler(this.infoLbl_MouseHover);
            // 
            // awsdPic
            // 
            this.awsdPic.Image = global::Pac_Man.Properties.Resources.awsd;
            this.awsdPic.Location = new System.Drawing.Point(39, 451);
            this.awsdPic.Name = "awsdPic";
            this.awsdPic.Size = new System.Drawing.Size(123, 100);
            this.awsdPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.awsdPic.TabIndex = 5;
            this.awsdPic.TabStop = false;
            this.awsdPic.Visible = false;
            // 
            // useLbl
            // 
            this.useLbl.AutoSize = true;
            this.useLbl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.useLbl.ForeColor = System.Drawing.Color.White;
            this.useLbl.Location = new System.Drawing.Point(54, 554);
            this.useLbl.Name = "useLbl";
            this.useLbl.Size = new System.Drawing.Size(108, 19);
            this.useLbl.TabIndex = 6;
            this.useLbl.Text = "^ use us :]";
            this.useLbl.Visible = false;
            // 
            // WelcomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(730, 702);
            this.Controls.Add(this.useLbl);
            this.Controls.Add(this.awsdPic);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.startLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(746, 741);
            this.MinimumSize = new System.Drawing.Size(746, 741);
            this.Name = "WelcomeWindow";
            this.Text = "Welcome!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awsdPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label startLbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.PictureBox awsdPic;
        private System.Windows.Forms.Label useLbl;
    }
}