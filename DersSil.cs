using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace YoklamaOtomasyonu
{
    public partial class DersSil : Form
    {
        OleDbConnection veritabani = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\YoklamaDatabase.accdb;Jet OLEDB:Database Password=232323;");
        GirisEkrani girisekrani = Application.OpenForms.OfType<GirisEkrani>().FirstOrDefault();
        AnaEkran anaekran = Application.OpenForms.OfType<AnaEkran>().FirstOrDefault();
        DataTable VTDersler;
        public DersSil()
        {
            InitializeComponent();
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            yoklamaparolasi.Clear();

            if (girisekrani == null)
            {
                girisekrani = new GirisEkrani();
                girisekrani.TopLevel = false;
                anaekran.AnaPanel.Controls.Add(girisekrani);
            }
            girisekrani.DersleriCek();
            this.Hide();
            girisekrani.Show();
        }

        public void DersleriCek()
        {
            string derss;

            if (veritabani.State == ConnectionState.Closed)
            {
                veritabani.Open();
            }

            VTDersler = veritabani.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

            Dersler.Items.Clear();

            foreach (DataRow tablo in VTDersler.Rows)
            {
                derss = tablo["TABLE_NAME"].ToString();

                if (derss.EndsWith("_") && !Dersler.Items.Contains(derss.Replace("_", "")))
                {
                    Dersler.Items.Add(derss.Remove(derss.Length - 1));
                }
            }
        }

        private void DersiSil_Click(object sender, EventArgs e)
        {
            if(Dersler.Text==""|| yoklamaparolasi.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Doğru Bir Şekilde Doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OleDbCommand komut = new OleDbCommand($"SELECT * FROM GörevliBilgileri Where Parola='{yoklamaparolasi.Text}' and DersAdı='{Dersler.Text}'", veritabani);
                OleDbDataReader oku = komut.ExecuteReader();

                if (oku.Read()) 
                {
                        OleDbCommand komuttt = new OleDbCommand($"DROP TABLE {Dersler.Text}_", veritabani);
                        komuttt.ExecuteNonQuery();

                        OleDbCommand komutttt = new OleDbCommand($"DELETE FROM GörevliBilgileri WHERE DersAdı ='{Dersler.Text}'", veritabani);
                        komutttt.ExecuteNonQuery();

                        MessageBox.Show("Ders Silme İşlemi Başarılı !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        yoklamaparolasi.Clear();
                }
                else
                {
                    MessageBox.Show("Parola Yanlış Tekrar Deneyiniz !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    yoklamaparolasi.Clear();
                }
            }
           
        }
    }
}
