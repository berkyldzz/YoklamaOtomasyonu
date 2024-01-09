namespace YoklamaOtomasyonu
{
    partial class YoklamaDurumu_YoneticiPaneli_
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
            this.OgrenciNoFiltre = new System.Windows.Forms.RadioButton();
            this.AdSoyadFiltre = new System.Windows.Forms.RadioButton();
            this.DevamsizlikFiltre = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GeriDon = new System.Windows.Forms.Button();
            this.Tablo = new System.Windows.Forms.ListView();
            this.FiltreyiTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OgrenciNoFiltre
            // 
            this.OgrenciNoFiltre.AutoSize = true;
            this.OgrenciNoFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrenciNoFiltre.ForeColor = System.Drawing.Color.White;
            this.OgrenciNoFiltre.Location = new System.Drawing.Point(12, 31);
            this.OgrenciNoFiltre.Name = "OgrenciNoFiltre";
            this.OgrenciNoFiltre.Size = new System.Drawing.Size(181, 21);
            this.OgrenciNoFiltre.TabIndex = 1;
            this.OgrenciNoFiltre.TabStop = true;
            this.OgrenciNoFiltre.Text = "Öğrenci No ile Filtreleme";
            this.OgrenciNoFiltre.UseVisualStyleBackColor = true;
            this.OgrenciNoFiltre.CheckedChanged += new System.EventHandler(this.OgrenciNoFiltre_CheckedChanged);
            // 
            // AdSoyadFiltre
            // 
            this.AdSoyadFiltre.AutoSize = true;
            this.AdSoyadFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdSoyadFiltre.ForeColor = System.Drawing.Color.White;
            this.AdSoyadFiltre.Location = new System.Drawing.Point(161, 65);
            this.AdSoyadFiltre.Name = "AdSoyadFiltre";
            this.AdSoyadFiltre.Size = new System.Drawing.Size(170, 21);
            this.AdSoyadFiltre.TabIndex = 2;
            this.AdSoyadFiltre.TabStop = true;
            this.AdSoyadFiltre.Text = "Ad Soyad İle Filtreleme";
            this.AdSoyadFiltre.UseVisualStyleBackColor = true;
            this.AdSoyadFiltre.CheckedChanged += new System.EventHandler(this.AdSoyadFiltre_CheckedChanged);
            // 
            // DevamsizlikFiltre
            // 
            this.DevamsizlikFiltre.AutoSize = true;
            this.DevamsizlikFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DevamsizlikFiltre.ForeColor = System.Drawing.Color.White;
            this.DevamsizlikFiltre.Location = new System.Drawing.Point(12, 100);
            this.DevamsizlikFiltre.Name = "DevamsizlikFiltre";
            this.DevamsizlikFiltre.Size = new System.Drawing.Size(224, 21);
            this.DevamsizlikFiltre.TabIndex = 2;
            this.DevamsizlikFiltre.TabStop = true;
            this.DevamsizlikFiltre.Text = "Devamsızlık Sayısı İle Filtreleme";
            this.DevamsizlikFiltre.UseVisualStyleBackColor = true;
            this.DevamsizlikFiltre.CheckedChanged += new System.EventHandler(this.DevamsizlikFiltre_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(19, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 225);
            this.panel1.TabIndex = 3;
            // 
            // GeriDon
            // 
            this.GeriDon.BackColor = System.Drawing.Color.DarkRed;
            this.GeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GeriDon.Font = new System.Drawing.Font("Tahoma", 15F);
            this.GeriDon.ForeColor = System.Drawing.Color.Wheat;
            this.GeriDon.Location = new System.Drawing.Point(19, 482);
            this.GeriDon.Name = "GeriDon";
            this.GeriDon.Size = new System.Drawing.Size(295, 48);
            this.GeriDon.TabIndex = 4;
            this.GeriDon.Text = "Geri Dön";
            this.GeriDon.UseVisualStyleBackColor = false;
            this.GeriDon.Click += new System.EventHandler(this.GeriDon_Click);
            // 
            // Tablo
            // 
            this.Tablo.BackColor = System.Drawing.Color.Aqua;
            this.Tablo.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Tablo.HideSelection = false;
            this.Tablo.Location = new System.Drawing.Point(336, 12);
            this.Tablo.Name = "Tablo";
            this.Tablo.Size = new System.Drawing.Size(636, 537);
            this.Tablo.TabIndex = 5;
            this.Tablo.UseCompatibleStateImageBehavior = false;
            this.Tablo.View = System.Windows.Forms.View.List;
            // 
            // FiltreyiTemizle
            // 
            this.FiltreyiTemizle.BackColor = System.Drawing.Color.DarkGreen;
            this.FiltreyiTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FiltreyiTemizle.Font = new System.Drawing.Font("Tahoma", 15F);
            this.FiltreyiTemizle.ForeColor = System.Drawing.Color.Wheat;
            this.FiltreyiTemizle.Location = new System.Drawing.Point(19, 394);
            this.FiltreyiTemizle.Name = "FiltreyiTemizle";
            this.FiltreyiTemizle.Size = new System.Drawing.Size(295, 48);
            this.FiltreyiTemizle.TabIndex = 6;
            this.FiltreyiTemizle.Text = "Filtreyi Temizle";
            this.FiltreyiTemizle.UseVisualStyleBackColor = false;
            this.FiltreyiTemizle.Click += new System.EventHandler(this.FiltreyiTemizle_Click);
            // 
            // YoklamaDurumu_YoneticiPaneli_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.FiltreyiTemizle);
            this.Controls.Add(this.Tablo);
            this.Controls.Add(this.GeriDon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DevamsizlikFiltre);
            this.Controls.Add(this.AdSoyadFiltre);
            this.Controls.Add(this.OgrenciNoFiltre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YoklamaDurumu_YoneticiPaneli_";
            this.Text = "YoklamaDurumu_YoneticiPaneli_";
            this.Load += new System.EventHandler(this.OgrencileriGetir);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton OgrenciNoFiltre;
        private System.Windows.Forms.RadioButton AdSoyadFiltre;
        private System.Windows.Forms.RadioButton DevamsizlikFiltre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GeriDon;
        private System.Windows.Forms.ListView Tablo;
        private System.Windows.Forms.Button FiltreyiTemizle;
    }
}