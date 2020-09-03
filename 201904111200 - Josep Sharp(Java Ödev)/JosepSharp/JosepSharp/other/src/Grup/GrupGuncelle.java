package Grup; 
import java.awt.Component;
import java.awt.HeadlessException;
import java.sql.Date;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.security.auth.callback.ConfirmationCallback;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.table.DefaultTableModel;
import veritabani.DB;

public class GrupGuncelle extends javax.swing.JFrame {

    DefaultTableModel tb = new DefaultTableModel();
    DefaultComboBoxModel<String> cmb = new DefaultComboBoxModel<>();
    DefaultComboBoxModel<String> cmb2 = new DefaultComboBoxModel<>();
    int grupid;
    ArrayList<String> dizi = new ArrayList<>();
    DB d = new DB();

    public GrupGuncelle() {
        initComponents();
        comboGuncelle();
        grupComboGuncelle();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        txtGrupNo = new javax.swing.JTextField();
        jLabel2 = new javax.swing.JLabel();
        txtGrupAciklama = new javax.swing.JTextField();
        jLabel3 = new javax.swing.JLabel();
        txtGrupKontenjan = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        jDateChooserBaslangic = new com.toedter.calendar.JDateChooser();
        jLabel6 = new javax.swing.JLabel();
        jDateChooserGrupBitis = new com.toedter.calendar.JDateChooser();
        btnGuncelle = new javax.swing.JButton();
        btnSil = new javax.swing.JButton();
        cbGrupListesi = new javax.swing.JComboBox<>();
        jLabel7 = new javax.swing.JLabel();
        cbGrupDanismani = new javax.swing.JComboBox<>();
        jButton1 = new javax.swing.JButton();
        jLabel9 = new javax.swing.JLabel();
        jLabel8 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Grup Güncelleme Paneli");
        setMinimumSize(new java.awt.Dimension(850, 568));
        setResizable(false);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jPanel1.setBorder(javax.swing.BorderFactory.createTitledBorder(""));
        jPanel1.setMaximumSize(new java.awt.Dimension(850, 568));
        jPanel1.setMinimumSize(new java.awt.Dimension(850, 568));
        jPanel1.setPreferredSize(new java.awt.Dimension(850, 568));
        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 51, 102));
        jLabel1.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        jLabel1.setText("Grup No : ");
        jPanel1.add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 120, 80, -1));
        jPanel1.add(txtGrupNo, new org.netbeans.lib.awtextra.AbsoluteConstraints(320, 120, 290, -1));

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(0, 51, 102));
        jLabel2.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        jLabel2.setText("Grup Açıklaması :");
        jPanel1.add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(160, 170, 130, -1));
        jPanel1.add(txtGrupAciklama, new org.netbeans.lib.awtextra.AbsoluteConstraints(320, 170, 290, -1));

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(0, 51, 102));
        jLabel3.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        jLabel3.setText("Grup Kontenjanı :");
        jPanel1.add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(159, 220, 130, -1));
        jPanel1.add(txtGrupKontenjan, new org.netbeans.lib.awtextra.AbsoluteConstraints(320, 220, 290, -1));

        jLabel4.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(0, 51, 102));
        jLabel4.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        jLabel4.setText("Grup Danışmanı :");
        jPanel1.add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 270, 136, -1));

        jLabel5.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(0, 51, 102));
        jLabel5.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        jLabel5.setText("Grup Başlama Tarihi : ");
        jPanel1.add(jLabel5, new org.netbeans.lib.awtextra.AbsoluteConstraints(130, 310, 160, -1));
        jPanel1.add(jDateChooserBaslangic, new org.netbeans.lib.awtextra.AbsoluteConstraints(320, 310, 290, -1));

        jLabel6.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel6.setForeground(new java.awt.Color(0, 51, 102));
        jLabel6.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        jLabel6.setText("Grup Bitiş Tarihi :");
        jPanel1.add(jLabel6, new org.netbeans.lib.awtextra.AbsoluteConstraints(160, 360, 130, -1));
        jPanel1.add(jDateChooserGrupBitis, new org.netbeans.lib.awtextra.AbsoluteConstraints(320, 360, 290, -1));

        btnGuncelle.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnGuncelle.setForeground(new java.awt.Color(0, 51, 102));
        btnGuncelle.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/guncelle.png"))); // NOI18N
        btnGuncelle.setText("Güncelle");
        btnGuncelle.setMaximumSize(new java.awt.Dimension(100, 30));
        btnGuncelle.setMinimumSize(new java.awt.Dimension(100, 30));
        btnGuncelle.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnGuncelleActionPerformed(evt);
            }
        });
        jPanel1.add(btnGuncelle, new org.netbeans.lib.awtextra.AbsoluteConstraints(310, 410, 130, 40));

        btnSil.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnSil.setForeground(new java.awt.Color(0, 51, 102));
        btnSil.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/sil.png"))); // NOI18N
        btnSil.setText("Sil");
        btnSil.setMaximumSize(new java.awt.Dimension(100, 30));
        btnSil.setMinimumSize(new java.awt.Dimension(100, 30));
        btnSil.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnSilActionPerformed(evt);
            }
        });
        jPanel1.add(btnSil, new org.netbeans.lib.awtextra.AbsoluteConstraints(490, 410, 130, 40));

        cbGrupListesi.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        cbGrupListesi.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                cbGrupListesiItemStateChanged(evt);
            }
        });
        jPanel1.add(cbGrupListesi, new org.netbeans.lib.awtextra.AbsoluteConstraints(320, 70, 290, -1));

        jLabel7.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel7.setForeground(new java.awt.Color(0, 51, 102));
        jLabel7.setText("Grup Listesi :");
        jPanel1.add(jLabel7, new org.netbeans.lib.awtextra.AbsoluteConstraints(200, 70, 90, -1));

        cbGrupDanismani.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(cbGrupDanismani, new org.netbeans.lib.awtextra.AbsoluteConstraints(320, 270, 290, -1));

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
        jPanel1.add(jButton1, new org.netbeans.lib.awtextra.AbsoluteConstraints(740, 10, 100, -1));

        jLabel9.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel9.setForeground(new java.awt.Color(153, 0, 51));
        jLabel9.setText("Grup Güncelleme  Paneli");
        jPanel1.add(jLabel9, new org.netbeans.lib.awtextra.AbsoluteConstraints(340, 20, -1, -1));

        jLabel8.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel8.setForeground(new java.awt.Color(0, 51, 102));
        jLabel8.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        jLabel8.setMaximumSize(new java.awt.Dimension(850, 568));
        jLabel8.setMinimumSize(new java.awt.Dimension(850, 568));
        jLabel8.setPreferredSize(new java.awt.Dimension(850, 568));
        jPanel1.add(jLabel8, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 850, 568));

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 850, 568));

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    public void grupComboGuncelle() {

        cmb2 = new DefaultComboBoxModel<>();
        cmb2.setSelectedItem("Grup Danışmanını Seçiniz");
        d.baglan();
        ResultSet rs;
        try {
            
            rs = d.st.executeQuery("select *from ogretmen");
            while (rs.next()) {
                String soyad = rs.getString("ogretmenSoyadi");
                cmb2.addElement(rs.getString("ogretmenAdi") + " " + soyad);
                cbGrupDanismani.setModel(cmb2);
            }
        } catch (SQLException ex) {
            Logger.getLogger(GrupGuncelle.class.getName()).log(Level.SEVERE, null, ex);
        }finally {
            d.kapat();
        }

    }

    public void comboGuncelle() {
        cmb = new DefaultComboBoxModel<>();
        cmb.setSelectedItem("Grup Numarasını Seçiniz.");
        
        d.baglan();
        ResultSet rs;
        try {
            rs = d.st.executeQuery("select grupNo from grup");
            while (rs.next()) {
                cmb.addElement(rs.getString("grupNo"));
                cbGrupListesi.setModel(cmb);
            }
        } catch (SQLException ex) {
            Logger.getLogger(GrupGuncelle.class.getName()).log(Level.SEVERE, null, ex);
        }finally {
            d.kapat();
        }

    }
    private void cbGrupListesiItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_cbGrupListesiItemStateChanged

        String aranan = cmb.getSelectedItem().toString();
        tb.setRowCount(0);
        
        try {
            d.baglan();
            ResultSet rs = d.st.executeQuery("call grupBilgisiGetirme('" + aranan + "')");
            grupComboGuncelle();
            while (rs.next()) {
                txtGrupNo.setText(rs.getString("grupNo"));
                txtGrupAciklama.setText(rs.getString("grupAciklama"));
                txtGrupKontenjan.setText(rs.getString("grupKontenjan"));

                cbGrupDanismani.setSelectedItem(rs.getString("grupDanisman"));
                cbGrupDanismani.setModel(cmb2);
                jDateChooserBaslangic.setDate(rs.getDate("grupAcilisTarihi"));
                jDateChooserGrupBitis.setDate(rs.getDate("grupBitisTarihi"));
                grupid = Integer.valueOf(rs.getString("grupID"));
            }

        } catch (SQLException ex) {
            Logger.getLogger(GrupGuncelle.class.getName()).log(Level.SEVERE, null, ex);
        }finally {
            d.kapat();
        }
    }//GEN-LAST:event_cbGrupListesiItemStateChanged

    private void btnGuncelleActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnGuncelleActionPerformed

        String grupNo = txtGrupNo.getText().trim();
        String grupAciklama = txtGrupAciklama.getText().trim();
        String grupDanisman = cbGrupDanismani.getSelectedItem().toString();
        String grupKontenjan = txtGrupKontenjan.getText().trim();
        
        if (txtDenetim() || dateDenetim() || sayiKontrol(grupKontenjan)) {

        } else {
            try {
                Date baslangicTarih = new Date(jDateChooserBaslangic.getDate().getTime());
                Date bitisTarih = new Date(jDateChooserGrupBitis.getDate().getTime());
                int cevap = JOptionPane.showConfirmDialog(rootPane, "Güncellemek İstediğinizden Emin Misiniz?", "Başlık", ConfirmationCallback.YES_NO_OPTION);

                if (cevap == 0) {
                    d.baglan();
                    int rs = d.st.executeUpdate("call grupBilgisiGuncelle('" + grupNo + "','" + grupAciklama + "','" + grupKontenjan + "','" + grupDanisman + "','" + baslangicTarih + "','" + bitisTarih + "','" + grupid + "') ");
                    txtGrupNo.setText("");
                    txtGrupAciklama.setText("");
                    txtGrupKontenjan.setText("");
                    cbGrupDanismani.setToolTipText("");
                    jDateChooserBaslangic.setDate(null);
                    jDateChooserGrupBitis.setDate(null);
                    comboGuncelle();
                    grupComboGuncelle();
                } else if (cevap == 1) {
                    txtGrupNo.requestFocus();
                }
            } catch (SQLException ex) {
                Logger.getLogger(GrupGuncelle.class.getName()).log(Level.SEVERE, null, ex);
            }finally {
                d.kapat();
            }
        }

        
    }//GEN-LAST:event_btnGuncelleActionPerformed

    private void btnSilActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnSilActionPerformed
        String silinecekGrup = cmb.getSelectedItem().toString();
       
        if(cbGrupListesi.getSelectedIndex() == -1) {
            JOptionPane.showMessageDialog(rootPane, "Lütfen Grup Numarasını Seçiniz");
        }else {
        try {
            d.baglan();
            int cevap = JOptionPane.showConfirmDialog(rootPane, "Silmek İstediğinizden Emin Misiniz?", "Başlık", ConfirmationCallback.YES_NO_OPTION);
            if (cevap == 0) {
                ResultSet rs = d.st.executeQuery("call grupBilgisiSilme('" + silinecekGrup + "')");

                txtGrupNo.setText("");
                txtGrupAciklama.setText("");
                txtGrupKontenjan.setText("");
                cbGrupDanismani.setToolTipText("");
                jDateChooserBaslangic.setDate(null);
                jDateChooserGrupBitis.setDate(null);
                comboGuncelle();
                grupComboGuncelle();
            } else if (cevap == 1) {
                txtGrupNo.requestFocus();
            }
        } catch (SQLException ex) {
            Logger.getLogger(GrupGuncelle.class.getName()).log(Level.SEVERE, null, ex);
        }finally {
            d.kapat();
        }
        }
        
    }//GEN-LAST:event_btnSilActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        GrupNavigasyon navigasyon = new GrupNavigasyon();
        navigasyon.setVisible(true);
        this.setVisible(false);
        d.kapat();
    }//GEN-LAST:event_jButton1ActionPerformed

    public boolean txtDenetim() {
        boolean durum = false;
        Component[] comDizi = jPanel1.getComponents();
        for (Component component : comDizi) {
            if (component instanceof JTextField) {
                JTextField txt = (JTextField) component;
                if (txt.getText().equals("")) {
                    JOptionPane.showMessageDialog(component, "Lütfen Boş Alanları Doldurunuz.");
                    txtGrupNo.requestFocus();
                    durum = true;
                    break;
                }
            }
        }
        return durum;
    }

    public boolean grupKontrol() {
        boolean durum = false;
        
        try {
            ResultSet rs = d.st.executeQuery("select *from grup");
            while (rs.next()) {
                dizi.add(rs.getString("grupNo"));
            }
            
            if (dizi.contains(txtGrupNo.getText())) {
                durum = true;
                JOptionPane.showMessageDialog(rootPane, "Eklemek İstediğiniz Grup Bulunmaktadır.");
            }
        } catch (SQLException | HeadlessException e) {
        }

        return durum;
    }

    public boolean dateDenetim() {
        java.util.Date baslangicTar = jDateChooserBaslangic.getDate();
        java.util.Date bitisTar = jDateChooserGrupBitis.getDate();
        boolean durum = false;
        if (baslangicTar == null || bitisTar == null) {
            JOptionPane.showMessageDialog(null, "Lütfen tarih alanlarını doğru formatta  doldurunuz.", "Error", JOptionPane.ERROR_MESSAGE);
            durum = true;
        }
        return durum;
    }

    public static boolean sayiKontrol(String gelen) {
        if (gelen.length() >= 11) {
            return true;
        }
        boolean durum = true;
        char[] diz = gelen.toCharArray();

        for (int i = 0; i < diz.length; i++) {

            if (Character.isDigit(diz[i])) {
                durum = false;

            } else {
                durum = true;
                JOptionPane.showMessageDialog(null, "Grup kontenjanını doğru formatta giriniz.");
                break;
            }

        }
        return durum;
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
            java.util.logging.Logger.getLogger(GrupGuncelle.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(GrupGuncelle.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(GrupGuncelle.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(GrupGuncelle.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new GrupGuncelle().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnGuncelle;
    private javax.swing.JButton btnSil;
    private javax.swing.JComboBox<String> cbGrupDanismani;
    private javax.swing.JComboBox<String> cbGrupListesi;
    private javax.swing.JButton jButton1;
    private com.toedter.calendar.JDateChooser jDateChooserBaslangic;
    private com.toedter.calendar.JDateChooser jDateChooserGrupBitis;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JTextField txtGrupAciklama;
    private javax.swing.JTextField txtGrupKontenjan;
    private javax.swing.JTextField txtGrupNo;
    // End of variables declaration//GEN-END:variables
}
