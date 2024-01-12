using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace YoklamaOtomasyonu
{
    public partial class BilgilendirmeMaili : Form
    {
        OleDbConnection veritabani = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\YoklamaDatabase.accdb;Jet OLEDB:Database Password=232323;");

        List<String > ogrenciNolar = new List<String>();
        public BilgilendirmeMaili()
        {
            InitializeComponent();
        }

        private void Gonder_Click(object sender, EventArgs e)
        {
            if(veritabani.State == ConnectionState.Closed)
            {
                veritabani.Open();
            }
            OleDbCommand komut = new OleDbCommand($"SELECT ÖğrenciNo FROM {GirisEkrani.ders}_ WHERE Devamsızlık > MaxDevamsızlık",veritabani);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                // Öğrenci numarasını List'e ekle
                string ogrenciNo = oku["ÖğrenciNo"].ToString();
                ogrenciNolar.Add(ogrenciNo);
            }
            string ogrenciNolarString = string.Join(", ", ogrenciNolar);


            try
            {
                string subject = "Yoklama Bilgilendirme";
                string body = $"Yoklama durumundan dersten kalan öğrencilerin öğrenci numaraları = {ogrenciNolarString}";
                string toMail = Mail.Text.Trim().ToString(); // Alıcının e-posta adresini buraya ekleyin.

                SmtpClient smtpClient = new SmtpClient("smtp.office365.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("yoklamaotomasyonu@outlook.com", "yoklama23"),
                    EnableSsl = true,
                };

                // Mail gönderme işlemi için gerekli bilgileri belirt
                MailMessage mailMessage = new MailMessage()
                {
                    From = new MailAddress("yoklamaotomasyonu@outlook.com"),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = false, // Eğer HTML içerikli bir mail göndermek istiyorsanız true yapabilirsiniz.
                };

                // Alıcı mail adresini ekle
                mailMessage.To.Add(toMail);

                // Mail'i gönder
                smtpClient.Send(mailMessage);

                MessageBox.Show("Mail gönderildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

