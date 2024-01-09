namespace YoklamaOtomasyonu
{
    partial class FiltreAdSoyad
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
            this.AdSoyad = new System.Windows.Forms.TextBox();
            this.Filtrele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdSoyad
            // 
            this.AdSoyad.Font = new System.Drawing.Font("Tahoma", 13F);
            this.AdSoyad.Location = new System.Drawing.Point(58, 91);
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.Size = new System.Drawing.Size(178, 28);
            this.AdSoyad.TabIndex = 0;
            // 
            // Filtrele
            // 
            this.Filtrele.BackColor = System.Drawing.Color.DarkOrange;
            this.Filtrele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Filtrele.Font = new System.Drawing.Font("Tahoma", 13F);
            this.Filtrele.Location = new System.Drawing.Point(102, 147);
            this.Filtrele.Name = "Filtrele";
            this.Filtrele.Size = new System.Drawing.Size(90, 42);
            this.Filtrele.TabIndex = 1;
            this.Filtrele.Text = "Filtrele";
            this.Filtrele.UseVisualStyleBackColor = false;
            this.Filtrele.Click += new System.EventHandler(this.Filtrele_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(58, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı Soyadı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FiltreAdSoyad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(295, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Filtrele);
            this.Controls.Add(this.AdSoyad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FiltreAdSoyad";
            this.Text = "Filtre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Filtrele;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox AdSoyad;
    }
}