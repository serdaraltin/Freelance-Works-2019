package personel;

import AnaMenu.Menu;
import java.awt.Component;
import java.awt.HeadlessException;
import java.sql.Date;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.table.DefaultTableModel;
import kullanici.kontrol;
import veritabani.DB;

/**
 *
 * @author Tacettin
 */
public class personelKayit extends javax.swing.JFrame {
    String tc = "";
    String adi = "";
    String soyadi = "";
    String mail = "";
    String adres = "";
    String evTel = "";
    String cepTel = "";
    String maas = "";
    String gorev = "";
    String aciklama = "";
    String sskNo = "";
    int id = 0;
    
    DefaultTableModel dt = new DefaultTableModel();
    DB db = new DB();
    kontrol kontrol=new kontrol();
    public personelKayit() {
        initComponents();
        
       
        
        dt.addColumn("Personel ID");
        dt.addColumn("TC No");
        dt.addColumn("Adı");
        dt.addColumn("Soyadı");
        dt.addColumn("eMail");
        dt.addColumn("Adres");
        dt.addColumn("Ev Telefon");
        dt.addColumn("Cep Telefon");
        dt.addColumn("İşe Giriş");
        dt.addColumn("İşten Çıkış");
        dt.addColumn("Maaş");
        dt.addColumn("Görev");
        dt.addColumn("Açıklama");
        dt.addColumn("SSK No");
        
        jTable1.setModel(dt);
        dataGetir();
    }
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {
        bindingGroup = new org.jdesktop.beansbinding.BindingGroup();

        jPanel1 = new javax.swing.JPanel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        txtAdres = new javax.swing.JTextField();
        jLabel5 = new javax.swing.JLabel();
        txtEvTel = new javax.swing.JTextField();
        jLabel6 = new javax.swing.JLabel();
        txtCepTel = new javax.swing.JTextField();
        jLabel7 = new javax.swing.JLabel();
        jLabel8 = new javax.swing.JLabel();
        txtMaas = new javax.swing.JTextField();
        jLabel9 = new javax.swing.JLabel();
        jLabel10 = new javax.swing.JLabel();
        jLabel11 = new javax.swing.JLabel();
        txtAciklama = new javax.swing.JTextField();
        txtSskNo = new javax.swing.JTextField();
        jLabel12 = new javax.swing.JLabel();
        txtSoyadi = new javax.swing.JTextField();
        txtAdi = new javax.swing.JTextField();
        jLabel13 = new javax.swing.JLabel();
        txtMail = new javax.swing.JTextField();
        txtCikis = new com.toedter.calendar.JDateChooser();
        txtGiris = new com.toedter.calendar.JDateChooser();
        cmbGorev = new javax.swing.JComboBox<>();
        txtTCNo = new javax.swing.JTextField();
        jLabel14 = new javax.swing.JLabel();
        btnKayit = new javax.swing.JButton();
        btnGuncelle = new javax.swing.JButton();
        btnSil = new javax.swing.JButton();
        jLabel16 = new javax.swing.JLabel();
        jScrollPane1 = new javax.swing.JScrollPane();
        jTable1 = new javax.swing.JTable();
        jButton1 = new javax.swing.JButton();
        jLabel15 = new javax.swing.JLabel();
        jLabel1 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Personel İşlemleri Paneli");
        setResizable(false);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(0, 51, 102));
        jLabel2.setText("Adı :");
        jPanel1.add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(102, 42, -1, -1));

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(0, 51, 102));
        jLabel3.setText("Soyadı :");
        jPanel1.add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(78, 73, -1, -1));

        jLabel4.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(0, 51, 102));
        jLabel4.setText("Adres :");
        jPanel1.add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(84, 135, -1, -1));
        jPanel1.add(txtAdres, new org.netbeans.lib.awtextra.AbsoluteConstraints(151, 135, 250, -1));

        jLabel5.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(0, 51, 102));
        jLabel5.setText("Ev Telefonu :");
        jPanel1.add(jLabel5, new org.netbeans.lib.awtextra.AbsoluteConstraints(43, 166, -1, -1));

        txtEvTel.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtEvTelKeyTyped(evt);
            }
        });
        jPanel1.add(txtEvTel, new org.netbeans.lib.awtextra.AbsoluteConstraints(151, 166, 250, -1));

        jLabel6.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel6.setForeground(new java.awt.Color(0, 51, 102));
        jLabel6.setText("Cep Telefonu :");
        jPanel1.add(jLabel6, new org.netbeans.lib.awtextra.AbsoluteConstraints(33, 197, -1, -1));

        txtCepTel.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtCepTelKeyTyped(evt);
            }
        });
        jPanel1.add(txtCepTel, new org.netbeans.lib.awtextra.AbsoluteConstraints(151, 197, 250, -1));

        jLabel7.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel7.setForeground(new java.awt.Color(0, 51, 102));
        jLabel7.setText("İşe Giriş Tarihi :");
        jPanel1.add(jLabel7, new org.netbeans.lib.awtextra.AbsoluteConstraints(27, 231, -1, -1));

        jLabel8.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel8.setForeground(new java.awt.Color(0, 51, 102));
        jLabel8.setText("Maaş :");
        jPanel1.add(jLabel8, new org.netbeans.lib.awtextra.AbsoluteConstraints(89, 290, -1, -1));
        jPanel1.add(txtMaas, new org.netbeans.lib.awtextra.AbsoluteConstraints(151, 290, 250, -1));

        jLabel9.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel9.setForeground(new java.awt.Color(0, 51, 102));
        jLabel9.setText("SSK No :");
        jPanel1.add(jLabel9, new org.netbeans.lib.awtextra.AbsoluteConstraints(72, 383, -1, -1));

        jLabel10.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel10.setForeground(new java.awt.Color(0, 51, 102));
        jLabel10.setText("Açıklama :");
        jPanel1.add(jLabel10, new org.netbeans.lib.awtextra.AbsoluteConstraints(64, 352, -1, -1));

        jLabel11.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel11.setForeground(new java.awt.Color(0, 51, 102));
        jLabel11.setText("Görev :");
        jPanel1.add(jLabel11, new org.netbeans.lib.awtextra.AbsoluteConstraints(83, 321, -1, -1));
        jPanel1.add(txtAciklama, new org.netbeans.lib.awtextra.AbsoluteConstraints(151, 352, 257, -1));
        jPanel1.add(txtSskNo, new org.netbeans.lib.awtextra.AbsoluteConstraints(151, 383, 257, -1));

        jLabel12.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel12.setForeground(new java.awt.Color(0, 51, 102));
        jLabel12.setText("İşten Çıkış Tarihi :");
        jPanel1.add(jLabel12, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 262, -1, -1));
        jPanel1.add(txtSoyadi, new org.netbeans.lib.awtextra.AbsoluteConstraints(151, 73, 250, -1));
        jPanel1.add(txtAdi, new org.netbeans.lib.awtextra.AbsoluteConstraints(151, 42, 250, -1));

        jLabel13.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel13.setForeground(new java.awt.Color(0, 51, 102));
        jLabel13.setText("Mail :");
        jPanel1.add(jLabel13, new org.netbeans.lib.awtextra.AbsoluteConstraints(98, 104, -1, -1));
        jPanel1.add(txtMail, new org.netbeans.lib.awtextra.AbsoluteConstraints(151, 104, 250, -1));

        txtCikis.setDateFormatString("dd.MM.yyyy");
        jPanel1.add(txtCikis, new org.netbeans.lib.awtextra.AbsoluteConstraints(151, 259, 250, -1));

        txtGiris.setDateFormatString("dd.MM.yyyy");
        jPanel1.add(txtGiris, new org.netbeans.lib.awtextra.AbsoluteConstraints(151, 228, 250, -1));

        cmbGorev.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Müdür", "Müdür Yardımcısı", "Öğretmen", "Sekreter", "Güvenlik", "Müstahdem", "Diğer" }));
        jPanel1.add(cmbGorev, new org.netbeans.lib.awtextra.AbsoluteConstraints(151, 321, 250, -1));

        txtTCNo.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtTCNoKeyTyped(evt);
            }
        });
        jPanel1.add(txtTCNo, new org.netbeans.lib.awtextra.AbsoluteConstraints(151, 11, 250, -1));

        jLabel14.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel14.setForeground(new java.awt.Color(0, 51, 102));
        jLabel14.setText("TC No :");
        jPanel1.add(jLabel14, new org.netbeans.lib.awtextra.AbsoluteConstraints(81, 11, -1, -1));

        btnKayit.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnKayit.setForeground(new java.awt.Color(0, 51, 102));
        btnKayit.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/add.png"))); // NOI18N
        btnKayit.setText("Yeni Kayıt");

        org.jdesktop.beansbinding.Binding binding = org.jdesktop.beansbinding.Bindings.createAutoBinding(org.jdesktop.beansbinding.AutoBinding.UpdateStrategy.READ_WRITE, btnKayit, org.jdesktop.beansbinding.ObjectProperty.create(), btnKayit, org.jdesktop.beansbinding.BeanProperty.create("border"));
        bindingGroup.addBinding(binding);

        btnKayit.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnKayitActionPerformed(evt);
            }
        });
        jPanel1.add(btnKayit, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 420, 140, -1));

        btnGuncelle.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnGuncelle.setForeground(new java.awt.Color(0, 51, 102));
        btnGuncelle.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/guncelle.png"))); // NOI18N
        btnGuncelle.setText("Güncelle");
        jPanel1.add(btnGuncelle, new org.netbeans.lib.awtextra.AbsoluteConstraints(165, 420, 120, 40));

        btnSil.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnSil.setForeground(new java.awt.Color(0, 51, 102));
        btnSil.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/sil.png"))); // NOI18N
        btnSil.setText("Sil");
        jPanel1.add(btnSil, new org.netbeans.lib.awtextra.AbsoluteConstraints(300, 420, 110, 40));

        jLabel16.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        jPanel1.add(jLabel16, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 420, 470));

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 60, 420, 470));

        jTable1.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        jTable1.setAutoResizeMode(javax.swing.JTable.AUTO_RESIZE_OFF);
        jTable1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jTable1MouseClicked(evt);
            }
        });
        jScrollPane1.setViewportView(jTable1);

        getContentPane().add(jScrollPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(440, 60, 419, 460));

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
        getContentPane().add(jButton1, new org.netbeans.lib.awtextra.AbsoluteConstraints(760, 10, 100, -1));

        jLabel15.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel15.setForeground(new java.awt.Color(153, 0, 51));
        jLabel15.setText("Personel İşlemleri Paneli");
        getContentPane().add(jLabel15, new org.netbeans.lib.awtextra.AbsoluteConstraints(320, 20, -1, -1));

        jLabel1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        jLabel1.setPreferredSize(new java.awt.Dimension(875, 583));
        getContentPane().add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 870, 560));

        bindingGroup.bind();

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents


   int secim = -1;
    private void jTable1MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jTable1MouseClicked
        db.baglan();
        secim = Integer.valueOf(jTable1.getValueAt(jTable1.getSelectedRow(), 0).toString());
        id = secim;
        txtTCNo.setText(jTable1.getValueAt(jTable1.getSelectedRow(), 1).toString());
        txtAdi.setText(jTable1.getValueAt(jTable1.getSelectedRow(), 2).toString());
        txtSoyadi.setText(jTable1.getValueAt(jTable1.getSelectedRow(), 3).toString());
        txtMail.setText(jTable1.getValueAt(jTable1.getSelectedRow(), 4).toString());
        txtAdres.setText(jTable1.getValueAt(jTable1.getSelectedRow(), 5).toString());
        txtEvTel.setText(jTable1.getValueAt(jTable1.getSelectedRow(), 6).toString());
        txtCepTel.setText(jTable1.getValueAt(jTable1.getSelectedRow(), 7).toString());
        txtGiris.setDate(Date.valueOf(jTable1.getValueAt(jTable1.getSelectedRow(), 8).toString()));
        txtCikis.setDate(Date.valueOf(jTable1.getValueAt(jTable1.getSelectedRow(), 9).toString()));
        txtMaas.setText(jTable1.getValueAt(jTable1.getSelectedRow(), 10).toString());
        cmbGorev.setSelectedItem(jTable1.getValueAt(jTable1.getSelectedRow(), 11).toString());
        txtAciklama.setText(jTable1.getValueAt(jTable1.getSelectedRow(), 12).toString());
        txtSskNo.setText(jTable1.getValueAt(jTable1.getSelectedRow(), 13).toString());
