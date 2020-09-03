package Grup;
import java.awt.Component;
import java.awt.HeadlessException;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Date;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.security.auth.callback.ConfirmationCallback;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import veritabani.DB;

public class YeniGrupOlustur extends javax.swing.JFrame {

    DefaultComboBoxModel<String> cmb = new DefaultComboBoxModel<>();
    ArrayList<String> dizi = new ArrayList<>();
    DB d = new DB();
    
    public YeniGrupOlustur() {

        initComponents();
        comboGuncelle();

    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        txtGrupNo = new javax.swing.JTextField();
        txtGrupAciklama = new javax.swing.JTextField();
        txtGrupKontenjan = new javax.swing.JTextField();
        jLabel5 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        btnKaydet = new javax.swing.JButton();
        jDateChooserBaslangic = new com.toedter.calendar.JDateChooser();
        jDateChooserGrupBitis = new com.toedter.calendar.JDateChooser();
        cbGrupDanismani = new javax.swing.JComboBox<>();
        jButton1 = new javax.swing.JButton();
        jLabel7 = new javax.swing.JLabel();
        jLabel8 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Yeni Grup Oluşturma Paneli");
        setPreferredSize(new java.awt.Dimension(850, 568));
        setResizable(false);
        getContentPane().setLayout(null);

        jPanel1.setMaximumSize(null);
        jPanel1.setMinimumSize(new java.awt.Dimension(850, 600));
        jPanel1.setLayout(null);

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 51, 102));
        jLabel1.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        jLabel1.setText("Grup No : ");
        jPanel1.add(jLabel1);
        jLabel1.setBounds(200, 120, 90, 17);

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(0, 51, 102));
        jLabel2.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        jLabel2.setText("Grup Açıklaması :");
        jPanel1.add(jLabel2);
        jLabel2.setBounds(160, 170, 130, 17);

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(0, 51, 102));
        jLabel3.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        jLabel3.setText("Grup Kontenjanı :");
        jPanel1.add(jLabel3);
        jLabel3.setBounds(160, 220, 130, 17);

        jLabel4.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(0, 51, 102));
        jLabel4.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        jLabel4.setText("Grup Danışmanı :");
        jPanel1.add(jLabel4);
        jLabel4.setBounds(140, 270, 150, 17);

        txtGrupNo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtGrupNoActionPerformed(evt);
            }
        });
        jPanel1.add(txtGrupNo);
        txtGrupNo.setBounds(310, 120, 340, 20);
        jPanel1.add(txtGrupAciklama);
        txtGrupAciklama.setBounds(310, 170, 340, 20);
        jPanel1.add(txtGrupKontenjan);
        txtGrupKontenjan.setBounds(310, 220, 340, 20);

        jLabel5.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(0, 51, 102));
        jLabel5.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        jLabel5.setText("Grup Başlama Tarihi : ");
        jPanel1.add(jLabel5);
        jLabel5.setBounds(130, 310, 160, 17);

        jLabel6.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel6.setForeground(new java.awt.Color(0, 51, 102));
        jLabel6.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        jLabel6.setText("Grup Bitiş Tarihi :");
        jPanel1.add(jLabel6);
        jLabel6.setBounds(160, 350, 130, 17);

        btnKaydet.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        btnKaydet.setForeground(new java.awt.Color(51, 0, 51));
        btnKaydet.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/kaydet.png"))); // NOI18N
        btnKaydet.setText("Kaydet");
        btnKaydet.setMaximumSize(new java.awt.Dimension(100, 30));
        btnKaydet.setMinimumSize(new java.awt.Dimension(100, 30));
        btnKaydet.setPreferredSize(new java.awt.Dimension(100, 30));
        btnKaydet.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnKaydetActionPerformed(evt);
            }
        });
        jPanel1.add(btnKaydet);
        btnKaydet.setBounds(520, 390, 130, 40);
        jPanel1.add(jDateChooserBaslangic);
        jDateChooserBaslangic.setBounds(310, 310, 340, 20);
        jPanel1.add(jDateChooserGrupBitis);
        jDateChooserGrupBitis.setBounds(310, 350, 340, 20);

        cbGrupDanismani.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(cbGrupDanismani);
        cbGrupDanismani.setBounds(310, 270, 340, 20);

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
        jPanel1.add(jButton1);
        jButton1.setBounds(740, 10, 100, 33);

        jLabel7.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel7.setForeground(new java.awt.Color(153, 0, 51));
        jLabel7.setText("Yeni Grup Oluşturma Paneli");
        jPanel1.add(jLabel7);
        jLabel7.setBounds(340, 40, 290, 22);

        jLabel8.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        jLabel8.setAlignmentY(0.0F);
        jLabel8.setMaximumSize(new java.awt.Dimension(800, 600));
        jLabel8.setMinimumSize(new java.awt.Dimension(800, 600));
        jLabel8.setPreferredSize(new java.awt.Dimension(800, 600));
        jPanel1.add(jLabel8);
        jLabel8.setBounds(0, 0, 850, 570);

        getContentPane().add(jPanel1);
        jPanel1.setBounds(0, 0, 850, 570);

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        GrupNavigasyon navigasyon = new GrupNavigasyon();
        navigasyon.setVisible(true);
        this.setVisible(false);
        d.kapat();
    }//GEN-LAST:event_jButton1ActionPerformed

    private void btnKaydetActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnKaydetActionPerformed

        String grupNo = txtGrupNo.getText().trim();
        String grupAciklama = txtGrupAciklama.getText().trim();
        String grupDanisman = cbGrupDanismani.getSelectedItem().toString();
        String grupKontenjan = txtGrupKontenjan.getText().trim();

        if (txtDenetim() || dateDenetim() || sayiKontrol(grupKontenjan) ||grupKontrol()) {

        }
        else {

            Date baslangicTarih = new Date(jDateChooserBaslangic.getDate().getTime());
            Date bitisTarih = new Date(jDateChooserGrupBitis.getDate().getTime());

            try {
                int cevap = JOptionPane.showConfirmDialog(rootPane, "Kaydetmek İstediğinizden Emin Misiniz?", "Başlık", ConfirmationCallback.YES_NO_OPTION);
                if (cevap == 0) {
                    ResultSet rs = d.st.executeQuery("call grupEkle ('" + grupNo + "','" + grupAciklama + "','" + grupKontenjan + "','" + grupDanisman + "','" + baslangicTarih + "','" + bitisTarih + "')");
                    JOptionPane.showMessageDialog(rootPane, "Grup Başarıyla Kaydedildi");
                } else if (cevap == 1) {
                    txtGrupNo.requestFocus();
                }
            } catch (SQLException ex) {
                Logger.getLogger(YeniGrupOlustur.class.getName()).log(Level.SEVERE, null, ex);
            }

            txtGrupNo.setText("");
            txtGrupAciklama.setText("");
            cbGrupDanismani.setToolTipText("");
            txtGrupKontenjan.setText("");
            jDateChooserBaslangic.setDate(null);
            jDateChooserGrupBitis.setDate(null);
            comboGuncelle();

        }
    }//GEN-LAST:event_btnKaydetActionPerformed

    private void txtGrupNoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtGrupNoActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtGrupNoActionPerformed
    public boolean grupKontrol() {
      boolean durum = false;
        
        try {
             ResultSet rs = d.st.executeQuery("select *from grup");
        while(rs.next()){
                    dizi.add(rs.getString("grupNo"));
                }
        if(dizi.contains(txtGrupNo.getText())) {
            durum = true;
            JOptionPane.showMessageDialog(rootPane, "Eklemek İstediğiniz Grup Bulunmaktadır.");
        }
        } catch (SQLException | HeadlessException e) {
        }
       
      return durum;  
    }
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

     public void comboGuncelle() {
        cmb = new DefaultComboBoxModel<>();
        cmb.setSelectedItem("Grup Danışmanını Seçiniz");
        

        ResultSet rs;
        try {
            rs = d.st.executeQuery("select *from ogretmen");
            while (rs.next()) {
                String soyad = rs.getString("ogretmenSoyadi");
                cmb.addElement(rs.getString("ogretmenAdi")+" "+soyad);
                cbGrupDanismani.setModel(cmb);
           
            }
        } catch (SQLException ex) {
            Logger.getLogger(GrupGuncelle.class.getName()).log(Level.SEVERE, null, ex);
        }

    }
    
    public static void main(String args[]) {
       
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("windows".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(YeniGrupOlustur.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(YeniGrupOlustur.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(YeniGrupOlustur.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(YeniGrupOlustur.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
      

 
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new YeniGrupOlustur().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnKaydet;
    private javax.swing.JComboBox<String> cbGrupDanismani;
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
    private javax.swing.JPanel jPanel1;
    private javax.swing.JTextField txtGrupAciklama;
    private javax.swing.JTextField txtGrupKontenjan;
    private javax.swing.JTextField txtGrupNo;
    // End of variables declaration//GEN-END:variables
}
