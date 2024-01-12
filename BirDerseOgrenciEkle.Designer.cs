namespace YoklamaOtomasyonu
{
    partial class BirDerseOgrenciEkle
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
            this.Dersler = new System.Windows.Forms.ComboBox();
            this.AdSoyad = new System.Windows.Forms.TextBox();
            this.OgrenciNo = new System.Windows.Forms.TextBox();
            this.GorevliOgretmenParolasi = new System.Windows.Forms.TextBox();
            this.OgrenciyiKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Dersler
            // 
            this.Dersler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dersler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dersler.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Dersler.FormattingEnabled = true;
            this.Dersler.Location = new System.Drawing.Point(113, 22);
            this.Dersler.Name = "Dersler";
            this.Dersler.Size = new System.Drawing.Size(289, 32);
            this.Dersler.TabIndex = 0;
            this.Dersler.SelectedIndexChanged += new System.EventHandler(this.Dersler_SelectedIndexChanged);
            // 
            // AdSoyad
            // 
            this.AdSoyad.Font = new System.Drawing.Font("Tahoma", 15F);
            this.AdSoyad.Location = new System.Drawing.Point(113, 91);
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.Size = new System.Drawing.Size(289, 32);
            this.AdSoyad.TabIndex = 1;
            this.AdSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OgrenciNo
            // 
            this.OgrenciNo.Font = new System.Drawing.Font("Tahoma", 15F);
            this.OgrenciNo.Location = new System.Drawing.Point(113, 155);
            this.OgrenciNo.MaxLength = 9;
            this.OgrenciNo.Name = "OgrenciNo";
            this.OgrenciNo.Size = new System.Drawing.Size(289, 32);
            this.OgrenciNo.TabIndex = 2;
            this.OgrenciNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GorevliOgretmenParolasi
            // 
            this.GorevliOgretmenParolasi.Font = new System.Drawing.Font("Tahoma", 15F);
            this.GorevliOgretmenParolasi.Location = new System.Drawing.Point(113, 229);
            this.GorevliOgretmenParolasi.Name = "GorevliOgretmenParolasi";
            this.GorevliOgretmenParolasi.Size = new System.Drawing.Size(289, 32);
            this.GorevliOgretmenParolasi.TabIndex = 3;
            this.GorevliOgretmenParolasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GorevliOgretmenParolasi.UseSystemPasswordChar = true;
            // 
            // OgrenciyiKaydet
            // 
            this.OgrenciyiKaydet.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.OgrenciyiKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OgrenciyiKaydet.Font = new System.Drawing.Font("Tahoma", 15F);
            this.OgrenciyiKaydet.ForeColor = System.Drawing.Color.White;
            this.OgrenciyiKaydet.Location = new System.Drawing.Point(116, 282);
            this.OgrenciyiKaydet.Name = "OgrenciyiKaydet";
            this.OgrenciyiKaydet.Size = new System.Drawing.Size(171, 47);
            this.OgrenciyiKaydet.TabIndex = 4;
            this.OgrenciyiKaydet.Text = "Öğrenciyi Kaydet";
            this.OgrenciyiKaydet.UseVisualStyleBackColor = false;
            this.OgrenciyiKaydet.Click += new System.EventHandler(this.OgrenciyiKaydet_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 77);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ders Veya Liste";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 58);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adı Soyadı ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 53);
            this.label3.TabIndex = 5;
            this.label3.Text = "Öğrenci Numarası";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 74);
            this.label4.TabIndex = 5;
            this.label4.Text = "Görevli Öğretmen Parolası";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BirDerseOgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(414, 341);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OgrenciyiKaydet);
            this.Controls.Add(this.GorevliOgretmenParolasi);
            this.Controls.Add(this.OgrenciNo);
            this.Controls.Add(this.AdSoyad);
            this.Controls.Add(this.Dersler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BirDerseOgrenciEkle";
            this.Text = "BirDerseOgrenciEkle";
            this.Load += new System.EventHandler(this.BirDerseOgrenciEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OgrenciyiKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox Dersler;
        public System.Windows.Forms.TextBox AdSoyad;
        public System.Windows.Forms.TextBox OgrenciNo;
        public System.Windows.Forms.TextBox GorevliOgretmenParolasi;
    }
}