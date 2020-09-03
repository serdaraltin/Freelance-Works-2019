package Grup;

import com.lowagie.text.DocumentException;
import java.awt.event.KeyEvent;
import java.io.File;
import java.io.IOException;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import raporlama.sinifRaporuPDF;
import veritabani.DB;

public class GrupListele extends javax.swing.JFrame {

    static String aranan = "";
    DefaultTableModel tb = new DefaultTableModel();
    DefaultComboBoxModel<String> cmb = new DefaultComboBoxModel<>();
    ArrayList<String> dizi = new ArrayList<>();
    DB d = new DB();

    public GrupListele() {
        initComponents();
        tb.addColumn("ogrenciId");
        tb.addColumn("Öğrenci Adı");
        tb.addColumn("Ögrenci Soyadı");
        tb.addColumn("Ögrenci Tc");
        tb.addColumn("Ögrenci Tel No");
        tblOgrenciBilgi.setModel(tb);
        cmb.addElement("Grup Numarasını Seçiniz");

        try {
            d.baglan();
            ResultSet rs = d.st.executeQuery("select *from grup");
            while (rs.next()) {
                String acik = rs.getString("grupAciklama");
                cmb.addElement(rs.getString("grupNo") + " / " + acik);
                dizi.add(rs.getString("grupNo"));
            }
            cbGrupListele.setModel(cmb);
        } catch (SQLException ex) {
            Logger.getLogger(GrupListele.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            d.kapat();
        }
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPopupMenu1 = new javax.swing.JPopupMenu();
        jPopupMenu2 = new javax.swing.JPopupMenu();
        jPanel1 = new javax.swing.JPanel();
        cbGrupListele = new javax.swing.JComboBox<>();
        jLabel1 = new javax.swing.JLabel();
        txtAranacakGrup = new javax.swing.JTextField();
        jLabel2 = new javax.swing.JLabel();
        btnAra = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        tblOgrenciBilgi = new javax.swing.JTable();
        lblSinifAdi = new javax.swing.JLabel();
        jButton1 = new javax.swing.JButton();
        jButton2 = new javax.swing.JButton();
        jLabel7 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Grup Listeleme Paneli");
        setPreferredSize(new java.awt.Dimension(850, 568));
        setResizable(false);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jPanel1.setBorder(javax.swing.BorderFactory.createTitledBorder(""));
        jPanel1.setMaximumSize(new java.awt.Dimension(850, 568));
        jPanel1.setMinimumSize(new java.awt.Dimension(850, 568));
        jPanel1.setPreferredSize(new java.awt.Dimension(850, 568));
        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        cbGrupListele.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        cbGrupListele.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                cbGrupListeleItemStateChanged(evt);
            }
        });
        jPanel1.add(cbGrupListele, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 180, 241, 29));

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 51, 102));
        jLabel1.setText("Grup No :");
        jPanel1.add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(200, 110, -1, -1));

        txtAranacakGrup.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                txtAranacakGrupKeyPressed(evt);
            }
        });
        jPanel1.add(txtAranacakGrup, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 110, 241, -1));

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(0, 51, 102));
        jLabel2.setText("Grup Listesi :");
        jPanel1.add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(170, 190, -1, -1));

        btnAra.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnAra.setForeground(new java.awt.Color(0, 51, 102));
        btnAra.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/search-24.png"))); // NOI18N
        btnAra.setText("Ara");
        btnAra.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAraActionPerformed(evt);
            }
        });
        jPanel1.add(btnAra, new org.netbeans.lib.awtextra.AbsoluteConstraints(530, 100, 130, 40));

        tblOgrenciBilgi.setModel(new javax.swing.table.DefaultTableModel(
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
        jScrollPane1.setViewportView(tblOgrenciBilgi);

        jPanel1.add(jScrollPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(60, 290, 720, 210));

        lblSinifAdi.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        lblSinifAdi.setForeground(new java.awt.Color(0, 51, 102));
        lblSinifAdi.setToolTipText("");
        lblSinifAdi.setAutoscrolls(true);
        lblSinifAdi.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        jPanel1.add(lblSinifAdi, new org.netbeans.lib.awtextra.AbsoluteConstraints(70, 240, 560, 15));

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
        jPanel1.add(jButton1, new org.netbeans.lib.awtextra.AbsoluteConstraints(730, 10, 100, -1));

        jButton2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton2.setForeground(new java.awt.Color(0, 51, 102));
        jButton2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/print.png"))); // NOI18N
        jButton2.setText("Yazdır");
        jButton2.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jButton2MouseClicked(evt);
            }
        });
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });
        jPanel1.add(jButton2, new org.netbeans.lib.awtextra.AbsoluteConstraints(530, 170, 130, 40));

        jLabel7.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel7.setForeground(new java.awt.Color(153, 0, 51));
        jLabel7.setText("Grup Listeleme Paneli");
        jPanel1.add(jLabel7, new org.netbeans.lib.awtextra.AbsoluteConstraints(310, 40, -1, -1));

        jLabel4.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        jLabel4.setMaximumSize(new java.awt.Dimension(850, 568));
        jLabel4.setMinimumSize(new java.awt.Dimension(850, 568));
        jLabel4.setPreferredSize(new java.awt.Dimension(850, 568));
        jPanel1.add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 850, 568));

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 1, 850, 568));

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void btnAraActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAraActionPerformed
        String aranacak = txtAranacakGrup.getText().trim();
        String aciklama = "";

        try {
            d.baglan();
            ResultSet rs2 = d.st.executeQuery("select *from grup where grupNo = '" + aranacak + "'");
            while (rs2.next()) {
                aciklama = rs2.getString("grupAciklama");
            }

        } catch (Exception e) {
        } finally {
            d.kapat();
        }
        tb.setRowCount(0);
        lblSinifAdi.setText(aranacak + " " + aciklama + " " + "Grubu Öğrenci Listesi");
        if (aranacak.equals("")) {
            JOptionPane.showMessageDialog(rootPane, "Lütfen Aramak İstediğiniz Grup Numarasını Giriniz.");
        } else if (!dizi.contains(aranacak)) {
            JOptionPane.showMessageDialog(rootPane, "Bu İsimde Bir Grup Bulunmamaktadır.");
        } else {
            try {
                d.baglan();
                ResultSet rs = d.st.executeQuery("call ogrenciBilgiGetir('" + aranacak + "')");
                while (rs.next()) {
                    tb.addRow(new String[]{rs.getString("ogrenciId"), rs.getString("ogrenciAdi"), rs.getString("ogrenciSoyadi"), rs.getString("ogrenciTc"), rs.getString("ogrenciTel")});
                }
                tblOgrenciBilgi.setModel(tb);
                txtAranacakGrup.setText("");
            } catch (SQLException ex) {
                Logger.getLogger(GrupListele.class.getName()).log(Level.SEVERE, null, ex);
            } finally {
                d.kapat();
            }
        }

    }//GEN-LAST:event_btnAraActionPerformed

    private void cbGrupListeleItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_cbGrupListeleItemStateChanged
        if (!cmb.getSelectedItem().equals("Grup Numarasını Seçiniz")) {
            aranan = cmb.getSelectedItem().toString();
            String secilen = cmb.getSelectedItem().toString();
            int slas = aranan.indexOf("/");
            aranan = aranan.substring(0, slas);
            lblSinifAdi.setText(secilen + " " + "Grubu Öğrenci Listesi");
            tb.setRowCount(0);

            try {
                d.baglan();
                ResultSet rs = d.st.executeQuery("call ogrenciBilgiGetir('" + aranan + "')");
                while (rs.next()) {
                    tb.addRow(new String[]{rs.getString("ogrenciId"), rs.getString("ogrenciAdi"), rs.getString("ogrenciSoyadi"), rs.getString("ogrenciTc"), rs.getString("ogrenciTel")});
                }
                tblOgrenciBilgi.setModel(tb);
            } catch (SQLException ex) {
                Logger.getLogger(GrupListele.class.getName()).log(Level.SEVERE, null, ex);
            } finally {
                d.kapat();
            }
        }
    }//GEN-LAST:event_cbGrupListeleItemStateChanged

    private void txtAranacakGrupKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtAranacakGrupKeyPressed
        if (evt.getKeyCode() == KeyEvent.VK_ENTER) {
            btnAraActionPerformed(null);
        }
    }//GEN-LAST:event_txtAranacakGrupKeyPressed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        GrupNavigasyon navigasyon = new GrupNavigasyon();
        navigasyon.setVisible(true);
        this.setVisible(false);
        d.kapat();
    }//GEN-LAST:event_jButton1ActionPerformed

    private void jButton2MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jButton2MouseClicked
        // Lambda Runnable
        Runnable task2 = () -> {
            

        sinifRaporuPDF sinifPDF = new sinifRaporuPDF();
        try {
            sinifPDF.sinifRapor(aranan);
        } catch (DocumentException ex) {
            Logger.getLogger(GrupListele.class.getName()).log(Level.SEVERE, null, ex);
        } catch (IOException ex) {
            Logger.getLogger(GrupListele.class.getName()).log(Level.SEVERE, null, ex);
        }

        // senetRaporuPDF senetrapor= new senetRaporuPDF();
        // senetrapor.senetRaporu(123324);
        try {

            if ((new File(sinifRaporuPDF.dosyaAdi)).exists()) {

                Process p = Runtime.getRuntime().exec("rundll32 url.dll,FileProtocolHandler " + sinifRaporuPDF.dosyaAdi);

                p.waitFor();

            } else {

                System.out.println("File does not exists");

            }

            System.out.println("Done");

        } catch (Exception ex) {

            ex.printStackTrace();

        }
        };
new Thread(task2).start();

    }//GEN-LAST:event_jButton2MouseClicked

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jButton2ActionPerformed

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
            java.util.logging.Logger.getLogger(GrupListele.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(GrupListele.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(GrupListele.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(GrupListele.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new GrupListele().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnAra;
    private javax.swing.JComboBox<String> cbGrupListele;
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPopupMenu jPopupMenu1;
    private javax.swing.JPopupMenu jPopupMenu2;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JLabel lblSinifAdi;
    private javax.swing.JTable tblOgrenciBilgi;
    private javax.swing.JTextField txtAranacakGrup;
    // End of variables declaration//GEN-END:variables
}
