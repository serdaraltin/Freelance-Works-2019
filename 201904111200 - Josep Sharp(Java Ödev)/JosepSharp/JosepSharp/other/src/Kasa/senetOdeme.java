package Kasa;


import veritabani.DB;
import AnaMenu.Menu;
import AnaMenu.muhasebe2;
import com.lowagie.text.DocumentException;
import java.awt.event.KeyEvent;
import java.io.File;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import raporlama.senetRaporuPDF;

public class senetOdeme extends javax.swing.JFrame {

    DefaultTableModel tt = new DefaultTableModel();
    int sayi = 0;
    String odeme = "";

    public senetOdeme() {
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        txtOgrenci = new javax.swing.JTextField();
        jScrollPane1 = new javax.swing.JScrollPane();
        jTable1 = new javax.swing.JTable();
        btnOdeme = new javax.swing.JButton();
        jButton1 = new javax.swing.JButton();
        jLabel9 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("Senet Ödeme Giriş Paneli");
        setMaximumSize(new java.awt.Dimension(850, 568));
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
        jLabel1.setText("Öğrenci Numarası:");
        jPanel1.add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(60, 130, -1, -1));

        txtOgrenci.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                txtOgrenciKeyReleased(evt);
            }
        });
        jPanel1.add(txtOgrenci, new org.netbeans.lib.awtextra.AbsoluteConstraints(200, 130, 230, -1));

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
        jTable1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jTable1MouseClicked(evt);
            }
        });
        jScrollPane1.setViewportView(jTable1);

        jPanel1.add(jScrollPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(48, 200, 750, 220));

        btnOdeme.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnOdeme.setForeground(new java.awt.Color(0, 51, 102));
        btnOdeme.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/odeme.png"))); // NOI18N
        btnOdeme.setText("Ödeme Yap");
        btnOdeme.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnOdemeActionPerformed(evt);
            }
        });
        jPanel1.add(btnOdeme, new org.netbeans.lib.awtextra.AbsoluteConstraints(650, 440, -1, -1));

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
        jLabel9.setText("Senet Ödeme Giriş Paneli");
        jPanel1.add(jLabel9, new org.netbeans.lib.awtextra.AbsoluteConstraints(320, 50, -1, -1));

        jLabel2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        jPanel1.add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 850, 568));

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, -1, -1));

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void txtOgrenciKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtOgrenciKeyReleased
        if (evt.getKeyCode() != KeyEvent.VK_ENTER) {
            try {
                int i = (Integer.valueOf(txtOgrenci.getText()) / 1);
                i = 0;
                if (txtOgrenci.getText().trim().equals("")) {

                } else {
                    DB bd = new DB();
                    tt.setRowCount(0);
                    tt = bd.muhaSenetAra(Integer.valueOf(txtOgrenci.getText()));
                    jTable1.setModel(tt);
                    bd.kapat();
                }
            } catch (NumberFormatException e) {
                JOptionPane.showMessageDialog(this, "Lütfen sadece rakam giriniz.");
                txtOgrenci.setText("");
                System.err.println("Kasa Miktar Girişi Hatası: " + e);
            }
        }


    }//GEN-LAST:event_txtOgrenciKeyReleased

    private void btnOdemeActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnOdemeActionPerformed
        // Senet Ödeme İşlemi
        if (odeme.equals("Ödendi")) {
            JOptionPane.showMessageDialog(this, "Seçimini yaptığınız senet ödenmiştir.");
            jTable1.clearSelection();
            odeme = "";
        } else if (sayi == 0) {
            JOptionPane.showMessageDialog(this, "Lütfen seçim yapın.");
        } else {
            //ödeme yap
            DB bd = new DB();
            bd.genel("call proSenetOde('" + Integer.valueOf(txtOgrenci.getText().trim()) + "','" + sayi + "')");
            tt.setRowCount(0);
            tt = bd.muhaSenetAra(Integer.valueOf(txtOgrenci.getText()));
            jTable1.setModel(tt);
            bd.kapat();
            senetPDF(Integer.valueOf(txtOgrenci.getText()));
            jTable1.clearSelection();
            sayi = 0;
        }
    }//GEN-LAST:event_btnOdemeActionPerformed
public void senetPDF(int senet_ogrenci_id){
 senetRaporuPDF senetrapor= new senetRaporuPDF();
        try {
            senetrapor.senetRaporu(senet_ogrenci_id);
        } catch (DocumentException ex) {
            Logger.getLogger(senetOdeme.class.getName()).log(Level.SEVERE, null, ex);
        } catch (IOException ex) {
            Logger.getLogger(senetOdeme.class.getName()).log(Level.SEVERE, null, ex);
        }
        try {

            if ((new File(senetRaporuPDF.dosyaAdi)).exists()) {

                Process p = Runtime.getRuntime().exec("rundll32 url.dll,FileProtocolHandler " +senetRaporuPDF.dosyaAdi);

                p.waitFor();

            } else {

                System.out.println("File is not exists");

            }

            System.out.println("Done");

        } catch (Exception ex) {

            ex.printStackTrace();

        }
}
    private void jTable1MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jTable1MouseClicked
        int satir = jTable1.getSelectedRow();
        String taksit = jTable1.getValueAt(satir, 1).toString();
        odeme = jTable1.getValueAt(satir, 5).toString();
        String[] splitDizi = taksit.split("/");
        sayi = Integer.valueOf(splitDizi[0]);
    }//GEN-LAST:event_jTable1MouseClicked

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
     muhasebe2 m=new muhasebe2();
       m.setVisible(true);
       this.setVisible(false);
        
    }//GEN-LAST:event_jButton1ActionPerformed

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
            java.util.logging.Logger.getLogger(senetOdeme.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(senetOdeme.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(senetOdeme.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(senetOdeme.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new senetOdeme().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnOdeme;
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable jTable1;
    private javax.swing.JTextField txtOgrenci;
    // End of variables declaration//GEN-END:variables
}
