package Rehberlik;



import java.sql.ResultSet;
import java.sql.SQLException;


import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import veritabani.DB;


public class ogrenciDersNotuGirme extends javax.swing.JFrame {

   DefaultTableModel dt = new DefaultTableModel();
    DefaultComboBoxModel<String> df=new DefaultComboBoxModel<>();
    DB s=new DB();
    
    

    public ogrenciDersNotuGirme() {
        initComponents();
        dt.addColumn("Ogrenci ID");
        dt.addColumn("ogrenci Adi");
        dt.addColumn("Ogrenci Soyadi");
        dt.addColumn("Ogrenci TC");
        jTable1.setModel(dt);
        df.setSelectedItem("Lütfen Sınıf Seç");
        jComboBox1.setModel(df);
        
        sinifGetir();
        
    }

   
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jComboBox1 = new javax.swing.JComboBox<>();
        jLabel1 = new javax.swing.JLabel();
        jScrollPane1 = new javax.swing.JScrollPane();
        jTable1 = new javax.swing.JTable();
        jLabel3 = new javax.swing.JLabel();
        jTextField1 = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        jTextField2 = new javax.swing.JTextField();
        jButton1 = new javax.swing.JButton();
        lblsoyadi = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        lblogrenciid = new javax.swing.JLabel();
        lbladi = new javax.swing.JLabel();
        lbltc = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        jLabel8 = new javax.swing.JLabel();
        jLabel9 = new javax.swing.JLabel();
        jSeparator1 = new javax.swing.JSeparator();
        jButton3 = new javax.swing.JButton();
        jButton4 = new javax.swing.JButton();
        jLabel13 = new javax.swing.JLabel();
        jButton2 = new javax.swing.JButton();
        jLabel2 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Öğrenci Ders Notu Paneli");
        setPreferredSize(new java.awt.Dimension(988, 568));
        setResizable(false);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jPanel1.setMaximumSize(new java.awt.Dimension(800, 700));
        jPanel1.setMinimumSize(new java.awt.Dimension(0, 0));
        jPanel1.setOpaque(false);
        jPanel1.setPreferredSize(new java.awt.Dimension(800, 700));
        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jComboBox1.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jComboBox1.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                jComboBox1ItemStateChanged(evt);
            }
        });
        jPanel1.add(jComboBox1, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 20, 350, -1));

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 51, 102));
        jLabel1.setText("Sınıf Seçiniz :");
        jPanel1.add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 20, 110, -1));

        jTable1.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {},
                {},
                {},
                {}
            },
            new String [] {

            }
        ));
        jTable1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jTable1MouseClicked(evt);
            }
        });
        jScrollPane1.setViewportView(jTable1);

        jPanel1.add(jScrollPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 60, 860, 191));

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(0, 51, 102));
        jLabel3.setText("1.Sınav Notu :");
        jPanel1.add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(170, 270, -1, -1));
        jPanel1.add(jTextField1, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 270, 130, -1));

        jLabel4.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(0, 51, 102));
        jLabel4.setText("2.Sınav Notu :");
        jPanel1.add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(520, 270, -1, -1));
        jPanel1.add(jTextField2, new org.netbeans.lib.awtextra.AbsoluteConstraints(640, 270, 130, -1));

        jButton1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton1.setForeground(new java.awt.Color(0, 51, 102));
        jButton1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/kaydet.png"))); // NOI18N
        jButton1.setText("Notları Kaydet");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        jPanel1.add(jButton1, new org.netbeans.lib.awtextra.AbsoluteConstraints(400, 410, 147, 41));
        jPanel1.add(lblsoyadi, new org.netbeans.lib.awtextra.AbsoluteConstraints(470, 350, 180, 26));
        jPanel1.add(jLabel6, new org.netbeans.lib.awtextra.AbsoluteConstraints(530, 60, 62, 26));
        jPanel1.add(lblogrenciid, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 350, 180, 26));
        jPanel1.add(lbladi, new org.netbeans.lib.awtextra.AbsoluteConstraints(220, 350, 180, 26));
        jPanel1.add(lbltc, new org.netbeans.lib.awtextra.AbsoluteConstraints(710, 350, 180, 26));

        jLabel5.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(0, 51, 102));
        jLabel5.setText("Öğrenci ID");
        jPanel1.add(jLabel5, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 320, -1, -1));

        jLabel7.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel7.setForeground(new java.awt.Color(0, 51, 102));
        jLabel7.setText("Ögrenci Adı");
        jPanel1.add(jLabel7, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 320, -1, -1));

        jLabel8.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel8.setForeground(new java.awt.Color(0, 51, 102));
        jLabel8.setText("Ögrenci Soyadı");
        jPanel1.add(jLabel8, new org.netbeans.lib.awtextra.AbsoluteConstraints(510, 320, -1, -1));

        jLabel9.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel9.setForeground(new java.awt.Color(0, 51, 102));
        jLabel9.setText("Ögrenci TC No");
        jPanel1.add(jLabel9, new org.netbeans.lib.awtextra.AbsoluteConstraints(760, 320, -1, -1));
        jPanel1.add(jSeparator1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 310, 870, 10));

        jButton3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton3.setForeground(new java.awt.Color(0, 51, 102));
        jButton3.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/notlar.png"))); // NOI18N
        jButton3.setText("Tüm Notlar");
        jButton3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton3ActionPerformed(evt);
            }
        });
        jPanel1.add(jButton3, new org.netbeans.lib.awtextra.AbsoluteConstraints(600, 410, -1, -1));

        jButton4.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton4.setForeground(new java.awt.Color(0, 51, 102));
        jButton4.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/guncelle.png"))); // NOI18N
        jButton4.setText("Güncelle");
        jButton4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton4ActionPerformed(evt);
            }
        });
        jPanel1.add(jButton4, new org.netbeans.lib.awtextra.AbsoluteConstraints(170, 410, 147, 41));

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 70, 940, 480));

        jLabel13.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel13.setForeground(new java.awt.Color(153, 0, 51));
        jLabel13.setText("Öğrenci Ders Notu Paneli");
        getContentPane().add(jLabel13, new org.netbeans.lib.awtextra.AbsoluteConstraints(380, 40, -1, -1));

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
        getContentPane().add(jButton2, new org.netbeans.lib.awtextra.AbsoluteConstraints(870, 10, 100, -1));

        jLabel2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        getContentPane().add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 990, 570));

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents
 int secim=-1;
 int sec=-1;
    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
      secim=jComboBox1.getSelectedIndex();
      sec=jTable1.getSelectedRow();
      if(secim == -1){
      JOptionPane.showMessageDialog(rootPane, "Lütfen Sınıf Seçiniz");
      }
      
      else{
          if(sec==-1)
          {JOptionPane.showMessageDialog(rootPane, "Lütfen Tablodan Öğrenci Seçiniz");}
        
          else{
        if(sayiKontrol(jTextField1.getText().trim())&& sayiKontrol(jTextField2.getText().trim())){
        String sinif=jComboBox1.getSelectedItem().toString();
           
            String ogrenciAdi=lbladi.getText();
            String ogrenciSoyadi=lblsoyadi.getText();
            String ogrencitc=lbltc.getText();
            String ogrenciID=lblogrenciid.getText();
            String not1=jTextField1.getText();
            String not2=jTextField2.getText();
            
          
                
            
             try {
                 if (!sinifVarmi(ogrenciID)) {
                     
                 
                 
                boolean rs = s.st.execute("call ogrenciDersNotuGirme ('" +ogrenciID+ "', '" +sinif+ "', '" + ogrenciAdi + "', '" + ogrenciSoyadi + "', '" + ogrencitc + "', '" +not1+ "','" +not2+ "')");
                 
       JOptionPane.showMessageDialog(rootPane, "Ekleme Başarılı");
                
                 }
                 else{
                 JOptionPane.showMessageDialog(rootPane, "Öğrencinin Notu Girilmiştir.Güncelleme Yapınız");
                 }
                
                }
             catch (Exception e) {
                JOptionPane.showMessageDialog(rootPane, "MySql Yoklama Hatası");
            }
        }
        else{
        
        JOptionPane.showMessageDialog(rootPane, "Lütfen Sayı Formatında Giriniz");
            jTextField1.requestFocus();
        }
          }
      }
        
    }//GEN-LAST:event_jButton1ActionPerformed
