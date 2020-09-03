package OgrenciKayit;
import com.github.sarxos.webcam.Webcam;
import java.awt.Component;
import java.awt.Dimension;
import java.awt.event.KeyEvent;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import java.sql.Date;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import javax.imageio.ImageIO;
import javax.swing.ImageIcon;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import veritabani.DB;

public class ogrenciAnaKayit extends javax.swing.JFrame {

    DB db = new DB();

    public ogrenciAnaKayit() {
        initComponents();
        db.baglan();
        txtAra.requestFocus();
        combogetir();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jLabel2 = new javax.swing.JLabel();
        txtAdi = new javax.swing.JTextField();
        txtSoyadi = new javax.swing.JTextField();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        txtTC = new javax.swing.JTextField();
        jLabel6 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        txtDokuman = new javax.swing.JTextField();
        jLabel8 = new javax.swing.JLabel();
        jLabel10 = new javax.swing.JLabel();
        txtVadiSoyadi = new javax.swing.JTextField();
        jLabel11 = new javax.swing.JLabel();
        jLabel13 = new javax.swing.JLabel();
        jScrollPane1 = new javax.swing.JScrollPane();
        txtAdres = new javax.swing.JTextArea();
        btnKayit = new javax.swing.JButton();
        txtOmail = new javax.swing.JTextField();
        txtVmail = new javax.swing.JTextField();
        jLabel9 = new javax.swing.JLabel();
        jLabel12 = new javax.swing.JLabel();
        btnBaslat = new javax.swing.JButton();
        btnFotoCek = new javax.swing.JButton();
        lblFoto = new javax.swing.JLabel();
        cmbGrup = new javax.swing.JComboBox<>();
        jLabel14 = new javax.swing.JLabel();
        jLabel15 = new javax.swing.JLabel();
        txtDogum = new com.toedter.calendar.JDateChooser();
        txtTel = new javax.swing.JFormattedTextField();
        txtVtel = new javax.swing.JFormattedTextField();
        txtAra = new javax.swing.JTextField();
        jLabel1 = new javax.swing.JLabel();
        btnGetir = new javax.swing.JButton();
        btnGeri = new javax.swing.JButton();
        jLabel18 = new javax.swing.JLabel();
        jLabel16 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Esas Kayıt Paneli");
        setMaximumSize(new java.awt.Dimension(850, 568));
        setMinimumSize(new java.awt.Dimension(850, 568));
        setPreferredSize(new java.awt.Dimension(850, 568));
        setResizable(false);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jPanel1.setOpaque(false);
        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(0, 51, 102));
        jLabel2.setText("Öğrenci Adı :");
        jPanel1.add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 40, -1, -1));

        txtAdi.setName("Öğrenci Adı"); // NOI18N
        txtAdi.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                txtAdiKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtAdiKeyTyped(evt);
            }
        });
        jPanel1.add(txtAdi, new org.netbeans.lib.awtextra.AbsoluteConstraints(140, 40, 238, -1));

        txtSoyadi.setName("Öğrenci Soyadı"); // NOI18N
        txtSoyadi.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                txtSoyadiKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtSoyadiKeyTyped(evt);
            }
        });
        jPanel1.add(txtSoyadi, new org.netbeans.lib.awtextra.AbsoluteConstraints(140, 90, 238, -1));

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(0, 51, 102));
        jLabel3.setText("Öğrenci Soyadı :");
        jPanel1.add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(13, 93, -1, -1));

        jLabel4.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(0, 51, 102));
        jLabel4.setText("Doğum Tarihi :");
        jPanel1.add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 140, -1, -1));

        jLabel5.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(0, 51, 102));
        jLabel5.setText("Öğrenci Telefon :");
        jPanel1.add(jLabel5, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 280, -1, -1));

        txtTC.setName("TC Kimlik No"); // NOI18N
        txtTC.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                txtTCKeyPressed(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtTCKeyTyped(evt);
            }
        });
        jPanel1.add(txtTC, new org.netbeans.lib.awtextra.AbsoluteConstraints(140, 250, 240, -1));

        jLabel6.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel6.setForeground(new java.awt.Color(0, 51, 102));
        jLabel6.setText("TC Kimlik No :");
        jPanel1.add(jLabel6, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 250, -1, -1));

        jLabel7.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel7.setForeground(new java.awt.Color(0, 51, 102));
        jLabel7.setText("Alınacak Eğitim :");
        jPanel1.add(jLabel7, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 200, -1, -1));

        txtDokuman.setName("Döküman"); // NOI18N
        jPanel1.add(txtDokuman, new org.netbeans.lib.awtextra.AbsoluteConstraints(610, 370, 212, -1));

        jLabel8.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel8.setForeground(new java.awt.Color(0, 51, 102));
        jLabel8.setText("Dökümanlar :");
        jPanel1.add(jLabel8, new org.netbeans.lib.awtextra.AbsoluteConstraints(500, 370, -1, -1));

        jLabel10.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel10.setForeground(new java.awt.Color(0, 51, 102));
        jLabel10.setText("Veli Telefonu :");
        jPanel1.add(jLabel10, new org.netbeans.lib.awtextra.AbsoluteConstraints(490, 330, -1, -1));

        txtVadiSoyadi.setName("Veli Adı-Soyadı"); // NOI18N
        txtVadiSoyadi.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                txtVadiSoyadiKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtVadiSoyadiKeyTyped(evt);
            }
        });
        jPanel1.add(txtVadiSoyadi, new org.netbeans.lib.awtextra.AbsoluteConstraints(610, 300, 212, -1));

        jLabel11.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel11.setForeground(new java.awt.Color(0, 51, 102));
        jLabel11.setText("Veli Adı-Soyadı :");
        jPanel1.add(jLabel11, new org.netbeans.lib.awtextra.AbsoluteConstraints(480, 300, -1, -1));

        jLabel13.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel13.setForeground(new java.awt.Color(0, 51, 102));
        jLabel13.setText("Adres :");
        jPanel1.add(jLabel13, new org.netbeans.lib.awtextra.AbsoluteConstraints(80, 410, -1, -1));

        txtAdres.setColumns(20);
        txtAdres.setFont(new java.awt.Font("Arial", 0, 12)); // NOI18N
        txtAdres.setRows(5);
        txtAdres.setName("Adres"); // NOI18N
        txtAdres.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtAdresKeyTyped(evt);
            }
        });
        jScrollPane1.setViewportView(txtAdres);

        jPanel1.add(jScrollPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(140, 370, 241, -1));

        btnKayit.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnKayit.setForeground(new java.awt.Color(0, 51, 102));
        btnKayit.setText("Kaydet");
        btnKayit.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnKayitActionPerformed(evt);
            }
        });
        jPanel1.add(btnKayit, new org.netbeans.lib.awtextra.AbsoluteConstraints(610, 430, 212, 33));

        txtOmail.setName("Öğrenci Mail"); // NOI18N
        jPanel1.add(txtOmail, new org.netbeans.lib.awtextra.AbsoluteConstraints(140, 320, 240, -1));

        txtVmail.setName("Veli Mail"); // NOI18N
        jPanel1.add(txtVmail, new org.netbeans.lib.awtextra.AbsoluteConstraints(610, 400, 212, -1));

        jLabel9.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel9.setForeground(new java.awt.Color(0, 51, 102));
        jLabel9.setText("Öğrenci Mail :");
        jPanel1.add(jLabel9, new org.netbeans.lib.awtextra.AbsoluteConstraints(33, 320, -1, -1));

        jLabel12.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel12.setForeground(new java.awt.Color(0, 51, 102));
        jLabel12.setText("Veli Mail :");
        jPanel1.add(jLabel12, new org.netbeans.lib.awtextra.AbsoluteConstraints(520, 400, -1, -1));

        btnBaslat.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnBaslat.setForeground(new java.awt.Color(0, 51, 102));
        btnBaslat.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/power.png"))); // NOI18N
        btnBaslat.setText("Başlat");
        btnBaslat.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnBaslatActionPerformed(evt);
            }
        });
        jPanel1.add(btnBaslat, new org.netbeans.lib.awtextra.AbsoluteConstraints(530, 230, -1, 39));

        btnFotoCek.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnFotoCek.setForeground(new java.awt.Color(0, 51, 102));
        btnFotoCek.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/camera.png"))); // NOI18N
        btnFotoCek.setText("Fotoğraf Çek");
        btnFotoCek.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnFotoCekActionPerformed(evt);
            }
        });
        jPanel1.add(btnFotoCek, new org.netbeans.lib.awtextra.AbsoluteConstraints(660, 230, -1, 39));

        lblFoto.setText(" ");
        jPanel1.add(lblFoto, new org.netbeans.lib.awtextra.AbsoluteConstraints(590, 0, 190, 220));

        cmbGrup.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { " " }));
        cmbGrup.setName("Alınacak Eğitim"); // NOI18N
        cmbGrup.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                cmbGrupItemStateChanged(evt);
            }
        });
        jPanel1.add(cmbGrup, new org.netbeans.lib.awtextra.AbsoluteConstraints(140, 200, 105, -1));
        jPanel1.add(jLabel14, new org.netbeans.lib.awtextra.AbsoluteConstraints(350, 200, 120, 20));

        jLabel15.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel15.setForeground(new java.awt.Color(0, 51, 102));
        jLabel15.setText("Grup No:");
        jPanel1.add(jLabel15, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 200, -1, 20));
        jPanel1.add(txtDogum, new org.netbeans.lib.awtextra.AbsoluteConstraints(140, 140, 240, -1));

        try {
            txtTel.setFormatterFactory(new javax.swing.text.DefaultFormatterFactory(new javax.swing.text.MaskFormatter("+90 (###)-### ## ##")));
        } catch (java.text.ParseException ex) {
            ex.printStackTrace();
        }
        jPanel1.add(txtTel, new org.netbeans.lib.awtextra.AbsoluteConstraints(140, 280, 240, -1));

        try {
            txtVtel.setFormatterFactory(new javax.swing.text.DefaultFormatterFactory(new javax.swing.text.MaskFormatter("+90 (###)-### ## ##")));
        } catch (java.text.ParseException ex) {
            ex.printStackTrace();
        }
        jPanel1.add(txtVtel, new org.netbeans.lib.awtextra.AbsoluteConstraints(610, 330, 212, -1));

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 90, 840, 480));

        txtAra.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                txtAraKeyPressed(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtAraKeyTyped(evt);
            }
        });
        getContentPane().add(txtAra, new org.netbeans.lib.awtextra.AbsoluteConstraints(160, 50, 212, -1));

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 51, 102));
        jLabel1.setText("TC Kimlik No :");
        getContentPane().add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(50, 50, -1, -1));

        btnGetir.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnGetir.setForeground(new java.awt.Color(0, 51, 102));
        btnGetir.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/data.png"))); // NOI18N
        btnGetir.setText("Data Getir");
        btnGetir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnGetirActionPerformed(evt);
            }
        });
        getContentPane().add(btnGetir, new org.netbeans.lib.awtextra.AbsoluteConstraints(390, 40, -1, 42));

        btnGeri.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnGeri.setForeground(new java.awt.Color(0, 51, 102));
        btnGeri.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1466161311_agt_back.png"))); // NOI18N
        btnGeri.setText("Geri");
        btnGeri.setBorder(null);
        btnGeri.setBorderPainted(false);
        btnGeri.setContentAreaFilled(false);
        btnGeri.setFocusable(false);
        btnGeri.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnGeriActionPerformed(evt);
            }
        });
        getContentPane().add(btnGeri, new org.netbeans.lib.awtextra.AbsoluteConstraints(730, 10, 100, -1));

        jLabel18.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel18.setForeground(new java.awt.Color(153, 0, 51));
        jLabel18.setText("Esas Kayıt Paneli");
        getContentPane().add(jLabel18, new org.netbeans.lib.awtextra.AbsoluteConstraints(360, 10, -1, -1));

        jLabel16.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        jLabel16.setPreferredSize(new java.awt.Dimension(834, 561));
        getContentPane().add(jLabel16, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, -1, -1));

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    ArrayList<String> lsid = new ArrayList<>();

    public void combogetir() {
        try {
            ResultSet ress = db.dataGetir("grup");

            while (ress.next()) {
                cmbGrup.addItem(ress.getString("grupAciklama"));
                lsid.add(ress.getString("grupID"));
            }
            image = ImageIO.read(new File("picture.png"));
            ImageIcon profil = new ImageIcon(image.getScaledInstance(lblFoto.getWidth(), lblFoto.getHeight(), 1));
            lblFoto.setIcon(profil);

        } catch (SQLException ex) {
            System.err.println("Combobox getirme hatası : " + ex);
        } catch (IOException ex) {
            Logger.getLogger(ogrenciAnaKayit.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

//mail dogru formatta mı kontrolu.
    boolean donus = false;

    public boolean mailKontrol() {
        
        String emailPattern = "^[\\w!#$%&’*+/=?`{|}~^-]+(?:\\.[\\w!#$%&’*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$";
        Pattern p = Pattern.compile(emailPattern);
        Matcher m = p.matcher(txtOmail.getText().trim());
        Matcher mm = p.matcher(txtVmail.getText().trim());
        if (!(m.matches())) {
            JOptionPane.showMessageDialog(rootPane, "Lütfen Öğrenci Mail Adresini Doğru Giriniz");
            txtOmail.requestFocus();

        } else if (!(mm.matches())) {
            JOptionPane.showMessageDialog(rootPane, "Lütfen Veli Mail Adresini Doğru Giriniz");
            txtVmail.requestFocus();
        } else {
            donus = true;
        }
        return donus;
    }

    public boolean kontrol() {
        boolean durumm = true;
        Component[] compo = jPanel1.getComponents();
        for (Component compon : compo) {
            if (compon instanceof JTextField) {

                if (((JTextField) compon).getText().trim().isEmpty()) {
                    JOptionPane.showMessageDialog(compon, "lütfen " + compon.getName() + "'nı doldurun.");
                    compon.requestFocus();
                    durumm = false;
                    break;
                }
            }
        }
        return durumm;
    }

    public void datagetirme(String tc) throws IOException {

        try {
            ResultSet rs = db.dataGetir("ogrenci where ogrenciTc = " + tc);
            if (rs.next()) {
                System.out.println("gelen öğrenci adı : " + rs.getString("ogrenciAdi"));
                txtAdi.setText(rs.getString("ogrenciAdi"));
                txtSoyadi.setText(rs.getString("ogrenciSoyadi"));
                txtTC.setText(rs.getString("ogrenciTc"));
                txtTel.setText(rs.getString("ogrenciTel"));
                txtVadiSoyadi.setText(rs.getString("veliAdSoyad"));
                txtVtel.setText(rs.getString("veliTel"));
                txtOmail.setText(rs.getString("ogrenciMail"));
                txtVmail.setText(rs.getString("veliMail"));
                txtDogum.setDate(rs.getDate("ogrenciDogumTarihi"));
                txtAdres.setText(rs.getString("ogrenciAdres"));
                txtDokuman.setText(rs.getString("dokumantasyon"));

                //combo_seçim
                ResultSet rst = db.dataGetir("grup where grupNo = '" + rs.getString("grupNo") + "' ");
                if (rst.next()) {
                    cmbGrup.setSelectedItem(rst.getString("grupAciklama"));
                }

                image = ImageIO.read(new File(txtAra.getText().trim() + ".png"));
                ImageIcon imageIcon = new ImageIcon(image.getScaledInstance(lblFoto.getWidth(), lblFoto.getHeight(), 1));
                lblFoto.setIcon(imageIcon);

            } else {
                JOptionPane.showMessageDialog(rootPane, "Girilen TC Kimlik Numarası Kayıtlarda Bulunamadı");
            }

        } catch (Exception e) {
            System.err.println("image bulunamadı : " + e);
        }

    }

    private void btnGeriActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnGeriActionPerformed
        
        KayitYonlendirme ky = new KayitYonlendirme();
        ky.setVisible(true);
        this.setVisible(false);
        Webcam webcam = Webcam.getDefault();
        webcam.close();
        
    }//GEN-LAST:event_btnGeriActionPerformed

    String tc = "";

    private void btnGetirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnGetirActionPerformed

        if (txtAra.getText().trim().equals("")) {
            JOptionPane.showMessageDialog(rootPane, "TC Kimlik Numarasını Girmediniz");
        } else {
            tc = txtAra.getText().trim();
            try {
                datagetirme(tc);
            } catch (IOException ex) {
                System.err.println("kayıttan getirme hatası : " + ex);
            }
        }

    }//GEN-LAST:event_btnGetirActionPerformed
    int gelen = 0;

    public boolean Update(String query) {
        db.baglan();
        boolean durum = false;
        try {
            gelen = db.st.executeUpdate(query);
            if (gelen > 0) {
                durum = true;
            }

        } catch (Exception e) {
            System.err.println("genelQuery Hatası : " + e);
        }
        return durum;
    }

    int yukleme = 0;
    String grupNo = "";
    int sayi = 0;
    boolean sonuc = false;

    public boolean denetim() {

        if (!txtAdi.getText().trim().equals("") && !txtSoyadi.getText().trim().equals("") && !txtDogum.getDate().equals(null) && cmbGrup.getSelectedIndex() != 0 && !txtTC.getText().trim().equals("")
                && !txtTel.getText().trim().equals("") && !txtOmail.getText().trim().equals("") && !txtAdres.getText().trim().equals("") && !txtVadiSoyadi.getText().trim().equals("") && !txtVtel.getText().trim().equals("")
                && !txtVmail.getText().trim().equals("") && !txtDokuman.getText().trim().equals("")) {
            sonuc = true;
        }

        return sonuc;
    }

    public boolean egitimKontrol() {
        boolean durum2 = false;
        if (cmbGrup.getSelectedIndex() != 0) {
            durum2 = true;
        } else {
            JOptionPane.showMessageDialog(rootPane, "Alınacak Eğitimi Giriniz");
            cmbGrup.requestFocus();
        }

        return durum2;
    }
//     try {
//            ResultSet rs = d.st.executeQuery("select *from grup");
//            while (rs.next()) {
//                String acik = rs.getString("grupAciklama");
//                cmb.addElement(rs.getString("grupNo") + " / " + acik);
//                dizi.add(rs.getString("grupNo"));
//            }
//            cbGrupListele.setModel(cmb);
//        } catch (SQLException ex) {
//            Logger.getLogger(GrupListele.class.getName()).log(Level.SEVERE, null, ex);
//        }
    
//    private void cbGrupListeleItemStateChanged(java.awt.event.ItemEvent evt) {                                               
//        if (!cmb.getSelectedItem().equals("Grup Numarasını Seçiniz")) {
//             aranan = cmb.getSelectedItem().toString();
//            String secilen = cmb.getSelectedItem().toString();
//            int slas = aranan.indexOf("/");
//            aranan = aranan.substring(0, slas);
//            lblSinifAdi.setText(secilen + " " + "Grubu Öğrenci Listesi");
//            tb.setRowCount(0);
//            
//            try {
//                ResultSet rs = d.st.executeQuery("call ogrenciBilgiGetir('" + aranan + "')");
//                while (rs.next()) {
//                    tb.addRow(new String[]{rs.getString("ogrenciId"), rs.getString("ogrenciAdi"), rs.getString("ogrenciSoyadi"), rs.getString("ogrenciTc"), rs.getString("ogrenciTel")});
//                }
//                tblOgrenciBilgi.setModel(tb);
//            } catch (SQLException ex) {
//                Logger.getLogger(GrupListele.class.getName()).log(Level.SEVERE, null, ex);
//            }
//        }
//    }           

    public boolean tcKontrol() {
        
        boolean netice = false;
        ResultSet rest = db.dataGetir("ogrenci where ogrenciTc = '" + txtTC.getText() + "' ");
        try {
            if (rest.next()) {
                netice = true;
                JOptionPane.showMessageDialog(rootPane, "Aynı TC Kimlik Numaralı Kayıtlı!");
                txtTC.requestFocus();
            }
        } catch (SQLException ex) {
            System.err.println("ogrencitckontrol hatası : " + ex);
        }
        return netice;
    }

    private void btnKayitActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnKayitActionPerformed

        if (kontrol() && egitimKontrol() && mailKontrol() && kontrol11() && kontrol19()) {

            try {

                ResultSet rs = db.st.executeQuery("select * from grup where grupAciklama = '" + cmbGrup.getSelectedItem().toString() + "'  ");

                if (rs.next()) {

                    grupNo = rs.getString("grupNo");
                    int kont = Integer.valueOf(rs.getString("grupKontenjan"));
                    ResultSet rss = db.st.executeQuery(" SELECT COUNT(grupNo) as sayi FROM ogrenci where grupNo='" + grupNo + "' ; ");

                    if (rss.next()) {
                        sayi = Integer.valueOf(rss.getString("sayi"));
                    }
//                    if (!tcKontrol()) {
                        if (kont > sayi) {

                            if (!txtAra.getText().equals("")) {

                                if (Update("update ogrenci set grupNo = '" + grupNo + "' where ogrenciTc = '" + txtTC.getText().trim() + "' ")) {
                                    guncelle();
                                    ImageIO.write(image, "PNG", new File(txtTC.getText().trim() + ".png"));
                                    JOptionPane.showMessageDialog(rootPane, "Kayıt Yapıldı");
                                    temizle();
                                    txtAra.requestFocus();
                                    image = ImageIO.read(new File("picture.png"));
                                    ImageIcon profil = new ImageIcon(image.getScaledInstance(lblFoto.getWidth(), lblFoto.getHeight(), 1));
                                    lblFoto.setIcon(profil);
                                }

                            } else if(!tcKontrol()){
                                System.out.println("tc_ara kısmı boş");
                                Date jdatechooser = new Date(txtDogum.getDate().getTime());
                                boolean xx = db.st.execute("call kayitInsert('" + txtAdi.getText().trim() + "',"
                                        + "'" + txtSoyadi.getText().trim() + "','" + jdatechooser + "',"
                                        + "'" + grupNo + "', '" + txtTC.getText().trim() + "','" + txtTel.getText().trim() + "', "
                                        + "'" + txtAdres.getText().trim() + "', '" + txtVadiSoyadi.getText().trim() + "',   "
                                        + "'" + txtVtel.getText().trim() + "', '" + txtDokuman.getText().trim() + "', "
                                        + "'" + "aktif" + "' , '" + txtOmail.getText().trim() + "', '" + txtVmail.getText().trim() + "' )");

                                if (!xx) {
                                    // IMAGE KAYIT
                                    ImageIO.write(image, "PNG", new File(txtTC.getText().trim() + ".png"));

                                    JOptionPane.showMessageDialog(rootPane, "Kayıt Yapıldı");
                                    temizle();
                                    txtAdi.requestFocus();

                                    image = ImageIO.read(new File("picture.png"));
                                    ImageIcon profil = new ImageIcon(image.getScaledInstance(lblFoto.getWidth(), lblFoto.getHeight(), 1));
                                    lblFoto.setIcon(profil);

                                } else {
                                    System.out.println("insert yapmadı");
                                }

                            }

                        } else {
                            JOptionPane.showMessageDialog(rootPane, "Kontenjan Dolu");
                            cmbGrup.setSelectedIndex(0);
                        }
//                    }
                }
            } catch (SQLException ex) {
                System.err.println("grupno ekleme hatası : " + ex);
            } catch (IOException ex) {
                System.err.println("image kayıt hatası : " + ex);
            }

        }

    }//GEN-LAST:event_btnKayitActionPerformed
    public static boolean durum = false;
 

    void cam_calis() {
        
        durum = true;
        Runnable calis = () -> {
//            Dimension resolution = new Dimension(320, 180);
            Dimension resolution = new Dimension(190, 230);
            Webcam webcam = Webcam.getDefault();
            webcam.setCustomViewSizes(new Dimension[]{resolution});
            webcam.setViewSize(resolution);
            webcam.open();
            BufferedImage img = null;
            while (durum) {

                // get image
                img = webcam.getImage();

                if (img != null) {
                    ImageIcon imageIcon = new ImageIcon(img.getScaledInstance(lblFoto.getWidth(), lblFoto.getHeight(), 1));
                    lblFoto.setIcon(imageIcon);
                }

            }
        };
        new Thread(calis).start();

    }
    BufferedImage image;

    public void fotoAl() throws IOException {

        durum = false;
        Webcam webcam = Webcam.getDefault();
        image = webcam.getImage();

        if (image != null) {
            ImageIcon imageIcon = new ImageIcon(image.getScaledInstance(lblFoto.getWidth(), lblFoto.getHeight(), 1));
            lblFoto.setIcon(imageIcon);
        }

        webcam.close();
    }

    public boolean kontrol11() {
        boolean knt = false;
        if (txtTC.getText().length() != 11) {
            JOptionPane.showMessageDialog(rootPane, "Eksik TC Girdiniz");
            txtTC.requestFocus();
        } else {
            knt = true;
        }
        return knt;
    }
     public boolean kontrol19() {
        System.out.println("boyut: " + txtTel.getText().trim().length());
        boolean kntt = false;
        if (txtTel.getText().trim().length() != 19) {
            JOptionPane.showMessageDialog(rootPane, "Eksik Numara Girdiniz.");
            txtTel.requestFocus();
        } else if (txtVtel.getText().trim().length() != 19) {
            JOptionPane.showMessageDialog(rootPane, "Eksik Numara Girdiniz.");
            txtVtel.requestFocus();
        } else {
            kntt = true;
        }
        return kntt;

    }
    
    private void btnBaslatActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnBaslatActionPerformed
        cam_calis();
    }//GEN-LAST:event_btnBaslatActionPerformed

    private void btnFotoCekActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnFotoCekActionPerformed

        try {
            fotoAl();
        } catch (IOException ex) {
            System.err.println("foto alım hatası : " + ex);
        }


    }//GEN-LAST:event_btnFotoCekActionPerformed

    private void txtAraKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtAraKeyPressed
        sayi(null, txtAra, "Aranan TC Numarasını");
        if (evt.getKeyCode() == KeyEvent.VK_ENTER) {
            btnGetirActionPerformed(null);
        } else if (evt.getKeyCode() == KeyEvent.VK_ESCAPE) {
            btnGeriActionPerformed(null);
        }
    }//GEN-LAST:event_txtAraKeyPressed
    String deger = "";
    private void cmbGrupItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_cmbGrupItemStateChanged
        if (cmbGrup.getSelectedIndex() > 0) {
            String tiknanID = lsid.get(cmbGrup.getSelectedIndex() - 1);

            ResultSet rs = db.dataGetir("grup where grupID = '" + tiknanID + "' ");
            try {
                if (rs.next()) {
                    deger = rs.getString("grupNo");
                }
            } catch (SQLException ex) {
                System.err.println("cmb-grup hatası : " + ex);
            }

            jLabel14.setText(deger);
        }
    }//GEN-LAST:event_cmbGrupItemStateChanged

    private void txtAraKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtAraKeyTyped
        if (txtAra.getText().length() > 10) {
            getToolkit().beep();
            evt.consume();
        }
    }//GEN-LAST:event_txtAraKeyTyped

    private void txtTCKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtTCKeyTyped
        if (txtTC.getText().length() > 10) {
            getToolkit().beep();
            evt.consume();
        }
    }//GEN-LAST:event_txtTCKeyTyped

    public void sayi(String bisey, JTextField x, String gelentxt) {
        bisey = x.getText();
        for (int i = 0; i < x.getText().length(); i++) {
            if (!Character.isDigit(bisey.charAt(i))) {
                JOptionPane.showMessageDialog(rootPane, "Lütfen " + gelentxt + " Doğru Giriniz");
                bisey = bisey.substring(0, bisey.length() - 1);
                x.setText(bisey);
                x.requestFocus();

            }

        }
    }


    private void txtAdiKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtAdiKeyReleased

        for (int i = 0; i < txtAdi.getText().length(); i++) {
            if (Character.isDigit(txtAdi.getText().charAt(i))) {
                JOptionPane.showMessageDialog(rootPane, "Lütfen Rakam Girmeyiniz");
                txtAdi.setText("");
                txtAdi.requestFocus();

                break;
            }

        }
    }//GEN-LAST:event_txtAdiKeyReleased

    private void txtSoyadiKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtSoyadiKeyReleased
        for (int i = 0; i < txtSoyadi.getText().length(); i++) {
            if (Character.isDigit(txtSoyadi.getText().charAt(i))) {
                JOptionPane.showMessageDialog(rootPane, "Lütfen Rakam Girmeyiniz");
                txtSoyadi.setText("");
                txtSoyadi.requestFocus();

                break;
            }

        }
    }//GEN-LAST:event_txtSoyadiKeyReleased

    private void txtVadiSoyadiKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtVadiSoyadiKeyReleased

        for (int i = 0; i < txtVadiSoyadi.getText().length(); i++) {
            if (Character.isDigit(txtVadiSoyadi.getText().charAt(i))) {
                JOptionPane.showMessageDialog(rootPane, "Lütfen Rakam Girmeyiniz");
                txtVadiSoyadi.setText("");
                txtVadiSoyadi.requestFocus();

                break;
            }

        }
    }//GEN-LAST:event_txtVadiSoyadiKeyReleased

    private void txtAdresKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtAdresKeyTyped
        if (txtAdres.getText().length() > 95) {
            getToolkit().beep();
            evt.consume();
        }
    }//GEN-LAST:event_txtAdresKeyTyped

    private void txtAdiKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtAdiKeyTyped
        if (txtAdi.getText().length() > 20) {
            getToolkit().beep();
            evt.consume();
        }
    }//GEN-LAST:event_txtAdiKeyTyped

    private void txtSoyadiKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtSoyadiKeyTyped
        if (txtSoyadi.getText().length() > 20) {
            getToolkit().beep();
            evt.consume();
        }
    }//GEN-LAST:event_txtSoyadiKeyTyped

    private void txtVadiSoyadiKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtVadiSoyadiKeyTyped
        if (txtVadiSoyadi.getText().length() > 30) {
            getToolkit().beep();
            evt.consume();
        }
    }//GEN-LAST:event_txtVadiSoyadiKeyTyped

    private void txtTCKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtTCKeyPressed
        sayi(null, txtTC, "TC Numarasını");
    }//GEN-LAST:event_txtTCKeyPressed

    public void guncelle() {
        try {
            Date jdatechooser = new Date(txtDogum.getDate().getTime());
            yukleme = db.st.executeUpdate("call asilKayit('" + jdatechooser + "','" + txtAdi.getText().trim() + "',"
                    + "'" + txtSoyadi.getText().trim() + "', '" + txtTC.getText().trim() + "',"
                    + "'" + txtTel.getText().trim() + "', '" + txtOmail.getText().trim() + "', "
                    + "'" + txtVadiSoyadi.getText().trim() + "', '" + txtVtel.getText().trim() + "', "
                    + "'" + txtVmail.getText().trim() + "', '" + txtAdres.getText().trim() + "',"
                    + "'" + txtDokuman.getText().trim() + "', '" + txtTC.getText().trim() + "')");

            if (yukleme > 0) {
                System.out.println("Güncelleme Başarılı");
            } else {
                System.out.println("güncelle() başarısız");
            }
        } catch (SQLException ex) {
            System.err.println("Güncelleme Hatası : " + ex);
        }
    }

    public void temizle() {
        txtAdi.setText("");
        txtTel.setText("");
        txtSoyadi.setText("");
        txtTC.setText("");
        txtVadiSoyadi.setText("");
        txtVtel.setText("");
        txtAdres.setText("");
        txtDogum.setDate(null);
        txtDokuman.setText("");
        cmbGrup.setSelectedIndex(0);
        txtOmail.setText("");
        txtVmail.setText("");
        txtAra.setText("");
    }

    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(ogrenciAnaKayit.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(ogrenciAnaKayit.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(ogrenciAnaKayit.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(ogrenciAnaKayit.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new ogrenciAnaKayit().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnBaslat;
    private javax.swing.JButton btnFotoCek;
    private javax.swing.JButton btnGeri;
    private javax.swing.JButton btnGetir;
    private javax.swing.JButton btnKayit;
    private javax.swing.JComboBox<String> cmbGrup;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel11;
    private javax.swing.JLabel jLabel12;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JLabel jLabel14;
    private javax.swing.JLabel jLabel15;
    private javax.swing.JLabel jLabel16;
    private javax.swing.JLabel jLabel18;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JLabel lblFoto;
    private javax.swing.JTextField txtAdi;
    private javax.swing.JTextArea txtAdres;
    private javax.swing.JTextField txtAra;
    private com.toedter.calendar.JDateChooser txtDogum;
    private javax.swing.JTextField txtDokuman;
    private javax.swing.JTextField txtOmail;
    private javax.swing.JTextField txtSoyadi;
    private javax.swing.JTextField txtTC;
    private javax.swing.JFormattedTextField txtTel;
    private javax.swing.JTextField txtVadiSoyadi;
    private javax.swing.JTextField txtVmail;
    private javax.swing.JFormattedTextField txtVtel;
    // End of variables declaration//GEN-END:variables
}