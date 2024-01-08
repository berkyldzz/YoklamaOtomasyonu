using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace YoklamaOtomasyonu
{
    public partial class SifreYenile : Form
    {
        AnaEkran anaekran = Application.OpenForms.OfType<AnaEkran>().FirstOrDefault();
        GirisEkrani girisekrani = Application.OpenForms.OfType<GirisEkrani>().FirstOrDefault();
        OleDbConnection veritabani = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\YoklamaDatabase.accdb;Jet OLEDB:Database Password=232323;");
        DataTable VTDersler;
        String ders;

        public SifreYenile()
        {
            InitializeComponent();
        }
               
        private void SifreYenile_Load(object sender, EventArgs e)
        {
            DersleriCek();
        }

        private void ParolayiDegistir_Click(object sender, EventArgs e)
        {
            string dersadi = Dersler.Text.Trim();
                string yoneticiparolasi = YoneticiParolasi.Text;
                    string yeniparola = YeniParola.Text;

            OleDbCommand komut = new OleDbCommand("SELECT * FROM YöneticiParolası Where Parola=@parola", veritabani);
                komut.Parameters.AddWithValue("@parola", yoneticiparolasi);
                    OleDbDataReader oku = komut.ExecuteReader();

            if (dersadi == "" || yeniparola == "")
            {
                MessageBox.Show("Gerekli Bilgileri Doğru Şekilde Giriniz !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                YeniParola.Clear();
                YoneticiParolasi.Clear();
            }
            else if (yeniparola.Length < 6)
            {
                MessageBox.Show("Güvenliğiniz İçin En Az 6 Karakter İçeren Bir Parola Oluşturunuz !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                YeniParola.Clear();
                YoneticiParolasi.Clear();
            }
            else
            {    
                if (oku.Read()) 
                {

                    OleDbCommand komutt = new OleDbCommand($"UPDATE GörevliBilgileri SET Parola ='{yeniparola}' WHERE DersAdı ='{dersadi}'", veritabani);
                    komutt.ExecuteNonQuery();
                   
                   MessageBox.Show("Yoklama Parolası Güncellendi !","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    YeniParola.Clear();
                    YoneticiParolasi.Clear();
                }
                else
                {
                    MessageBox.Show("Yönetici Parolası Hatalı !\nTekrar Deneyiniz !","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    YeniParola.Clear();
                    YoneticiParolasi.Clear();
                }

            }

        }

        private void YoneticiParolaGizle_Click(object sender, EventArgs e)
        {
            if (YoneticiParolasi.UseSystemPasswordChar == false)
            {
                YoneticiParolasi.UseSystemPasswordChar= true;
                yoneticiparolagizle.BackgroundImage=Properties.Resources.closeeye;
            }
            else
            {
                YoneticiParolasi.UseSystemPasswordChar = false;
                yoneticiparolagizle.BackgroundImage = Properties.Resources.openneye;
            }
        }

        private void YeniParolaGizle_Click(object sender, EventArgs e)
        {
            if (YeniParola.UseSystemPasswordChar == false)
            {
                YeniParola.UseSystemPasswordChar = true;
                yeniparolagizle.BackgroundImage = Properties.Resources.closeeye;
            }
            else
            {
                YeniParola.UseSystemPasswordChar = false;
                yeniparolagizle.BackgroundImage = Properties.Resources.openneye;
            }
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            girisekrani.Show();
            this.Hide();
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
