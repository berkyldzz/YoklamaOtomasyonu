using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;

namespace YoklamaOtomasyonu
{
    public partial class DersEkle : Form
    {
        OleDbConnection veritabani = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\YoklamaDatabase.accdb;Jet OLEDB:Database Password=232323;");
        AnaEkran anaekran = Application.OpenForms.OfType<AnaEkran>().FirstOrDefault();
        GirisEkrani girisekrani = Application.OpenForms.OfType<GirisEkrani>().FirstOrDefault();

        public DersEkle()
        {
            InitializeComponent();
        }

        private void DersEkle_Load(object sender, EventArgs e)
        {
            veritabani.Open();
        }

        private void DersiEkle_Click(object sender, EventArgs e)
        {
            string dersadi = DersAdi.Text.Trim().ToUpper().Replace(" ","");
            string devamhakki = Devamsizlik.Text.Trim();
            string yoklamaparolasi = YoklamaParola.Text;
            string yöneticiparolasi = YoneticiParola.Text;

            try
            {

                OleDbCommand komu = new OleDbCommand("SELECT * FROM YöneticiParolası Where Parola=@parola", veritabani);
                    komu.Parameters.AddWithValue("@parola", yöneticiparolasi);
                        OleDbDataReader oku = komu.ExecuteReader();

                DataTable tablolar = veritabani.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                    bool tabloVarMi = tablolar.AsEnumerable().Any(row => row["TABLE_NAME"].ToString() == dersadi + "_");

                if (dersadi == "" || devamhakki == "" || yoklamaparolasi == "")
                {
                    MessageBox.Show("Gerekli Bilgileri Doğru Şekilde Doldurunuz !","",MessageBoxButtons.OK,MessageBoxIcon.Error); 
                    YoklamaParola.Clear();
                    YoneticiParola.Clear();

                }
                else if (int.TryParse(dersadi, out int dersAdiInt))
                {
                    MessageBox.Show("Lütfen Geçerli Bir Ders Adı Giriniz !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    YoklamaParola.Clear();
                    YoneticiParola.Clear();
                }
                else if (tabloVarMi)
                {
                    MessageBox.Show("Ders Zaten Mevcut !","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    YoklamaParola.Clear();
                    YoneticiParola.Clear();
                }
                else if (yoklamaparolasi.Length < 6)
                {
                    MessageBox.Show("Güvenliğiniz İçin En Az 6 Karakter İçeren Bir Parola Oluşturunuz !","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    YoklamaParola.Clear();
                    YoneticiParola.Clear();
                }
                else 
                { 

                    if (oku.Read())
                    {
                        OleDbCommand komut = new OleDbCommand($"INSERT INTO [GörevliBilgileri] (Parola,DersAdı) VALUES (@parola,@dersadi)",veritabani);
                            komut.Parameters.AddWithValue("@parola", yoklamaparolasi);
                               komut.Parameters.AddWithValue("@dersadi", dersadi);
                                   komut.ExecuteNonQuery();

                        OleDbCommand komutt = new OleDbCommand($"SELECT * INTO {dersadi+"_"} FROM [ÖğrenciBilgileri]", veritabani);
                           komutt.ExecuteNonQuery();

                        OleDbCommand komuttt = new OleDbCommand($"UPDATE {dersadi+"_"} SET MaxDevamsızlık = {devamhakki}",veritabani);
                            komuttt.ExecuteNonQuery();

                           MessageBox.Show("Ders Ekleme İşlemi Başarılı !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           YoneticiParola.Clear();
                           YoklamaParola.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Yönetici Parolası Yanlış Girildi!\n        Tekrar Deneyiniz !","",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        YoklamaParola.Clear();
                        YoneticiParola.Clear();
                    }

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void YoklamaParolaGizle_Click(object sender, EventArgs e)
        {
            if (YoklamaParola.UseSystemPasswordChar == false)
            {
                YoklamaParola.UseSystemPasswordChar = true;
                YoklamaParolaGizle.BackgroundImage = Properties.Resources.closeeye;
            }
            else
            {
                YoklamaParola.UseSystemPasswordChar = false;
                YoklamaParolaGizle.BackgroundImage = Properties.Resources.openneye;
            }
        }

        private void YoneticiParolaGizle_Click(object sender, EventArgs e)
        {
            if (YoneticiParola.UseSystemPasswordChar == false)
            {
                YoneticiParola.UseSystemPasswordChar = true;
                YoneticiParolaGizle.BackgroundImage = Properties.Resources.closeeye;
            }
            else
            {
                YoneticiParola.UseSystemPasswordChar = false;
                YoneticiParolaGizle.BackgroundImage = Properties.Resources.openneye;
            }
        }
        
        private void GeriDon_Click(object sender, EventArgs e)
        {
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
    }
}
