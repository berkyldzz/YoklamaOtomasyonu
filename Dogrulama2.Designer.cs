namespace YoklamaOtomasyonu
{
    partial class Dogrulama2
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
            this.Kapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Parola = new System.Windows.Forms.TextBox();
            this.GeriDon = new System.Windows.Forms.Button();
            this.ParolaGizle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Kapat
            // 
            this.Kapat.BackColor = System.Drawing.Color.Firebrick;
            this.Kapat.FlatAppearance.BorderSize = 0;
            this.Kapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Kapat.ForeColor = System.Drawing.Color.White;
            this.Kapat.Location = new System.Drawing.Point(563, 11);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(50, 50);
            this.Kapat.TabIndex = 24;
            this.Kapat.Text = "X";
            this.Kapat.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 61);
            this.label1.TabIndex = 21;
            this.label1.Text = "Parola";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Parola
            // 
            this.Parola.Font = new System.Drawing.Font("Tahoma", 20F);
            this.Parola.Location = new System.Drawing.Point(154, 374);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(299, 40);
            this.Parola.TabIndex = 20;
            this.Parola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Parola.UseSystemPasswordChar = true;
            // 
            // GeriDon
            // 
            this.GeriDon.BackColor = System.Drawing.Color.DarkRed;
            this.GeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GeriDon.Font = new System.Drawing.Font("Tahoma", 15F);
            this.GeriDon.ForeColor = System.Drawing.Color.White;
            this.GeriDon.Location = new System.Drawing.Point(240, 455);
            this.GeriDon.Name = "GeriDon";
            this.GeriDon.Size = new System.Drawing.Size(129, 63);
            this.GeriDon.TabIndex = 19;
            this.GeriDon.Text = "Yoklamayı Bitir";
            this.GeriDon.UseVisualStyleBackColor = false;
            this.GeriDon.Click += new System.EventHandler(this.GeriDon_Click);
            // 
            // ParolaGizle
            // 
            this.ParolaGizle.BackColor = System.Drawing.Color.DarkGray;
            this.ParolaGizle.BackgroundImage = global::YoklamaOtomasyonu.Properties.Resources.closeeye;
            this.ParolaGizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ParolaGizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ParolaGizle.Location = new System.Drawing.Point(493, 373);
            this.ParolaGizle.Name = "ParolaGizle";
            this.ParolaGizle.Size = new System.Drawing.Size(44, 41);
            this.ParolaGizle.TabIndex = 23;
            this.ParolaGizle.UseVisualStyleBackColor = false;
            this.ParolaGizle.Click += new System.EventHandler(this.ParolaGizle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::YoklamaOtomasyonu.Properties.Resources.human;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(161, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 181);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Dogrulama2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(629, 561);
            this.Controls.Add(this.Kapat);
            this.Controls.Add(this.ParolaGizle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.GeriDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dogrulama2";
            this.Text = "Dogrulama2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kapat;
        private System.Windows.Forms.Button ParolaGizle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Parola;
        private System.Windows.Forms.Button GeriDon;
    }
}