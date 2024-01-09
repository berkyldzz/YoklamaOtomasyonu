namespace YoklamaOtomasyonu
{
    partial class YoklamaEkrani
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
            this.OgrenciNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yoneticiparolagizle = new System.Windows.Forms.Button();
            this.Dersadilabel = new System.Windows.Forms.Label();
            this.GeriDon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Imzala = new System.Windows.Forms.Button();
            this.isimlabel = new System.Windows.Forms.Label();
            this.YoklamaAlindiMi = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OgrenciNo
            // 
            this.OgrenciNo.Font = new System.Drawing.Font("Tahoma", 15F);
            this.OgrenciNo.Location = new System.Drawing.Point(32, 348);
            this.OgrenciNo.MaxLength = 9;
            this.OgrenciNo.Name = "OgrenciNo";
            this.OgrenciNo.Size = new System.Drawing.Size(265, 32);
            this.OgrenciNo.TabIndex = 0;
            this.OgrenciNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OgrenciNo.Click += new System.EventHandler(this.OgrenciNo_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Numarası";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.yoneticiparolagizle);
            this.panel1.Controls.Add(this.Dersadilabel);
            this.panel1.Controls.Add(this.GeriDon);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Imzala);
            this.panel1.Controls.Add(this.isimlabel);
            this.panel1.Controls.Add(this.YoklamaAlindiMi);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.OgrenciNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(621, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 561);
            this.panel1.TabIndex = 3;
            // 
            // yoneticiparolagizle
            // 
            this.yoneticiparolagizle.BackgroundImage = global::YoklamaOtomasyonu.Properties.Resources.openneye;
            this.yoneticiparolagizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.yoneticiparolagizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yoneticiparolagizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yoneticiparolagizle.Location = new System.Drawing.Point(301, 348);
            this.yoneticiparolagizle.Name = "yoneticiparolagizle";
            this.yoneticiparolagizle.Size = new System.Drawing.Size(34, 32);
            this.yoneticiparolagizle.TabIndex = 15;
            this.yoneticiparolagizle.UseVisualStyleBackColor = true;
            this.yoneticiparolagizle.Click += new System.EventHandler(this.YoneticiParolaGizle_Click);
            // 
            // Dersadilabel
            // 
            this.Dersadilabel.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Dersadilabel.ForeColor = System.Drawing.Color.White;
            this.Dersadilabel.Location = new System.Drawing.Point(32, 172);
            this.Dersadilabel.Name = "Dersadilabel";
            this.Dersadilabel.Size = new System.Drawing.Size(303, 45);
            this.Dersadilabel.TabIndex = 8;
            this.Dersadilabel.Text = "Ders";
            this.Dersadilabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GeriDon
            // 
            this.GeriDon.BackColor = System.Drawing.Color.SlateBlue;
            this.GeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GeriDon.Font = new System.Drawing.Font("Tahoma", 15F);
            this.GeriDon.ForeColor = System.Drawing.Color.White;
            this.GeriDon.Location = new System.Drawing.Point(191, 457);
            this.GeriDon.Name = "GeriDon";
            this.GeriDon.Size = new System.Drawing.Size(144, 92);
            this.GeriDon.TabIndex = 3;
            this.GeriDon.Text = "Geri Dön";
            this.GeriDon.UseVisualStyleBackColor = false;
            this.GeriDon.Click += new System.EventHandler(this.GeriDon_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(32, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "Devamsızlık Durumunu Gör";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.DevamDurumu_Click);
            // 
            // Imzala
            // 
            this.Imzala.BackColor = System.Drawing.Color.DarkGreen;
            this.Imzala.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Imzala.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Imzala.ForeColor = System.Drawing.Color.White;
            this.Imzala.Location = new System.Drawing.Point(32, 395);
            this.Imzala.Name = "Imzala";
            this.Imzala.Size = new System.Drawing.Size(303, 53);
            this.Imzala.TabIndex = 1;
            this.Imzala.Text = "Yoklamayı İmzala";
            this.Imzala.UseVisualStyleBackColor = false;
            this.Imzala.Click += new System.EventHandler(this.Imzala_Click);
            // 
            // isimlabel
            // 
            this.isimlabel.BackColor = System.Drawing.Color.DarkCyan;
            this.isimlabel.Font = new System.Drawing.Font("Tahoma", 15F);
            this.isimlabel.ForeColor = System.Drawing.Color.White;
            this.isimlabel.Location = new System.Drawing.Point(32, 217);
            this.isimlabel.Name = "isimlabel";
            this.isimlabel.Size = new System.Drawing.Size(303, 36);
            this.isimlabel.TabIndex = 6;
            this.isimlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YoklamaAlindiMi
            // 
            this.YoklamaAlindiMi.BackColor = System.Drawing.Color.DarkCyan;
            this.YoklamaAlindiMi.Font = new System.Drawing.Font("Tahoma", 15F);
            this.YoklamaAlindiMi.ForeColor = System.Drawing.Color.White;
            this.YoklamaAlindiMi.Location = new System.Drawing.Point(32, 253);
            this.YoklamaAlindiMi.Name = "YoklamaAlindiMi";
            this.YoklamaAlindiMi.Size = new System.Drawing.Size(303, 45);
            this.YoklamaAlindiMi.TabIndex = 5;
            this.YoklamaAlindiMi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::YoklamaOtomasyonu.Properties.Resources.graduated;
            this.pictureBox2.Location = new System.Drawing.Point(205, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YoklamaOtomasyonu.Properties.Resources.graduated__1_;
            this.pictureBox1.Location = new System.Drawing.Point(32, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::YoklamaOtomasyonu.Properties.Resources.graduation;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 561);
            this.panel2.TabIndex = 4;
            // 
            // YoklamaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YoklamaEkrani";
            this.Text = "Yoklama Ekranı";
            this.Load += new System.EventHandler(this.YoklamaEkrani_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox OgrenciNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label YoklamaAlindiMi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label isimlabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Imzala;
        private System.Windows.Forms.Button GeriDon;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label Dersadilabel;
        private System.Windows.Forms.Button yoneticiparolagizle;
    }
}