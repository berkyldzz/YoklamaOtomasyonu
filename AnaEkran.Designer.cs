namespace YoklamaOtomasyonu
{
    partial class AnaEkran
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
            this.AnaPanel = new System.Windows.Forms.Panel();
            this.Kapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnaPanel
            // 
            this.AnaPanel.Location = new System.Drawing.Point(0, 24);
            this.AnaPanel.Name = "AnaPanel";
            this.AnaPanel.Size = new System.Drawing.Size(984, 561);
            this.AnaPanel.TabIndex = 0;
            this.AnaPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnaEkran_MouseDown);
            this.AnaPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnaEkran_MouseMove);
            this.AnaPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AnaEkran_MouseUp);
            // 
            // Kapat
            // 
            this.Kapat.BackColor = System.Drawing.Color.Red;
            this.Kapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Kapat.ForeColor = System.Drawing.Color.White;
            this.Kapat.Location = new System.Drawing.Point(941, -1);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(43, 25);
            this.Kapat.TabIndex = 1;
            this.Kapat.Text = "X";
            this.Kapat.UseVisualStyleBackColor = false;
            this.Kapat.Click += new System.EventHandler(this.Kapat_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 584);
            this.Controls.Add(this.Kapat);
            this.Controls.Add(this.AnaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yoklama Otomasyonu";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel AnaPanel;
        private System.Windows.Forms.Button Kapat;
    }
}