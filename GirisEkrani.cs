using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace YoklamaOtomasyonu
{
    public partial class GirisEkrani : Form
    {
        readonly OleDbConnection veritabani = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\YoklamaDatabase.accdb;Jet OLEDB:Database Password=232323;");
        AnaEkran anaekran = Application.OpenForms.OfType<AnaEkran>().FirstOrDefault();
        public static string ders;
        DersEkle dersekle;
        SifreYenile sifreyenile;
        public static YoklamaEkrani yoklamaekrani;
        DataTable VTDersler;
        YoklamaDurumu_YoneticiPaneli_ yoklamadurumu;
        OgrenciEkleCikar ogrencieklecikar;

        public GirisEkrani()
        {
            InitializeComponent();
        }
 
        private void GirisEkrani_load(object sender, EventArgs e)
        {
            DersleriCek();
        }

        private void GirisYap_Click(object sender, EventArgs e)
        {
            ders = Dersler.Text;
            
            OleDbCommand komut = new OleDbCommand($"SELECT * FROM GörevliBilgileri Where Parola='{Parola.Text}' and DersAdı='{ders}'", veritabani);
                OleDbDataReader oku = komut.ExecuteReader();

            if (Parola.Text==""||Dersler.Text=="")
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Doğru Şekilde Doldurun !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (oku.Read())
                {
                    if (yoklamaekrani == null)
                    {
                        yoklamaekrani = new YoklamaEkrani();
                        yoklamaekrani.TopLevel = false;
                        anaekran.AnaPanel.Controls.Add(yoklamaekrani);
                    }
                        yoklamaekrani.Dersadilabel.Text = ders;
                        this.Hide();
                        yoklamaekrani.Show();  
                        Parola.Clear();
                }
                else
                {
                    MessageBox.Show("Hatalı Parola!\nTekrar Deneyiniz!","",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Parola.Clear();
                }
            }
        }

        private void YeniDers_Click(object sender, EventArgs e)
        {
            dersekle = Application.OpenForms.OfType<DersEkle>().FirstOrDefault();
           
            if (dersekle == null) 
            { 
                dersekle = new DersEkle();
                dersekle.TopLevel = false;
                anaekran.AnaPanel.Controls.Add(dersekle);
            }
                    this.Hide();
                    dersekle.Show();
            Parola.Clear();
        }

        private void SifreYenile_Click(object sender, EventArgs e)
        {
            sifreyenile = Application.OpenForms.OfType<SifreYenile>().FirstOrDefault();
            
            if (sifreyenile == null)
            {
                sifreyenile = new SifreYenile();
                sifreyenile.TopLevel = false;
                anaekran.AnaPanel.Controls.Add(sifreyenile);
            }
            
            Parola.Clear();
            sifreyenile.DersleriCek();
            this.Hide();
            sifreyenile.Show();
        }

        private void YoklamaDurumu_Click(object sender, EventArgs e)
        {
            ders = Dersler.Text;

            if (Dersler.Text == "" || Parola.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Doldurunuz !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OleDbCommand komut = new OleDbCommand($"SELECT * FROM GörevliBilgileri Where Parola='{Parola.Text}' and DersAdı='{ders}'", veritabani);
                OleDbDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    if (yoklamadurumu == null)
                    {
                        yoklamadurumu = new YoklamaDurumu_YoneticiPaneli_();
                        yoklamadurumu.TopLevel = false;
                        anaekran.AnaPanel.Controls.Add(yoklamadurumu);
                    }
                    Parola.Clear();
                    this.Hide();
                    yoklamadurumu.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı Parola!\nTekrar Deneyiniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Parola.Clear();
                }
            }
        }

        private void ParolaGizle_Click(object sender, EventArgs e)
        {
            if (Parola.UseSystemPasswordChar == false)
            {
                Parola.UseSystemPasswordChar = true;
                parolasett.BackgroundImage = Properties.Resources.closeeye;
            }
            else
            {
                Parola.UseSystemPasswordChar = false;
                parolasett.BackgroundImage = Properties.Resources.openneye;
            }
        }

        public void DersleriCek()
        {
            string derss ;

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

        private void OgrenciEkleCikar_Click(object sender, EventArgs e)
        {
            ogrencieklecikar = Application.OpenForms.OfType<OgrenciEkleCikar>().FirstOrDefault();

            if (ogrencieklecikar == null)
            {
                ogrencieklecikar = new OgrenciEkleCikar();
                ogrencieklecikar.TopLevel = false;
                anaekran.AnaPanel.Controls.Add(ogrencieklecikar);
            }
            this.Hide();
            ogrencieklecikar.Show();
        }
    }
}
