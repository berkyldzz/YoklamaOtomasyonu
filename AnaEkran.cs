using System;
using System.Linq;
using System.Windows.Forms;

namespace YoklamaOtomasyonu
{
    public partial class AnaEkran : Form
    {
        DialogResult cevap;
        Dogrulama2 dogrulama= new Dogrulama2 ();

        public AnaEkran()
        {
            InitializeComponent();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            GirisEkrani girisekrani = new GirisEkrani();
                girisekrani.TopLevel = false;
                    girisekrani.TopMost = true;
                        AnaPanel.Controls.Add(girisekrani);
                            girisekrani.Show();
        }
    }
}
