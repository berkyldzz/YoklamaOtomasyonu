namespace YoklamaOtomasyonu
{
    partial class Dogrulama
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
            this.GeriDon = new System.Windows.Forms.Button();
            this.Parola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ParolaGizle = new System.Windows.Forms.Button();
            this.Kapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GeriDon
            // 
            this.GeriDon.BackColor = System.Drawing.Color.DarkRed;
            this.GeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GeriDon.Font = new System.Drawing.Font("Tahoma", 15F);
            this.GeriDon.Location = new System.Drawing.Point(244, 456);
            this.GeriDon.Name = "GeriDon";
            this.GeriDon.Size = new System.Drawing.Size(129, 54);
            this.GeriDon.TabIndex = 0;
            this.GeriDon.Text = "Geri Dön";
            this.GeriDon.UseVisualStyleBackColor = false;
            this.GeriDon.Click += new System.EventHandler(this.GeriDon_Click);
            // 
            // Parola
            // 
            this.Parola.Font = new System.Drawing.Font("Tahoma", 20F);
            this.Parola.Location = new System.Drawing.Point(158, 375);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(299, 40);
            this.Parola.TabIndex = 1;
            this.Parola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Parola.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(158, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parola";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::YoklamaOtomasyonu.Properties.Resources.human;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(165, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 181);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ParolaGizle
            // 
            this.ParolaGizle.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ParolaGizle.BackgroundImage = global::YoklamaOtomasyonu.Properties.Resources.closeeye;
            this.ParolaGizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ParolaGizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ParolaGizle.Location = new System.Drawing.Point(497, 374);
            this.ParolaGizle.Name = "ParolaGizle";
            this.ParolaGizle.Size = new System.Drawing.Size(44, 41);
            this.ParolaGizle.TabIndex = 17;
            this.ParolaGizle.UseVisualStyleBackColor = false;
            this.ParolaGizle.Click += new System.EventHandler(this.ParolaGizle_Click);
            // 
            // Kapat
            // 
            this.Kapat.BackColor = System.Drawing.Color.Firebrick;
            this.Kapat.FlatAppearance.BorderSize = 0;
            this.Kapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Kapat.ForeColor = System.Drawing.Color.White;
            this.Kapat.Location = new System.Drawing.Point(567, 12);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(50, 50);
            this.Kapat.TabIndex = 18;
            this.Kapat.Text = "X";
            this.Kapat.UseVisualStyleBackColor = false;
            this.Kapat.Click += new System.EventHandler(this.Kapat_Click);
            // 
            // Dogrulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(629, 561);
            this.Controls.Add(this.Kapat);
            this.Controls.Add(this.ParolaGizle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.GeriDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dogrulama";
            this.Text = "Dogrulama";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GeriDon;
        private System.Windows.Forms.TextBox Parola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ParolaGizle;
        private System.Windows.Forms.Button Kapat;
    }
}