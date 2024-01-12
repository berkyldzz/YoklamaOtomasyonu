namespace YoklamaOtomasyonu
{
    partial class OgrenciEkleCikar
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.GeriDon = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TumDerslereEkle = new System.Windows.Forms.RadioButton();
            this.BirDerseEkle = new System.Windows.Forms.RadioButton();
            this.TumDerslerdenCikar = new System.Windows.Forms.RadioButton();
            this.BirDerstenCikar = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // GeriDon
            // 
            this.GeriDon.BackColor = System.Drawing.Color.Crimson;
            this.GeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GeriDon.Font = new System.Drawing.Font("Tahoma", 15F);
            this.GeriDon.ForeColor = System.Drawing.Color.White;
            this.GeriDon.Location = new System.Drawing.Point(128, 483);
            this.GeriDon.Name = "GeriDon";
            this.GeriDon.Size = new System.Drawing.Size(171, 47);
            this.GeriDon.TabIndex = 0;
            this.GeriDon.Text = "Geri Dön";
            this.GeriDon.UseVisualStyleBackColor = false;
            this.GeriDon.Click += new System.EventHandler(this.GeriDon_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.DarkCyan;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(436, 561);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Location = new System.Drawing.Point(12, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 341);
            this.panel1.TabIndex = 3;
            // 
            // TumDerslereEkle
            // 
            this.TumDerslereEkle.AutoSize = true;
            this.TumDerslereEkle.BackColor = System.Drawing.Color.DarkCyan;
            this.TumDerslereEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TumDerslereEkle.ForeColor = System.Drawing.Color.White;
            this.TumDerslereEkle.Location = new System.Drawing.Point(12, 30);
            this.TumDerslereEkle.Name = "TumDerslereEkle";
            this.TumDerslereEkle.Size = new System.Drawing.Size(173, 19);
            this.TumDerslereEkle.TabIndex = 4;
            this.TumDerslereEkle.TabStop = true;
            this.TumDerslereEkle.Text = "Tüm Derslere Öğrenci Ekle";
            this.TumDerslereEkle.UseVisualStyleBackColor = false;
            this.TumDerslereEkle.CheckedChanged += new System.EventHandler(this.TumDerslereEkle_CheckedChanged);
            // 
            // BirDerseEkle
            // 
            this.BirDerseEkle.AutoSize = true;
            this.BirDerseEkle.BackColor = System.Drawing.Color.DarkCyan;
            this.BirDerseEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BirDerseEkle.ForeColor = System.Drawing.Color.White;
            this.BirDerseEkle.Location = new System.Drawing.Point(229, 30);
            this.BirDerseEkle.Name = "BirDerseEkle";
            this.BirDerseEkle.Size = new System.Drawing.Size(183, 19);
            this.BirDerseEkle.TabIndex = 4;
            this.BirDerseEkle.TabStop = true;
            this.BirDerseEkle.Text = "Belirli Bir Derse Öğrenci Ekle";
            this.BirDerseEkle.UseVisualStyleBackColor = false;
            this.BirDerseEkle.CheckedChanged += new System.EventHandler(this.BirDerseEkle_CheckedChanged);
            // 
            // TumDerslerdenCikar
            // 
            this.TumDerslerdenCikar.AutoSize = true;
            this.TumDerslerdenCikar.BackColor = System.Drawing.Color.DarkCyan;
            this.TumDerslerdenCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TumDerslerdenCikar.ForeColor = System.Drawing.Color.White;
            this.TumDerslerdenCikar.Location = new System.Drawing.Point(12, 63);
            this.TumDerslerdenCikar.Name = "TumDerslerdenCikar";
            this.TumDerslerdenCikar.Size = new System.Drawing.Size(191, 19);
            this.TumDerslerdenCikar.TabIndex = 4;
            this.TumDerslerdenCikar.TabStop = true;
            this.TumDerslerdenCikar.Text = "Tüm Derslerden Öğrenci Çıkar";
            this.TumDerslerdenCikar.UseVisualStyleBackColor = false;
            this.TumDerslerdenCikar.CheckedChanged += new System.EventHandler(this.TumDerslerdenCikar_CheckedChanged);
            // 
            // BirDerstenCikar
            // 
            this.BirDerstenCikar.AutoSize = true;
            this.BirDerstenCikar.BackColor = System.Drawing.Color.DarkCyan;
            this.BirDerstenCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BirDerstenCikar.ForeColor = System.Drawing.Color.White;
            this.BirDerstenCikar.Location = new System.Drawing.Point(229, 63);
            this.BirDerstenCikar.Name = "BirDerstenCikar";
            this.BirDerstenCikar.Size = new System.Drawing.Size(197, 19);
            this.BirDerstenCikar.TabIndex = 4;
            this.BirDerstenCikar.TabStop = true;
            this.BirDerstenCikar.Text = "Belirli Bir Dersten Öğrenci Çıkar";
            this.BirDerstenCikar.UseVisualStyleBackColor = false;
            this.BirDerstenCikar.CheckedChanged += new System.EventHandler(this.BirDerstenCikar_CheckedChanged);
            // 
            // OgrenciEkleCikar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.BirDerstenCikar);
            this.Controls.Add(this.BirDerseEkle);
            this.Controls.Add(this.TumDerslerdenCikar);
            this.Controls.Add(this.TumDerslereEkle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GeriDon);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgrenciEkleCikar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GeriDon;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton TumDerslereEkle;
        private System.Windows.Forms.RadioButton BirDerseEkle;
        private System.Windows.Forms.RadioButton TumDerslerdenCikar;
        private System.Windows.Forms.RadioButton BirDerstenCikar;
    }
}
