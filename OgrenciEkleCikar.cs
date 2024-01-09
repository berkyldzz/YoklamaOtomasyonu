using System.Linq;
using System.Windows.Forms;

namespace YoklamaOtomasyonu
{
    public partial class OgrenciEkleCikar : Form
    {
        GirisEkrani girisekrani;
        BirDerseOgrenciEkle birderseogrenciekle;
        BirDerstenOgrenciCikar birderstenogrencicikar;
        TumDerslereOgrenciEkle tumderslereogrenciekle;
        TumDerslerdenCikar tumderslerdencikar;

        public OgrenciEkleCikar()
        {
            InitializeComponent();
        }

        private void GeriDon_Click(object sender, System.EventArgs e)
        {
            girisekrani = Application.OpenForms.OfType<GirisEkrani>().FirstOrDefault();

            TumDerslerdenCikar.Checked = false;
            TumDerslereEkle.Checked= false;
            BirDerseEkle.Checked = false;
            BirDerstenCikar.Checked = false;

            this.Hide();
            girisekrani.Show();
            
        }

        private void BirDerseEkle_CheckedChanged(object sender, System.EventArgs e)
        {
            birderseogrenciekle = Application.OpenForms.OfType<BirDerseOgrenciEkle>().FirstOrDefault();
            
            if(birderstenogrencicikar != null && birderstenogrencicikar.Visible == true)
            {
                birderstenogrencicikar.Hide();
            }

            if (tumderslereogrenciekle != null && tumderslereogrenciekle.Visible == true)
            {
                tumderslereogrenciekle.Hide();
            }

            if (tumderslerdencikar != null && tumderslerdencikar.Visible == true)
            {
                tumderslerdencikar.Hide();
            }

            if (birderseogrenciekle == null)
            {
                birderseogrenciekle = new BirDerseOgrenciEkle();
                birderseogrenciekle.TopLevel = false;
                panel1.Controls.Add(birderseogrenciekle);
            }

            birderseogrenciekle.DersleriCek();
            birderseogrenciekle.Show();
        }

        private void BirDerstenCikar_CheckedChanged(object sender, System.EventArgs e)
        {
            birderstenogrencicikar = Application.OpenForms.OfType<BirDerstenOgrenciCikar>().FirstOrDefault();

            if(birderseogrenciekle != null && birderseogrenciekle.Visible == true)
            {
                birderseogrenciekle.Hide();
            }

            if (tumderslereogrenciekle != null && tumderslereogrenciekle.Visible == true)
            {
                tumderslereogrenciekle.Hide();
            }
           
            if (tumderslerdencikar != null && tumderslerdencikar.Visible == true)
            {
                tumderslerdencikar.Hide();
            }

            if (birderstenogrencicikar == null)
            {
                birderstenogrencicikar = new BirDerstenOgrenciCikar();
                birderstenogrencicikar.TopLevel = false;
                panel1.Controls.Add(birderstenogrencicikar);
            }
            
            birderstenogrencicikar.DersleriCek();
            birderstenogrencicikar.Show();
        }

        private void TumDerslereEkle_CheckedChanged(object sender, System.EventArgs e)
        {
            tumderslereogrenciekle = Application.OpenForms.OfType<TumDerslereOgrenciEkle>().FirstOrDefault();

            if(birderseogrenciekle != null && birderseogrenciekle.Visible == true)
            {
                birderseogrenciekle.Hide();
            }

            if (birderstenogrencicikar != null && birderstenogrencicikar.Visible == true)
            {
                birderstenogrencicikar.Hide();
            }

            if (tumderslerdencikar != null && tumderslerdencikar.Visible == true)
            {
                tumderslerdencikar.Hide();
            }

            if (tumderslereogrenciekle == null)
            {
                tumderslereogrenciekle = new TumDerslereOgrenciEkle();
                tumderslereogrenciekle.TopLevel = false;
                panel1.Controls.Add(tumderslereogrenciekle);
            }

            tumderslereogrenciekle.Show();

        }

        private void TumDerslerdenCikar_CheckedChanged(object sender, System.EventArgs e)
        {
            tumderslerdencikar=Application.OpenForms.OfType<TumDerslerdenCikar>().FirstOrDefault();

            if (birderseogrenciekle != null && birderseogrenciekle.Visible == true)
            {
                birderseogrenciekle.Hide();
            }

            if (birderstenogrencicikar != null && birderstenogrencicikar.Visible == true)
            {
                birderstenogrencicikar.Hide();
            }

            if (tumderslereogrenciekle != null && tumderslereogrenciekle.Visible ==true)
            {
                tumderslereogrenciekle.Hide();
            }

            if (tumderslerdencikar == null)
            {
                tumderslerdencikar = new TumDerslerdenCikar();
                tumderslerdencikar.TopLevel = false;
                panel1.Controls.Add(tumderslerdencikar);
            }

            tumderslerdencikar.Show();
        }
    }
}
