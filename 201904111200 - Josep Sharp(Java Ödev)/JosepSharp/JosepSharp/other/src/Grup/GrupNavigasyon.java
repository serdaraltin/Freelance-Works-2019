package Grup;

import AnaMenu.Menu;
import javax.swing.JOptionPane;
import kullanici.kontrol;

public class GrupNavigasyon extends javax.swing.JFrame {

    kontrol kontrol = new kontrol();

    public GrupNavigasyon() {
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        btnYeniGrup = new javax.swing.JButton();
        btnGrupGuncelle = new javax.swing.JButton();
        btnGrupListele = new javax.swing.JButton();
        jButton8 = new javax.swing.JButton();
        jLabel2 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setPreferredSize(new java.awt.Dimension(600, 350));
        setResizable(false);
        getContentPane().setLayout(null);

        btnYeniGrup.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnYeniGrup.setForeground(new java.awt.Color(0, 51, 102));
        btnYeniGrup.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/grup ekle.png"))); // NOI18N
        btnYeniGrup.setText("Yeni Grup Oluştur");
        btnYeniGrup.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnYeniGrupActionPerformed(evt);
            }
        });
        getContentPane().add(btnYeniGrup);
        btnYeniGrup.setBounds(60, 80, 230, 80);

        btnGrupGuncelle.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnGrupGuncelle.setForeground(new java.awt.Color(0, 51, 102));
        btnGrupGuncelle.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/grup güncelle.png"))); // NOI18N
        btnGrupGuncelle.setText("Grup Güncelle");
        btnGrupGuncelle.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnGrupGuncelleActionPerformed(evt);
            }
        });
        getContentPane().add(btnGrupGuncelle);
        btnGrupGuncelle.setBounds(320, 80, 230, 80);

        btnGrupListele.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnGrupListele.setForeground(new java.awt.Color(0, 51, 102));
        btnGrupListele.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/grup oluştur.png"))); // NOI18N
        btnGrupListele.setText("Grup Listele");
        btnGrupListele.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnGrupListeleActionPerformed(evt);
            }
        });
        getContentPane().add(btnGrupListele);
        btnGrupListele.setBounds(180, 190, 230, 80);

        jButton8.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton8.setForeground(new java.awt.Color(0, 51, 102));
        jButton8.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1466161311_agt_back.png"))); // NOI18N
        jButton8.setText("Geri");
        jButton8.setBorder(null);
        jButton8.setBorderPainted(false);
        jButton8.setContentAreaFilled(false);
        jButton8.setFocusable(false);
        jButton8.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton8ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton8);
        jButton8.setBounds(490, 10, 100, 33);

        jLabel2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Grup/600-350.jpg"))); // NOI18N
        jLabel2.setMaximumSize(new java.awt.Dimension(600, 350));
        jLabel2.setMinimumSize(new java.awt.Dimension(600, 350));
        jLabel2.setPreferredSize(new java.awt.Dimension(600, 350));
        getContentPane().add(jLabel2);
        jLabel2.setBounds(0, 0, 600, 350);

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void btnYeniGrupActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnYeniGrupActionPerformed
        YeniGrupOlustur y=new YeniGrupOlustur();
        y.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_btnYeniGrupActionPerformed

    private void btnGrupGuncelleActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnGrupGuncelleActionPerformed
      GrupGuncelle g=new GrupGuncelle();
        g.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_btnGrupGuncelleActionPerformed

    private void btnGrupListeleActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnGrupListeleActionPerformed
        GrupListele l=new GrupListele();
        l.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_btnGrupListeleActionPerformed

    private void jButton8ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton8ActionPerformed
        Menu m=new Menu();
        m.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_jButton8ActionPerformed

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
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(GrupNavigasyon.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(GrupNavigasyon.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(GrupNavigasyon.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(GrupNavigasyon.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new GrupNavigasyon().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnGrupGuncelle;
    private javax.swing.JButton btnGrupListele;
    private javax.swing.JButton btnYeniGrup;
    private javax.swing.JButton jButton8;
    private javax.swing.JLabel jLabel2;
    // End of variables declaration//GEN-END:variables
}
