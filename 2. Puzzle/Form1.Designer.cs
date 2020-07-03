namespace PuzzleGame
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
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.startGameBtn = new System.Windows.Forms.Button();
            this.renewGameBtn = new System.Windows.Forms.Button();
            this.timersText = new System.Windows.Forms.TextBox();
            this.placeForPuzzles = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.placeForPuzzles)).BeginInit();
            this.SuspendLayout();
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(57, 42);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(122, 122);
            this.n1.TabIndex = 0;
            this.n1.UseVisualStyleBackColor = true;
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(185, 42);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(122, 122);
            this.n2.TabIndex = 1;
            this.n2.UseVisualStyleBackColor = true;
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(313, 42);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(122, 122);
            this.n3.TabIndex = 2;
            this.n3.UseVisualStyleBackColor = true;
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(57, 170);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(122, 122);
            this.n4.TabIndex = 3;
            this.n4.UseVisualStyleBackColor = true;
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(185, 170);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(122, 122);
            this.n5.TabIndex = 4;
            this.n5.UseVisualStyleBackColor = true;
            // 
            // n6
            // 
            this.n6.Location = new System.Drawing.Point(313, 170);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(122, 122);
            this.n6.TabIndex = 5;
            this.n6.UseVisualStyleBackColor = true;
            // 
            // n7
            // 
            this.n7.Location = new System.Drawing.Point(57, 298);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(122, 122);
            this.n7.TabIndex = 6;
            this.n7.UseVisualStyleBackColor = true;
            // 
            // n8
            // 
            this.n8.Location = new System.Drawing.Point(185, 298);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(122, 122);
            this.n8.TabIndex = 7;
            this.n8.UseVisualStyleBackColor = true;
            // 
            // n9
            // 
            this.n9.Location = new System.Drawing.Point(313, 298);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(122, 122);
            this.n9.TabIndex = 8;
            this.n9.UseVisualStyleBackColor = true;
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // startGameBtn
            // 
            this.startGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startGameBtn.Location = new System.Drawing.Point(483, 23);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(203, 35);
            this.startGameBtn.TabIndex = 9;
            this.startGameBtn.Text = "Start Game";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // renewGameBtn
            // 
            this.renewGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.renewGameBtn.Location = new System.Drawing.Point(483, 64);
            this.renewGameBtn.Name = "renewGameBtn";
            this.renewGameBtn.Size = new System.Drawing.Size(203, 35);
            this.renewGameBtn.TabIndex = 10;
            this.renewGameBtn.Text = "Renew Game";
            this.renewGameBtn.UseVisualStyleBackColor = true;
            this.renewGameBtn.Visible = false;
            this.renewGameBtn.Click += new System.EventHandler(this.renewGameBtn_Click);
            // 
            // timersText
            // 
            this.timersText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timersText.Location = new System.Drawing.Point(71, 434);
            this.timersText.Multiline = true;
            this.timersText.Name = "timersText";
            this.timersText.ReadOnly = true;
            this.timersText.Size = new System.Drawing.Size(347, 50);
            this.timersText.TabIndex = 13;
            this.timersText.TabStop = false;
            this.timersText.Text = "Time: 0 sec";
            this.timersText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // placeForPuzzles
            // 
            this.placeForPuzzles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.placeForPuzzles.Location = new System.Drawing.Point(483, 116);
            this.placeForPuzzles.Name = "placeForPuzzles";
            this.placeForPuzzles.Size = new System.Drawing.Size(203, 368);
            this.placeForPuzzles.TabIndex = 11;
            this.placeForPuzzles.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 508);
            this.Controls.Add(this.timersText);
            this.Controls.Add(this.placeForPuzzles);
            this.Controls.Add(this.renewGameBtn);
            this.Controls.Add(this.startGameBtn);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(735, 547);
            this.MinimumSize = new System.Drawing.Size(735, 547);
            this.Name = "Form1";
            this.Text = "Puzzle Game — LEVEL1";
            ((System.ComponentModel.ISupportInitialize)(this.placeForPuzzles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Button renewGameBtn;
        private System.Windows.Forms.PictureBox placeForPuzzles;
        private System.Windows.Forms.TextBox timersText;
    }
}

