namespace YoklamaOtomasyonu
{
    partial class DevamsizlikDurumu
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
            this.DevamsizlikSayisi = new System.Windows.Forms.Label();
            this.DevamHakki = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Kapat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DevamsizlikSayisi
            // 
            this.DevamsizlikSayisi.Font = new System.Drawing.Font("Tahoma", 25F);
            this.DevamsizlikSayisi.ForeColor = System.Drawing.Color.White;
            this.DevamsizlikSayisi.Location = new System.Drawing.Point(0, 165);
            this.DevamsizlikSayisi.Name = "DevamsizlikSayisi";
            this.DevamsizlikSayisi.Size = new System.Drawing.Size(629, 45);
            this.DevamsizlikSayisi.TabIndex = 0;
            this.DevamsizlikSayisi.Text = "Devam Durumu";
            this.DevamsizlikSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DevamHakki
            // 
            this.DevamHakki.Font = new System.Drawing.Font("Tahoma", 25F);
            this.DevamHakki.ForeColor = System.Drawing.Color.White;
            this.DevamHakki.Location = new System.Drawing.Point(0, 94);
            this.DevamHakki.Name = "DevamHakki";
            this.DevamHakki.Size = new System.Drawing.Size(629, 50);
            this.DevamHakki.TabIndex = 0;
            this.DevamHakki.Text = "Devam Hakkı";
            this.DevamHakki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(77, 261);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(478, 50);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 2;
            // 
            // Kapat
            // 
            this.Kapat.BackColor = System.Drawing.Color.Firebrick;
            this.Kapat.FlatAppearance.BorderSize = 0;
            this.Kapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Kapat.ForeColor = System.Drawing.Color.White;
            this.Kapat.Location = new System.Drawing.Point(567, 12);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(50, 50);
            this.Kapat.TabIndex = 2;
            this.Kapat.Text = "X";
            this.Kapat.UseVisualStyleBackColor = false;
            this.Kapat.Click += new System.EventHandler(this.Kapat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 337);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // DevamsizlikDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(629, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Kapat);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.DevamHakki);
            this.Controls.Add(this.DevamsizlikSayisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DevamsizlikDurumu";
            this.Text = "DevamsizlikDurumu";
            this.Load += new System.EventHandler(this.DevamsizlikDurumu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label DevamsizlikSayisi;
        private System.Windows.Forms.Label DevamHakki;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Kapat;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}