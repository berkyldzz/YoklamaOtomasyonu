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

            if (birderstenogrencicikar != null && birderstenogrencicikar.Visible == true)
            {
                birderstenogrencicikar.OgrenciNo.Clear();
                birderstenogrencicikar.GorevliOgretmenParolasi.Clear();
                birderstenogrencicikar.Hide();
            }

            if (birderseogrenciekle != null && birderseogrenciekle.Visible == true)
            {
                birderseogrenciekle.AdSoyad.Clear();
                birderseogrenciekle.OgrenciNo.Clear();
                birderseogrenciekle.GorevliOgretmenParolasi.Clear();
                birderseogrenciekle.Hide();
            }

            if (tumderslereogrenciekle != null && tumderslereogrenciekle.Visible == true)
            {
                tumderslereogrenciekle.AdSoyad.Clear();
                tumderslereogrenciekle.YoneticiParolasi.Clear();
                tumderslereogrenciekle.OgrenciNo.Clear();
                tumderslereogrenciekle.Hide();
            }

            if (tumderslerdencikar != null && tumderslerdencikar.Visible == true)
            {
                tumderslerdencikar.OgrenciNo.Clear();
                tumderslerdencikar.YoneticiParolasi.Clear();
                tumderslerdencikar.Hide();
            }

            this.Hide();
            girisekrani.Show();
            
        }

        private void BirDerseEkle_CheckedChanged(object sender, System.EventArgs e)
        {
            birderseogrenciekle = Application.OpenForms.OfType<BirDerseOgrenciEkle>().FirstOrDefault();
            
            if(birderstenogrencicikar != null && birderstenogrencicikar.Visible == true)
            {
                birderstenogrencicikar.Dersler.Text = "";
                birderstenogrencicikar.OgrenciNo.Clear();
                birderstenogrencicikar.GorevliOgretmenParolasi.Clear();
                birderstenogrencicikar.Hide();
            }

            if (tumderslereogrenciekle != null && tumderslereogrenciekle.Visible == true)
            {
                tumderslereogrenciekle.AdSoyad.Clear();
                tumderslereogrenciekle.YoneticiParolasi.Clear();
                tumderslereogrenciekle.OgrenciNo.Clear();
                tumderslereogrenciekle.Hide();
            }

            if (tumderslerdencikar != null && tumderslerdencikar.Visible == true)
            {
                tumderslerdencikar.OgrenciNo.Clear();
                tumderslerdencikar.YoneticiParolasi.Clear();
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
                birderseogrenciekle.AdSoyad.Clear();
                birderseogrenciekle.OgrenciNo.Clear();
                birderseogrenciekle.Dersler.Text = "";
                birderseogrenciekle.GorevliOgretmenParolasi.Clear();
                birderseogrenciekle.Hide();
            }

            if (tumderslereogrenciekle != null && tumderslereogrenciekle.Visible == true)
            {
                tumderslereogrenciekle.AdSoyad.Clear();
                tumderslereogrenciekle.YoneticiParolasi.Clear();
                tumderslereogrenciekle.OgrenciNo.Clear();
                tumderslereogrenciekle.Hide();
            }

            if (tumderslerdencikar != null && tumderslerdencikar.Visible == true)
            {
                tumderslerdencikar.OgrenciNo.Clear();
                tumderslerdencikar.YoneticiParolasi.Clear();
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

            if (birderseogrenciekle != null && birderseogrenciekle.Visible == true)
            {
                birderseogrenciekle.AdSoyad.Clear();
                birderseogrenciekle.OgrenciNo.Clear();
                birderseogrenciekle.Dersler.Text = "";
                birderseogrenciekle.GorevliOgretmenParolasi.Clear();
                birderseogrenciekle.Hide();
            }

            if (birderstenogrencicikar != null && birderstenogrencicikar.Visible == true)
            {
                birderstenogrencicikar.Dersler.Text = "";
                birderstenogrencicikar.OgrenciNo.Clear();
                birderstenogrencicikar.GorevliOgretmenParolasi.Clear();
                birderstenogrencicikar.Hide();
            }

            if (tumderslerdencikar != null && tumderslerdencikar.Visible == true)
            {
                tumderslerdencikar.OgrenciNo.Clear();
                tumderslerdencikar.YoneticiParolasi.Clear();
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
                birderseogrenciekle.AdSoyad.Clear();
                birderseogrenciekle.OgrenciNo.Clear();
                birderseogrenciekle.Dersler.Text = "";
                birderseogrenciekle.GorevliOgretmenParolasi.Clear();
                birderseogrenciekle.Hide();
            }

            if (birderstenogrencicikar != null && birderstenogrencicikar.Visible == true)
            {
                birderstenogrencicikar.Dersler.Text = "";
                birderstenogrencicikar.OgrenciNo.Clear();
                birderstenogrencicikar.GorevliOgretmenParolasi.Clear();
                birderstenogrencicikar.Hide();
            }

            if (tumderslereogrenciekle != null && tumderslereogrenciekle.Visible == true)
            {
                tumderslereogrenciekle.AdSoyad.Clear();
                tumderslereogrenciekle.YoneticiParolasi.Clear();
                tumderslereogrenciekle.OgrenciNo.Clear();
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
