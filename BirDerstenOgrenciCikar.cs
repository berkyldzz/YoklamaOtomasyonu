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
            }
            else
            {
                string dersadi = Dersler.Text.ToUpper();
                string ogrencino = OgrenciNo.Text;
                string parola = GorevliOgretmenParolasi.Text;

                try
                {

                    OleDbCommand komut = new OleDbCommand($"SELECT * FROM GörevliBilgileri Where Parola='{parola}' and DersAdı='{dersadi}'", veritabani);
                    OleDbDataReader oku = komut.ExecuteReader();

                    if (oku.Read())
                    {
                        OleDbCommand komutt = new OleDbCommand($"DELETE FROM {dersadi+"_"} WHERE ÖğrenciNo ='{ogrencino}'",veritabani);
                        komutt.ExecuteNonQuery();

                        MessageBox.Show("Öğrenci Silme Başarılı !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GorevliOgretmenParolasi.Clear();
                    }
                    else
                    {
                        GorevliOgretmenParolasi.Clear();
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
