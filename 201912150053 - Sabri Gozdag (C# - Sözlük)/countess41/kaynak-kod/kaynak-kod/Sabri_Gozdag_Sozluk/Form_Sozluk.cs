using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sabri_Gozdag_Sozluk
{
    public partial class Form_Sozluk : Form
    {
        public Form_Sozluk()
        {
            InitializeComponent();
        }

        VeritabaniIslemleri veritabani = new VeritabaniIslemleri();
        string tur = null;

        public void Ara(string aranan, string tur)
        {
            lstBulunan.DataSource = veritabani.Ara(aranan, tur, false);
        }
        public void Ara(string aranan, string tur, bool tam)
        {
            lstBulunan.DataSource = veritabani.Ara(aranan, tur, tam);
        }
        public void Ara(string aranan, string tur, bool tam, bool anlam)
        {
            rcAnlam.Text = veritabani.Ara(aranan, tur, tam, anlam);
            rcAnlam.SelectAll();
            rcAnlam.SelectionFont = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular);
            rcAnlam.SelectionColor = Color.Black;
            rcAnlam.DeselectAll();
            rcAnlam.Select(0, rcAnlam.Text.IndexOf(" :"));
            rcAnlam.SelectionColor = Color.Purple;
            rcAnlam.SelectionFont = new Font("Arial", 15f, FontStyle.Bold);
        }

        private void c_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                rcAnlam.Clear();
                if (Ayarlar.Default.sonDepola && cbAranan.Items.Count <= 10)
                    cbAranan.Items.Add(cbAranan.Text);
                if (chbTamKelime.Checked)
                {
                    Ara(cbAranan.Text, tur, true);
                    return;
                }
                Ara(cbAranan.Text, tur);
                return;
            }
        }

        private void rdbIngilizceTurkce_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIngilizceTurkce.Checked)
            {
                rdbIngilizceTurkce.ForeColor = Color.Yellow;
                tur = "ingilizce";
                return;
            }
            rdbIngilizceTurkce.ForeColor = Color.Black;
            return;
        }

        private void rdbTurkceIngilizce_CheckedChanged(object sender, EventArgs e)
        {
                        
            if (rdbTurkceIngilizce.Checked)
            {
                rdbTurkceIngilizce.ForeColor = Color.Yellow;
                tur = "turkce";
                return;
            }
            rdbTurkceIngilizce.ForeColor = Color.Black;
            return;
        }

        private void rdbTerim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBilgisayar.Checked)
            {
                rdbBilgisayar.ForeColor = Color.Yellow;
                tur = "bilgisayar";
                return;
            }
            rdbBilgisayar.ForeColor = Color.Black;
            return;
        }

        private void Form_Sozluk_Load(object sender, EventArgs e)
        {
            if((Ayarlar.Default.sunucu == "" || Ayarlar.Default.veritabani == "") || !veritabani.Baglanti_Test())
            {
                MessageBox.Show("Veritabanına bağlanılamadı!!!\nLütfen veritabanı ayarlarını yapılandırın.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form_VeritabaniBaglanti vtaban = new Form_VeritabaniBaglanti();
                vtaban.ShowDialog();
            }
            rdbIngilizceTurkce.Checked = true;
            this.BackColor = Ayarlar.Default.arkaPlan;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cbAranan.ResetText();
            lstBulunan.DataSource = null;
            rcAnlam.Clear();
        }

        private void lstBulunan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
                string secilen = lstBulunan.SelectedItem.ToString();
                Ara(secilen, tur, true, true);
            }
            catch { }
        }

        private void rdbTeknik_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTeknik.Checked)
            {
                rdbTeknik.ForeColor = Color.Yellow;
                tur = "teknik";
                return;
            }
            rdbTeknik.ForeColor = Color.Black;
            return;
        }

        private void rdbElektronik_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbElektronik.Checked)
            {
                rdbElektronik.ForeColor = Color.Yellow;
                tur = "elektronik";
                return;
            }
            rdbElektronik.ForeColor = Color.Black;
            return;
        }

        private void rdbtip_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtip.Checked)
            {
                rdbtip.ForeColor = Color.Yellow;
                tur = "tip";
                return;
            }
            rdbtip.ForeColor = Color.Black;
            return;
        }

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            Form_Hakkinda hakkinda = new Form_Hakkinda();
            hakkinda.ShowDialog();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            Form_Ayarlar ayarlar = new Form_Ayarlar();
            ayarlar.ShowDialog();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Form_Ekle ekle = new Form_Ekle();
            ekle.ShowDialog();
        }

        private void rdbBilisim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBilisim.Checked)
            {
                rdbBilisim.ForeColor = Color.Yellow;
                tur = "bilisim";
                return;
            }
            rdbBilisim.ForeColor = Color.Black;
            return;
        }
    }
}
