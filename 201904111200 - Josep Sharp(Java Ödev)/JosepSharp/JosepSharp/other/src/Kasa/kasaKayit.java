package Kasa;


import veritabani.DB;
import AnaMenu.Menu;
import AnaMenu.muhasebe2;
import com.lowagie.text.DocumentException;
import java.awt.event.FocusAdapter;
import java.awt.event.FocusEvent;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.beans.PropertyChangeEvent;
import java.beans.PropertyChangeListener;
import java.io.File;
import java.io.IOException;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JOptionPane;
import kullanici.kontrol;
import raporlama.islemRaporuPDF;

public class kasaKayit extends javax.swing.JFrame {

    /*
    Hareket(BD)/Kasa Hareketi: Database'e 0 giriş 1 çıkış olarak eklendi.
    Öğrenci ile ilişkisi olmayan işlemlerin kasa_ogrenci_id'si 0 olarak girildi.
     */
    kontrol kontrol=new kontrol();
    DefaultComboBoxModel<String> cm = new DefaultComboBoxModel<>();
    int secim = 0;
    String tarih = "1900-01-01 00:00";
    int miktar = 0;
    String islem = "";
    String tur, aciklama;
    int ogrenci;
    String af = "";

    public kasaKayit() {
        initComponents();
        rdoGiris.setSelected(true);
        dbOku();

        cmBoxIslem.getEditor().getEditorComponent().addKeyListener(new KeyAdapter() {
            public void keyReleased(KeyEvent evt) {
                if (evt.getKeyCode() == KeyEvent.VK_ENTER) {
                    btnEkleActionPerformed(null);
                }
            }
        });

        cmBoxIslem.getEditor().getEditorComponent().addFocusListener(new FocusAdapter() {
            public void focusGained(FocusEvent evt) {
                btnEkle.setText("Ekle");
            }
        });

        cmBoxIslem.addPropertyChangeListener(new PropertyChangeListener() {
            public void propertyChange(PropertyChangeEvent evt) {
                gorun();

            }
        });
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        btnGroup = new javax.swing.ButtonGroup();
        jPanel1 = new javax.swing.JPanel();
        btnEkle = new javax.swing.JButton();
        rdoGiris = new javax.swing.JRadioButton();
        rdoCikis = new javax.swing.JRadioButton();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        tarihSec = new com.toedter.calendar.JDateChooser();
        txtAciklama = new javax.swing.JTextField();
        cmBoxOdeme = new javax.swing.JComboBox<>();
        cmBoxIslem = new javax.swing.JComboBox<>();
        txtOgrenciID = new javax.swing.JTextField();
        jLabel7 = new javax.swing.JLabel();
        btnKaydet = new javax.swing.JButton();
        jLabel8 = new javax.swing.JLabel();
        frmtxtMiktar = new javax.swing.JTextField();
        btnSil = new javax.swing.JButton();
        jLabel10 = new javax.swing.JLabel();
        jButton1 = new javax.swing.JButton();
        jLabel9 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("Kasa Kayıt Paneli");
        setMaximumSize(new java.awt.Dimension(850, 568));
        setMinimumSize(new java.awt.Dimension(850, 568));
        setResizable(false);
        addWindowListener(new java.awt.event.WindowAdapter() {
            public void windowClosing(java.awt.event.WindowEvent evt) {
                formWindowClosing(evt);
            }
        });
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jPanel1.setBorder(javax.swing.BorderFactory.createTitledBorder(""));
        jPanel1.setMaximumSize(new java.awt.Dimension(850, 568));
        jPanel1.setMinimumSize(new java.awt.Dimension(850, 568));
        jPanel1.setPreferredSize(new java.awt.Dimension(850, 568));
        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        btnEkle.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnEkle.setForeground(new java.awt.Color(0, 51, 102));
        btnEkle.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/ekle.png"))); // NOI18N
        btnEkle.setText("Ekle");
        btnEkle.setMaximumSize(new java.awt.Dimension(100, 30));
        btnEkle.setMinimumSize(new java.awt.Dimension(100, 30));
        btnEkle.setPreferredSize(new java.awt.Dimension(75, 33));
        btnEkle.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEkleActionPerformed(evt);
            }
        });
        jPanel1.add(btnEkle, new org.netbeans.lib.awtextra.AbsoluteConstraints(570, 330, 90, -1));

        btnGroup.add(rdoGiris);
        rdoGiris.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        rdoGiris.setForeground(new java.awt.Color(0, 153, 0));
        rdoGiris.setText("Giriş");
        rdoGiris.setOpaque(false);
        jPanel1.add(rdoGiris, new org.netbeans.lib.awtextra.AbsoluteConstraints(340, 130, 70, -1));

        btnGroup.add(rdoCikis);
        rdoCikis.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        rdoCikis.setForeground(new java.awt.Color(204, 0, 0));
        rdoCikis.setText("Çıkış");
        rdoCikis.setOpaque(false);
        rdoCikis.addPropertyChangeListener(new java.beans.PropertyChangeListener() {
            public void propertyChange(java.beans.PropertyChangeEvent evt) {
                rdoCikisPropertyChange(evt);
            }
        });
        jPanel1.add(rdoCikis, new org.netbeans.lib.awtextra.AbsoluteConstraints(450, 130, 70, -1));

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 51, 102));
        jLabel1.setText("Tarih:");
        jPanel1.add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(250, 190, 40, -1));

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(0, 51, 102));
        jLabel2.setText("Miktar:");
        jPanel1.add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(240, 240, -1, -1));

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(0, 51, 102));
        jLabel3.setText("Ödeme Şekli:");
        jPanel1.add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(200, 290, -1, -1));

        jLabel4.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(0, 51, 102));
        jLabel4.setText("İşlem Türü:");
        jPanel1.add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 340, -1, -1));

        jLabel5.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(0, 51, 102));
        jLabel5.setText("Açıklama:");
        jPanel1.add(jLabel5, new org.netbeans.lib.awtextra.AbsoluteConstraints(230, 390, -1, -1));

        jLabel6.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel6.setForeground(new java.awt.Color(0, 51, 102));
        jLabel6.setText("Öğrenci Numarası:");
        jPanel1.add(jLabel6, new org.netbeans.lib.awtextra.AbsoluteConstraints(170, 430, -1, -1));

        tarihSec.setDate(new Date());
        tarihSec.setDateFormatString("dd.MM.yyyy HH:mm");
        jPanel1.add(tarihSec, new org.netbeans.lib.awtextra.AbsoluteConstraints(310, 190, 230, -1));

        txtAciklama.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                txtAciklamaKeyReleased(evt);
            }
        });
        jPanel1.add(txtAciklama, new org.netbeans.lib.awtextra.AbsoluteConstraints(310, 390, 230, -1));

        cmBoxOdeme.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Nakit", "Kredi Kartı", "Senet" }));
        jPanel1.add(cmBoxOdeme, new org.netbeans.lib.awtextra.AbsoluteConstraints(310, 290, 230, -1));

        cmBoxIslem.setEditable(true);
        cmBoxIslem.setMaximumSize(new java.awt.Dimension(150, 32767));
        cmBoxIslem.setMinimumSize(new java.awt.Dimension(150, 20));
        cmBoxIslem.setPreferredSize(new java.awt.Dimension(150, 20));
        cmBoxIslem.addFocusListener(new java.awt.event.FocusAdapter() {
            public void focusGained(java.awt.event.FocusEvent evt) {
                cmBoxIslemFocusGained(evt);
            }
        });
        cmBoxIslem.addPropertyChangeListener(new java.beans.PropertyChangeListener() {
            public void propertyChange(java.beans.PropertyChangeEvent evt) {
                cmBoxIslemPropertyChange(evt);
            }
        });
        cmBoxIslem.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                cmBoxIslemKeyReleased(evt);
            }
        });
        jPanel1.add(cmBoxIslem, new org.netbeans.lib.awtextra.AbsoluteConstraints(310, 340, 230, -1));
        jPanel1.add(txtOgrenciID, new org.netbeans.lib.awtextra.AbsoluteConstraints(310, 430, 230, -1));

        jLabel7.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel7.setForeground(new java.awt.Color(0, 51, 102));
        jLabel7.setText("Kasa Hareketi:");
        jPanel1.add(jLabel7, new org.netbeans.lib.awtextra.AbsoluteConstraints(190, 140, -1, -1));

        btnKaydet.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnKaydet.setForeground(new java.awt.Color(0, 51, 102));
        btnKaydet.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/kaydet.png"))); // NOI18N
        btnKaydet.setText("Kaydet");
        btnKaydet.setPreferredSize(new java.awt.Dimension(97, 23));
        btnKaydet.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnKaydetActionPerformed(evt);
            }
        });
        jPanel1.add(btnKaydet, new org.netbeans.lib.awtextra.AbsoluteConstraints(430, 470, 110, 30));

        jLabel8.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel8.setForeground(new java.awt.Color(0, 51, 102));
        jLabel8.setText("TL");
        jPanel1.add(jLabel8, new org.netbeans.lib.awtextra.AbsoluteConstraints(548, 244, 30, 10));

        frmtxtMiktar.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
        frmtxtMiktar.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                frmtxtMiktarKeyReleased(evt);
            }
        });
        jPanel1.add(frmtxtMiktar, new org.netbeans.lib.awtextra.AbsoluteConstraints(310, 240, 230, -1));

        btnSil.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnSil.setForeground(new java.awt.Color(0, 51, 102));
        btnSil.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/sil.png"))); // NOI18N
        btnSil.setText("Sil");
        btnSil.setToolTipText("Sil");
        btnSil.setBorder(null);
        btnSil.setMaximumSize(new java.awt.Dimension(100, 30));
        btnSil.setMinimumSize(new java.awt.Dimension(100, 30));
        btnSil.setPreferredSize(new java.awt.Dimension(75, 33));
        btnSil.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnSilActionPerformed(evt);
            }
        });
        jPanel1.add(btnSil, new org.netbeans.lib.awtextra.AbsoluteConstraints(670, 330, 90, -1));

        jLabel10.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel10.setForeground(new java.awt.Color(153, 0, 51));
        jLabel10.setText("Kasa Kayıt Paneli");
        jPanel1.add(jLabel10, new org.netbeans.lib.awtextra.AbsoluteConstraints(330, 70, -1, -1));

        jButton1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton1.setForeground(new java.awt.Color(0, 51, 102));
        jButton1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1466161311_agt_back.png"))); // NOI18N
        jButton1.setText("Geri");
        jButton1.setBorder(null);
        jButton1.setBorderPainted(false);
        jButton1.setContentAreaFilled(false);
        jButton1.setFocusable(false);
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        jPanel1.add(jButton1, new org.netbeans.lib.awtextra.AbsoluteConstraints(750, 10, -1, -1));

        jLabel9.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel9.setForeground(new java.awt.Color(0, 51, 102));
        jLabel9.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        jLabel9.setMaximumSize(new java.awt.Dimension(850, 568));
        jLabel9.setMinimumSize(new java.awt.Dimension(850, 568));
        jLabel9.setPreferredSize(new java.awt.Dimension(850, 568));
        jPanel1.add(jLabel9, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 850, 568));

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 850, 568));

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    public boolean ogrenciKontrol() {
        boolean k = false;
        String a = cmBoxIslem.getSelectedItem().toString();
        k = a.toLowerCase().contains("öğrenci");
        if (k == false) {
            k = a.toLowerCase().contains("ögrenci");
            if (k == false) {
                k = a.toLowerCase().contains("ogrenci");
                if (k == false) {
                    k = a.toLowerCase().contains("oğrenci");
                    if (k == false) {
                        k = a.toLowerCase().contains("ogrencı");
                        if (k == false) {
                            k = a.toLowerCase().contains("oğrencı");
                            if (k == false) {
                                k = a.toLowerCase().contains("öğrencı");
                            }
                        }
                    }
                }
            }
        }
        return k;
    }

    public void gorun() {
        if (cmBoxIslem.getItemCount() != 0 && ogrenciKontrol()) {
            jLabel6.setVisible(true);
            txtOgrenciID.setVisible(true);
        } else {
            jLabel6.setVisible(false);
            txtOgrenciID.setVisible(false);
        }
    }

    private void btnEkleActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnEkleActionPerformed

        if (!cmBoxIslem.getEditor().getItem().toString().trim().equals("")) {

            DB bd = new DB();

            if (itemVar(cmBoxIslem.getEditor().getItem().toString().trim())) {
                af = cmBoxIslem.getEditor().getItem().toString().trim();
                btnEkle.setText("Ekli");
            } else {
                bd.genel("call proTipYaz('" + cmBoxIslem.getEditor().getItem().toString().trim() + "')");
                af = cmBoxIslem.getEditor().getItem().toString().trim();
                btnEkle.setText("Eklendi");
            }
            bd.kapat();

            cmBoxIslem.removeAllItems();
            dbOku();
            cmBoxIslem.setSelectedItem(af);
            af = "";

        } else {
            cmBoxIslem.getEditor().setItem("");
            JOptionPane.showMessageDialog(this, "Boş işlem türü eklenemez.");
        }
        gorun();

    }//GEN-LAST:event_btnEkleActionPerformed

    private void cmBoxIslemKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_cmBoxIslemKeyReleased

    }//GEN-LAST:event_cmBoxIslemKeyReleased
    
    public static void pdfIslem() {
        islemRaporuPDF toPdf = new islemRaporuPDF();
        try {
            toPdf.islemRaporu();
        } catch (DocumentException ex) {
            Logger.getLogger(kasaKayit.class.getName()).log(Level.SEVERE, null, ex);
        } catch (IOException ex) {
            Logger.getLogger(kasaKayit.class.getName()).log(Level.SEVERE, null, ex);
        }
        try {
            if ((new File(islemRaporuPDF.dosyaAdi)).exists()) {
                Process p = Runtime.getRuntime().exec("rundll32 url.dll,FileProtocolHandler " + islemRaporuPDF.dosyaAdi);
                p.waitFor();
            } else {
                System.out.println("File is not exists");
            }
            System.out.println("Done");
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }
    
    private void btnKaydetActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnKaydetActionPerformed

        //to MySQL
        SimpleDateFormat dt = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
        tarih = dt.format(tarihSec.getDate());
        tur = cmBoxOdeme.getSelectedItem().toString();
        aciklama = txtAciklama.getText().trim();
        
        
        if (frmtxtMiktar.getText().trim().equals("")) {
            JOptionPane.showMessageDialog(this, "Lütfen ödeme miktarını giriniz.");
            frmtxtMiktar.requestFocus();
        } else if (cmBoxIslem.getItemCount() == 0) {
            JOptionPane.showMessageDialog(this, "Lütfen tür ekleyiniz.");
            cmBoxIslem.requestFocus();
        }else if(txtOgrenciID.isVisible()&&txtOgrenciID.getText().trim().equals("")){
            JOptionPane.showMessageDialog(rootPane, "Lütfen öğrencinin numarasını giriniz.");
            txtOgrenciID.requestFocus();
        }else {

            if (!txtOgrenciID.isVisible()) {
            ogrenci = 0;
            } else {
                ogrenci = Integer.valueOf(txtOgrenciID.getText().trim());
            }
            
            miktar = Integer.valueOf(frmtxtMiktar.getText().trim());
            islem = cmBoxIslem.getSelectedItem().toString().trim();
            DB bd = new DB();

            bd.genel("call proKasaKaydi('" + secim + "','" + tarih + "','" + miktar + "','" + tur + "','" + islem + "','" + aciklama + "','" + ogrenci + "')");
            bd.kapat();

            if (tur.equals("Senet")) {
                senet st = new senet(ogrenci, miktar);
                st.setVisible(true);
                this.setVisible(false);
            } else if (!tur.equals("Senet")) {
                pdfIslem();
            }

            secim = 0;
            tarih = "";
            miktar = 0;
            tur = "";
            islem = "";
            aciklama = "";
            ogrenci = 0;
            frmtxtMiktar.setText("");
            txtAciklama.setText("");
            txtOgrenciID.setText("");
            tarihSec.setDate(new Date());
            cmBoxIslem.setSelectedIndex(0);
            cmBoxOdeme.setSelectedIndex(0);
        }
        
    }//GEN-LAST:event_btnKaydetActionPerformed

    private void rdoCikisPropertyChange(java.beans.PropertyChangeEvent evt) {//GEN-FIRST:event_rdoCikisPropertyChange
        secim = rdoGiris.isSelected() ? 0 : 1;
    }//GEN-LAST:event_rdoCikisPropertyChange

    private void cmBoxIslemFocusGained(java.awt.event.FocusEvent evt) {//GEN-FIRST:event_cmBoxIslemFocusGained

    }//GEN-LAST:event_cmBoxIslemFocusGained

    private void cmBoxIslemPropertyChange(java.beans.PropertyChangeEvent evt) {//GEN-FIRST:event_cmBoxIslemPropertyChange

    }//GEN-LAST:event_cmBoxIslemPropertyChange

    private void frmtxtMiktarKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_frmtxtMiktarKeyReleased

        if (evt.getKeyCode() != KeyEvent.VK_ENTER) {
            try {
                int i = (Integer.valueOf(frmtxtMiktar.getText()) / 1);
                i = 0;
            } catch (NumberFormatException e) {
                JOptionPane.showMessageDialog(this, "Lütfen sadece rakam giriniz");
                frmtxtMiktar.setText("");
                System.err.println("Kasa Miktar Girişi Hatası: " + e);
            }
        }
    }//GEN-LAST:event_frmtxtMiktarKeyReleased

    private void btnSilActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnSilActionPerformed
        //Db tip sil
        if (cmBoxIslem.getItemCount() != 0) {
            DB bd = new DB();
            bd.genel("call proTipSil('" + cmBoxIslem.getSelectedItem().toString().trim() + "')");
            bd.kapat();
            cmBoxIslem.removeAllItems();
            dbOku();
        } else {
            JOptionPane.showMessageDialog(this, "Liste Boş!");
        }


    }//GEN-LAST:event_btnSilActionPerformed

    private void formWindowClosing(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowClosing
        AnaMenu.Menu ana = new Menu();
        ana.setVisible(true);
    }//GEN-LAST:event_formWindowClosing

    private void txtAciklamaKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtAciklamaKeyReleased
        if(evt.getKeyCode() == KeyEvent.VK_ENTER){
            if(txtOgrenciID.isVisible()){
            txtOgrenciID.requestFocus();
        }else{
                btnKaydetActionPerformed(null);
            }
        }
    }//GEN-LAST:event_txtAciklamaKeyReleased

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
       muhasebe2 m=new muhasebe2();
       m.setVisible(true);
       this.setVisible(false);
    }//GEN-LAST:event_jButton1ActionPerformed

    public void dbOku() {
        try {
            DB bd = new DB();
            ResultSet rs = bd.muhasebeTipOku();
            while (rs.next()) {
                cm.addElement(rs.getString("tip"));
            }
            cmBoxIslem.setModel(cm);
            bd.kapat();
        } catch (SQLException ex) {
            Logger.getLogger(kasaKayit.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    public boolean itemVar(String a) {
        boolean bol = false;

        try {

            DB bd = new DB();
            ResultSet rs = bd.muhasebeTipOku();
            while (rs.next()) {
                if (rs.getString("tip").equals(a)) {
                    bol = true;
                    break;
                }
            }
            bd.kapat();

        } catch (Exception e) {
            System.err.println("SQL Okuma Hatası: " + e);
        }

        return bol;
    }

    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Windows".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(kasaKayit.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(kasaKayit.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(kasaKayit.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(kasaKayit.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new kasaKayit().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnEkle;
    private javax.swing.ButtonGroup btnGroup;
    private javax.swing.JButton btnKaydet;
    private javax.swing.JButton btnSil;
    private javax.swing.JComboBox<String> cmBoxIslem;
    private javax.swing.JComboBox<String> cmBoxOdeme;
    private javax.swing.JTextField frmtxtMiktar;
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JRadioButton rdoCikis;
    private javax.swing.JRadioButton rdoGiris;
    private com.toedter.calendar.JDateChooser tarihSec;
    private javax.swing.JTextField txtAciklama;
    private javax.swing.JTextField txtOgrenciID;
    // End of variables declaration//GEN-END:variables
}
