     string[] kalin = new string[] { "a", "ı", "o", "u" };//kalın seslileri bir diziye attık
        string[] ince = new string[] { "e", "i", "ö", "ü" };//ince seslileri bir diziye attık
        string[] rakam = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };//rakamları bir diziye attık
        bool incevarmi = false;
        bool kalinvarmi = false;
        bool rakamvarmi = false;
        private void button1_Click(object sender, EventArgs e)
        {
            //textbox1in boş olup olmadığını kontrol etmeliyiz
            if (textBox1.Text=="" || textBox1.Text==" " || textBox1.Text==null)
            {
                MessageBox.Show("Lütfen bir kelime giriniz");
            }
            foreach (char k in textBox1.Text)
            {
                 if (kalin.Contains(k.ToString()))
                     kalinvarmi=true;//kalın sesli varsa kalinvarmiyi true yaptık
                 if (ince.Contains(k.ToString()))
	                 incevarmi=true;//ince sesli varsa incevarmiyi true yaptık
	             if (rakam.Contains(k.ToString()))
	                 rakamvarmi=true;//rakam varsa rakamvarmiyi true yaptık
            }
            if (rakamvarmi==true)
            {
                //rakam varsa messageboxla uyarı gönderdik.
                MessageBox.Show("Lütfen rakam girmeyiniz");
            }
            if (kalinvarmi==true && incevarmi==true)
            { 
                // hem kalın hem ince sesli varsa büyük ünlü uyumuna uymaz
                label1.Text = "Büyük Ünlü Uyumuna Uymaz.";
            }
            else if (kalinvarmi==true && incevarmi==false)
            {
                //sadece kalın sesli varsa büyük ünlü uyumuna uyar
                label1.Text = "Büyük Ünlü Uyumuna Uyar.";

            }
            else if (incevarmi==true && kalinvarmi==false)
            {
                //sadece ince sesli varsa büyük ünlü uyumuna uyar
                label1.Text = "Büyük Ünlü Uyumuna Uyar.";
            }
           