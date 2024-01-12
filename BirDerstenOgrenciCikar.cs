using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoklamaOtomasyonu
{
    public partial class BirDerstenOgrenciCikar : Form
    {
        OleDbConnection veritabani = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\YoklamaDatabase.accdb;Jet OLEDB:Database Password=232323;");
        DataTable VTDersler;
        String ders;

        public BirDerstenOgrenciCikar()
        {
            InitializeComponent();
        }

        private void BirDerstenOgrenciCikar_Load(object sender, System.EventArgs e)
        {
            DersleriCek();
        }

        private void OgrenciyiSil_Click(object sender, System.EventArgs e)
        {
            if (veritabani.State == ConnectionState.Closed)
            {
                veritabani.Open();
            }

            if (Dersler.Text == "" || OgrenciNo.Text == "" || GorevliOgretmenParolasi.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Doğru Şekilde Doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GorevliOgretmenParolasi.Clear();
            }
            else if (!OgrenciNo.Text.All(char.IsDigit))
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Doğru Şekilde Doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GorevliOgretmenParolasi.Clear();
            }
            else
            {
                string dersadi = Dersler.Text;
                string ogrencino = OgrenciNo.Text;
                string parola = GorevliOgretmenParolasi.Text;
                int kayitSayisi=0;

                try
                {
                    if (dersadi=="ÖğrenciBilgileri")
                    {
                        OleDbCommand komut = new OleDbCommand($"SELECT * FROM YöneticiParolası Where Parola='{parola}'", veritabani);
                        OleDbDataReader oku = komut.ExecuteReader();

                        if (oku.Read())
                        {
                            OleDbCommand kontrolKomut = new OleDbCommand($"SELECT COUNT(*) FROM ÖğrenciBilgileri WHERE ÖğrenciNo='{ogrencino}'", veritabani);
                            kayitSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());
                            
                            if (kayitSayisi > 0) 
                            {
                                OleDbCommand komuttt = new OleDbCommand($"DELETE FROM {dersadi} WHERE ÖğrenciNo ='{ogrencino}'", veritabani);
                                komuttt.ExecuteNonQuery();
                                OgrenciNo.Clear();
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
                        OleDbCommand komut = new OleDbCommand($"SELECT * FROM GörevliBilgileri Where Parola='{parola}' and DersAdı='{dersadi}'", veritabani);
                        OleDbDataReader oku = komut.ExecuteReader();

                        if (oku.Read())
                        {
                            bool ogrenciBulundu = false;

                            try
                            {
                                OleDbCommand komutKontrol = new OleDbCommand($"SELECT COUNT(*) FROM {dersadi}_ WHERE ÖğrenciNo='{ogrencino}'", veritabani);
                                kayitSayisi = Convert.ToInt32(komutKontrol.ExecuteScalar());

                                if (kayitSayisi > 0)
                                {
                                    OleDbCommand komutt = new OleDbCommand($"DELETE FROM {dersadi}_ WHERE ÖğrenciNo ='{ogrencino}'", veritabani);
                                    komutt.ExecuteNonQuery();
                                    ogrenciBulundu = true;
                                }
                                else
                                {
                                    ogrenciBulundu = false;
                                }
                            }
                            catch (Exception)
                            {
                                 MessageBox.Show("Lütfen Gerekli Yerleri Doğru Şekilde Doldurunuz !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                GorevliOgretmenParolasi.Clear();

                            }

                            if (ogrenciBulundu)
                            {
                                MessageBox.Show($"{dersadi} Dersinden Öğrenci Silme Başarılı !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GorevliOgretmenParolasi.Clear();
                            }
                            else
                            {
                                 MessageBox.Show("Öğrenci Bulunamadı !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                 GorevliOgretmenParolasi.Clear();
                            }
                        }
                        else
                        {
                            GorevliOgretmenParolasi.Clear();
                            MessageBox.Show("Parola Yanlış Tekrar Deneyiniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen Gerekli Yerleri Doğru Şekilde Doldurunuz !");
                    GorevliOgretmenParolasi.Clear();
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
    }
}
