﻿namespace YoklamaOtomasyonu
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnaPanel
            // 
            this.AnaPanel.Location = new System.Drawing.Point(0, 24);
            this.AnaPanel.Name = "AnaPanel";
            this.AnaPanel.Size = new System.Drawing.Size(984, 561);
            this.AnaPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(941, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 584);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}