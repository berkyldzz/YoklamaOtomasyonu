using System;
using System.Data;
using System.Data.OleDb;
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

                        foreach (DataRow tablo in VTDersler.Rows)
                        {
                            ders = tablo["TABLE_NAME"].ToString();

                            if (ders.EndsWith("_"))
                            {
                                OleDbCommand kontrolKomut = new OleDbCommand($"SELECT COUNT(*) FROM {ders} WHERE ÖğrenciNo='{ogrencino}'", veritabani);
                                int kayitSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                                if (kayitSayisi == 0) 
                                {
                                    OleDbCommand komutt = new OleDbCommand($"SELECT MaxDevamsızlık FROM {ders}", veritabani);
                                    maxdevamsizlik = Convert.ToInt32(komutt.ExecuteScalar());

                                    OleDbCommand komuttt = new OleDbCommand($"INSERT INTO {ders} (AdSoyad, ÖğrenciNo, Mail, Devamsızlık, MaxDevamsızlık) VALUES ('{adsoyad}', '{ogrencino}', '{ogrencino + "@firat.edu.tr"}', 0, {maxdevamsizlik})", veritabani);
                                    komuttt.ExecuteNonQuery();
                                    MessageBox.Show("Öğrenci Ekleme Başarılı !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Bu öğrenci zaten mevcut!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Parola Yanlış Tekrar Deneyiniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen Gerekli Yerleri Doğru Şekilde Giriniz!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