int tabloSecim=-1;
    private void jTable1MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jTable1MouseClicked

         tabloSecim = Integer.valueOf("" + dt.getValueAt(jTable1.getSelectedRow(), 0));
        
        
        try {
            ResultSet rs = s.st.executeQuery("select *from ogrenci where ogrenciId ='" + tabloSecim + "'");
            rs.next();//yazmazsak itaraayon bize bilgileri getirmez
            lbladi.setText(rs.getString("ogrenciAdi"));
            lblsoyadi.setText(rs.getString("ogrenciSoyadi"));
            lblogrenciid.setText(rs.getString("ogrenciId"));
            lbltc.setText(rs.getString("ogrenciTc"));
            
            
        } catch (SQLException ex) {
            Logger.getLogger(Yoklama.class.getName()).log(Level.SEVERE, null, ex);
        }
            
    }//GEN-LAST:event_jTable1MouseClicked
int comboSecim=-1;
    private void jComboBox1ItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_jComboBox1ItemStateChanged
       dt.setRowCount(0);
        comboSecim = jComboBox1.getSelectedIndex()+1;
        String aga=jComboBox1.getSelectedItem().toString();
        try {
            
         ResultSet rs=s.st.executeQuery("call yoklamaOgrenciGetir('"+aga+"') ");
         
          
          while (rs.next()) {
                if(rs.getString("ogrenciId").equals("")){
          JOptionPane.showMessageDialog(rootPane, "Sinifa Ait Öğrenci Yoktur");
          
          }
                dt.addRow(new String[]{rs.getString("ogrenciId"), rs.getString("ogrenciAdi"), rs.getString("ogrenciSoyadi"), rs.getString("ogrenciTc")});
          }
          
          }
         
         catch (Exception e) {
        }
    }//GEN-LAST:event_jComboBox1ItemStateChanged
    public  boolean sinifVarmi(String sinif) throws SQLException {
        
        ResultSet rs = null;
        boolean durum = false;
        System.out.println(sinif);
        
        try {
            rs =s.st.executeQuery("select COUNT(*) as sayi FROM ogrencidersnotlari where ogrenciID = '"+sinif+"' ");
            rs.next();
            if(rs.getInt("sayi") > 0) durum = true; else durum = false;
        } catch (SQLException ex) {
            Logger.getLogger(OgrenciDersProgramiOlustur.class.getName()).log(Level.SEVERE, null, ex);
        }
        return durum;
    }
    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
        Rehberlik mt=new Rehberlik();
        mt.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_jButton2ActionPerformed

    private void jButton3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton3ActionPerformed
        TumNotlar mt=new TumNotlar();
        mt.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_jButton3ActionPerformed
