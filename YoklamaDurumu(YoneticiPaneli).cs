using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace YoklamaOtomasyonu
{
    public partial class YoklamaDurumu_YoneticiPaneli_ : Form
    {
        OleDbConnection veritabani = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\YoklamaDatabase.accdb;Jet OLEDB:Database Password=232323;");
        private List<ListViewItem> originalItems = new List<ListViewItem>();
        FiltreAdSoyad filtread;
        FiltreOgrenciNo filtreogrencino;
        FiltreDevamsizlık filtredevamsizlik;
        GirisEkrani girisekrani;
        AnaEkran anaekran;

        public YoklamaDurumu_YoneticiPaneli_()
        {
            InitializeComponent();
        }

        public void OgrencileriGetir(object sender, EventArgs e)
        {
            if (veritabani.State == ConnectionState.Closed)
            {
                veritabani.Open();
            }

            OleDbCommand komut = new OleDbCommand($"SELECT AdSoyad, ÖğrenciNo, Mail, Devamsızlık, MaxDevamsızlık FROM {GirisEkrani.ders + "_"}", veritabani);
            OleDbDataReader oku = komut.ExecuteReader();

            Tablo.View = View.Details;
            Tablo.GridLines = true;
            Tablo.Columns.Add("Ad Soyad", 130);
            Tablo.Columns.Add("Öğrenci No", 90);
            Tablo.Columns.Add("Mail", 170);
            Tablo.Columns.Add("Devamsızlık", 100);
            Tablo.Columns.Add("Devamsızlık Hakkı", 140);

            originalItems.Clear();

            while (oku.Read())
            {
                string[] row = new string[] { oku["AdSoyad"].ToString(), oku["ÖğrenciNo"].ToString(), oku["Mail"].ToString(), oku["Devamsızlık"].ToString(), oku["MaxDevamsızlık"].ToString() };
                ListViewItem listViewItem = new ListViewItem(row);
                Tablo.Items.Add(listViewItem);

                originalItems.Add(listViewItem);
            }
            oku.Close();
        }

        public void Filtrele(int alt, int üst)
        {
            if (OgrenciNoFiltre.Checked)
            {
                Tablo.Items.Clear();

                foreach (ListViewItem item in originalItems)
                {
                    try
                    {
                        int ogrenciNo = Convert.ToInt32(item.SubItems[1].Text);

                        if (ogrenciNo >= alt && ogrenciNo <= üst)
                        {
                            Tablo.Items.Add((ListViewItem)item.Clone());
                        }
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else if (DevamsizlikFiltre.Checked)
            {
            }
        }

        public void Filtrele(string adsoyad)
        {
            if (AdSoyadFiltre.Checked)
            {
                Tablo.Items.Clear();

                foreach (ListViewItem item in originalItems)
                {
                    try
                    {
                        string adisoyadi = item.SubItems[0].Text;

                        if (adsoyad == adisoyadi)
                        {
                            Tablo.Items.Add((ListViewItem)item.Clone());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void AdSoyadFiltre_CheckedChanged(object sender, EventArgs e)
        {
            filtread = Application.OpenForms.OfType<FiltreAdSoyad>().FirstOrDefault();
            if (filtread == null)
            {
                filtread = new FiltreAdSoyad();
                filtread.TopLevel = false;
                panel1.Controls.Add(filtread);
            }
            if (filtreogrencino!=null && filtreogrencino.Visible==true)
            {
                filtreogrencino.Hide();
            }
            if (filtredevamsizlik != null && filtredevamsizlik.Visible == true)
            {
                filtredevamsizlik.Hide();
            }
            filtread.Show();
        }

        private void OgrenciNoFiltre_CheckedChanged(object sender, EventArgs e)
        {
            filtreogrencino = Application.OpenForms.OfType<FiltreOgrenciNo>().FirstOrDefault();
            if (filtreogrencino == null)
            {
                filtreogrencino = new FiltreOgrenciNo();
                filtreogrencino.TopLevel = false;
                panel1.Controls.Add(filtreogrencino);
            }
            if (filtread!=null && filtread.Visible == true)
            {
                filtread.Hide();
            }
            if (filtredevamsizlik != null && filtredevamsizlik.Visible == true)
            {
                filtredevamsizlik.Hide();
            }
            filtreogrencino.Show();
        }

        private void DevamsizlikFiltre_CheckedChanged(object sender, EventArgs e)
        {
            filtredevamsizlik = Application.OpenForms.OfType<FiltreDevamsizlık>().FirstOrDefault();
            if (filtredevamsizlik == null)
            {
                filtredevamsizlik = new FiltreDevamsizlık();
                filtredevamsizlik.TopLevel = false;
                panel1.Controls.Add(filtredevamsizlik);
            }
            if (filtread != null && filtread.Visible == true)
            {
                filtread.Hide();
            }
            if (filtreogrencino != null && filtreogrencino.Visible == true)
            {
                filtreogrencino.Hide();
            }
            filtredevamsizlik.Show();
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            girisekrani = Application.OpenForms.OfType<GirisEkrani>().FirstOrDefault();
            
            if (filtreogrencino != null && filtreogrencino.Visible == true)
            {
                filtreogrencino.ustsinir.Clear();
                filtreogrencino.altsinir.Clear();
                filtreogrencino.Hide();
            }

            if (filtread != null && filtread.Visible == true)
            {
                filtread.AdSoyad.Clear();
                filtread.Hide();
            }

            if (filtredevamsizlik != null && filtredevamsizlik.Visible == true)
            {
                filtredevamsizlik.ustsinir.Clear();
                filtredevamsizlik.altsinir.Clear();
                filtredevamsizlik.Hide();
            }

            girisekrani.DersleriCek();
            this.Hide();
            girisekrani.Show();
        }

        private void FiltreyiTemizle_Click(object sender, EventArgs e)
        {
            Tablo.Items.Clear();

            foreach (ListViewItem item in originalItems)
            {
                Tablo.Items.Add((ListViewItem)item.Clone());
            }

            OgrenciNoFiltre.Checked = false;
            AdSoyadFiltre.Checked = false;
            DevamsizlikFiltre.Checked = false;
            
            if (filtreogrencino != null && filtreogrencino.Visible == true)
            {
                filtreogrencino.ustsinir.Clear();
                filtreogrencino.altsinir.Clear();
                filtreogrencino.Hide();
            }
            
            if (filtread != null && filtread.Visible == true)
            {
                filtread.AdSoyad.Clear();
                filtread.Hide();
            }

            if (filtredevamsizlik != null && filtredevamsizlik.Visible == true)
            {
                filtredevamsizlik.ustsinir.Clear();
                filtredevamsizlik.altsinir.Clear();
                filtredevamsizlik.Hide();
            }
        }

    }
}
