package Rehberlik;
public class Rehberlik extends javax.swing.JFrame {
 
    public Rehberlik() {
        initComponents();
        
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jButton5 = new javax.swing.JButton();
        jPanel1 = new javax.swing.JPanel();
        btnyoklamalar = new javax.swing.JButton();
        btnogrenciders = new javax.swing.JButton();
        btnogretmenders = new javax.swing.JButton();
        jButton1 = new javax.swing.JButton();
        btnetutders = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Rehberlik Navigasyon Paneli");
        setResizable(false);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jButton5.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton5.setForeground(new java.awt.Color(0, 51, 102));
        jButton5.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1466161311_agt_back.png"))); // NOI18N
        jButton5.setText("Geri");
        jButton5.setBorder(null);
        jButton5.setBorderPainted(false);
        jButton5.setContentAreaFilled(false);
        jButton5.setFocusable(false);
        jButton5.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton5ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton5, new org.netbeans.lib.awtextra.AbsoluteConstraints(640, 10, 100, -1));

        jPanel1.setOpaque(false);
        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        btnyoklamalar.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnyoklamalar.setForeground(new java.awt.Color(0, 51, 102));
        btnyoklamalar.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/yoklama.png"))); // NOI18N
        btnyoklamalar.setText("Yoklamalar");
        btnyoklamalar.setOpaque(false);
        btnyoklamalar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnyoklamalarActionPerformed(evt);
            }
        });
        jPanel1.add(btnyoklamalar, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 30, 280, 80));

        btnogrenciders.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnogrenciders.setForeground(new java.awt.Color(0, 51, 102));
        btnogrenciders.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/ogrencider.png"))); // NOI18N
        btnogrenciders.setText("Öğrenci Ders Programı");
        btnogrenciders.setOpaque(false);
        btnogrenciders.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnogrencidersActionPerformed(evt);
            }
        });
        jPanel1.add(btnogrenciders, new org.netbeans.lib.awtextra.AbsoluteConstraints(410, 160, 280, 80));

        btnogretmenders.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnogretmenders.setForeground(new java.awt.Color(0, 51, 102));
        btnogretmenders.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/öğretmen.png"))); // NOI18N
        btnogretmenders.setText("Öğretmen Ders Programı");
        btnogretmenders.setOpaque(false);
        btnogretmenders.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnogretmendersActionPerformed(evt);
            }
        });
        jPanel1.add(btnogretmenders, new org.netbeans.lib.awtextra.AbsoluteConstraints(410, 30, 280, 80));

        jButton1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton1.setForeground(new java.awt.Color(0, 51, 102));
        jButton1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/not.png"))); // NOI18N
        jButton1.setText("Not Girişi");
        jButton1.setOpaque(false);
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        jPanel1.add(jButton1, new org.netbeans.lib.awtextra.AbsoluteConstraints(230, 260, 280, 80));

        btnetutders.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnetutders.setForeground(new java.awt.Color(0, 51, 102));
        btnetutders.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/etut.png"))); // NOI18N
        btnetutders.setText("Etüt Ders Programı");
        btnetutders.setOpaque(false);
        btnetutders.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnetutdersActionPerformed(evt);
            }
        });
        jPanel1.add(btnetutders, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 160, 280, 80));

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 80, 740, 380));

        jLabel1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        getContentPane().add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 750, 500));

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void jButton5ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton5ActionPerformed
        AnaMenu.Menu ana =new AnaMenu.Menu();
         ana.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_jButton5ActionPerformed

    private void btnetutdersActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnetutdersActionPerformed
        etutProgrami mt=new etutProgrami();
        mt.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_btnetutdersActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        ogrenciDersNotuGirme mt=new ogrenciDersNotuGirme();
        mt.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_jButton1ActionPerformed

    private void btnogretmendersActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnogretmendersActionPerformed
        ogretmenDersProgrami mt=new ogretmenDersProgrami();
        mt.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_btnogretmendersActionPerformed

    private void btnogrencidersActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnogrencidersActionPerformed
        OgrenciDersProgramiOlustur mt=new OgrenciDersProgramiOlustur ();
        mt.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_btnogrencidersActionPerformed

    private void btnyoklamalarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnyoklamalarActionPerformed
        Yoklama mt=new Yoklama();
        mt.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_btnyoklamalarActionPerformed
    
    public static void main(String args[]) {
     
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Rehberlik().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnetutders;
    private javax.swing.JButton btnogrenciders;
    private javax.swing.JButton btnogretmenders;
    private javax.swing.JButton btnyoklamalar;
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton5;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JPanel jPanel1;
    // End of variables declaration//GEN-END:variables
}
