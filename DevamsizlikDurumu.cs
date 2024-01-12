using System;
using System.Drawing;
using System.Windows.Forms;

namespace YoklamaOtomasyonu
{
    public partial class DevamsizlikDurumu : Form
    {
        public DevamsizlikDurumu()
        {
            InitializeComponent();
        }

        private void DevamsizlikDurumu_Load(object sender, EventArgs e)
        {
            DurumuGoster();
        }

        public void DurumuGoster()
        {
            if (YoklamaEkrani.devamsizlikhakki < YoklamaEkrani.devamsizlik)
            {
                progressBar1.Maximum = 100;
                progressBar1.Value = 100;
                pictureBox1.Image = Properties.Resources.warning;
                DevamHakki.Text = "Devamsızlık Hakkı : " + YoklamaEkrani.devamsizlikhakki.ToString() + " Ders";
                DevamsizlikSayisi.Text = "Devamsızlık Sayısı : " + YoklamaEkrani.devamsizlik.ToString() + " Ders";
                progressBar1.ForeColor = Color.Red;

            }
            else 
            { 
            progressBar1.Maximum = YoklamaEkrani.devamsizlikhakki;
            progressBar1.Value = YoklamaEkrani.devamsizlik;
            DevamHakki.Text = "Devamsızlık Hakkı : "+YoklamaEkrani.devamsizlikhakki.ToString()+" Ders";
            DevamsizlikSayisi.Text="Devamsızlık Sayısı : "+YoklamaEkrani.devamsizlik.ToString()+" Ders";
            progressBar1.ForeColor = Color.Red;
                if (YoklamaEkrani.devamsizlik == 0 || ((double)YoklamaEkrani.devamsizlik / YoklamaEkrani.devamsizlikhakki <= 0.5))
                {
                    pictureBox1.Image = Properties.Resources.ok;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.warning;
                }
            }
           
        }

        private void Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
