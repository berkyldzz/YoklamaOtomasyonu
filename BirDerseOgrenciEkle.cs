using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace YoklamaOtomasyonu
{
    public partial class BirDerseOgrenciEkle : Form
    {
        OleDbConnection veritabani = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\YoklamaDatabase.accdb;Jet OLEDB:Database Password=232323;");
        DataTable VTDersler;
        String ders;

        public BirDerseOgrenciEkle()
        {
            InitializeComponent();
        }

        private void BirDerseOgrenciEkle_Load(object sender, System.EventArgs e)
        {
            DersleriCek();
        }

        private void OgrenciyiKaydet_Click(object sender, System.EventArgs e)
        {
            if (veritabani.State == ConnectionState.Closed)
            {
                veritabani.Open();
            }

            if (Dersler.Text == "" || AdSoyad.Text == "" || OgrenciNo.Text == "" || GorevliOgretmenParolasi.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Doğru Şekilde Doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GorevliOgretmenParolasi.Clear();
            }
            else if ( AdSoyad.Text.Any(char.IsDigit) || !OgrenciNo.Text.All(char.IsDigit))
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Doğru Şekilde Doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GorevliOgretmenParolasi.Clear();
            }
            else
            {
                string dersadi = Dersler.Text;
                string adsoyad = AdSoyad.Text.Trim().ToUpper();
                string ogrencino = OgrenciNo.Text;
                string parola = GorevliOgretmenParolasi.Text;
                int maxdevamsizlik;

                try
                {
                    if (dersadi == "ÖğrenciBilgileri")
                    {                   
                        OleDbCommand komut = new OleDbCommand($"SELECT * FROM YöneticiParolası Where Parola='{parola}'", veritabani);
                        OleDbDataReader oku = komut.ExecuteReader();

                        if (oku.Read())
                        {
                            OleDbCommand kontrolKomut = new OleDbCommand($"SELECT COUNT(*) FROM ÖğrenciBilgileri WHERE ÖğrenciNo='{ogrencino}'", veritabani);
                            int kayitSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                            if (kayitSayisi == 0)
                            {
                                OleDbCommand komuttt = new OleDbCommand($"INSERT INTO ÖğrenciBilgileri (AdSoyad, ÖğrenciNo, Mail, Devamsızlık) VALUES ('{adsoyad}', '{ogrencino}', '{ogrencino + "@firat.edu.tr"}', 0)", veritabani);
                                komuttt.ExecuteNonQuery();

                                MessageBox.Show($"Öğrenci Bilgilerine {adsoyad} Eklendi !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                OgrenciNo.Clear();
                                AdSoyad.Clear();
                                GorevliOgretmenParolasi.Clear();
                            }
                            else
                            {
                                MessageBox.Show($"Bu Öğrenci Öğrenci Bilgilerinde Mevcut!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                GorevliOgretmenParolasi.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Parola Yanlış Tekrar Deneyiniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            GorevliOgretmenParolasi.Clear();
                        }
                    }
                    else
                    {                        
                        OleDbCommand komutt = new OleDbCommand($"SELECT * FROM GörevliBilgileri Where Parola='{parola}' and DersAdı='{dersadi}'", veritabani);
                        OleDbDataReader okuu = komutt.ExecuteReader();

                        if (okuu.Read())
                        {
                            OleDbCommand kontrolKomut = new OleDbCommand($"SELECT COUNT(*) FROM {dersadi}_ WHERE ÖğrenciNo='{ogrencino}'", veritabani);
                            int kayitSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                            if (kayitSayisi == 0)
                            {
                                OleDbCommand komuttt = new OleDbCommand($"SELECT MaxDevamsızlık FROM {dersadi}_", veritabani);
                                maxdevamsizlik = Convert.ToInt32(komuttt.ExecuteScalar());

                                OleDbCommand komutttt = new OleDbCommand($"INSERT INTO {dersadi}_ (AdSoyad, ÖğrenciNo, Mail, Devamsızlık, MaxDevamsızlık) VALUES ('{adsoyad}', '{ogrencino}', '{ogrencino + "@firat.edu.tr"}', 0, {maxdevamsizlik})", veritabani);
                                komutttt.ExecuteNonQuery();

                                MessageBox.Show($"{dersadi} dersine {adsoyad} Eklendi !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                OgrenciNo.Clear();
                                AdSoyad.Clear();
                                GorevliOgretmenParolasi.Clear();
                            }
                            else
                            {
                                MessageBox.Show($"Bu öğrenci zaten {dersadi} dersinde mevcut!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                GorevliOgretmenParolasi.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Parola Yanlış Tekrar Deneyiniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            GorevliOgretmenParolasi.Clear();
                        }
                    }

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lütfen Gerekli Yerleri Doğru Şekilde Doldurunuz !"+ex.ToString());
                    GorevliOgretmenParolasi.Clear();
                }
            }
        }

        public void DersleriCek()
        {
            if (veritabani.State == ConnectionState.Closed)
            {
                veritabani.Open();
            }

            VTDersler = veritabani.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

            foreach (DataRow tablo in VTDersler.Rows)
            {
                ders = tablo["TABLE_NAME"].ToString();

                if (ders.EndsWith("_") && !Dersler.Items.Contains(ders.Replace("_", "")))
                {
                    Dersler.Items.Add(ders.Remove(ders.Length - 1));
                }
                if (ders == "ÖğrenciBilgileri" && !Dersler.Items.Contains(ders))
                {
                    Dersler.Items.Add(ders);
                }

            }
        }

        private void Dersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Dersler.Text == "ÖğrenciBilgileri")
            {
                label4.Text = "Yönetici Parolası";
            }
            else
            {
                label4.Text = "Görevli Öğretmen Parolası";
            }
        }
    }
}
