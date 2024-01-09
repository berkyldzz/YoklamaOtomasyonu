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
            }
            else
            {
                string dersadi=Dersler.Text.ToUpper();
                string adsoyad = AdSoyad.Text.Trim().ToUpper();
                string ogrencino = OgrenciNo.Text;
                string parola = GorevliOgretmenParolasi.Text;
                int maxdevamsizlik=0;

                try
                {

                    OleDbCommand komut = new OleDbCommand($"SELECT * FROM GörevliBilgileri Where Parola='{parola}' and DersAdı='{dersadi}'", veritabani);
                    OleDbDataReader oku = komut.ExecuteReader();

                    OleDbCommand komuttt = new OleDbCommand($"SELECT MaxDevamsızlık FROM {dersadi + "_"}", veritabani);
                    OleDbDataReader okuu = komuttt.ExecuteReader();
                    if (okuu.Read())
                    {
                        maxdevamsizlik = Convert.ToInt32(okuu["MaxDevamsızlık"]);
                    }
                    if (oku.Read())
                    {
                        OleDbCommand komutt = new OleDbCommand($"INSERT INTO {dersadi+"_"} (AdSoyad, ÖğrenciNo, Mail, Devamsızlık, MaxDevamsızlık) VALUES ('{adsoyad}', '{ogrencino}', '{ogrencino+"@firat.edu.tr"}', 0, {maxdevamsizlik})",veritabani);
                        komutt.ExecuteNonQuery();
                        
                        MessageBox.Show("Öğrenci Ekleme Başarılı !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Parola Yanlış Tekrar Deneyiniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen Gerekli Yerleri Doğru Şekilde Doldurunuz !");
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
                this.ders = tablo["TABLE_NAME"].ToString();

                if (this.ders.EndsWith("_") && !Dersler.Items.Contains(ders.Replace("_", "")))
                {
                    Dersler.Items.Add(this.ders.Remove(this.ders.Length - 1));
                }

            }
        }
    }
}
