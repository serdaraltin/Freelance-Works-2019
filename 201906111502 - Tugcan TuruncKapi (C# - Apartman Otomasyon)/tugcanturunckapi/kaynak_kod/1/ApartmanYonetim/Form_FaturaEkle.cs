using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ApartmanYonetim
{
    public partial class Form_FaturaEkle : Form
    {
        public Form_FaturaEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=" + SunucuBilgi.Default.Sunucu + "; initial Catalog=" + SunucuBilgi.Default.VeriTabani + "; Integrated Security=true");
        VeriTabaniIslemleri veritabani = new VeriTabaniIslemleri();
        public int UyeId,BorcId;
        public string Tur;
        private void Form_FaturaEkle_Load(object sender, EventArgs e)
        {
           
            cbDurum.SelectedIndex = 1;

            txtUye.Text = veritabani.KullaniciCekAd(veritabani.UyeCekKullaniciId(UyeId));
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(txtFaturaId.Text !="" && txtTutar.Text != "")
            {
                float Tutar = (float)Convert.ToDouble(txtTutar.Text);
                int FaturaId = Convert.ToInt32(txtFaturaId.Text);
                try
                {
                    switch (Tur)
                    {
                        case "DogalGaz":
                            veritabani.DogalGazEkle(BorcId, FaturaId, dtTarih.Value, dtSonOdeme.Value, Tutar, cbDurum.Text);
                            break;
                        case "Elektrik":
                            veritabani.ElektrikEkle(BorcId, FaturaId, dtTarih.Value, dtSonOdeme.Value, Tutar, cbDurum.Text);
                            break;
                        case "Su":
                            veritabani.SuEkle(BorcId, FaturaId, dtTarih.Value, dtSonOdeme.Value, Tutar, cbDurum.Text);
                            break;
                    }
                    MessageBox.Show("Fatura kaydı eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("Eklenemedi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Gerekli alanlari doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
