namespace YoklamaOtomasyonu
{
    partial class SifreYenile
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
            this.ParolayiDegistir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.YoneticiParolasi = new System.Windows.Forms.TextBox();
            this.YeniParola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GeriDon = new System.Windows.Forms.Button();
            this.Dersler = new System.Windows.Forms.ComboBox();
            this.yeniparolagizle = new System.Windows.Forms.Button();
            this.yoneticiparolagizle = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ParolayiDegistir
            // 
            this.ParolayiDegistir.BackColor = System.Drawing.Color.DarkGreen;
            this.ParolayiDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ParolayiDegistir.Font = new System.Drawing.Font("Tahoma", 15F);
            this.ParolayiDegistir.ForeColor = System.Drawing.Color.White;
            this.ParolayiDegistir.Location = new System.Drawing.Point(708, 451);
            this.ParolayiDegistir.Name = "ParolayiDegistir";
            this.ParolayiDegistir.Size = new System.Drawing.Size(178, 53);
            this.ParolayiDegistir.TabIndex = 3;
            this.ParolayiDegistir.Text = "Parolayı Değiştir";
            this.ParolayiDegistir.UseVisualStyleBackColor = false;
            this.ParolayiDegistir.Click += new System.EventHandler(this.ParolayiDegistir_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(661, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yönetici Parolası";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(609, 561);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // YoneticiParolasi
            // 
            this.YoneticiParolasi.Font = new System.Drawing.Font("Tahoma", 15F);
            this.YoneticiParolasi.Location = new System.Drawing.Point(661, 316);
            this.YoneticiParolasi.Name = "YoneticiParolasi";
            this.YoneticiParolasi.Size = new System.Drawing.Size(275, 32);
            this.YoneticiParolasi.TabIndex = 1;
            this.YoneticiParolasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.YoneticiParolasi.UseSystemPasswordChar = true;
            // 
            // YeniParola
            // 
            this.YeniParola.Font = new System.Drawing.Font("Tahoma", 15F);
            this.YeniParola.Location = new System.Drawing.Point(661, 403);
            this.YeniParola.Name = "YeniParola";
            this.YeniParola.Size = new System.Drawing.Size(275, 32);
            this.YeniParola.TabIndex = 2;
            this.YeniParola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.YeniParola.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(661, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yeni Yoklama Parolası";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(685, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ders Adı";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GeriDon
            // 
            this.GeriDon.BackColor = System.Drawing.Color.Crimson;
            this.GeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GeriDon.Font = new System.Drawing.Font("Tahoma", 15F);
            this.GeriDon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GeriDon.Location = new System.Drawing.Point(708, 510);
            this.GeriDon.Name = "GeriDon";
            this.GeriDon.Size = new System.Drawing.Size(178, 39);
            this.GeriDon.TabIndex = 4;
            this.GeriDon.Text = "Geri Dön";
            this.GeriDon.UseVisualStyleBackColor = false;
            this.GeriDon.Click += new System.EventHandler(this.GeriDon_Click);
            // 
            // Dersler
            // 
            this.Dersler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dersler.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Dersler.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Dersler.FormattingEnabled = true;
            this.Dersler.Location = new System.Drawing.Point(661, 230);
            this.Dersler.Name = "Dersler";
            this.Dersler.Size = new System.Drawing.Size(275, 32);
            this.Dersler.TabIndex = 0;
            // 
            // yeniparolagizle
            // 
            this.yeniparolagizle.BackgroundImage = global::YoklamaOtomasyonu.Properties.Resources.closeeye;
            this.yeniparolagizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.yeniparolagizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yeniparolagizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yeniparolagizle.Location = new System.Drawing.Point(942, 403);
            this.yeniparolagizle.Name = "yeniparolagizle";
            this.yeniparolagizle.Size = new System.Drawing.Size(30, 32);
            this.yeniparolagizle.TabIndex = 15;
            this.yeniparolagizle.UseVisualStyleBackColor = true;
            this.yeniparolagizle.Click += new System.EventHandler(this.YeniParolaGizle_Click);
            // 
            // yoneticiparolagizle
            // 
            this.yoneticiparolagizle.BackgroundImage = global::YoklamaOtomasyonu.Properties.Resources.closeeye;
            this.yoneticiparolagizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.yoneticiparolagizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yoneticiparolagizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yoneticiparolagizle.Location = new System.Drawing.Point(942, 316);
            this.yoneticiparolagizle.Name = "yoneticiparolagizle";
            this.yoneticiparolagizle.Size = new System.Drawing.Size(30, 32);
            this.yoneticiparolagizle.TabIndex = 14;
            this.yoneticiparolagizle.UseVisualStyleBackColor = true;
            this.yoneticiparolagizle.Click += new System.EventHandler(this.YoneticiParolaGizle_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::YoklamaOtomasyonu.Properties.Resources.lock2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(661, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 171);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkBlue;
            this.pictureBox1.BackgroundImage = global::YoklamaOtomasyonu.Properties.Resources.loginpage;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(609, 561);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // SifreYenile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.yeniparolagizle);
            this.Controls.Add(this.yoneticiparolagizle);
            this.Controls.Add(this.Dersler);
            this.Controls.Add(this.GeriDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YeniParola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YoneticiParolasi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParolayiDegistir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SifreYenile";
            this.Text = "SifreYenile";
            this.Load += new System.EventHandler(this.SifreYenile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ParolayiDegistir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox YoneticiParolasi;
        private System.Windows.Forms.TextBox YeniParola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GeriDon;
        private System.Windows.Forms.ComboBox Dersler;
        private System.Windows.Forms.Button yoneticiparolagizle;
        private System.Windows.Forms.Button yeniparolagizle;
    }
}