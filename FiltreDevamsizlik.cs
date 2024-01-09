using System;
using System.Linq;
using System.Windows.Forms;

namespace YoklamaOtomasyonu
{
    public partial class FiltreDevamsizlik : Form
    {
        YoklamaDurumu_YoneticiPaneli_ yoklamadurumu;

        public FiltreDevamsizlik()
        {
            InitializeComponent();
        }

        private void Filtrele_Click(object sender, EventArgs e)
        {
            yoklamadurumu = Application.OpenForms.OfType<YoklamaDurumu_YoneticiPaneli_>().FirstOrDefault();
            
            if (altsinir.Text == "") { altsinir.Text = "0"; }

            try
            {
                yoklamadurumu.Filtrele(Convert.ToInt32(altsinir.Text),Convert.ToInt32(ustsinir.Text));
                altsinir.Clear();
                ustsinir.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Doğru Bir Şekilde Doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
