using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace YoklamaOtomasyonu
{
    public partial class AnaEkran : Form
    {
        Dogrulama2 dogrulama2;
        GirisEkrani girisekrani;
        YoklamaEkrani yoklamaekrani;
        DevamsizlikDurumu devamdurumu;
        Dogrulama dogrulama;
        private bool surukleniyor = false;
        private Point surukleBaslangicNoktasi;

        public AnaEkran()
        {
            InitializeComponent();
            this.MouseDown += AnaEkran_MouseDown;
            this.MouseMove += AnaEkran_MouseMove;
            this.MouseUp += AnaEkran_MouseUp;
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            girisekrani = new GirisEkrani();
                girisekrani.TopLevel = false;
                    girisekrani.TopMost = true;
                        AnaPanel.Controls.Add(girisekrani);
                            girisekrani.Show();
        }

        private void Kapat_Click(object sender, EventArgs e)
        {
            yoklamaekrani = Application.OpenForms.OfType<YoklamaEkrani>().FirstOrDefault();

            if (dogrulama!=null && dogrulama.Visible == true)
            {
                dogrulama.Visible = false;
            }

            if ( yoklamaekrani == null )
            {
                Application.Exit();
            }
            else if (yoklamaekrani.Visible == false)
            {
                Application.Exit();
            }
            else
            {
                dogrulama2=Application.OpenForms.OfType<Dogrulama2>().FirstOrDefault();
                devamdurumu=Application.OpenForms.OfType<DevamsizlikDurumu>().FirstOrDefault();

                if( devamdurumu != null && devamdurumu.Visible == true)
                {
                    devamdurumu.Visible = false;
                }

                if (dogrulama != null && dogrulama.Visible == true)
                {
                    dogrulama.Visible = false;
                }

                if (dogrulama2 == null)
                {
                    dogrulama2 = new Dogrulama2();
                    dogrulama2.TopLevel = false;
                    yoklamaekrani.panel2.Controls.Add(dogrulama2);
                }
                    dogrulama2.Show();
            }                
        }
        
        private void AnaEkran_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                surukleniyor = true;
                surukleBaslangicNoktasi = e.Location;
            }
        }

        private void AnaEkran_MouseMove(object sender, MouseEventArgs e)
        {
            if (surukleniyor)
            {
                Point yeniKonum = this.PointToScreen(new Point(e.X - surukleBaslangicNoktasi.X, e.Y - surukleBaslangicNoktasi.Y));
                this.Location = yeniKonum;
            }
        }

        private void AnaEkran_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                surukleniyor = false;
            }
        }
    }
}
