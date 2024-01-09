namespace YoklamaOtomasyonu
{
    partial class BirDerstenOgrenciCikar
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OgrenciyiKaydet = new System.Windows.Forms.Button();
            this.GorevliOgretmenParolasi = new System.Windows.Forms.TextBox();
            this.OgrenciNo = new System.Windows.Forms.TextBox();
            this.Dersler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 58);
            this.label4.TabIndex = 11;
            this.label4.Text = "Görevli Öğretmen Parolası";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 42);
            this.label3.TabIndex = 12;
            this.label3.Text = "Öğrenci Numarası";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ders ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OgrenciyiKaydet
            // 
            this.OgrenciyiKaydet.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.OgrenciyiKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OgrenciyiKaydet.Font = new System.Drawing.Font("Tahoma", 15F);
            this.OgrenciyiKaydet.ForeColor = System.Drawing.Color.White;
            this.OgrenciyiKaydet.Location = new System.Drawing.Point(123, 277);
            this.OgrenciyiKaydet.Name = "OgrenciyiKaydet";
            this.OgrenciyiKaydet.Size = new System.Drawing.Size(171, 47);
            this.OgrenciyiKaydet.TabIndex = 10;
            this.OgrenciyiKaydet.Text = "Öğrenciyi Sil";
            this.OgrenciyiKaydet.UseVisualStyleBackColor = false;
            this.OgrenciyiKaydet.Click += new System.EventHandler(this.OgrenciyiSil_Click);
            // 
            // GorevliOgretmenParolasi
            // 
            this.GorevliOgretmenParolasi.Font = new System.Drawing.Font("Tahoma", 15F);
            this.GorevliOgretmenParolasi.Location = new System.Drawing.Point(113, 203);
            this.GorevliOgretmenParolasi.Name = "GorevliOgretmenParolasi";
            this.GorevliOgretmenParolasi.Size = new System.Drawing.Size(289, 32);
            this.GorevliOgretmenParolasi.TabIndex = 9;
            this.GorevliOgretmenParolasi.UseSystemPasswordChar = true;
            // 
            // OgrenciNo
            // 
            this.OgrenciNo.Font = new System.Drawing.Font("Tahoma", 15F);
            this.OgrenciNo.Location = new System.Drawing.Point(113, 116);
            this.OgrenciNo.Name = "OgrenciNo";
            this.OgrenciNo.Size = new System.Drawing.Size(289, 32);
            this.OgrenciNo.TabIndex = 8;
            // 
            // Dersler
            // 
            this.Dersler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dersler.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Dersler.FormattingEnabled = true;
            this.Dersler.Location = new System.Drawing.Point(113, 32);
            this.Dersler.Name = "Dersler";
            this.Dersler.Size = new System.Drawing.Size(289, 32);
            this.Dersler.TabIndex = 6;
            // 
            // BirDerstenOgrenciCikar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(414, 341);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OgrenciyiKaydet);
            this.Controls.Add(this.GorevliOgretmenParolasi);
            this.Controls.Add(this.OgrenciNo);
            this.Controls.Add(this.Dersler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BirDerstenOgrenciCikar";
            this.Text = "BirDerstenOgrenciCikar";
            this.Load += new System.EventHandler(this.BirDerstenOgrenciCikar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OgrenciyiKaydet;
        private System.Windows.Forms.TextBox GorevliOgretmenParolasi;
        private System.Windows.Forms.TextBox OgrenciNo;
        private System.Windows.Forms.ComboBox Dersler;
    }
}