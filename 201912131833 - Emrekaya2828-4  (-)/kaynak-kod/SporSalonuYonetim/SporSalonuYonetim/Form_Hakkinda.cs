using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SporSalonuYonetim
{
    public partial class Form_Hakkinda : Form
    {
        public Form_Hakkinda()
        {
            InitializeComponent();
        }
        
        //kapat butonu tıklama
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            //hakkında formu(pencere) kapatılıyor
            this.Close();
        }
    }
}
