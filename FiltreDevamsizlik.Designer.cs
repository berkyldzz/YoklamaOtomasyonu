﻿namespace YoklamaOtomasyonu
{
    partial class FiltreDevamsizlik
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
            this.altsinir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Filtrele = new System.Windows.Forms.Button();
            this.ustsinir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // altsinir
            // 
            this.altsinir.Font = new System.Drawing.Font("Tahoma", 13F);
            this.altsinir.Location = new System.Drawing.Point(105, 116);
            this.altsinir.Name = "altsinir";
            this.altsinir.Size = new System.Drawing.Size(178, 28);
            this.altsinir.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(36, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 70);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lütfen Aralık Belirtin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Filtrele
            // 
            this.Filtrele.BackColor = System.Drawing.Color.DarkOrange;
            this.Filtrele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Filtrele.Font = new System.Drawing.Font("Tahoma", 13F);
            this.Filtrele.Location = new System.Drawing.Point(105, 171);
            this.Filtrele.Name = "Filtrele";
            this.Filtrele.Size = new System.Drawing.Size(90, 42);
            this.Filtrele.TabIndex = 8;
            this.Filtrele.Text = "Filtrele";
            this.Filtrele.UseVisualStyleBackColor = false;
            this.Filtrele.Click += new System.EventHandler(this.Filtrele_Click);
            // 
            // ustsinir
            // 
            this.ustsinir.Font = new System.Drawing.Font("Tahoma", 13F);
            this.ustsinir.Location = new System.Drawing.Point(105, 73);
            this.ustsinir.Name = "ustsinir";
            this.ustsinir.Size = new System.Drawing.Size(178, 28);
            this.ustsinir.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(1, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Alt Sınır";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(1, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Üst Sınır";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FiltreDevamsizlık
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(295, 225);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.altsinir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Filtrele);
            this.Controls.Add(this.ustsinir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FiltreDevamsizlık";
            this.Text = "FiltreDevamsizlık";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Filtrele;
        public System.Windows.Forms.TextBox ustsinir;
        public System.Windows.Forms.TextBox altsinir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}