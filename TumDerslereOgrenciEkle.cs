using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace YoklamaOtomasyonu
{
    public partial class TumDerslereOgrenciEkle : Form
    {
        OleDbConnection veritabani = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\YoklamaDatabase.accdb;Jet OLEDB:Database Password=232323;");
        DataTable VTDersler;
        String ders;

        public TumDerslereOgrenciEkle()
        {
            InitializeComponent();
        }

        private void OgrenciyiKaydet_Click(object sender, EventArgs e)
        {
            if (veritabani.State == ConnectionState.Closed)
            {
                veritabani.Open();
            }

            if (AdSoyad.Text == "" || OgrenciNo.Text == "" || YoneticiParolasi.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Doğru Şekilde Doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                YoneticiParolasi.Clear();
            }
            else if (AdSoyad.Text.Any(char.IsDigit) || !OgrenciNo.Text.All(char.IsDigit))
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Doğru Şekilde Doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                YoneticiParolasi.Clear();
            }
            else
            {
                string adsoyad = AdSoyad.Text.Trim().ToUpper();
                string ogrencino = OgrenciNo.Text;
                string parola = YoneticiParolasi.Text;
                int maxdevamsizlik = 0;

                try
                {
                    OleDbCommand komut = new OleDbCommand($"SELECT * FROM YöneticiParolası Where Parola='{parola}'", veritabani);
                    OleDbDataReader oku = komut.ExecuteReader();

                    if (oku.Read())
                    {
                        VTDersler = veritabani.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                        int eklenenDersSayisi = 0;

                        foreach (DataRow tablo in VTDersler.Rows)
                        {
                            ders = tablo["TABLE_NAME"].ToString();

                            if (ders.EndsWith("_") || ders == "ÖğrenciBilgileri")
                            {
                                OleDbCommand kontrolKomut = new OleDbCommand($"SELECT COUNT(*) FROM {ders} WHERE ÖğrenciNo='{ogrencino}'", veritabani);
                                int kayitSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                                if (kayitSayisi == 0)
                                {
                                    OleDbCommand komutt = new OleDbCommand($"SELECT MaxDevamsızlık FROM {ders}", veritabani);
                                    maxdevamsizlik = Convert.ToInt32(komutt.ExecuteScalar());

                                    OleDbCommand komuttt = new OleDbCommand($"INSERT INTO {ders} (AdSoyad, ÖğrenciNo, Mail, Devamsızlık, MaxDevamsızlık) VALUES ('{adsoyad}', '{ogrencino}', '{ogrencino + "@firat.edu.tr"}', 0, {maxdevamsizlik})", veritabani);
                                    komuttt.ExecuteNonQuery();
                                    eklenenDersSayisi++;

                                    YoneticiParolasi.Clear();
                                    AdSoyad.Clear();
                                    OgrenciNo.Clear();
                                }
                                else
                                {
                                    MessageBox.Show($"Bu Öğrenci {ders} Dersinde Mevcut!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    YoneticiParolasi.Clear();
                                }
                            }
                        }

                        MessageBox.Show($"Toplam {eklenenDersSayisi} derse {adsoyad} eklendi!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        YoneticiParolasi.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Parola Yanlış Tekrar Deneyiniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        YoneticiParolasi.Clear();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen Gerekli Yerleri Doğru Şekilde Giriniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    YoneticiParolasi.Clear();
                }
            }
        }
    }
}
