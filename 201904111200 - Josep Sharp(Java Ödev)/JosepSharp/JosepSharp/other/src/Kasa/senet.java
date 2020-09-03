package Kasa;


import veritabani.DB;
import AnaMenu.Menu;
import AnaMenu.muhasebe2;
import java.awt.event.KeyEvent;
import java.text.SimpleDateFormat;
import java.util.Date;
import javax.swing.JOptionPane;

public class senet extends javax.swing.JFrame {


    public senet() {
        initComponents();
        jDateChooser1.setDate(new Date());
        
    }
    
    public senet(int id,int miktar){
        initComponents();
        jDateChooser1.setDate(new Date());
        txtOgrenci.setText(String.valueOf(id));
        txtTotal.setText(String.valueOf(miktar));
        taksitHesapla();
        txtOgrenci.setEditable(false);
        txtOgrenci.setEnabled(false);
        
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        txtOgrenci = new javax.swing.JTextField();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        cmBoxTaksit = new javax.swing.JComboBox<>();
        jLabel3 = new javax.swing.JLabel();
        txtTotal = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        txtTutar = new javax.swing.JTextField();
        jLabel6 = new javax.swing.JLabel();
        jDateChooser1 = new com.toedter.calendar.JDateChooser();
        jLabel7 = new javax.swing.JLabel();
        btnSenet = new javax.swing.JButton();
        jButton1 = new javax.swing.JButton();
        jLabel9 = new javax.swing.JLabel();
        jLabel8 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("Senet İşlemleri Paneli");
        setMaximumSize(new java.awt.Dimension(850, 568));
        setMinimumSize(new java.awt.Dimension(850, 568));
        setResizable(false);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jPanel1.setBorder(javax.swing.BorderFactory.createTitledBorder(""));
        jPanel1.setMaximumSize(new java.awt.Dimension(850, 568));
        jPanel1.setMinimumSize(new java.awt.Dimension(850, 568));
        jPanel1.setPreferredSize(new java.awt.Dimension(850, 568));
        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        txtOgrenci.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                txtOgrenciKeyReleased(evt);
            }
        });
        jPanel1.add(txtOgrenci, new org.netbeans.lib.awtextra.AbsoluteConstraints(360, 130, 230, -1));

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 51, 102));
        jLabel1.setText("Öğrenci Numarası:");
        jPanel1.add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 130, -1, -1));

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(0, 51, 102));
        jLabel2.setText("Taksit Sayısı:");
        jPanel1.add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(250, 180, -1, -1));

        cmBoxTaksit.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" }));
        cmBoxTaksit.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                cmBoxTaksitİtemStateChanged(evt);
            }
        });
        jPanel1.add(cmBoxTaksit, new org.netbeans.lib.awtextra.AbsoluteConstraints(360, 180, 230, -1));

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(0, 51, 102));
        jLabel3.setText("Toplam Ödeme Miktarı:");
        jPanel1.add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(180, 230, -1, -1));

        txtTotal.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
        txtTotal.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                txtTotalKeyReleased(evt);
            }
        });
        jPanel1.add(txtTotal, new org.netbeans.lib.awtextra.AbsoluteConstraints(360, 230, 230, -1));

        jLabel4.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(0, 51, 102));
        jLabel4.setText("TL");
        jPanel1.add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(600, 235, 17, -1));

        jLabel5.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(0, 51, 102));
        jLabel5.setText("Taksit Tutarı:");
        jPanel1.add(jLabel5, new org.netbeans.lib.awtextra.AbsoluteConstraints(250, 280, -1, -1));

        txtTutar.setEditable(false);
        txtTutar.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
        jPanel1.add(txtTutar, new org.netbeans.lib.awtextra.AbsoluteConstraints(360, 280, 230, -1));

        jLabel6.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel6.setForeground(new java.awt.Color(0, 51, 102));
        jLabel6.setText("TL");
        jPanel1.add(jLabel6, new org.netbeans.lib.awtextra.AbsoluteConstraints(600, 280, 17, -1));

        jDateChooser1.setDateFormatString("dd.MM.yyyy");
        jPanel1.add(jDateChooser1, new org.netbeans.lib.awtextra.AbsoluteConstraints(360, 330, 230, -1));

        jLabel7.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel7.setForeground(new java.awt.Color(0, 51, 102));
        jLabel7.setText("Vade Tarihi:");
        jPanel1.add(jLabel7, new org.netbeans.lib.awtextra.AbsoluteConstraints(260, 330, -1, -1));

        btnSenet.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnSenet.setForeground(new java.awt.Color(0, 51, 102));
        btnSenet.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/senet.png"))); // NOI18N
        btnSenet.setText("Senet Oluştur");
        btnSenet.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnSenetActionPerformed(evt);
            }
        });
        jPanel1.add(btnSenet, new org.netbeans.lib.awtextra.AbsoluteConstraints(400, 380, -1, -1));

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
        jLabel9.setText("Senet İşlemleri Paneli");
        jPanel1.add(jLabel9, new org.netbeans.lib.awtextra.AbsoluteConstraints(360, 50, -1, -1));

        jLabel8.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        jLabel8.setMaximumSize(new java.awt.Dimension(850, 568));
        jLabel8.setMinimumSize(new java.awt.Dimension(850, 568));
        jPanel1.add(jLabel8, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 850, 568));

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 850, 568));

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void txtTotalKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtTotalKeyReleased
        if(evt.getKeyCode()!=KeyEvent.VK_ENTER){
            taksitHesapla();
        }else{
            txtTotal.requestFocus();
        }
    }//GEN-LAST:event_txtTotalKeyReleased

    private void btnSenetActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnSenetActionPerformed
        
        if(txtOgrenci.getText().equals("")||txtTotal.getText().equals("")){
            JOptionPane.showMessageDialog(this, "Lütfen boş alan bırakmayınız");            
        }else{
            SimpleDateFormat dt = new SimpleDateFormat("yyyy-MM-dd");
            String tarih = dt.format(jDateChooser1.getDate());
            DB bd = new DB();
            bd.genel("call proSenet('"+Integer.valueOf(txtOgrenci.getText().trim())+"','"+cmBoxTaksit.getSelectedItem().toString()+"','"+Integer.valueOf(txtTotal.getText().trim())+"','"+Integer.valueOf(txtTutar.getText().trim())+"','"+tarih+"')");
            bd.kapat();
            kasaKayit.pdfIslem();
            this.dispose();
        }
        
    }//GEN-LAST:event_btnSenetActionPerformed

    private void txtOgrenciKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtOgrenciKeyReleased
        
        if(evt.getKeyCode()!=KeyEvent.VK_ENTER){
        try {
            int i = Integer.valueOf(txtOgrenci.getText());
            i=0;
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(this, "Lütfen sadece rakam giriniz");
            txtOgrenci.setText("");
            System.err.println("Rakam Girişi Hatası: "+e);
        }
        }
    }//GEN-LAST:event_txtOgrenciKeyReleased

    private void cmBoxTaksitİtemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_cmBoxTaksitİtemStateChanged
        
        if(!txtTotal.getText().trim().isEmpty()){
            taksitHesapla();
        }
        
    }//GEN-LAST:event_cmBoxTaksitİtemStateChanged

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
   muhasebe2 m=new muhasebe2();
       m.setVisible(true);
       this.setVisible(false);
        
        
    }//GEN-LAST:event_jButton1ActionPerformed

    public void taksitHesapla(){
        try {
            txtTutar.setText(String.valueOf(Integer.valueOf(txtTotal.getText())/Integer.valueOf(cmBoxTaksit.getSelectedItem().toString())));
    
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(this, "Lütfen sadece rakam giriniz");
            txtTotal.setText("");
            txtTutar.setText("");
            System.err.println("Senet Rakam Girişi Hatası: "+e);
        }
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
            java.util.logging.Logger.getLogger(senet.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(senet.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(senet.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(senet.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new senet().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnSenet;
    private javax.swing.JComboBox<String> cmBoxTaksit;
    private javax.swing.JButton jButton1;
    private com.toedter.calendar.JDateChooser jDateChooser1;
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
    private javax.swing.JTextField txtOgrenci;
    private javax.swing.JTextField txtTotal;
    private javax.swing.JTextField txtTutar;
    // End of variables declaration//GEN-END:variables
}
