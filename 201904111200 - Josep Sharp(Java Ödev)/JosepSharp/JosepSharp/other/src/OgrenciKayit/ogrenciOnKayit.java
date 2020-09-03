
package OgrenciKayit;
import java.awt.Component;
import java.awt.TextField;
import java.awt.event.KeyEvent;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.text.DecimalFormat;
import java.text.NumberFormat;
import java.util.Locale;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import javax.swing.JFormattedTextField;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.table.DefaultTableModel;
import veritabani.DB;

public class ogrenciOnKayit extends javax.swing.JFrame {

    DB db = new DB();

    public ogrenciOnKayit() {
        initComponents();
        db.baglan();
        dataGetir();

    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel13 = new javax.swing.JLabel();
        jPanel1 = new javax.swing.JPanel();
        txtAdi = new javax.swing.JTextField();
        jLabel1 = new javax.swing.JLabel();
        txtSoyadi = new javax.swing.JTextField();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        txtTC = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        txtVadiSoyadi = new javax.swing.JTextField();
        jLabel5 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        jButton3 = new javax.swing.JButton();
        txtOgrenciMail = new javax.swing.JTextField();
        jLabel7 = new javax.swing.JLabel();
        jLabel8 = new javax.swing.JLabel();
        txtVeliMail = new javax.swing.JTextField();
        txtCep = new javax.swing.JFormattedTextField();
        txtVcep = new javax.swing.JFormattedTextField();
        jPanel2 = new javax.swing.JPanel();
        jScrollPane1 = new javax.swing.JScrollPane();
        jTable1 = new javax.swing.JTable();
        jButton2 = new javax.swing.JButton();
        jLabel12 = new javax.swing.JLabel();
        jButton1 = new javax.swing.JButton();
        jLabel9 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Ön Kayıt Paneli");
        setPreferredSize(new java.awt.Dimension(800, 600));
        setResizable(false);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jLabel13.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel13.setForeground(new java.awt.Color(153, 0, 51));
        jLabel13.setText("Ön Kayıt Paneli");
        getContentPane().add(jLabel13, new org.netbeans.lib.awtextra.AbsoluteConstraints(360, 30, -1, -1));

        jPanel1.setOpaque(false);
        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        txtAdi.setName("Öğrenci Adı"); // NOI18N
        txtAdi.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                txtAdiKeyPressed(evt);
            }
        });
        jPanel1.add(txtAdi, new org.netbeans.lib.awtextra.AbsoluteConstraints(170, 20, 180, -1));

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 51, 102));
        jLabel1.setText("Öğrenci Adı :");
        jLabel1.setHorizontalTextPosition(javax.swing.SwingConstants.RIGHT);
        jPanel1.add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(60, 20, -1, -1));

        txtSoyadi.setName("Öğrenci Soyadı"); // NOI18N
        txtSoyadi.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                txtSoyadiKeyPressed(evt);
            }
        });
        jPanel1.add(txtSoyadi, new org.netbeans.lib.awtextra.AbsoluteConstraints(170, 50, 180, -1));

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(0, 51, 102));
        jLabel2.setText("Öğrenci Soyadı :");
        jLabel2.setHorizontalTextPosition(javax.swing.SwingConstants.RIGHT);
        jPanel1.add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 50, 120, -1));

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(0, 51, 102));
        jLabel3.setText("Öğrenci T.C. No : ");
        jLabel3.setHorizontalTextPosition(javax.swing.SwingConstants.RIGHT);
        jPanel1.add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 80, -1, -1));

        txtTC.setName("Öğrenci T.C. Numarası"); // NOI18N
        txtTC.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                txtTCKeyPressed(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtTCKeyTyped(evt);
            }
        });
        jPanel1.add(txtTC, new org.netbeans.lib.awtextra.AbsoluteConstraints(170, 80, 180, -1));

        jLabel4.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(0, 51, 102));
        jLabel4.setText("Veli Adı Soyadı :");
        jLabel4.setHorizontalTextPosition(javax.swing.SwingConstants.RIGHT);
        jPanel1.add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(420, 20, -1, -1));

        txtVadiSoyadi.setName("Veli Adı Soyadı"); // NOI18N
        txtVadiSoyadi.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                txtVadiSoyadiKeyPressed(evt);
            }
        });
        jPanel1.add(txtVadiSoyadi, new org.netbeans.lib.awtextra.AbsoluteConstraints(550, 20, 180, -1));

        jLabel5.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(0, 51, 102));
        jLabel5.setText("Veli Cep Tel : ");
        jLabel5.setHorizontalTextPosition(javax.swing.SwingConstants.RIGHT);
        jPanel1.add(jLabel5, new org.netbeans.lib.awtextra.AbsoluteConstraints(440, 50, 100, -1));

        jLabel6.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel6.setForeground(new java.awt.Color(0, 51, 102));
        jLabel6.setText("Öğrenci Cep Tel :");
        jLabel6.setHorizontalTextPosition(javax.swing.SwingConstants.RIGHT);
        jPanel1.add(jLabel6, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 110, -1, -1));

        jButton3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton3.setForeground(new java.awt.Color(0, 51, 102));
        jButton3.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/kayıt ekle.png"))); // NOI18N
        jButton3.setText("Ön Kayıt Ekle");
        jButton3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton3ActionPerformed(evt);
            }
        });
        jPanel1.add(jButton3, new org.netbeans.lib.awtextra.AbsoluteConstraints(550, 130, -1, 50));

        txtOgrenciMail.setName("Öğrenci Mail Adresi"); // NOI18N
        jPanel1.add(txtOgrenciMail, new org.netbeans.lib.awtextra.AbsoluteConstraints(170, 140, 180, -1));

        jLabel7.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel7.setForeground(new java.awt.Color(0, 51, 102));
        jLabel7.setText("Öğrenci Mail Adresi :");
        jLabel7.setHorizontalTextPosition(javax.swing.SwingConstants.RIGHT);
        jPanel1.add(jLabel7, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 140, -1, -1));

        jLabel8.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel8.setForeground(new java.awt.Color(0, 51, 102));
        jLabel8.setText("Veli Mail Adresi :");
        jLabel8.setHorizontalTextPosition(javax.swing.SwingConstants.RIGHT);
        jPanel1.add(jLabel8, new org.netbeans.lib.awtextra.AbsoluteConstraints(420, 90, -1, -1));

        txtVeliMail.setName("Veli Maili"); // NOI18N
        jPanel1.add(txtVeliMail, new org.netbeans.lib.awtextra.AbsoluteConstraints(550, 90, 180, -1));

        try {
            txtCep.setFormatterFactory(new javax.swing.text.DefaultFormatterFactory(new javax.swing.text.MaskFormatter("+90 (###)-### ## ##")));
        } catch (java.text.ParseException ex) {
            ex.printStackTrace();
        }
        jPanel1.add(txtCep, new org.netbeans.lib.awtextra.AbsoluteConstraints(170, 110, 180, -1));

        try {
            txtVcep.setFormatterFactory(new javax.swing.text.DefaultFormatterFactory(new javax.swing.text.MaskFormatter("+90 (###)-### ## ##")));
        } catch (java.text.ParseException ex) {
            ex.printStackTrace();
        }
        jPanel1.add(txtVcep, new org.netbeans.lib.awtextra.AbsoluteConstraints(550, 50, 180, -1));

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 60, 800, 210));

        jPanel2.setOpaque(false);
        jPanel2.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jTable1.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {},
                {},
                {},
                {}
            },
            new String [] {

            }
        ));
        jTable1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jTable1MouseClicked(evt);
            }
        });
        jScrollPane1.setViewportView(jTable1);

        jPanel2.add(jScrollPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 10, 780, 170));

        jButton2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton2.setForeground(new java.awt.Color(0, 51, 102));
        jButton2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/kayıtsil.png"))); // NOI18N
        jButton2.setText("Ön Kayıt Sil");
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });
        jPanel2.add(jButton2, new org.netbeans.lib.awtextra.AbsoluteConstraints(620, 190, 170, 50));

        getContentPane().add(jPanel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 310, 800, 250));

        jLabel12.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel12.setForeground(new java.awt.Color(0, 51, 102));
        jLabel12.setText("Ön Kayıtlar");
        getContentPane().add(jLabel12, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 280, -1, -1));

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
        getContentPane().add(jButton1, new org.netbeans.lib.awtextra.AbsoluteConstraints(740, 10, 100, -1));

        jLabel9.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        getContentPane().add(jLabel9, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 850, 568));

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        KayitYonlendirme ky = new KayitYonlendirme();

        ky.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_jButton1ActionPerformed
    int secim = -1;

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed

        if (secim > -1) {
            int karar = JOptionPane.showConfirmDialog(rootPane, "Silmek istediğinizden eminmisiniz", "Başlık", JOptionPane.YES_NO_OPTION);
            if (karar == 0) {
                try {
                    //silme yap
                    int silDurum = db.st.executeUpdate("delete from ogrenci where ogrenciId='" + secim2 + "'");
                    if (silDurum > 0) {
                        System.out.println("silme başarılı");
                        dataGetir();
                    }
                } catch (SQLException ex) {
                    System.err.println("Sql Silme hatası:" + ex);
                }
            }
        } else {
            JOptionPane.showMessageDialog(rootPane, "Lütfen önce seçim yapınız");

        }


    }//GEN-LAST:event_jButton2ActionPerformed
    String secim2 = "";
    private void jTable1MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jTable1MouseClicked
        secim = jTable1.getSelectedRow();
        secim2 = (String) jTable1.getValueAt(secim, 0);
        txtAdi.setText((String) jTable1.getValueAt(secim, 1));
        txtSoyadi.setText((String) jTable1.getValueAt(secim, 2));
        txtTC.setText((String) jTable1.getValueAt(secim, 3));
        txtCep.setText((String) jTable1.getValueAt(secim, 4));
        txtVadiSoyadi.setText((String) jTable1.getValueAt(secim, 6));
        txtVcep.setText((String) jTable1.getValueAt(secim, 7));
        txtOgrenciMail.setText((String) jTable1.getValueAt(secim, 5));
        txtVeliMail.setText((String) jTable1.getValueAt(secim, 8));

        System.out.println("Data değişti : " + secim2);
    }//GEN-LAST:event_jTable1MouseClicked

    private void jButton3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton3ActionPerformed

        if (kontrol2() && mailKontrol() && kontrol11() && !tcKontrol() && kontrol19()) {
            try {
                boolean rs = db.st.execute("call onKayıtEkle('" + txtAdi.getText().trim() + "','" + txtSoyadi.getText().trim() + "','" + txtTC.getText().trim() + "','" + txtCep.getText().trim() + "','" + txtVadiSoyadi.getText().trim() + "','" + txtVcep.getText().trim() + "','" + "Pasif" + "','" + txtOgrenciMail.getText().trim() + "','" + txtVeliMail.getText().trim() + "')");
                if (rs) {
                    JOptionPane.showMessageDialog(rootPane, "Ekleme Başarılı");
                    temizle();
                }
                dataGetir();
            } catch (SQLException ex) {
                Logger.getLogger(ogrenciOnKayit.class.getName()).log(Level.SEVERE, null, ex);
            }

        }


    }//GEN-LAST:event_jButton3ActionPerformed

    private void txtTCKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtTCKeyTyped

        if (txtTC.getText().length() >= 11) {
            getToolkit().beep();
            evt.consume();
        }
    }//GEN-LAST:event_txtTCKeyTyped

    private void txtTCKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtTCKeyPressed
        sayi(null, txtTC, "TC Numarasını");
    }//GEN-LAST:event_txtTCKeyPressed

    private void txtAdiKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtAdiKeyPressed
        kelime(null, txtAdi);
    }//GEN-LAST:event_txtAdiKeyPressed

    private void txtSoyadiKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtSoyadiKeyPressed
        kelime(null, txtSoyadi);
    }//GEN-LAST:event_txtSoyadiKeyPressed

    private void txtVadiSoyadiKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtVadiSoyadiKeyPressed
        kelime(null, txtVadiSoyadi);
    }//GEN-LAST:event_txtVadiSoyadiKeyPressed
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

    public void kelime(String bisi, JTextField x) {
        bisi = x.getText();
        for (int i = 0; i < x.getText().length(); i++) {
            if (Character.isDigit(bisi.charAt(i))) {
                JOptionPane.showMessageDialog(rootPane, "Lütfen Rakam Girmeyiniz");
                bisi = bisi.substring(0, bisi.length() - 1);
                x.setText(bisi);
                x.requestFocus();
            }

        }
    }

    public boolean kontrol2() {
        boolean durum = true;
        Component[] compo = jPanel1.getComponents();
        for (Component compon : compo) {
            if (compon instanceof JTextField) {

                if (((JTextField) compon).getText().trim().isEmpty()) {
                    JOptionPane.showMessageDialog(compon, "lütfen " + compon.getName() + "'nı doldurun.");
                    compon.requestFocus();
                    durum = false;
                    break;

                }
            }
        }
        return durum;
    }

    public void dataGetir() {
        DefaultTableModel dt = new DefaultTableModel();
        dt.addColumn("Öğrenci ID");
        dt.addColumn("Öğrenci Adı");
        dt.addColumn("Öğrenci Soyadı");
        dt.addColumn("Öğrenci TC");
        dt.addColumn("Öğrenci Cep");
        dt.addColumn("Öğrenci Mail");
        dt.addColumn("Veli Adı Soyadı");
        dt.addColumn("Veli Cep");
        dt.addColumn("Veli Mail");
        String sorgu = null;
        ResultSet rs = db.dataGetir("ogrenci where kayitDurumu = 'Pasif'");
        try {
            while (rs.next()) {
                dt.addRow(new String[]{rs.getString("ogrenciId"), rs.getString("ogrenciAdi"), rs.getString("ogrenciSoyadi"), rs.getString("ogrenciTC"), rs.getString("ogrenciTel"), rs.getString("ogrenciMail"), rs.getString("veliAdSoyad"), rs.getString("veliTel"), rs.getString("veliMail")});
                jTable1.setModel(dt);
            }
        } catch (SQLException ex) {
            Logger.getLogger(ogrenciOnKayit.class.getName()).log(Level.SEVERE, null, ex);
        }

    }
    boolean donus = false;

    public boolean mailKontrol() {
        String emailPattern = "^[\\w!#$%&’*+/=?`{|}~^-]+(?:\\.[\\w!#$%&’*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$";
        Pattern p = Pattern.compile(emailPattern);
        Matcher m = p.matcher(txtOgrenciMail.getText().trim());
        Matcher mm = p.matcher(txtVeliMail.getText().trim());
        if (!(m.matches())) {
            JOptionPane.showMessageDialog(rootPane, "Lütfen Öğrenci Mail Adresini Doğru Giriniz");
            txtOgrenciMail.requestFocus();

        } else if (!(mm.matches())) {
            JOptionPane.showMessageDialog(rootPane, "Lütfen Veli Mail Adresini Doğru Giriniz");
            txtVeliMail.requestFocus();
        } else {
            donus = true;
        }
        return donus;
    }

    public boolean kontrol11() {
        boolean knt = false;
        if (txtTC.getText().length() != 11) {
            JOptionPane.showMessageDialog(rootPane, "Eksik TC girdiniz.");
            txtTC.requestFocus();
        } else {
            knt = true;
        }
        return knt;

    }

    public boolean kontrol19() {
        System.out.println("boyut: " + txtCep.getText().trim().length());
        boolean kntt = false;
        if (txtCep.getText().trim().length() != 19) {
            JOptionPane.showMessageDialog(rootPane, "Eksik Numara Girdiniz.");
            txtCep.requestFocus();
        } else if (txtVcep.getText().trim().length() != 19) {
            JOptionPane.showMessageDialog(rootPane, "Eksik Numara Girdiniz.");
            txtVcep.requestFocus();
        } else {
            kntt = true;
        }
        return kntt;

    }

    public void temizle() {
        txtAdi.setText("");
        txtSoyadi.setText("");
        txtCep.setText("");
        txtVadiSoyadi.setText("");
        txtVcep.setText("");
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
            java.util.logging.Logger.getLogger(ogrenciOnKayit.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(ogrenciOnKayit.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(ogrenciOnKayit.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(ogrenciOnKayit.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {

                new ogrenciOnKayit().setVisible(true);

            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JButton jButton3;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel12;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable jTable1;
    private javax.swing.JTextField txtAdi;
    private javax.swing.JFormattedTextField txtCep;
    private javax.swing.JTextField txtOgrenciMail;
    private javax.swing.JTextField txtSoyadi;
    private javax.swing.JTextField txtTC;
    private javax.swing.JTextField txtVadiSoyadi;
    private javax.swing.JFormattedTextField txtVcep;
    private javax.swing.JTextField txtVeliMail;
    // End of variables declaration//GEN-END:variables

    private void requestFocus(JTextField txtTC) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}
