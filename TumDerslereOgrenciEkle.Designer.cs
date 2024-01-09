namespace YoklamaOtomasyonu
{
    partial class TumDerslereOgrenciEkle
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
            this.OgrenciyiKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.YoneticiParolasi = new System.Windows.Forms.TextBox();
            this.OgrenciNo = new System.Windows.Forms.TextBox();
            this.AdSoyad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OgrenciyiKaydet
            // 
            this.OgrenciyiKaydet.BackColor = System.Drawing.Color.OrangeRed;
            this.OgrenciyiKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OgrenciyiKaydet.Font = new System.Drawing.Font("Tahoma", 15F);
            this.OgrenciyiKaydet.Location = new System.Drawing.Point(115, 247);
            this.OgrenciyiKaydet.Name = "OgrenciyiKaydet";
            this.OgrenciyiKaydet.Size = new System.Drawing.Size(183, 42);
            this.OgrenciyiKaydet.TabIndex = 1;
            this.OgrenciyiKaydet.Text = "Öğrenciyi Kaydet";
            this.OgrenciyiKaydet.UseVisualStyleBackColor = false;
            this.OgrenciyiKaydet.Click += new System.EventHandler(this.OgrenciyiKaydet_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 58);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yönetici Parolası";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "Öğrenci Numarası";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Adı Soyadı ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YoneticiParolasi
            // 
            this.YoneticiParolasi.Font = new System.Drawing.Font("Tahoma", 15F);
            this.YoneticiParolasi.Location = new System.Drawing.Point(115, 167);
            this.YoneticiParolasi.Name = "YoneticiParolasi";
            this.YoneticiParolasi.Size = new System.Drawing.Size(289, 32);
            this.YoneticiParolasi.TabIndex = 8;
            this.YoneticiParolasi.UseSystemPasswordChar = true;
            // 
            // OgrenciNo
            // 
            this.OgrenciNo.Font = new System.Drawing.Font("Tahoma", 15F);
            this.OgrenciNo.Location = new System.Drawing.Point(115, 106);
            this.OgrenciNo.Name = "OgrenciNo";
            this.OgrenciNo.Size = new System.Drawing.Size(289, 32);
            this.OgrenciNo.TabIndex = 7;
            // 
            // AdSoyad
            // 
            this.AdSoyad.Font = new System.Drawing.Font("Tahoma", 15F);
            this.AdSoyad.Location = new System.Drawing.Point(115, 43);
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.Size = new System.Drawing.Size(289, 32);
            this.AdSoyad.TabIndex = 6;
            // 
            // TumDerslereOgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(414, 341);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YoneticiParolasi);
            this.Controls.Add(this.OgrenciNo);
            this.Controls.Add(this.AdSoyad);
            this.Controls.Add(this.OgrenciyiKaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TumDerslereOgrenciEkle";
            this.Text = "TumDerslereOgrenciEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OgrenciyiKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox YoneticiParolasi;
        private System.Windows.Forms.TextBox OgrenciNo;
        private System.Windows.Forms.TextBox AdSoyad;
    }
}