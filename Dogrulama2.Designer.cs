namespace YoklamaOtomasyonu
{
    partial class Dogrulama2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Parola = new System.Windows.Forms.TextBox();
            this.YoklamayiBitir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ParolaGizle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 61);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lütfen Öğretim Görevlisi Parolasını Girin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Parola
            // 
            this.Parola.Font = new System.Drawing.Font("Tahoma", 20F);
            this.Parola.Location = new System.Drawing.Point(168, 321);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(292, 40);
            this.Parola.TabIndex = 20;
            this.Parola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Parola.UseSystemPasswordChar = true;
            // 
            // YoklamayiBitir
            // 
            this.YoklamayiBitir.BackColor = System.Drawing.Color.DarkRed;
            this.YoklamayiBitir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YoklamayiBitir.Font = new System.Drawing.Font("Tahoma", 15F);
            this.YoklamayiBitir.ForeColor = System.Drawing.Color.White;
            this.YoklamayiBitir.Location = new System.Drawing.Point(243, 391);
            this.YoklamayiBitir.Name = "YoklamayiBitir";
            this.YoklamayiBitir.Size = new System.Drawing.Size(129, 63);
            this.YoklamayiBitir.TabIndex = 19;
            this.YoklamayiBitir.Text = "Yoklamayı Bitir";
            this.YoklamayiBitir.UseVisualStyleBackColor = false;
            this.YoklamayiBitir.Click += new System.EventHandler(this.YoklamayiBitir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(243, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 63);
            this.button1.TabIndex = 24;
            this.button1.Text = "Yoklamaya Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.GeriDon_Click);
            // 
            // ParolaGizle
            // 
            this.ParolaGizle.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ParolaGizle.BackgroundImage = global::YoklamaOtomasyonu.Properties.Resources.closeeye;
            this.ParolaGizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ParolaGizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ParolaGizle.Location = new System.Drawing.Point(488, 321);
            this.ParolaGizle.Name = "ParolaGizle";
            this.ParolaGizle.Size = new System.Drawing.Size(44, 40);
            this.ParolaGizle.TabIndex = 23;
            this.ParolaGizle.UseVisualStyleBackColor = false;
            this.ParolaGizle.Click += new System.EventHandler(this.ParolaGizle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::YoklamaOtomasyonu.Properties.Resources.human;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(168, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 181);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Dogrulama2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(629, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ParolaGizle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.YoklamayiBitir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dogrulama2";
            this.Text = "Dogrulama2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ParolaGizle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Parola;
        private System.Windows.Forms.Button YoklamayiBitir;
        private System.Windows.Forms.Button button1;
    }
}