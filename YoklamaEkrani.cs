using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoklamaOtomasyonu
{
    public partial class YoklamaEkrani : Form
    {
        public YoklamaEkrani()
        {
            InitializeComponent();
        }

        readonly OleDbConnection veritabani = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\YoklamaDatabase.accdb;Jet OLEDB:Database Password=232323;");
        public static int devamsizlikhakki;
        public static int devamsizlik;
        DevamsizlikDurumu devamdurumu = Application.OpenForms.OfType<DevamsizlikDurumu>().FirstOrDefault();
        List<string> katilanlar = new List<string>();
        Dogrulama dogrulama;

        private void YoklamaEkrani_Load(object sender, EventArgs e)
        {
        }

        private void DevamDurumu_Click(object sender, EventArgs e)
        {
            
            if (dogrulama!=null && dogrulama.Visible == true)
            {
                dogrulama.Hide();
            }

            if(veritabani.State == ConnectionState.Closed)
            { 
                veritabani.Open();
            }

            if (OgrenciNo.Text == "")
            {
                MessageBox.Show("Lütfen Öğrenci Numarasını Giriniz !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            { 
                OleDbCommand komut = new OleDbCommand($"SELECT * FROM {GirisEkrani.ders+"_"} Where ÖğrenciNo='{OgrenciNo.Text.Trim()}'", veritabani);
                    OleDbDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                     devamsizlikhakki = Convert.ToInt32(oku["MaxDevamsızlık"]);
                     devamsizlik = Convert.ToInt32(oku["Devamsızlık"]);
                     isimlabel.Text = oku["AdSoyad"].ToString();


                    if (devamdurumu != null && devamdurumu.Visible)
                    {
                        devamdurumu.Close();

                        devamdurumu = new DevamsizlikDurumu();
                        devamdurumu.TopLevel = false;

                        panel2.Controls.Add(devamdurumu);

                        devamdurumu.Show();
                    }
                    else
                    {
                        devamdurumu = new DevamsizlikDurumu();
                        devamdurumu.TopLevel = false;

                        panel2.Controls.Add(devamdurumu);
                        devamdurumu.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Öğrenci Bulunamadı !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                
            }
        }

        private void Imzala_Click(object sender, EventArgs e)
        {
            if (dogrulama!=null && dogrulama.Visible == true)
            {
                dogrulama.Hide();
            }

            if (devamdurumu != null && devamdurumu.Visible)
            {
                devamdurumu.Close();
            }

            if (veritabani.State == ConnectionState.Closed)
            {
                veritabani.Open();
            }

            if (OgrenciNo.Text == "")
            {
                MessageBox.Show("Lütfen Öğrenci Numarasını Giriniz !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OleDbCommand komut = new OleDbCommand($"SELECT * FROM {GirisEkrani.ders + "_"} Where ÖğrenciNo='{OgrenciNo.Text.Trim()}'", veritabani);
                OleDbDataReader oku = komut.ExecuteReader();

                if(oku.Read())
                {
                    isimlabel.Text = oku["AdSoyad"].ToString();
                    katilanlar.Add(OgrenciNo.Text);
                    YoklamaAlindiMi.Text = "Yoklama İmzalandı !";
                }
                else
                {
                    MessageBox.Show("Öğrenci Bulunamadı!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            dogrulama = new Dogrulama();
                dogrulama.TopLevel = false;
                    panel2.Controls.Add(dogrulama);
                        if (devamdurumu!=null && devamdurumu.Visible==true)
                        {
                            devamdurumu.Hide();

                        }
                            dogrulama.Show();
                                OgrenciNo.Clear();
                                    isimlabel.Text = "";
                                        YoklamaAlindiMi.Text = "";
        }

        private void OgrenciNo_Click(object sender, EventArgs e)
        {
            YoklamaAlindiMi.Text = "";
            isimlabel.Text = "";
        }

        private void YoneticiParolaGizle_Click(object sender, EventArgs e)
        {
            if (OgrenciNo.UseSystemPasswordChar == false)
            {
                OgrenciNo.UseSystemPasswordChar = true;
                yoneticiparolagizle.BackgroundImage = Properties.Resources.closeeye;
            }
            else
            {
                OgrenciNo.UseSystemPasswordChar = false;
                yoneticiparolagizle.BackgroundImage = Properties.Resources.openneye;
            }
        }
    }
}
