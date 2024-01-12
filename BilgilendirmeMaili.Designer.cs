namespace YoklamaOtomasyonu
{
    partial class BilgilendirmeMaili
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
            this.Mail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Gonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mail
            // 
            this.Mail.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Mail.Location = new System.Drawing.Point(36, 99);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(225, 32);
            this.Mail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mail Adresi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gonder
            // 
            this.Gonder.BackColor = System.Drawing.Color.Crimson;
            this.Gonder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Gonder.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Gonder.ForeColor = System.Drawing.Color.White;
            this.Gonder.Location = new System.Drawing.Point(89, 159);
            this.Gonder.Name = "Gonder";
            this.Gonder.Size = new System.Drawing.Size(113, 38);
            this.Gonder.TabIndex = 2;
            this.Gonder.Text = "Gönder";
            this.Gonder.UseVisualStyleBackColor = false;
            this.Gonder.Click += new System.EventHandler(this.Gonder_Click);
            // 
            // BilgilendirmeMaili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(295, 225);
            this.Controls.Add(this.Gonder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BilgilendirmeMaili";
            this.Text = "BilgilendirmeMaili";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Gonder;
    }
}