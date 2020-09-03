using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sabri_Gozdag_Sozluk
{
    public partial class Form_Ayarlar : Form
    {
        public Form_Ayarlar()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbSonAranan_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSonAranan.Checked)
            {
                Ayarlar.Default.sonDepola = true;
                Ayarlar.Default.Save();
            }
            else
            {
                Ayarlar.Default.sonDepola = false;
                Ayarlar.Default.Save();
            }
        }

        private void chbVeritabaniKontrol_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVeritabaniKontrol.Checked)
            {
                Ayarlar.Default.vKontrol = true;
                Ayarlar.Default.Save();
            }
            else
            {
                Ayarlar.Default.vKontrol = false;
                Ayarlar.Default.Save();
            }
        }

        private void brnVeritabaniYapilandir_Click(object sender, EventArgs e)
        {
            Form_VeritabaniBaglanti veritabani = new Form_VeritabaniBaglanti();
            veritabani.ShowDialog();
        }

        private void Form_Ayarlar_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Ayarlar.Default.arkaPlan;
            if (Ayarlar.Default.sonDepola)
                chbSonAranan.Checked = true;
            if (Ayarlar.Default.vKontrol)
                chbVeritabaniKontrol.Checked = true;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            ColorDialog renk = new ColorDialog();
            if(renk.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = renk.Color;
                Ayarlar.Default.arkaPlan = renk.Color;
                Ayarlar.Default.Save();

                DialogResult soru = MessageBox.Show("Renk değişikliği algılandı.\nAktif olması için yeniden başlatmak istermisiniz", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (soru == DialogResult.Yes)
                    Application.Restart();
            }
        }
    }
}
