namespace YoklamaOtomasyonu
{
    partial class TumDerslerdenCikar
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
            this.YoneticiParolasi = new System.Windows.Forms.TextBox();
            this.OgrenciNo = new System.Windows.Forms.TextBox();
            this.OgrenciyiSil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // YoneticiParolasi
            // 
            this.YoneticiParolasi.Font = new System.Drawing.Font("Tahoma", 15F);
            this.YoneticiParolasi.Location = new System.Drawing.Point(113, 157);
            this.YoneticiParolasi.Name = "YoneticiParolasi";
            this.YoneticiParolasi.Size = new System.Drawing.Size(289, 32);
            this.YoneticiParolasi.TabIndex = 11;
            this.YoneticiParolasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.YoneticiParolasi.UseSystemPasswordChar = true;
            // 
            // OgrenciNo
            // 
            this.OgrenciNo.Font = new System.Drawing.Font("Tahoma", 15F);
            this.OgrenciNo.Location = new System.Drawing.Point(113, 59);
            this.OgrenciNo.MaxLength = 9;
            this.OgrenciNo.Name = "OgrenciNo";
            this.OgrenciNo.Size = new System.Drawing.Size(289, 32);
            this.OgrenciNo.TabIndex = 10;
            this.OgrenciNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OgrenciyiSil
            // 
            this.OgrenciyiSil.BackColor = System.Drawing.Color.OrangeRed;
            this.OgrenciyiSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OgrenciyiSil.Font = new System.Drawing.Font("Tahoma", 15F);
            this.OgrenciyiSil.Location = new System.Drawing.Point(116, 255);
            this.OgrenciyiSil.Name = "OgrenciyiSil";
            this.OgrenciyiSil.Size = new System.Drawing.Size(171, 47);
            this.OgrenciyiSil.TabIndex = 9;
            this.OgrenciyiSil.Text = "Öğrenciyi Sil";
            this.OgrenciyiSil.UseVisualStyleBackColor = false;
            this.OgrenciyiSil.Click += new System.EventHandler(this.OgrenciyiSil_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 58);
            this.label4.TabIndex = 12;
            this.label4.Text = "Yönetici Parolası";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 53);
            this.label3.TabIndex = 13;
            this.label3.Text = "Öğrenci Numarası";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TumDerslerdenCikar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(414, 341);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YoneticiParolasi);
            this.Controls.Add(this.OgrenciNo);
            this.Controls.Add(this.OgrenciyiSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TumDerslerdenCikar";
            this.Text = "TumDerslerdenCikar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OgrenciyiSil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox YoneticiParolasi;
        public System.Windows.Forms.TextBox OgrenciNo;
    }
}