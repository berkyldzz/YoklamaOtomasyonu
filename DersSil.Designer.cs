namespace YoklamaOtomasyonu
{
    partial class DersSil
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
            this.label1 = new System.Windows.Forms.Label();
            this.GeriDon = new System.Windows.Forms.Button();
            this.DersiSil = new System.Windows.Forms.Button();
            this.Dersler = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.yoklamaparolasi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 70);
            this.label4.TabIndex = 10;
            this.label4.Text = "Yoklama Parolası";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ders Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GeriDon
            // 
            this.GeriDon.BackColor = System.Drawing.Color.ForestGreen;
            this.GeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GeriDon.Font = new System.Drawing.Font("Tahoma", 15F);
            this.GeriDon.ForeColor = System.Drawing.Color.Cornsilk;
            this.GeriDon.Location = new System.Drawing.Point(140, 441);
            this.GeriDon.Name = "GeriDon";
            this.GeriDon.Size = new System.Drawing.Size(267, 69);
            this.GeriDon.TabIndex = 9;
            this.GeriDon.Text = "Geri Dön";
            this.GeriDon.UseVisualStyleBackColor = false;
            this.GeriDon.Click += new System.EventHandler(this.GeriDon_Click);
            // 
            // DersiSil
            // 
            this.DersiSil.BackColor = System.Drawing.Color.Crimson;
            this.DersiSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DersiSil.Font = new System.Drawing.Font("Tahoma", 15F);
            this.DersiSil.ForeColor = System.Drawing.Color.Cornsilk;
            this.DersiSil.Location = new System.Drawing.Point(140, 342);
            this.DersiSil.Name = "DersiSil";
            this.DersiSil.Size = new System.Drawing.Size(267, 69);
            this.DersiSil.TabIndex = 8;
            this.DersiSil.Text = "Dersi Sil";
            this.DersiSil.UseVisualStyleBackColor = false;
            this.DersiSil.Click += new System.EventHandler(this.DersiSil_Click);
            // 
            // Dersler
            // 
            this.Dersler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dersler.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Dersler.FormattingEnabled = true;
            this.Dersler.Location = new System.Drawing.Point(248, 99);
            this.Dersler.Name = "Dersler";
            this.Dersler.Size = new System.Drawing.Size(245, 32);
            this.Dersler.TabIndex = 12;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(542, 561);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // yoklamaparolasi
            // 
            this.yoklamaparolasi.Font = new System.Drawing.Font("Tahoma", 15F);
            this.yoklamaparolasi.Location = new System.Drawing.Point(248, 212);
            this.yoklamaparolasi.Name = "yoklamaparolasi";
            this.yoklamaparolasi.Size = new System.Drawing.Size(245, 32);
            this.yoklamaparolasi.TabIndex = 14;
            this.yoklamaparolasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yoklamaparolasi.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::YoklamaOtomasyonu.Properties.Resources.kepgorsel;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(537, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 561);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // DersSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.yoklamaparolasi);
            this.Controls.Add(this.Dersler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GeriDon);
            this.Controls.Add(this.DersiSil);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DersSil";
            this.Text = "DersSil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GeriDon;
        private System.Windows.Forms.Button DersiSil;
        private System.Windows.Forms.ComboBox Dersler;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox yoklamaparolasi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}