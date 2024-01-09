using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoklamaOtomasyonu
{
    public partial class FiltreOgrenciNo : Form
    {
        YoklamaDurumu_YoneticiPaneli_ yoklamadurum;
        public FiltreOgrenciNo()
        {
            InitializeComponent();
        }

        private void Filtrele_Click(object sender, EventArgs e)
        {
            yoklamadurum = Application.OpenForms.OfType<YoklamaDurumu_YoneticiPaneli_>().FirstOrDefault();

            if (altsinir.Text == "") { altsinir.Text = "0"; }

            try
            {
                yoklamadurum.Filtrele(Convert.ToInt32(altsinir.Text), Convert.ToInt32(ustsinir.Text));
                altsinir.Clear();
                ustsinir.Clear();

            }
            catch(FormatException)
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Doğru Bir Şekilde Doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
