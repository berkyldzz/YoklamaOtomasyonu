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
            }
            else
            {
                string ogrencino = OgrenciNo.Text;
                string parola = YoneticiParolasi.Text;

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
                                    OleDbCommand komutt = new OleDbCommand($"DELETE FROM {ders} WHERE ÖğrenciNo ='{ogrencino}'", veritabani);
                                    komutt.ExecuteNonQuery();                  
                            }
                        }
                        MessageBox.Show("Öğrenci Silme Başarılı !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Parola Yanlış Tekrar Deneyiniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen Gerekli Yerleri Doğru Şekilde Giriniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }
    }
}
