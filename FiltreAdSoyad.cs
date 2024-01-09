using System;
using System.Linq;
using System.Windows.Forms;

namespace YoklamaOtomasyonu
{
    public partial class FiltreAdSoyad : Form
    {
        YoklamaDurumu_YoneticiPaneli_ yoklamadurumu;
        public FiltreAdSoyad()
        {
            InitializeComponent();
        }

        private void Filtrele_Click(object sender, EventArgs e)
        {
            yoklamadurumu = Application.OpenForms.OfType<YoklamaDurumu_YoneticiPaneli_>().FirstOrDefault();
            if (AdSoyad.Text == "")
            {
                MessageBox.Show("Lütfen Ad Soyad Giriniz!","",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            { 
                try
                {
                    yoklamadurumu.Filtrele(AdSoyad.Text.ToUpper());
                    AdSoyad.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen Gerekli Yerleri Doğru Bir Şekilde Doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }
    }
}
