package kullanici;

import AnaMenu.Menu;
import java.awt.event.KeyEvent;
import java.sql.ResultSet;
import javax.swing.JOptionPane;
import veritabani.DB;

public class girisPaneli extends javax.swing.JFrame {

    kontrol kontrol = new kontrol();

    public girisPaneli() {
        initComponents();
        txt_kullaniciAdi.requestFocus();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        txt_kullaniciAdi = new javax.swing.JTextField();
        jButton_giris = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jPasswordField1 = new javax.swing.JPasswordField();
        jLabel3 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Kullanıcı Giriş Paneli");
        setMaximumSize(new java.awt.Dimension(444, 410));
        setMinimumSize(new java.awt.Dimension(444, 410));
        setPreferredSize(new java.awt.Dimension(729, 596));
        setResizable(false);
        getContentPane().setLayout(null);

        txt_kullaniciAdi.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                txt_kullaniciAdiKeyPressed(evt);
            }
        });
        getContentPane().add(txt_kullaniciAdi);
        txt_kullaniciAdi.setBounds(300, 120, 240, 20);

        jButton_giris.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jButton_giris.setForeground(new java.awt.Color(0, 51, 102));
        jButton_giris.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/giriş yap.png"))); // NOI18N
        jButton_giris.setText("Giriş Yap");
        jButton_giris.setOpaque(false);
        jButton_giris.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton_girisActionPerformed(evt);
            }
        });
        getContentPane().add(jButton_giris);
        jButton_giris.setBounds(410, 210, 130, 41);

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 51, 102));
        jLabel1.setText("Kullanıcı Adı :");
        getContentPane().add(jLabel1);
        jLabel1.setBounds(184, 120, 90, 17);

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(0, 51, 102));
        jLabel2.setText("Şifre :");
        getContentPane().add(jLabel2);
        jLabel2.setBounds(230, 160, 50, 17);

        jPasswordField1.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                jPasswordField1KeyPressed(evt);
            }
        });
        getContentPane().add(jPasswordField1);
        jPasswordField1.setBounds(300, 160, 240, 20);

        jLabel3.setIcon(new javax.swing.ImageIcon(getClass().getResource("/kullanici/17949-NRYKWW.jpg"))); // NOI18N
        jLabel3.setPreferredSize(new java.awt.Dimension(729, 596));
        getContentPane().add(jLabel3);
        jLabel3.setBounds(0, 0, 730, 600);

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void jButton_girisActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton_girisActionPerformed
        String isim = txt_kullaniciAdi.getText().trim();
        String sifre = (String.copyValueOf(jPasswordField1.getPassword()));
        String kullanici_id = "";
        String kullanici_yetki = "";
        if (!isim.isEmpty() && !sifre.isEmpty()) {

            DB db = new DB();
            db.baglan();
            
            try {

                String sqlSorgu = "kullanicilar where kullanici_isim='" + isim + "'and kullanici_sifre='" + sifre + "'";
                ResultSet rs = db.dataGetir(sqlSorgu);
                if (rs.next()) {
                    kullanici_id = rs.getString("kullanici_id");
                    kullanici_yetki = rs.getString("kullanici_yetki");
                    kontrol.setKul_yet(kullanici_yetki);
                    db.genelQuery("insert into giris_islemi values('" + kullanici_id + "',now())");
                    AnaMenu.Menu anamenu = new Menu();
                   anamenu.setVisible(true);
                    this.setVisible(false);
                }
               
                if (kullanici_id.isEmpty()) {
                    JOptionPane.showMessageDialog(rootPane, "Kullanıcı adı veya şifre hatalı!");
                }
            } catch (Exception e) {

                System.out.println("Giriş işlemi hatası:" + e);
            } finally {
                db.kapat();
            }
        } else {
            JOptionPane.showMessageDialog(rootPane, "alanlar boş!");
        }
    }//GEN-LAST:event_jButton_girisActionPerformed

    private void txt_kullaniciAdiKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_kullaniciAdiKeyPressed
        if (evt.getKeyCode() == KeyEvent.VK_ENTER) {
            jPasswordField1.requestFocus();
        }
    }//GEN-LAST:event_txt_kullaniciAdiKeyPressed

    private void jPasswordField1KeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_jPasswordField1KeyPressed
        if (evt.getKeyCode() == KeyEvent.VK_ENTER) {
            jButton_girisActionPerformed(null);
        }
    }//GEN-LAST:event_jPasswordField1KeyPressed

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
                if ("Windows".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(girisPaneli.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(girisPaneli.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(girisPaneli.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(girisPaneli.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(() -> {
            new girisPaneli().setVisible(true);
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton_giris;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JPasswordField jPasswordField1;
    private javax.swing.JTextField txt_kullaniciAdi;
    // End of variables declaration//GEN-END:variables
}