////prosedur           
////                                            "call personelSec('" + secim + "')"
////sorgu
////                                            "select *from personel where personelID = '" + secim + "'"

    }//GEN-LAST:event_jTable1MouseClicked

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
//       buraya hangi sayfaya gidilecekse setVisible'si yazılacak!!
        AnaMenu.Menu anMenu = new Menu();
        anMenu.setVisible(true);
        this.setVisible(false);
        db.kapat();
    }//GEN-LAST:event_jButton1ActionPerformed

    private void txtTCNoKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtTCNoKeyTyped
        if (txtTCNo.getText().length()>=11) {
            getToolkit().beep();
            evt.consume();
        }
    }//GEN-LAST:event_txtTCNoKeyTyped

    private void txtEvTelKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtEvTelKeyTyped
        if (txtEvTel.getText().length()>=11) {
            getToolkit().beep();
            evt.consume();
        }
    }//GEN-LAST:event_txtEvTelKeyTyped

    private void txtCepTelKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtCepTelKeyTyped
       if (txtCepTel.getText().length()>=11) {
            getToolkit().beep();
            evt.consume();
        }
    }//GEN-LAST:event_txtCepTelKeyTyped

    private void btnKayitActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnKayitActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_btnKayitActionPerformed
//+

    public void dataGetir() {
        dt.setRowCount(0);
        db.baglan();
        
        try {
            ResultSet rs = db.st.executeQuery("call personelGetir");
//sorgu
//                                             "select *from personel"  
            while (rs.next()) {
                dt.addRow(new String[]{rs.getString("personelID"),rs.getString("personelTC"),
                    rs.getString("personelAdi"), rs.getString("personelSoyadi"),
                    rs.getString("personelMail"), rs.getString("personelAdres"),
                    rs.getString("personelEvTel"), rs.getString("personelCepTel"),
                    rs.getString("personelGirisTarih"), rs.getString("personelCikisTarih"),
                    rs.getString("personelMaas"), rs.getString("personelGorev"),
                    rs.getString("personelAciklama"), rs.getString("personelSskNo")});
            }
        } catch (Exception e) {
            System.err.println("Data Getirme Hatası :" + e);
        }
        try {
            int sonuc2 = db.st.executeUpdate("call ogretmenEkle");
            
        } catch (Exception e) {
            System.err.println("Öğretmen Ekleme Hatası : " + e);
        }
        jTable1.setModel(dt);
    }
    
    public void temizle() {
        txtTCNo.setText("");
        txtAdi.setText("");
        txtSoyadi.setText("");
        txtMail.setText("");
        txtAdres.setText("");
        txtEvTel.setText("");
        txtCepTel.setText("");
        txtGiris.setDate(null);
        txtCikis.setDate(null);
        txtMaas.setText("");
        cmbGorev.setSelectedItem(null);
        txtAciklama.setText("");
        txtSskNo.setText("");
    }
    public boolean  tcDenetim (){
         boolean durum = false;
        ResultSet rs = db.dataGetir("personel where personelTC = '" + txtTCNo.getText() + "' ");        
        try {
            if (rs.next()) {
                JOptionPane.showMessageDialog(rootPane, "Aynı TC Kimlik Numarası Mevcut!");
                txtTCNo.requestFocus();
                durum = true;
               
            }
        } catch (SQLException ex) {
            System.err.println("Personel TC Kontrol Hatası : " + ex);
        }
        return durum;
    }
    public boolean denetim() {
        boolean durum = false;
//bos bilgi girilemez kontrolu
        Component[] compDizi = jPanel1.getComponents();
        for (Object component : compDizi) {
            if (component instanceof JTextField) {
                JTextField tf = (JTextField) component;
                if (tf.getText().equals("") ) {
                    JOptionPane.showMessageDialog(rootPane, "Lütfen Boş Yerleri Doldurunuz!");
                    tf.requestFocus();
                    durum = true;
                    break;
                }
            }
        }
        
         
        
//evTel numarası dogru formatta mı kontrolu(sayı mı?)       
        for (int i = 0; i < txtEvTel.getText().length(); i++) {
            if (!Character.isDigit(txtEvTel.getText().charAt(i))) {
                JOptionPane.showMessageDialog(rootPane, "Lütfen Doğru Bir Ev Telefon Numarası Giriniz?");
                txtEvTel.requestFocus();
                durum = true;
                break;
            }
        }
//cepTel numarası dogru formatta mı kontrolu(sayı mı?)
        for (int i = 0; i < txtCepTel.getText().length(); i++) {
            if (!Character.isDigit(txtCepTel.getText().charAt(i))) {
                JOptionPane.showMessageDialog(rootPane, "Lütfen Doğru Bir Cep Telefon Numarası Giriniz?");
                txtCepTel.requestFocus();
                durum = true;
                break;
            }
        }
//sskNo numarası dogru formatta mı kontrolu(sayı mı?)        
        for (int i = 0; i < txtSskNo.getText().length(); i++) {
            if (!Character.isDigit(txtSskNo.getText().charAt(i))) {
                JOptionPane.showMessageDialog(rootPane, "Lütfen Doğru SSK Numarası Giriniz?");
                txtSskNo.requestFocus();
                durum = true;
                break;
            }
        }
//mail dogru formatta mı kontrolu.
        String emailPattern = "^[\\w!#$%&’*+/=?`{|}~^-]+(?:\\.[\\w!#$%&’*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$";
        Pattern p = Pattern.compile(emailPattern);
        Matcher m = p.matcher(txtMail.getText().trim());
        if (!(m.matches())) {
            JOptionPane.showMessageDialog(rootPane, "Lütfen Doğru Mail Giriniz?");
            txtMail.requestFocus();
            durum = true;
        }
        return durum;
    }
    
    

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
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
        } catch (ClassNotFoundException | InstantiationException | IllegalAccessException | javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(personelKayit.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new personelKayit().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnGuncelle;
    private javax.swing.JButton btnKayit;
    private javax.swing.JButton btnSil;
    private javax.swing.JComboBox<String> cmbGorev;
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel11;
    private javax.swing.JLabel jLabel12;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JLabel jLabel14;
    private javax.swing.JLabel jLabel15;
    private javax.swing.JLabel jLabel16;
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
    private javax.swing.JTable jTable1;
    private javax.swing.JTextField txtAciklama;
    private javax.swing.JTextField txtAdi;
    private javax.swing.JTextField txtAdres;
    private javax.swing.JTextField txtCepTel;
    private com.toedter.calendar.JDateChooser txtCikis;
    private javax.swing.JTextField txtEvTel;
    private com.toedter.calendar.JDateChooser txtGiris;
    private javax.swing.JTextField txtMaas;
    private javax.swing.JTextField txtMail;
    private javax.swing.JTextField txtSoyadi;
    private javax.swing.JTextField txtSskNo;
    private javax.swing.JTextField txtTCNo;
    private org.jdesktop.beansbinding.BindingGroup bindingGroup;
    // End of variables declaration//GEN-END:variables
}
