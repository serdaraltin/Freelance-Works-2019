package Kasa;


import AnaMenu.muhasebe2;
import java.sql.ResultSet;
import java.sql.SQLException;
import javax.swing.table.DefaultTableModel;
import veritabani.DB;

public class ist extends javax.swing.JFrame {

    DefaultTableModel tb = new DefaultTableModel();
    int top = 0, nakit = 0, kredi = 0, senet = 0, tut = 0;

    public ist() {
        initComponents();
        tabloDoldur();
    }

    public void tabloDoldur() {
        try {
            DB bd = new DB();
            ResultSet rs = bd.dataGetir("kasa left join ogrenci on ogrenciId = kasa_ogrenci_id order by islem_id desc");
            tb.setRowCount(0);
            tb.setColumnCount(0);
            tb.addColumn("İşlem ID");
            tb.addColumn("Hareket");
            tb.addColumn("İşlem Tarihi");
            tb.addColumn("Tutar");
            tb.addColumn("Ödeme Türü");
            tb.addColumn("İşlem Tipi");
            tb.addColumn("Açıklama");
            tb.addColumn("Öğrenci No");
            tb.addColumn("Öğrenci Adı");
            tb.addColumn("Öğrenci Soyadı");

            while (rs.next()) {
                String sonuc = (rs.getInt("hareket")) == 0 ? "Giriş" : "Çıkış";
                String ogren = (rs.getInt("kasa_ogrenci_id")) == 0 ? "-" : rs.getString("kasa_ogrenci_id");
                String odeme = rs.getString("odeme_sekli");
                tut = rs.getInt("miktar");
                tb.addRow(new Object[]{rs.getInt("islem_id"), sonuc, rs.getString("islem_tarihi"), tut, odeme, rs.getString("islem_tipi"), rs.getString("aciklama"), ogren, rs.getString("ogrenciAdi"), rs.getString("ogrenciSoyadi")});
                if (sonuc.equals("Giriş")) {
                    if (odeme.equals("Nakit")) {
                        nakit += tut;
                    } else if (odeme.equals("Senet")) {
                        senet += tut;
                    } else if (odeme.equals("Kredi Kartı")) {
                        kredi += tut;
                    }
                } else if(sonuc.equals("Çıkış")){ 
                    if (odeme.equals("Nakit")) {
                    nakit -= tut;
                    } else if (odeme.equals("Senet")) {
                    senet -= tut;
                    } else if (odeme.equals("Kredi Kartı")){
                    kredi -= tut;
                }
                }

                top = kredi + nakit + senet;
            }
            jLabel2.setText(String.valueOf(top));
            jTable1.setModel(tb);
            bd.kapat();
        } catch (SQLException ex) {
            System.err.println("Tablo Doldurma Hatası: " + ex);
        }
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        jTable1 = new javax.swing.JTable();
        jLabel1 = new javax.swing.JLabel();
        cmSec = new javax.swing.JComboBox<>();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        btnR = new javax.swing.JButton();
        jLabel9 = new javax.swing.JLabel();
        jButton1 = new javax.swing.JButton();
        jLabel4 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Kasa İşlemleri");
        setMaximumSize(new java.awt.Dimension(850, 568));
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

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
        jScrollPane1.setViewportView(jTable1);

        getContentPane().add(jScrollPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 120, 850, 360));

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 51, 102));
        jLabel1.setText("Kasa Durumu:");
        getContentPane().add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(270, 500, -1, -1));

        cmSec.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Tüm İşlemler", "Nakit", "Kredi Kartı", "Senet" }));
        cmSec.addPropertyChangeListener(new java.beans.PropertyChangeListener() {
            public void propertyChange(java.beans.PropertyChangeEvent evt) {
                cmSecPropertyChange(evt);
            }
        });
        getContentPane().add(cmSec, new org.netbeans.lib.awtextra.AbsoluteConstraints(90, 500, 150, 20));

        jLabel2.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        getContentPane().add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(361, 297, 80, 23));
        getContentPane().add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(390, 500, 150, 20));

        btnR.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnR.setForeground(new java.awt.Color(0, 51, 102));
        btnR.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/guncelle.png"))); // NOI18N
        btnR.setText("Yenile");
        btnR.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnRActionPerformed(evt);
            }
        });
        getContentPane().add(btnR, new org.netbeans.lib.awtextra.AbsoluteConstraints(560, 490, -1, -1));

        jLabel9.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel9.setForeground(new java.awt.Color(153, 0, 51));
        jLabel9.setText("Kasa İşlemleri Paneli");
        getContentPane().add(jLabel9, new org.netbeans.lib.awtextra.AbsoluteConstraints(340, 60, -1, -1));

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

        jLabel4.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        jLabel4.setMaximumSize(new java.awt.Dimension(850, 568));
        jLabel4.setMinimumSize(new java.awt.Dimension(850, 568));
        jLabel4.setPreferredSize(new java.awt.Dimension(850, 568));
        getContentPane().add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 850, 568));

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void btnRActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnRActionPerformed
        
        top=0;
        senet =0;
        nakit=0;
        kredi=0;
        tabloDoldur();
    }//GEN-LAST:event_btnRActionPerformed

    private void cmSecPropertyChange(java.beans.PropertyChangeEvent evt) {//GEN-FIRST:event_cmSecPropertyChange

        if (cmSec.getSelectedItem().equals("Nakit")) {
            jLabel2.setText(String.valueOf(nakit));
        } else if (cmSec.getSelectedItem().equals("Senet")) {
            jLabel2.setText(String.valueOf(senet));
        } else if (cmSec.getSelectedItem().equals("Kredi Kartı")) {
            jLabel2.setText(String.valueOf(kredi));
        } else if(cmSec.getSelectedItem().equals("Tüm İşlemler")){
            jLabel2.setText(String.valueOf(top));
        }
    }//GEN-LAST:event_cmSecPropertyChange

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
            java.util.logging.Logger.getLogger(ist.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(ist.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(ist.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(ist.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new ist().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnR;
    private javax.swing.JComboBox<String> cmSec;
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable jTable1;
    // End of variables declaration//GEN-END:variables
}
