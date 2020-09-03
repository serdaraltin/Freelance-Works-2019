package Rehberlik;

import java.sql.ResultSet;
import java.sql.SQLException;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.security.auth.callback.ConfirmationCallback;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import veritabani.DB;

public class Yoklama extends javax.swing.JFrame {

    DefaultTableModel dt = new DefaultTableModel();
    DefaultComboBoxModel<String> df = new DefaultComboBoxModel<>();
    DB s=new DB();



    public Yoklama() {
        initComponents();
        dt.addColumn("Ogrenci ID");
        dt.addColumn("ogrenci Adi");
        dt.addColumn("Ogrenci Soyadi");
        dt.addColumn("Ogrenci TC");
        yoklamaOgrenciTBL.setModel(dt);
        df.setSelectedItem("Lütfen Sınıf Seç");
        yoklamaSinif.setModel(df);
        ogrenciGetir();
        sinifGetir();

        try {
            tarihGetir();
        } catch (ParseException ex) {

        }
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        btnAnamenu = new javax.swing.JButton();
        lblAdi = new javax.swing.JLabel();
        lblSoyadi = new javax.swing.JLabel();
        lblogrenciID = new javax.swing.JLabel();
        lblogrenciTC = new javax.swing.JLabel();
        jButton1 = new javax.swing.JButton();
        Sifirla = new javax.swing.JButton();
        jLabel5 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        jLabel1 = new javax.swing.JLabel();
        yoklamaSinif = new javax.swing.JComboBox<>();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        yoklamaDurum = new javax.swing.JComboBox<>();
        yoklamatarih = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        btnkaydet = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        yoklamaOgrenciTBL = new javax.swing.JTable();
        jLabel13 = new javax.swing.JLabel();
        jLabel8 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Yoklama Paneli");
        setPreferredSize(new java.awt.Dimension(850, 568));
        setResizable(false);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        btnAnamenu.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnAnamenu.setForeground(new java.awt.Color(0, 51, 102));
        btnAnamenu.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1466161311_agt_back.png"))); // NOI18N
        btnAnamenu.setText("Geri");
        btnAnamenu.setBorder(null);
        btnAnamenu.setBorderPainted(false);
        btnAnamenu.setContentAreaFilled(false);
        btnAnamenu.setFocusable(false);
        btnAnamenu.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAnamenuActionPerformed(evt);
            }
        });
        getContentPane().add(btnAnamenu, new org.netbeans.lib.awtextra.AbsoluteConstraints(740, 10, 100, -1));
        getContentPane().add(lblAdi, new org.netbeans.lib.awtextra.AbsoluteConstraints(110, 420, 140, 25));
        getContentPane().add(lblSoyadi, new org.netbeans.lib.awtextra.AbsoluteConstraints(380, 420, 160, 29));
        getContentPane().add(lblogrenciID, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 360, 88, 30));
        getContentPane().add(lblogrenciTC, new org.netbeans.lib.awtextra.AbsoluteConstraints(630, 420, 190, 25));

        jButton1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton1.setForeground(new java.awt.Color(0, 51, 102));
        jButton1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/yokolan.png"))); // NOI18N
        jButton1.setText("Yok Olanları Getir");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton1, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 480, 190, 40));

        Sifirla.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        Sifirla.setForeground(new java.awt.Color(0, 51, 102));
        Sifirla.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/verileri sıfırla.png"))); // NOI18N
        Sifirla.setText("Verileri Sıfırla");
        Sifirla.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                SifirlaActionPerformed(evt);
            }
        });
        getContentPane().add(Sifirla, new org.netbeans.lib.awtextra.AbsoluteConstraints(450, 480, 193, 40));

        jLabel5.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(0, 51, 102));
        jLabel5.setText("Adı :");
        getContentPane().add(jLabel5, new org.netbeans.lib.awtextra.AbsoluteConstraints(60, 420, -1, -1));

        jLabel6.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel6.setForeground(new java.awt.Color(0, 51, 102));
        jLabel6.setText("Soyadı :");
        getContentPane().add(jLabel6, new org.netbeans.lib.awtextra.AbsoluteConstraints(310, 420, -1, -1));

        jLabel7.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel7.setForeground(new java.awt.Color(0, 51, 102));
        jLabel7.setText("TC :");
        getContentPane().add(jLabel7, new org.netbeans.lib.awtextra.AbsoluteConstraints(590, 420, -1, -1));

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 51, 102));
        jLabel1.setText("Sınıf :");
        getContentPane().add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 110, 40, -1));

        yoklamaSinif.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                yoklamaSinifItemStateChanged(evt);
            }
        });
        getContentPane().add(yoklamaSinif, new org.netbeans.lib.awtextra.AbsoluteConstraints(60, 110, 170, -1));

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 20)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(0, 51, 102));
        jLabel2.setText("ÖGRENCİLER");
        getContentPane().add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(360, 160, -1, -1));

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(0, 51, 102));
        jLabel3.setText("Durum :");
        getContentPane().add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 110, 60, -1));

        yoklamaDurum.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "SECİM YAPINIZ", "RAPORLU", "DEVAMSIZ", "İZİNLİ", " " }));
        getContentPane().add(yoklamaDurum, new org.netbeans.lib.awtextra.AbsoluteConstraints(360, 110, 180, -1));
        getContentPane().add(yoklamatarih, new org.netbeans.lib.awtextra.AbsoluteConstraints(640, 110, 170, -1));

        jLabel4.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(0, 51, 102));
        jLabel4.setText("Tarih :");
        getContentPane().add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(580, 110, 50, -1));

        btnkaydet.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnkaydet.setForeground(new java.awt.Color(0, 51, 102));
        btnkaydet.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/kaydet.png"))); // NOI18N
        btnkaydet.setText("Kaydet");
        btnkaydet.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnkaydetActionPerformed(evt);
            }
        });
        getContentPane().add(btnkaydet, new org.netbeans.lib.awtextra.AbsoluteConstraints(720, 370, -1, 40));

        yoklamaOgrenciTBL.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {},
                {},
                {},
                {}
            },
            new String [] {

            }
        ));
        yoklamaOgrenciTBL.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                yoklamaOgrenciTBLMouseClicked(evt);
            }
        });
        jScrollPane1.setViewportView(yoklamaOgrenciTBL);

        getContentPane().add(jScrollPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 210, 800, 150));

        jLabel13.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel13.setForeground(new java.awt.Color(153, 0, 51));
        jLabel13.setText("Yoklama  Paneli");
        getContentPane().add(jLabel13, new org.netbeans.lib.awtextra.AbsoluteConstraints(370, 40, -1, -1));

        jLabel8.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        getContentPane().add(jLabel8, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 850, 570));

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void btnAnamenuActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAnamenuActionPerformed
        Rehberlik mt = new Rehberlik();
        mt.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_btnAnamenuActionPerformed
    int secimDurum = -1;
    private void btnkaydetActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnkaydetActionPerformed
        secimDurum = yoklamaDurum.getSelectedIndex();
        if (comboSecim == -1) {
            JOptionPane.showMessageDialog(rootPane, "Lütfen Sinif seçiniz");
        } else if (secimDurum == 0) {
            JOptionPane.showMessageDialog(rootPane, "Lütfen Durum seçiniz");
        } else {

            String sinif = yoklamaSinif.getSelectedItem().toString();
            String durumu = yoklamaDurum.getSelectedItem().toString();
            String ogrenciAdi = lblAdi.getText();
            String ogrenciSoyadi = lblSoyadi.getText();
            String ogrencitc = lblogrenciTC.getText();
            String ogrenciID = lblogrenciID.getText();
            if (ogrenciAdi.equals("")) {
                JOptionPane.showMessageDialog(rootPane, "Lütfen Tablodan Öğrenci Seçiniz");
            } else {
                
                    

                    // önceki kontrol
                    ResultSet rss = null;
                    try {
                        rss = s.st.executeQuery("select * from yoklama where yoklamaTarihi =  DATE(NOW()) and ogrenciID = '" + ogrenciID + "'");
                    } catch (SQLException ex) {
                        Logger.getLogger(Yoklama.class.getName()).log(Level.SEVERE, null, ex);
                    }
                    try {
                        if (rss.next()) {
                            JOptionPane.showMessageDialog(rootPane, "Bu öğrencinin bu günkü durumu belirtilmiş.");
                        } else {
                            
                            boolean rs = s.st.execute("insert into yoklama values (null, '" + ogrenciID + "', '" + sinif + "', '" + ogrenciAdi + "', '" + ogrenciSoyadi + "', '" + ogrencitc + "', '" + durumu + "',now())");
                            
                            JOptionPane.showMessageDialog(rootPane, "Ekleme Başarılı");
                        }
                    } catch (SQLException ex) {
                        Logger.getLogger(Yoklama.class.getName()).log(Level.SEVERE, null, ex);
                    }
          
            }
        }
    }//GEN-LAST:event_btnkaydetActionPerformed
    int tabloSecim = -1;
    private void yoklamaOgrenciTBLMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_yoklamaOgrenciTBLMouseClicked
        
        tabloSecim = Integer.valueOf("" + dt.getValueAt(yoklamaOgrenciTBL.getSelectedRow(), 0));

        try {
            ResultSet rs = s.st.executeQuery("select * from ogrenci where ogrenciId ='" + tabloSecim + "'");
            rs.next();//yazmazsak itaraayon bize bilgileri getirmez
            lblAdi.setText(rs.getString("ogrenciAdi"));
            lblSoyadi.setText(rs.getString("ogrenciSoyadi"));
            lblogrenciID.setText(rs.getString("ogrenciId"));
            lblogrenciTC.setText(rs.getString("ogrenciTc"));

        } catch (SQLException ex) {
            Logger.getLogger(Yoklama.class.getName()).log(Level.SEVERE, null, ex);
        }


    }//GEN-LAST:event_yoklamaOgrenciTBLMouseClicked
    int comboSecim = -1;

    private void yoklamaSinifItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_yoklamaSinifItemStateChanged
        
        dt.setRowCount(0);
        comboSecim = yoklamaSinif.getSelectedIndex() + 1;
        String aga = yoklamaSinif.getSelectedItem().toString();
        try {
            
            ResultSet rs = s.st.executeQuery("call yoklamaOgrenciGetir('" + aga + "') ");

            while (rs.next()) {

                dt.addRow(new String[]{rs.getString("ogrenciId"), rs.getString("ogrenciAdi"), rs.getString("ogrenciSoyadi"), rs.getString("ogrenciTc")});
            }

        } catch (Exception e) {
        }


    }//GEN-LAST:event_yoklamaSinifItemStateChanged
    public boolean sinifVarmi(String sinif) throws SQLException {
        
        ResultSet rs = null;
        boolean durum = false;
        System.out.println(sinif);

        try {
            rs = s.st.executeQuery("select COUNT(*) as sayi FROM ogretmendersprog where Ogretmen = '" + sinif + "' ");
            rs.next();
            if (rs.getInt("sayi") > 0) {
                durum = false;
            } else {
                durum = true;
            }
        } catch (SQLException ex) {
            Logger.getLogger(OgrenciDersProgramiOlustur.class.getName()).log(Level.SEVERE, null, ex);
        }
        return durum;
    }

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        yokolanlar mt = new yokolanlar();
        mt.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_jButton1ActionPerformed

    private void SifirlaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_SifirlaActionPerformed
        
        int cevap=JOptionPane.showConfirmDialog(rootPane,"Silmek İstediğinize Eminmisiniz","Verileri Sıfırlama Uyarısı",ConfirmationCallback.YES_NO_OPTION);
        if(cevap==0)
        {
        
        try {
            boolean bjk=s.st.execute("Truncate yoklama");
            JOptionPane.showMessageDialog(rootPane,"Yoklamalar Sifirlandi");
        } catch (Exception e) {
        }
        }
    }//GEN-LAST:event_SifirlaActionPerformed
    public void sinifGetir() {
        try {
            
            ResultSet rs = s.st.executeQuery("select *from grup");
            while (rs.next()) {

                yoklamaSinif.addItem(rs.getString("grupNo"));

            }
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(rootPane, "MySql Sinif Getirme Hatasi");
        }

    }

    public void ogrenciGetir() {

    }

    public void tarihGetir() throws ParseException {
        Date simdikiZaman = new Date();
        DateFormat dx = new SimpleDateFormat("dd/MM/yyyy");
        yoklamatarih.setText(dx.format(simdikiZaman));

    }

    public static void main(String args[]) {

        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Yoklama().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton Sifirla;
    private javax.swing.JButton btnAnamenu;
    private javax.swing.JButton btnkaydet;
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JLabel lblAdi;
    private javax.swing.JLabel lblSoyadi;
    private javax.swing.JLabel lblogrenciID;
    private javax.swing.JLabel lblogrenciTC;
    private javax.swing.JComboBox<String> yoklamaDurum;
    private javax.swing.JTable yoklamaOgrenciTBL;
    private javax.swing.JComboBox<String> yoklamaSinif;
    private javax.swing.JTextField yoklamatarih;
    // End of variables declaration//GEN-END:variables
}
