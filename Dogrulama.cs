using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace YoklamaOtomasyonu
{
    public partial class Dogrulama : Form
    {
        GirisEkrani girisekrani = Application.OpenForms.OfType<GirisEkrani>().FirstOrDefault();
        YoklamaEkrani yoklamaekrani = Application.OpenForms.OfType<YoklamaEkrani>().FirstOrDefault();
        readonly OleDbConnection veritabani = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\YoklamaDatabase.accdb;Jet OLEDB:Database Password=232323;");
        
        public Dogrulama()
        {
            InitializeComponent();
        }
       
        private void ParolaGizle_Click(object sender, EventArgs e)
        {
            if (Parola.UseSystemPasswordChar == false)
            {
                Parola.UseSystemPasswordChar = true;
                ParolaGizle.BackgroundImage = Properties.Resources.closeeye;
            }
            else
            {
                Parola.UseSystemPasswordChar = false;
                ParolaGizle.BackgroundImage = Properties.Resources.openneye;
            }
        }

        private void Kapat_Click(object sender, EventArgs e)
        {
            Parola.Clear();
            this.Hide();
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            if (veritabani.State == ConnectionState.Closed)
            {
                veritabani.Open();
            }
            if (Parola.Text == "")
            {
                MessageBox.Show("Lütfen Parolayı Giriniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                OleDbCommand komut = new OleDbCommand($"SELECT * FROM GörevliBilgileri Where Parola='{Parola.Text}' and DersAdı='{GirisEkrani.ders}'", veritabani);
                OleDbDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    string katilanlarString = string.Join("','", YoklamaEkrani.katilanlar);

                    OleDbCommand komutt = new OleDbCommand($"UPDATE {GirisEkrani.ders}_ SET Devamsızlık=Devamsızlık+1 WHERE ÖğrenciNo NOT IN ('{katilanlarString}')", veritabani);
                    komutt.ExecuteNonQuery();

                    OleDbCommand komutttt = new OleDbCommand($"UPDATE {GirisEkrani.ders}_ SET DevamsızlıkTarihleri = DevamsızlıkTarihleri & '#{yoklamaekrani.Tarih.Text}#' WHERE ÖğrenciNo NOT IN ('{katilanlarString}')", veritabani);
                    komutttt.ExecuteNonQuery();

                    this.Hide();
                    yoklamaekrani.Hide();
                    girisekrani.DersleriCek();
                    girisekrani.Show();
                    Parola.Clear();
                }
                else
                {
                    MessageBox.Show("Hatalı Parola!\nTekrar Deneyiniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Parola.Clear();
                }
            }

            
                
        }

    }
}
