using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace VeriTabanıproje
{
    public partial class Form_CustomerPanel : Form
    {
        public Form_CustomerPanel()
        {
            InitializeComponent();
        }
        public string KullaniciId;
        SqlConnection connect = new SqlConnection("Data Source=" + Properties.Settings.Default.Sunucu + ";Initial Catalog=" + Properties.Settings.Default.VeriTabani + ";Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        private void UrunListeYukle()
        {
            DataTable dt = new DataTable();
            string sql = "ParcaBilgileriCek";
            da = new SqlDataAdapter(sql, connect);
            ds = new DataSet();
            connect.Open();
            da.Fill(ds, "tablo");
            connect.Close();
            dataGridView1.DataSource = ds.Tables["tablo"];
        }
        private void VerilmisSiparislerYukle()
        {
           // string sql = "Select MusteriFirma.FirmaId, FirmaAdi, Eposta,Telefon,Mensei,YetkiliIsim,Sifre,Il,Ilce,Mahalle,Sokak,No from MusteriFirma join FirmaAdresi on MusteriFirma.FirmaId = FirmaAdresi.FirmaId";

            DataTable dt = new DataTable();
            string sql = "Select Siparis.SiparisKod,ParcaId,SiparisTarihi,TeslimTarihi,ParcaAdedi,DövizTürü,yukseklik,en,boy,cap,renk from Siparis join Parca_Ozellikleri on Siparis.SiparisKod = Parca_Ozellikleri.SiparisKod where FirmaId='"+KullaniciId+"'";
            da = new SqlDataAdapter(sql, connect);
            ds = new DataSet();
            connect.Open();
            da.Fill(ds, "tablo");
            connect.Close();
            dataGridView2.DataSource = ds.Tables["tablo"];
        }
        private void UrunListeArama(string sorgu)
        {
            try
            {
                DataTable dt = new DataTable();
                da = new SqlDataAdapter(sorgu, connect);
                ds = new DataSet();
                connect.Open();
                da.Fill(ds, "tablo");
                connect.Close();
                dataGridView1.DataSource = ds.Tables["tablo"];
            }
            catch
            {
                connect.Close();
                //MessageBox.Show("Filtre içinde aranan değer bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void ProfilIslemleriYukle()
        {
            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand("select *from MusteriFirma where FirmaId='"+KullaniciId+"'", connect);
                SqlDataReader datareader = command.ExecuteReader();
                txtYetkiliNumarasi.Text = KullaniciId;
                while(datareader.Read())
                {
                    txt_FirmaAdi.Text = datareader["FirmaAdi"].ToString();
                    txtTelefon.Text = datareader["Telefon"].ToString();
                    txtEposta.Text = datareader["Eposta"].ToString();
                    txtMensei.Text = datareader["Mensei"].ToString();
                    txtSifre.Text = datareader["Sifre"].ToString();
                    txtYetkili.Text = datareader["YetkiliIsim"].ToString();
                }
                datareader.Close();
                SqlCommand command2 = new SqlCommand("select *from FirmaAdresi where FirmaId='" + KullaniciId + "'", connect);
                SqlDataReader datareader2 = command2.ExecuteReader();
                while (datareader2.Read())
                {
                    txtIl.Text = datareader2["Il"].ToString();
                    txtIlce.Text = datareader2["Ilce"].ToString();
                    txtMahalle.Text = datareader2["Mahalle"].ToString();
                    txtSokakCadde.Text = datareader2["Sokak"].ToString();
                    txtNo.Text = datareader2["No"].ToString();
                }
                datareader2.Close();
                connect.Close();
            }
            catch
            {
                connect.Close();
                //MessageBox.Show("Filtre içinde aranan değer bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnUrunListesi_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabUrunListesi;
            UrunListeYukle();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtParcaNumarasi.Text = ds.Tables["tablo"].Rows[e.RowIndex]["ParcaId"].ToString();
                picUrunResmi.ImageLocation = ds.Tables["tablo"].Rows[e.RowIndex]["ResimNo"].ToString()+ds.Tables["tablo"].Rows[e.RowIndex]["IslemeResimNo"].ToString();
                txtUrunIsmi.Text = ds.Tables["tablo"].Rows[e.RowIndex]["ParcaAdi"].ToString();
            }
            catch
            {
            }

        }

        private void btnSiparisİptal_Click(object sender, EventArgs e)
        {
            foreach(Control control in groupBox1.Controls)
            {
                if (control is TextBox)
                    control.Text = "";
            }
            foreach (Control control in groupBox3.Controls)
            {
                if (control is TextBox)
                    control.Text = "";
            }
            picUrunResmi.Image = null;
            txtYetkiliNumarasi.Text = KullaniciId;
        }


        private void btnYenile_Click(object sender, EventArgs e)
        {
            UrunListeYukle();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select *from ParcaBilgileri where ParcaAdi Like '%" + txtArama.Text + "%'";

            UrunListeArama(sql);
        }

        private void Form_CustomerPanel_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("select *from MusteriFirma where FirmaId='"+KullaniciId+"'",connect);
            SqlDataReader datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                lbMusteriAdi.Text = datareader["YetkiliIsim"].ToString();
                lbFirmaAdi.Text = datareader["FirmaAdi"].ToString();
            }
           
            connect.Close();
            txtSiparisVeren.Text = KullaniciId;
            cmbDovizTuru.Text = cmbDovizTuru.Items[0].ToString();
            UrunListeYukle();
            ProfilIslemleriYukle();
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            bool bosdeger = false;
            foreach(Control control in groupBox1.Controls)
            {
                if (control is TextBox && control.Text == "")
                    bosdeger = true;
            }
            foreach (Control control in groupBox3.Controls)
            {
                if (control is TextBox && control.Text == "")
                    bosdeger = true;
                if (control is DateTimePicker && control.Text == "")
                    bosdeger = true;
            }
            if (!(bosdeger))
                SiparisVer(dateTimePicker1.Value,dateTimePicker2.Value, txtParcaAdedi.Text,cmbDovizTuru.Text,txtParcaNumarasi.Text,KullaniciId,"Y1545",txtYukseklik.Text,txtEn.Text,txtCap.Text,txtBoy.Text,txtRenk.Text);
            else
                MessageBox.Show("Gerekli alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        public void SiparisVer(DateTime SiparisTarihi, DateTime TeslimTarihi, string ParcaAdedi,string Dovizturu, string ParcaId,string FirmaId, string YoneticiId, string yukseklik,string en,string cap,string boy,string renk)
        {
            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand("insert into Siparis (SiparisTarihi,TeslimTarihi,ParcaAdedi,DövizTürü,ParcaId,FirmaId,YöneticiId) values (@SiparisTarihi,@TeslimTarihi,@ParcaAdedi,@DövizTürü,@ParcaId,@FirmaId,@YöneticiId)", connect);
                command.Parameters.AddWithValue("@SiparisTarihi", SiparisTarihi);
                command.Parameters.AddWithValue("@TeslimTarihi", TeslimTarihi);
                command.Parameters.AddWithValue("@ParcaAdedi", ParcaAdedi);
                command.Parameters.AddWithValue("@DövizTürü", Dovizturu);
                command.Parameters.AddWithValue("@ParcaId", ParcaId);
                command.Parameters.AddWithValue("@FirmaId", FirmaId);
                command.Parameters.AddWithValue("@YöneticiId", YoneticiId);
                command.ExecuteNonQuery();


                //SiparisKod verisini alma
                SqlCommand command2 = new SqlCommand("Select *from Siparis", connect);
                SqlDataReader datareader = command2.ExecuteReader();
                string SiparisKod = "";
                while (datareader.Read())
                    SiparisKod = datareader["SiparisKod"].ToString();
                MessageBox.Show(SiparisKod);
                datareader.Close();

                SqlCommand command3 = new SqlCommand("insert into Parca_Ozellikleri (yukseklik,en,boy,cap,renk,SiparisKod) values (@yukseklik,@en,@boy,@cap,@renk,@SiparisKod)", connect);
                command3.Parameters.AddWithValue("@yukseklik", yukseklik);
                command3.Parameters.AddWithValue("@en", en);
                command3.Parameters.AddWithValue("@boy", boy);
                command3.Parameters.AddWithValue("@cap", cap);
                command3.Parameters.AddWithValue("@renk", renk);
                command3.Parameters.AddWithValue("@SiparisKod", SiparisKod);
                command3.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Siparişiniz başarılı bir şekilde yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
            catch(Exception hata) {
                connect.Close();
                MessageBox.Show(hata.Message.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabSiparisVer;
        }

        private void brnCikisYap_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            login.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabProfilIslemleri;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabVerilmisSiparisler;
            VerilmisSiparislerYukle();
        }

        private void btnBilgileriGunvelle_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand("update MusteriFirma set FirmaAdi=@FirmaAdi,Eposta=@Eposta,Telefon=@Telefon,Mensei=@Mensei,YetkiliIsim=@YetkiliIsim,Sifre=@Sifre where FirmaId=" + KullaniciId, connect);
                command.Parameters.AddWithValue("@FirmaAdi", txt_FirmaAdi.Text);
                command.Parameters.AddWithValue("@Eposta", txtEposta.Text);
                command.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                command.Parameters.AddWithValue("@Mensei", txtMensei.Text);
                command.Parameters.AddWithValue("@YetkiliIsim", txtYetkili.Text);
                command.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                command.ExecuteNonQuery();
                SqlCommand command2 = new SqlCommand("update FirmaAdresi set Il=@Il,Ilce=@Ilce,Mahalle=@MAhalle,Sokak=@Sokak,No=@No where FirmaId=" + KullaniciId, connect);
                command2.Parameters.AddWithValue("@Il", txtIl.Text);
                command2.Parameters.AddWithValue("@Ilce", txtIlce.Text);
                command2.Parameters.AddWithValue("@Mahalle", txtMahalle.Text);
                command2.Parameters.AddWithValue("@Sokak", txtSokakCadde.Text);
                command2.Parameters.AddWithValue("@No", txtNo.Text);
                command2.ExecuteNonQuery();
                connect.Close();
                ProfilIslemleriYukle();
                lbMusteriAdi.Text = txtYetkili.Text;
                lbFirmaAdi.Text = txt_FirmaAdi.Text;
                MessageBox.Show("Güncelleme başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                connect.Close();
                MessageBox.Show(hata.Message.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
