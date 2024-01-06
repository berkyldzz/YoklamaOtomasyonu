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
    public partial class Dogrulama2 : Form
    {
        readonly OleDbConnection veritabani = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\YoklamaDatabase.accdb;Jet OLEDB:Database Password=232323;");

        public Dogrulama2()
        {
            InitializeComponent();
        }

        private void ParolaGizle_Click(object sender, EventArgs e)
        {
            if (Parola.UseSystemPasswordChar == false)
            {
                Parola.UseSystemPasswordChar = true;
                ParolaGizle.BackgroundImage = Properties.Resources.closeeye;
            }
            else
            {
                Parola.UseSystemPasswordChar = false;
                ParolaGizle.BackgroundImage = Properties.Resources.openneye;
            }
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            if (veritabani.State == ConnectionState.Closed)
            {
                veritabani.Open();
            }
            if (Parola.Text == "")
            {
                MessageBox.Show("Lütfen Parolayı Giriniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                OleDbCommand komut = new OleDbCommand($"SELECT * FROM GörevliBilgileri Where Parola='{Parola.Text}' and DersAdı='{GirisEkrani.ders}'", veritabani);
                OleDbDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Hatalı Parola!\nTekrar Deneyiniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Parola.Clear();
                }
            }
        }

    }
}
