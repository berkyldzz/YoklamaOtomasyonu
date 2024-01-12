using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoklamaOtomasyonu
{
    public partial class TumDerslerdenCikar : Form
    {
        OleDbConnection veritabani = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\YoklamaDatabase.accdb;Jet OLEDB:Database Password=232323;");
        DataTable VTDersler;
        String ders;

        public TumDerslerdenCikar()
        {
            InitializeComponent();
        }

        private void OgrenciyiSil_Click(object sender, EventArgs e)
        {
            if (veritabani.State == ConnectionState.Closed)
            {
                veritabani.Open();
            }

            if (OgrenciNo.Text == "" || YoneticiParolasi.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Doğru Şekilde Doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                YoneticiParolasi.Clear();
            }
            else if (!OgrenciNo.Text.All(char.IsDigit))
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Doğru Şekilde Doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                YoneticiParolasi.Clear();
            }
            else
            {
                string ogrencino = OgrenciNo.Text;
                string parola = YoneticiParolasi.Text;
                int kayitSayisi=0;
                int toplamders=0;
                try
                {
                    OleDbCommand komut = new OleDbCommand($"SELECT * FROM YöneticiParolası Where Parola='{parola}'", veritabani);
                    OleDbDataReader oku = komut.ExecuteReader();

                    if (oku.Read())
                    {
                        bool ogrenciBulundu = false;

                        VTDersler = veritabani.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                        foreach (DataRow tablo in VTDersler.Rows)
                        {
                            ders = tablo["TABLE_NAME"].ToString();

                            if (ders.EndsWith("_") || ders  == "ÖğrenciBilgileri")
                            {
                                try 
                                {
                                    OleDbCommand komutKontrol = new OleDbCommand($"SELECT COUNT(*) FROM {ders} WHERE ÖğrenciNo='{ogrencino}'", veritabani);
                                    kayitSayisi = Convert.ToInt32(komutKontrol.ExecuteScalar());

                                    if (kayitSayisi > 0)
                                    {
                                        OleDbCommand komutt = new OleDbCommand($"DELETE FROM {ders} WHERE ÖğrenciNo ='{ogrencino}'", veritabani);
                                        komutt.ExecuteNonQuery();
                                        ogrenciBulundu = true;
                                        toplamders++;
                                    }
                                    else
                                    {
                                        ogrenciBulundu = false;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lütfen Gerekli Yerleri Doğru Şekilde Doldurunuz !"+ex.Message,"",MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    YoneticiParolasi.Clear();
                                }
                            }
                        }
                        if (ogrenciBulundu)
                        {
                            MessageBox.Show($"{toplamders} Dersten Öğrenci Silme Başarılı !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            YoneticiParolasi.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Öğrenci Bulunamadı !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            YoneticiParolasi.Clear();
                        }
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
