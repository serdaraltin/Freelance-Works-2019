package OgretmenUcret;


import AnaMenu.muhasebe2;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.DefaultComboBoxModel;
import javax.swing.DefaultListModel;
import javax.swing.JOptionPane;

import javax.swing.table.DefaultTableModel;
import veritabani.DB;

public class dersUcretlendirme extends javax.swing.JFrame {

    DB db = new DB();
    
    ArrayList<Integer> idd = new ArrayList<>();

    DefaultTableModel dt = new DefaultTableModel();

    Connection conn = null;

    ArrayList<String> arr = new ArrayList<>();
    DefaultListModel<String> ls = new DefaultListModel<>();
    DefaultComboBoxModel<Integer> cm = new DefaultComboBoxModel<>();

    public dersUcretlendirme() {
        initComponents();

        combox();
    }

    public void sifirla() {
        jTextField1.setText("");
        jTextField2.setText("");
        jTextField3.setText("");
        jTextField4.setText("");
        combo2.setSelectedIndex(0);
        combo1.setSelectedIndex(0);
        ogrtlist.removeAll();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        pnl = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        combo1 = new javax.swing.JComboBox<>();
        jScrollPane1 = new javax.swing.JScrollPane();
        ogrtlist = new javax.swing.JList<>();
        jLabel2 = new javax.swing.JLabel();
        jTextField1 = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        jTextField2 = new javax.swing.JTextField();
        jLabel6 = new javax.swing.JLabel();
        jTextField3 = new javax.swing.JTextField();
        jLabel7 = new javax.swing.JLabel();
        jTextField4 = new javax.swing.JTextField();
        jLabel5 = new javax.swing.JLabel();
        combo2 = new javax.swing.JComboBox<>();
        jButton1 = new javax.swing.JButton();
        jLabel8 = new javax.swing.JLabel();
        jLabel13 = new javax.swing.JLabel();
        jButton2 = new javax.swing.JButton();
        jLabel9 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Ders Ücretlendirme Paneli");
        setResizable(false);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        pnl.setMinimumSize(new java.awt.Dimension(850, 568));
        pnl.setPreferredSize(new java.awt.Dimension(850, 568));
        pnl.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 51, 102));
        jLabel1.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel1.setText("Öğretmenler");
        pnl.add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 150, 124, 24));

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(0, 51, 102));
        jLabel3.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel3.setText("Öğretmen Bilgileri");
        pnl.add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(540, 190, 210, 24));

        combo1.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                combo1İtemStateChanged(evt);
            }
        });
        combo1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mousePressed(java.awt.event.MouseEvent evt) {
                combo1MousePressed(evt);
            }
        });
        combo1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                combo1ActionPerformed(evt);
            }
        });
        pnl.add(combo1, new org.netbeans.lib.awtextra.AbsoluteConstraints(120, 110, 282, -1));

        ogrtlist.setBorder(javax.swing.BorderFactory.createTitledBorder(javax.swing.BorderFactory.createTitledBorder(""), "", javax.swing.border.TitledBorder.CENTER, javax.swing.border.TitledBorder.BELOW_TOP));
        ogrtlist.setModel(new javax.swing.AbstractListModel<String>() {
            String[] strings = { " " };
            public int getSize() { return strings.length; }
            public String getElementAt(int i) { return strings[i]; }
        });
        ogrtlist.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                ogrtlistMouseClicked(evt);
            }
        });
        jScrollPane1.setViewportView(ogrtlist);

        pnl.add(jScrollPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 180, 310, 370));

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(0, 51, 102));
        jLabel2.setText("Öğretmen Adı :");
        pnl.add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(400, 230, 110, -1));
        pnl.add(jTextField1, new org.netbeans.lib.awtextra.AbsoluteConstraints(520, 230, 270, -1));

        jLabel4.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(0, 51, 102));
        jLabel4.setText("Öğretmen Soyadı :");
        pnl.add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(380, 270, 140, -1));
        pnl.add(jTextField2, new org.netbeans.lib.awtextra.AbsoluteConstraints(520, 260, 270, -1));

        jLabel6.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel6.setForeground(new java.awt.Color(0, 51, 102));
        jLabel6.setText("İş Tecrübesi(Gün) :");
        pnl.add(jLabel6, new org.netbeans.lib.awtextra.AbsoluteConstraints(380, 300, 140, -1));
        pnl.add(jTextField3, new org.netbeans.lib.awtextra.AbsoluteConstraints(520, 300, 270, -1));

        jLabel7.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel7.setForeground(new java.awt.Color(0, 51, 102));
        jLabel7.setText("Aylık Toplam Ders :");
        pnl.add(jLabel7, new org.netbeans.lib.awtextra.AbsoluteConstraints(380, 340, 140, -1));
        pnl.add(jTextField4, new org.netbeans.lib.awtextra.AbsoluteConstraints(520, 340, 270, -1));

        jLabel5.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(0, 51, 102));
        jLabel5.setText("Ders Saat Ücreti :");
        pnl.add(jLabel5, new org.netbeans.lib.awtextra.AbsoluteConstraints(390, 380, 130, -1));

        pnl.add(combo2, new org.netbeans.lib.awtextra.AbsoluteConstraints(520, 380, 270, -1));

        jButton1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton1.setForeground(new java.awt.Color(0, 51, 102));
        jButton1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/kaydet.png"))); // NOI18N
        jButton1.setText("Kaydet");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        pnl.add(jButton1, new org.netbeans.lib.awtextra.AbsoluteConstraints(580, 410, 155, -1));

        jLabel8.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel8.setForeground(new java.awt.Color(0, 51, 102));
        jLabel8.setText("Branşlar :");
        pnl.add(jLabel8, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 110, 71, -1));

        jLabel13.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel13.setForeground(new java.awt.Color(153, 0, 51));
        jLabel13.setText("Ders Ücretlendirme Paneli");
        pnl.add(jLabel13, new org.netbeans.lib.awtextra.AbsoluteConstraints(300, 40, -1, -1));

        jButton2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton2.setForeground(new java.awt.Color(0, 51, 102));
        jButton2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1466161311_agt_back.png"))); // NOI18N
        jButton2.setText("Geri");
        jButton2.setBorder(null);
        jButton2.setBorderPainted(false);
        jButton2.setContentAreaFilled(false);
        jButton2.setFocusable(false);
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });
        pnl.add(jButton2, new org.netbeans.lib.awtextra.AbsoluteConstraints(740, 10, 100, -1));

        jLabel9.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        pnl.add(jLabel9, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 850, 568));

        getContentPane().add(pnl, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 850, 568));

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void combo1İtemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_combo1İtemStateChanged
        ls.removeAllElements();
        idd.removeAll(idd);
        String secili = (String) combo1.getSelectedItem();
        String sorgu = "select * from ogretmenbilgileri where ogrtBrans like '" + secili + "'";
        try {
            DB db = new DB();
            db.baglan();
            ResultSet rs = db.st.executeQuery(sorgu);
            while (rs.next()) {
                String s = rs.getString("ogretmenAdi") + " " + rs.getString("ogretmenSoyadi");
                ls.addElement(s);
                idd.add(rs.getInt("ogretmenID"));
            }
            db.kapat();
            ogrtlist.setModel(ls);

        } catch (SQLException ex) {
            System.err.println("getirme hatasi" + ex);
        }
        jTextField1.setText("");
        jTextField2.setText("");
        jTextField3.setText("");
        jTextField4.setText("");

    }//GEN-LAST:event_combo1İtemStateChanged
    int tiklanan = 0;
    private void ogrtlistMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_ogrtlistMouseClicked

        aktar();

        tecrube();


    }//GEN-LAST:event_ogrtlistMouseClicked

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed

        if (combo1.getSelectedIndex() != 0) {
            if (!jTextField1.getText().trim().equals("") && !jTextField2.getText().trim().equals("")
                    && !jTextField3.getText().trim().equals("")) {
                String s = (String) combo2.getSelectedItem();
                String g = jTextField4.getText().trim();

                if (sayiKontrol(g) && !g.equals("")) {
                    if (sayiKontrol(s)) {

                        try {
                            DB db = new DB();
                            db.baglan();
                            maas();
                            int sonuc = db.st.executeUpdate("UPDATE ogretmenbilgileri SET dersUcreti ='" + s + "' WHERE ogretmenID ='" + tiklanan + "'");

                            if (sonuc > 0) {
                                JOptionPane.showMessageDialog(rootPane, "Maaş Kaydedildi");
                                sifirla();

                            }
                            db.kapat();
                        } catch (SQLException ex) {
                            System.err.println("Güncelleme Hatası" + ex);
                        }

                    } else {
                        JOptionPane.showMessageDialog(rootPane, "Lütfen Ders Ücretini Seçiniz");
                    }
                } else {
                    JOptionPane.showMessageDialog(rootPane, "Lütfen Ders Saati Giriniz");
                }
            } else {
                JOptionPane.showMessageDialog(rootPane, "Lütfen İşlem Yapmak İstediğiniz Öğretmeni Seçin");
            }

        } else {
            JOptionPane.showMessageDialog(rootPane, "Lütfen Branş Seçiniz");
        }

    }//GEN-LAST:event_jButton1ActionPerformed

    private void combo1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_combo1ActionPerformed

    }//GEN-LAST:event_combo1ActionPerformed

    private void combo1MousePressed(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_combo1MousePressed

    }//GEN-LAST:event_combo1MousePressed

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
        muhasebe2 m=new muhasebe2();
        m.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_jButton2ActionPerformed
    public void maas() {
        String gmaas = jTextField4.getText().trim();

        if (!gmaas.equals("")) {
            int combogle = Integer.valueOf((String) combo2.getSelectedItem());
            int gelmaas = combogle * Integer.valueOf(gmaas);
            try {
                DB db = new DB();
                db.baglan();
                int maas = db.st.executeUpdate("update ogretmenbilgileri set maas ='" + gelmaas + "' where ogretmenID ='" + tiklanan + "'");
                db.kapat();
            } catch (SQLException ex) {
                System.err.println("maasş kaydetme hatasi" + ex);
            }
        } else {
            JOptionPane.showMessageDialog(rootPane, "lütfen ders saatini giriniz");
            jTextField4.requestFocus();
        }
    }

    public void combox() {
        arr.add("Branş Seçiniz");
        String sorgu = "select DISTINCT ogrtBrans from ogretmenbilgileri ";
        try {
            db.baglan();
            ResultSet rs = db.st.executeQuery(sorgu);
            while (rs.next()) {
                arr.add(rs.getString("ogrtBrans"));
            }
            arr.stream().forEach((item) -> {
                combo1.addItem(item);
            });
            db.kapat();
        } catch (SQLException ex) {
            System.err.println("Combo getirme hatası"+ex);
        }
        combo2.addItem("Ücret Seçiniz");
        combo2.addItem("50");
        combo2.addItem("60");
        combo2.addItem("70");
        combo2.addItem("80");
        combo2.addItem("90");

    }

    public void tecrube() {
        try {

            db.baglan();
            int tecrube = 0;
            String sorgu1 = "SELECT DATEDIFF(NOW(),baslamaTarihi) as gecen_gun FROM ogretmenbilgileri where ogretmenId ='" + tiklanan + "'";
        
            ResultSet rs1 = db.st.executeQuery(sorgu1);
            rs1.next();
            jTextField3.setText(rs1.getString("gecen_gun"));
            db.kapat();
        } catch (Exception e) {
            System.err.println("Hata : " + e);
        }
    }

    public void aktar() {
        tiklanan = idd.get(ogrtlist.getSelectedIndex());
        try {
            db.baglan();
            String sorgu = " select * from ogretmenbilgileri where ogretmenID =" + tiklanan + "";
            ResultSet rs = db.st.executeQuery(sorgu);
            while (rs.next()) {
                jTextField1.setText(rs.getString("ogretmenAdi"));
                jTextField2.setText(rs.getString("ogretmenSoyadi"));
                jTextField4.setText("");
            }
        } catch (SQLException ex) {
            Logger.getLogger(dersUcretlendirme.class.getName()).log(Level.SEVERE, null, ex);
        }

    }

    public static boolean sayiKontrol(String gelen) {// sayı kontrol fonksiyonu
        if (gelen.length() >= 10) {
            return false;
        }
        boolean durum = false;
        char[] diz = gelen.toCharArray();
        for (int i = 0; i < diz.length; i++) {
            if (Character.isDigit(diz[i])) {
                durum = true;
            } else {
                durum = false;
                break;
            }
        }
        return durum;
    }

    public static void main(String args[]) {

        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new dersUcretlendirme().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JComboBox<String> combo1;
    private javax.swing.JComboBox<String> combo2;
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTextField jTextField1;
    private javax.swing.JTextField jTextField2;
    private javax.swing.JTextField jTextField3;
    private javax.swing.JTextField jTextField4;
    private javax.swing.JList<String> ogrtlist;
    private javax.swing.JPanel pnl;
    // End of variables declaration//GEN-END:variables
}
