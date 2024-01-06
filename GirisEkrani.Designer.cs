namespace YoklamaOtomasyonu
{
    partial class GirisEkrani
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Parola = new System.Windows.Forms.TextBox();
            this.GirisYap = new System.Windows.Forms.Button();
            this.Dersler = new System.Windows.Forms.ComboBox();
            this.SifreYenile = new System.Windows.Forms.Button();
            this.YeniDers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.YoklamaDurumu = new System.Windows.Forms.Button();
            this.parolasett = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Parola
            // 
            this.Parola.BackColor = System.Drawing.Color.SeaShell;
            this.Parola.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Parola.Location = new System.Drawing.Point(100, 309);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(311, 32);
            this.Parola.TabIndex = 1;
            this.Parola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Parola.UseSystemPasswordChar = true;
            // 
            // GirisYap
            // 
            this.GirisYap.BackColor = System.Drawing.Color.Green;
            this.GirisYap.ForeColor = System.Drawing.Color.White;
            this.GirisYap.Location = new System.Drawing.Point(100, 371);
            this.GirisYap.Name = "GirisYap";
            this.GirisYap.Size = new System.Drawing.Size(311, 61);
            this.GirisYap.TabIndex = 2;
            this.GirisYap.Text = "Yoklamayı Başlat";
            this.GirisYap.UseVisualStyleBackColor = false;
            this.GirisYap.Click += new System.EventHandler(this.GirisYap_Click);
            // 
            // Dersler
            // 
            this.Dersler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dersler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dersler.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Dersler.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Dersler.FormattingEnabled = true;
            this.Dersler.Location = new System.Drawing.Point(100, 223);
            this.Dersler.Name = "Dersler";
            this.Dersler.Size = new System.Drawing.Size(311, 32);
            this.Dersler.TabIndex = 0;
            // 
            // SifreYenile
            // 
            this.SifreYenile.BackColor = System.Drawing.Color.Maroon;
            this.SifreYenile.ForeColor = System.Drawing.Color.White;
            this.SifreYenile.Location = new System.Drawing.Point(360, 450);
            this.SifreYenile.Name = "SifreYenile";
            this.SifreYenile.Size = new System.Drawing.Size(140, 80);
            this.SifreYenile.TabIndex = 4;
            this.SifreYenile.Text = "Şifremi Unuttum!";
            this.SifreYenile.UseVisualStyleBackColor = false;
            this.SifreYenile.Click += new System.EventHandler(this.SifreYenile_Click);
            // 
            // YeniDers
            // 
            this.YeniDers.BackColor = System.Drawing.Color.MediumVioletRed;
            this.YeniDers.ForeColor = System.Drawing.Color.White;
            this.YeniDers.Location = new System.Drawing.Point(12, 450);
            this.YeniDers.Name = "YeniDers";
            this.YeniDers.Size = new System.Drawing.Size(140, 80);
            this.YeniDers.TabIndex = 3;
            this.YeniDers.Text = "Yeni Ders Ekle";
            this.YeniDers.UseVisualStyleBackColor = false;
            this.YeniDers.Click += new System.EventHandler(this.YeniDers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(94, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Parola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(94, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ders Adı";
            // 
            // YoklamaDurumu
            // 
            this.YoklamaDurumu.BackColor = System.Drawing.Color.SaddleBrown;
            this.YoklamaDurumu.ForeColor = System.Drawing.Color.White;
            this.YoklamaDurumu.Location = new System.Drawing.Point(185, 450);
            this.YoklamaDurumu.Name = "YoklamaDurumu";
            this.YoklamaDurumu.Size = new System.Drawing.Size(140, 80);
            this.YoklamaDurumu.TabIndex = 17;
            this.YoklamaDurumu.Text = "Yoklama Durumu";
            this.YoklamaDurumu.UseVisualStyleBackColor = false;
            this.YoklamaDurumu.Click += new System.EventHandler(this.YoklamaDurumu_Click);
            // 
            // parolasett
            // 
            this.parolasett.BackgroundImage = global::YoklamaOtomasyonu.Properties.Resources.closeeye;
            this.parolasett.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.parolasett.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parolasett.Location = new System.Drawing.Point(429, 309);
            this.parolasett.Name = "parolasett";
            this.parolasett.Size = new System.Drawing.Size(43, 32);
            this.parolasett.TabIndex = 16;
            this.parolasett.UseVisualStyleBackColor = true;
            this.parolasett.Click += new System.EventHandler(this.ParolaGizle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.BackgroundImage = global::YoklamaOtomasyonu.Properties.Resources.human;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::YoklamaOtomasyonu.Properties.Resources.human;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox2.BackgroundImage = global::YoklamaOtomasyonu.Properties.Resources.book;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::YoklamaOtomasyonu.Properties.Resources.book;
            this.pictureBox2.Location = new System.Drawing.Point(45, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(514, 561);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox5.BackgroundImage = global::YoklamaOtomasyonu.Properties.Resources.school;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox5.Location = new System.Drawing.Point(510, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(474, 561);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox3.BackgroundImage = global::YoklamaOtomasyonu.Properties.Resources._lock;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(45, 309);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.YoklamaDurumu);
            this.Controls.Add(this.parolasett);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SifreYenile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.YeniDers);
            this.Controls.Add(this.GirisYap);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Dersler);
            this.Controls.Add(this.pictureBox4);
            this.Font = new System.Drawing.Font("Tahoma", 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GirisEkrani";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.GirisEkrani_load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Parola;
        private System.Windows.Forms.Button GirisYap;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox Dersler;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button SifreYenile;
        private System.Windows.Forms.Button YeniDers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button parolasett;
        private System.Windows.Forms.Button YoklamaDurumu;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

