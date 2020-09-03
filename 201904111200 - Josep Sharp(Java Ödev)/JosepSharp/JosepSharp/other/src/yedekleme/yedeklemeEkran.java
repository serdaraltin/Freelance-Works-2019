package yedekleme;

import AnaMenu.Menu;
import java.io.File;
import java.sql.SQLException;
import javax.swing.JFileChooser;
import yedekleme.yedekleme;

public class yedeklemeEkran extends javax.swing.JFrame {

    public yedeklemeEkran() {
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        txtYedekleme = new javax.swing.JTextField();
        tusKlasor = new javax.swing.JButton();
        tusYedekle = new javax.swing.JButton();
        lblBilgi = new javax.swing.JLabel();
        jButton1 = new javax.swing.JButton();
        jLabel13 = new javax.swing.JLabel();
        jLabel1 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("Yedekleme Paneli");
        setPreferredSize(new java.awt.Dimension(768, 440));
        setResizable(false);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        txtYedekleme.setEditable(false);
        jPanel1.add(txtYedekleme, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 80, 461, -1));

        tusKlasor.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        tusKlasor.setForeground(new java.awt.Color(0, 51, 102));
        tusKlasor.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/dosya ara.png"))); // NOI18N
        tusKlasor.setText("Klasör Ara");
        tusKlasor.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                tusKlasorActionPerformed(evt);
            }
        });
        jPanel1.add(tusKlasor, new org.netbeans.lib.awtextra.AbsoluteConstraints(490, 70, -1, 47));

        tusYedekle.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        tusYedekle.setForeground(new java.awt.Color(0, 51, 102));
        tusYedekle.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/yedekle.png"))); // NOI18N
        tusYedekle.setText("Yedekle");
        tusYedekle.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                tusYedekleActionPerformed(evt);
            }
        });
        jPanel1.add(tusYedekle, new org.netbeans.lib.awtextra.AbsoluteConstraints(490, 130, 130, 47));
        jPanel1.add(lblBilgi, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 210, 720, 197));

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
        jPanel1.add(jButton1, new org.netbeans.lib.awtextra.AbsoluteConstraints(660, 10, 100, -1));

        jLabel13.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel13.setForeground(new java.awt.Color(153, 0, 51));
        jLabel13.setText("Yedekleme Paneli");
        jPanel1.add(jLabel13, new org.netbeans.lib.awtextra.AbsoluteConstraints(200, 10, -1, -1));

        jLabel1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        jPanel1.add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 770, 440));

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 770, 440));

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void tusKlasorActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_tusKlasorActionPerformed

        JFileChooser dosya = new JFileChooser();
        String dosyabaslik = null;
        dosya.setCurrentDirectory(new java.io.File("."));
        dosya.setDialogTitle(dosyabaslik);
        dosya.setFileSelectionMode(JFileChooser.DIRECTORIES_ONLY);
        dosya.setCurrentDirectory(new File("C:\\Users\\java2\\Desktop"));
        dosya.setAcceptAllFileFilterUsed(false);

        if (dosya.showOpenDialog(this) == JFileChooser.APPROVE_OPTION) {
            System.out.println("Açılan Kaynak Dosya : "
                    + dosya.getCurrentDirectory());
            System.out.println("Seçilen Dosya : "
                    + dosya.getSelectedFile());
            String kaynak = dosya.getSelectedFile().toString();
            txtYedekleme.setText(kaynak);

        } else {
            System.out.println("Seçim Yapılmadı");
        }


    }//GEN-LAST:event_tusKlasorActionPerformed

    private void tusYedekleActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_tusYedekleActionPerformed

        new Thread(() -> {
            yedekleme ye = new yedekleme();
            String kaynak = txtYedekleme.getText().trim();
            if ("".equals(kaynak)) {
                lblBilgi.setText("Lütfen Hedef Klasörünü Seçiniz !");
            } else {
                try {
                    ye.backup(kaynak);
                    System.out.println("deneme");
                    txtYedekleme.setText("");
                    Menu menu = new Menu();
                    menu.setVisible(true);
                    this.setVisible(false);
                } catch (ClassNotFoundException | SQLException | InterruptedException ex) {
                    System.err.println("Hata : " + ex);
                }
            }
        }).start();


    }//GEN-LAST:event_tusYedekleActionPerformed


    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        Menu menu = new Menu();
        menu.setVisible(true);
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
            java.util.logging.Logger.getLogger(yedeklemeEkran.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(yedeklemeEkran.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(yedeklemeEkran.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(yedeklemeEkran.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new yedeklemeEkran().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JLabel lblBilgi;
    private javax.swing.JButton tusKlasor;
    private javax.swing.JButton tusYedekle;
    private javax.swing.JTextField txtYedekleme;
    // End of variables declaration//GEN-END:variables
}