int secimli=-1;
 int secil=-1;
    private void jButton4ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton4ActionPerformed
        secimli=jComboBox1.getSelectedIndex();
        secil=jTable1.getSelectedRow();
        
        if(secimli == -1){
      JOptionPane.showMessageDialog(rootPane, "Lütfen Sınıf Seçiniz");
      }
      
      else{
          if(secil==-1)
          {JOptionPane.showMessageDialog(rootPane, "Lütfen Tablodan Öğrenci Seçiniz");}
        
          else{
        if(sayiKontrol(jTextField1.getText().trim())&& sayiKontrol(jTextField2.getText().trim())){
        String sinif=jComboBox1.getSelectedItem().toString();
           
            String ogrenciAdi=lbladi.getText();
            String ogrenciSoyadi=lblsoyadi.getText();
            String ogrencitc=lbltc.getText();
            String ogrenciID=lblogrenciid.getText();
            String not1=jTextField1.getText();
            String not2=jTextField2.getText();
            
            try {
                if (sinifVarmi(ogrenciID)) {
                    
                
            boolean ts=s.st.execute("UPDATE ogrencidersnotlari SET 1_notu='"+not1+"',2_notu='"+not2+"' where ogrenciID='"+ogrenciID+"'");
            JOptionPane.showMessageDialog(rootPane, "Güncelleme Başarılı");
                }
                else{
                JOptionPane.showMessageDialog(rootPane, "Bu kayıt Bulunamadı.Lütfen Önce Ekleyin");
                }
        } catch (Exception e) {
            JOptionPane.showMessageDialog(rootPane, "Güncelleme Hatasi");
        }
            
    }//GEN-LAST:event_jButton4ActionPerformed
          }
        }
    }
    public void sinifGetir()
    {
        try {
            
            ResultSet rs=s.st.executeQuery("select *from grup");
          while (rs.next()) {
                
                jComboBox1.addItem(rs.getString("grupNo"));
                
            }
       } catch (Exception ex) {
            JOptionPane.showMessageDialog(rootPane, "MySql Sinif Getirme Hatasi");
        }
    
    }
      
    public static boolean sayiKontrol(String gelen) {
        if (gelen.length() >= 14) {
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
                new ogrenciDersNotuGirme().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JButton jButton3;
    private javax.swing.JButton jButton4;
    private javax.swing.JComboBox<String> jComboBox1;
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
    private javax.swing.JPanel jPanel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JSeparator jSeparator1;
    private javax.swing.JTable jTable1;
    private javax.swing.JTextField jTextField1;
    private javax.swing.JTextField jTextField2;
    private javax.swing.JLabel lbladi;
    private javax.swing.JLabel lblogrenciid;
    private javax.swing.JLabel lblsoyadi;
    private javax.swing.JLabel lbltc;
    // End of variables declaration//GEN-END:variables
}
