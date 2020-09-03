package Rehberlik;


import java.awt.Component;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.security.auth.callback.ConfirmationCallback;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JComboBox;
import javax.swing.JOptionPane;
import veritabani.DB;


public class ogretmenDersProgrami extends javax.swing.JFrame {

    public ogretmenDersProgrami() {
        initComponents();
        tumCombo();
        ogretmenGetir();
        ArryListekle();
    }
    DB s= new DB();
    Connection conn = null;
    Statement st = null;
    DefaultComboBoxModel<String> df = null;
    ArrayList<String> ls = new ArrayList<>();
   

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        carsamba09 = new javax.swing.JComboBox<>();
        persembe09 = new javax.swing.JComboBox<>();
        cuma09 = new javax.swing.JComboBox<>();
        pazartesi11 = new javax.swing.JComboBox<>();
        sali11 = new javax.swing.JComboBox<>();
        carsamba11 = new javax.swing.JComboBox<>();
        persembe11 = new javax.swing.JComboBox<>();
        cuma11 = new javax.swing.JComboBox<>();
        pazartesi13 = new javax.swing.JComboBox<>();
        sali13 = new javax.swing.JComboBox<>();
        jLabel1 = new javax.swing.JLabel();
        carsamba13 = new javax.swing.JComboBox<>();
        jLabel2 = new javax.swing.JLabel();
        pazartesi15 = new javax.swing.JComboBox<>();
        jLabel3 = new javax.swing.JLabel();
        sali15 = new javax.swing.JComboBox<>();
        jLabel4 = new javax.swing.JLabel();
        carsamba15 = new javax.swing.JComboBox<>();
        jLabel5 = new javax.swing.JLabel();
        persembe13 = new javax.swing.JComboBox<>();
        jLabel6 = new javax.swing.JLabel();
        cuma15 = new javax.swing.JComboBox<>();
        jLabel7 = new javax.swing.JLabel();
        cuma13 = new javax.swing.JComboBox<>();
        jLabel8 = new javax.swing.JLabel();
        persembe15 = new javax.swing.JComboBox<>();
        jLabel9 = new javax.swing.JLabel();
        pazartesi09 = new javax.swing.JComboBox<>();
        sali09 = new javax.swing.JComboBox<>();
        jSeparator1 = new javax.swing.JSeparator();
        jSeparator2 = new javax.swing.JSeparator();
        jSeparator3 = new javax.swing.JSeparator();
        jSeparator4 = new javax.swing.JSeparator();
        jLabel12 = new javax.swing.JLabel();
        btnKaydet = new javax.swing.JButton();
        btnAnamenu = new javax.swing.JButton();
        jLabel10 = new javax.swing.JLabel();
        btnkaydet = new javax.swing.JButton();
        combo = new javax.swing.JComboBox<>();
        jButton1 = new javax.swing.JButton();
        Sifirla = new javax.swing.JButton();
        jLabel13 = new javax.swing.JLabel();
        jLabel11 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Öğretmen Ders Programı Paneli");
        setPreferredSize(new java.awt.Dimension(850, 568));
        setResizable(false);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jPanel1.setOpaque(false);
        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        carsamba09.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(carsamba09, new org.netbeans.lib.awtextra.AbsoluteConstraints(460, 60, -1, -1));

        persembe09.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(persembe09, new org.netbeans.lib.awtextra.AbsoluteConstraints(600, 60, -1, -1));

        cuma09.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(cuma09, new org.netbeans.lib.awtextra.AbsoluteConstraints(730, 60, -1, -1));

        pazartesi11.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(pazartesi11, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 120, -1, -1));

        sali11.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(sali11, new org.netbeans.lib.awtextra.AbsoluteConstraints(330, 120, -1, -1));

        carsamba11.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(carsamba11, new org.netbeans.lib.awtextra.AbsoluteConstraints(460, 120, -1, -1));

        persembe11.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(persembe11, new org.netbeans.lib.awtextra.AbsoluteConstraints(600, 120, -1, -1));

        cuma11.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(cuma11, new org.netbeans.lib.awtextra.AbsoluteConstraints(730, 120, -1, -1));

        pazartesi13.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(pazartesi13, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 180, -1, -1));

        sali13.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(sali13, new org.netbeans.lib.awtextra.AbsoluteConstraints(330, 180, -1, -1));

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 51, 102));
        jLabel1.setText("Pazartesi ");
        jPanel1.add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 10, -1, -1));

        carsamba13.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(carsamba13, new org.netbeans.lib.awtextra.AbsoluteConstraints(460, 180, -1, -1));

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(0, 51, 102));
        jLabel2.setText("Sali");
        jPanel1.add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(340, 10, -1, -1));

        pazartesi15.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(pazartesi15, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 250, -1, -1));

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(0, 51, 102));
        jLabel3.setText("Çarşamba");
        jPanel1.add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(460, 10, -1, -1));

        sali15.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(sali15, new org.netbeans.lib.awtextra.AbsoluteConstraints(330, 250, -1, -1));

        jLabel4.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(0, 51, 102));
        jLabel4.setText("Perşembe");
        jPanel1.add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(600, 10, -1, -1));

        carsamba15.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(carsamba15, new org.netbeans.lib.awtextra.AbsoluteConstraints(460, 250, -1, -1));

        jLabel5.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(0, 51, 102));
        jLabel5.setText("Cuma");
        jPanel1.add(jLabel5, new org.netbeans.lib.awtextra.AbsoluteConstraints(740, 10, -1, -1));

        persembe13.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(persembe13, new org.netbeans.lib.awtextra.AbsoluteConstraints(600, 180, -1, -1));

        jLabel6.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel6.setForeground(new java.awt.Color(0, 51, 102));
        jLabel6.setText("09.00-10.30");
        jPanel1.add(jLabel6, new org.netbeans.lib.awtextra.AbsoluteConstraints(80, 60, -1, -1));

        cuma15.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(cuma15, new org.netbeans.lib.awtextra.AbsoluteConstraints(730, 250, -1, -1));

        jLabel7.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel7.setForeground(new java.awt.Color(0, 51, 102));
        jLabel7.setText("11.00-12.30");
        jPanel1.add(jLabel7, new org.netbeans.lib.awtextra.AbsoluteConstraints(80, 120, -1, -1));

        cuma13.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(cuma13, new org.netbeans.lib.awtextra.AbsoluteConstraints(730, 180, -1, -1));

        jLabel8.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel8.setForeground(new java.awt.Color(0, 51, 102));
        jLabel8.setText("13.00-14.30");
        jPanel1.add(jLabel8, new org.netbeans.lib.awtextra.AbsoluteConstraints(80, 180, -1, -1));

        persembe15.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(persembe15, new org.netbeans.lib.awtextra.AbsoluteConstraints(600, 250, -1, -1));

        jLabel9.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel9.setForeground(new java.awt.Color(0, 51, 102));
        jLabel9.setText("15.00-16.30");
        jPanel1.add(jLabel9, new org.netbeans.lib.awtextra.AbsoluteConstraints(80, 250, -1, -1));

        pazartesi09.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(pazartesi09, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 60, -1, -1));

        sali09.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        jPanel1.add(sali09, new org.netbeans.lib.awtextra.AbsoluteConstraints(330, 60, -1, -1));
        jPanel1.add(jSeparator1, new org.netbeans.lib.awtextra.AbsoluteConstraints(190, 30, 610, 10));
        jPanel1.add(jSeparator2, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 100, 759, 10));
        jPanel1.add(jSeparator3, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 160, 759, 10));
        jPanel1.add(jSeparator4, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 220, 759, 10));

        jLabel12.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel12.setForeground(new java.awt.Color(153, 0, 51));
        jLabel12.setText("Öğretmen Ders Programı");
        jPanel1.add(jLabel12, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 10, 160, -1));

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 160, 830, 290));

        btnKaydet.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnKaydet.setForeground(new java.awt.Color(0, 51, 102));
        btnKaydet.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/guncelle.png"))); // NOI18N
        btnKaydet.setText("Güncelle");
        btnKaydet.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnKaydetActionPerformed(evt);
            }
        });
        getContentPane().add(btnKaydet, new org.netbeans.lib.awtextra.AbsoluteConstraints(200, 470, -1, 40));

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

        jLabel10.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel10.setForeground(new java.awt.Color(0, 51, 102));
        jLabel10.setText("Öğretmen Seçiniz :");
        getContentPane().add(jLabel10, new org.netbeans.lib.awtextra.AbsoluteConstraints(50, 110, -1, -1));

        btnkaydet.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnkaydet.setForeground(new java.awt.Color(0, 51, 102));
        btnkaydet.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/kaydet.png"))); // NOI18N
        btnkaydet.setText("Kaydet");
        btnkaydet.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnkaydetActionPerformed(evt);
            }
        });
        getContentPane().add(btnkaydet, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 470, -1, 40));

        getContentPane().add(combo, new org.netbeans.lib.awtextra.AbsoluteConstraints(200, 110, 270, -1));

        jButton1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton1.setForeground(new java.awt.Color(0, 51, 102));
        jButton1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/ogretmenders.png"))); // NOI18N
        jButton1.setText("Ögretmenin Ders Programı");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton1, new org.netbeans.lib.awtextra.AbsoluteConstraints(560, 470, -1, 40));

        Sifirla.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        Sifirla.setForeground(new java.awt.Color(0, 51, 102));
        Sifirla.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/verileri sıfırla.png"))); // NOI18N
        Sifirla.setText("Verileri Sıfırla");
        Sifirla.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                SifirlaActionPerformed(evt);
            }
        });
        getContentPane().add(Sifirla, new org.netbeans.lib.awtextra.AbsoluteConstraints(360, 470, 160, 40));

        jLabel13.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel13.setForeground(new java.awt.Color(153, 0, 51));
        jLabel13.setText("Öğretmen Ders Programı Paneli");
        getContentPane().add(jLabel13, new org.netbeans.lib.awtextra.AbsoluteConstraints(300, 40, -1, -1));

        jLabel11.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        getContentPane().add(jLabel11, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 850, 570));

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void btnAnamenuActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAnamenuActionPerformed
        Rehberlik mt=new Rehberlik();
        mt.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_btnAnamenuActionPerformed

    private void btnKaydetActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnKaydetActionPerformed
        guncelle();
    }//GEN-LAST:event_btnKaydetActionPerformed

    private void btnkaydetActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnkaydetActionPerformed
        ekleLutfen();
    }//GEN-LAST:event_btnkaydetActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        ogretmenprogramlar mt=new ogretmenprogramlar();
        mt.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_jButton1ActionPerformed

    private void SifirlaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_SifirlaActionPerformed
        
        int cevap=JOptionPane.showConfirmDialog(rootPane,"Silmek İstediğinize Eminmisiniz","Verileri Sıfırlama Uyarısı",ConfirmationCallback.YES_NO_OPTION);
        if(cevap==0)
        {
        
        try {
            boolean bjk=s.st.execute("Truncate ogretmendersprog");
            JOptionPane.showMessageDialog(rootPane,"Tüm Öğretmen Ders Programlari Sifirlandi");
        } catch (Exception e) {
        }
        }
    }//GEN-LAST:event_SifirlaActionPerformed
    public boolean tumCombo() {
        boolean durum = false;
        Component[] comDizi = jPanel1.getComponents();
        for (Component component : comDizi) {
            if (component instanceof JComboBox) {
                JComboBox combo = (JComboBox) component;
               
                   try {
                    df = new DefaultComboBoxModel<>();
                    df.addElement("Ders yok");
                    ResultSet rs = s.st.executeQuery("select *from grup");
                    while (rs.next()) {

                        
                        df.addElement(rs.getString("grupNo"));

                        combo.setModel(df);
                    }
                    durum = true;
                } catch (Exception e) {
                    JOptionPane.showMessageDialog(rootPane, "MySql Sinif Getirme Hatasi");
                }

            }
        }
        return durum;
    } 
    public  boolean sinifVarmi(String sinif) throws SQLException {
        
        ResultSet rs = null;
        boolean durum = false;
        System.out.println(sinif);
        
        try {
            rs = s.st.executeQuery("select COUNT(*) as sayi FROM ogretmendersprog where Ogretmen = '"+sinif+"' ");
            rs.next();
            if(rs.getInt("sayi") > 0) durum = false; else durum = true;
        } catch (SQLException ex) {
            Logger.getLogger(OgrenciDersProgramiOlustur.class.getName()).log(Level.SEVERE, null, ex);
        }
        return durum;
    }
    public void ogretmenGetir() {
      
        try {
            ResultSet rs=s.st.executeQuery("select *from ogretmen");
            while (rs.next()) {
              String ali=rs.getString("ogretmenAdi");
              String soyAdi=rs.getString("ogretmenSoyadi");
              ali+=" "+soyAdi;
              combo.addItem(ali);
              ali="";
              soyAdi="";
              
            }
        } catch (Exception e) {
        }

        
    }
    public void ekleLutfen() {
       String ogretmen = combo.getSelectedItem().toString();
        
        try {
            if(sinifVarmi(ogretmen)){
                
                String ders1 = "09.00-10.30";
                String ders2 = "11.00-12.30";
                String ders3 = "13.00-14.30";
                String ders4 = "15.00-16.30";
                String pazartesi9 = pazartesi09.getSelectedItem().toString();
                String pazartesi1 = pazartesi11.getSelectedItem().toString();
                String pazartesi3 = pazartesi13.getSelectedItem().toString();
                String pazartesi5 = pazartesi15.getSelectedItem().toString();
                
                String sali9 = sali09.getSelectedItem().toString();
                String sali1 = sali11.getSelectedItem().toString();
                String sali3 = sali13.getSelectedItem().toString();
                String sali5 = sali15.getSelectedItem().toString();
                
                String carsamba9 = carsamba09.getSelectedItem().toString();
                String carsamba1 = carsamba11.getSelectedItem().toString();
                String carsamba3 = carsamba13.getSelectedItem().toString();
                String carsamba5 = carsamba15.getSelectedItem().toString();
                
                String persembe9 = persembe09.getSelectedItem().toString();
                String persembe1 = persembe11.getSelectedItem().toString();
                String persembe3 = persembe13.getSelectedItem().toString();
                String persembe5 = persembe15.getSelectedItem().toString();
                
                String cuma9 = cuma09.getSelectedItem().toString();
                String cuma1 = cuma11.getSelectedItem().toString();
                String cuma3 = cuma13.getSelectedItem().toString();
                String cuma5 = cuma15.getSelectedItem().toString();
               
                try {
                   
                    boolean rs = s.st.execute("call ogretmendersprogekle1(null,'" + ders1 + "',  '" + ogretmen + "', '" + pazartesi9 + "', '" + sali9 + "', '" + carsamba9 + "', '" + persembe9 + "','" + cuma9 + "')");
                    boolean ts = s.st.execute("call ogretmendersprogekle1(null,'" + ders2 + "',  '" + ogretmen + "', '" + pazartesi1 + "', '" + sali1 + "', '" + carsamba1 + "', '" + persembe1 + "','" + cuma1 + "')");
                    boolean fs =s.st.execute("call ogretmendersprogekle1(null,'" + ders3 + "',  '" + ogretmen + "', '" + pazartesi3 + "', '" + sali3 + "', '" + carsamba3 + "', '" + persembe3 + "','" + cuma3 + "')");
                    boolean gs = s.st.execute("call ogretmendersprogekle1(null,'" + ders4 + "',  '" + ogretmen + "', '" + pazartesi5 + "', '" + sali5 + "', '" + carsamba5 + "', '" + persembe5 + "','" + cuma5 + "')");
                    JOptionPane.showMessageDialog(rootPane, "Ekleme Başarılı");
                } catch (Exception e) {
                    JOptionPane.showMessageDialog(rootPane, "Ekleme Başarısiz");
                }
           
            }
            else{
            JOptionPane.showMessageDialog(rootPane, "Bu Ögretmenin Ders Programı kayıtlı!!Güncelleme yapınız");
            
            }
        } catch (SQLException ex) {
            Logger.getLogger(OgrenciDersProgramiOlustur.class.getName()).log(Level.SEVERE, null, ex);
        }

    }
    public void guncelle(){
    String ogretmen = combo.getSelectedItem().toString();
        try {
            if(!sinifVarmi(ogretmen)){
                String ders1 = "09.00-10.30";
                String ders2 = "11.00-12.30";
                String ders3 = "13.00-14.30";
                String ders4 = "15.00-16.30";
                String pazartesi9 = pazartesi09.getSelectedItem().toString();
                String pazartesi1 = pazartesi11.getSelectedItem().toString();
                String pazartesi3 = pazartesi13.getSelectedItem().toString();
                String pazartesi5 = pazartesi15.getSelectedItem().toString();
                
                String sali9 = sali09.getSelectedItem().toString();
                String sali1 = sali11.getSelectedItem().toString();
                String sali3 = sali13.getSelectedItem().toString();
                String sali5 = sali15.getSelectedItem().toString();
                
                String carsamba9 = carsamba09.getSelectedItem().toString();
                String carsamba1 = carsamba11.getSelectedItem().toString();
                String carsamba3 = carsamba13.getSelectedItem().toString();
                String carsamba5 = carsamba15.getSelectedItem().toString();
                
                String persembe9 = persembe09.getSelectedItem().toString();
                String persembe1 = persembe11.getSelectedItem().toString();
                String persembe3 = persembe13.getSelectedItem().toString();
                String persembe5 = persembe15.getSelectedItem().toString();
                
                String cuma9 = cuma09.getSelectedItem().toString();
                String cuma1 = cuma11.getSelectedItem().toString();
                String cuma3 = cuma13.getSelectedItem().toString();
                String cuma5 = cuma15.getSelectedItem().toString();
                
                
                for (int i = 0; i < ls.size(); i++) {
                    
                    if (ls.get(i).equals(ogretmen)) {
                        System.out.println(i);
                        try {
                            
                            boolean fb = s.st.execute("UPDATE ogretmendersprog SET Ogretmen='" + ogretmen + "' ,Pazartesi='" + pazartesi9 + "',Sali='" + sali9 + "',Carsamba='" + carsamba9 + "',Persembe='" + persembe9 + "',Cuma='" + cuma9 + "' where ogretmenProID='" + (i + 1) + "'");
                            boolean gs = s.st.execute("UPDATE ogretmendersprog SET Ogretmen='" + ogretmen + "' ,Pazartesi='" + pazartesi3 + "',Sali='" + sali3 + "',Carsamba='" + carsamba3 + "',Persembe='" + persembe3 + "',Cuma='" + cuma3 + "' where ogretmenProID='" + (i + 2) + "'");
                            boolean ts = s.st.execute("UPDATE ogretmendersprog SET Ogretmen='" + ogretmen + "' ,Pazartesi='" + pazartesi1 + "',Sali='" + sali1 + "',Carsamba='" + carsamba1 + "',Persembe='" + persembe1 + "',Cuma='" + cuma1 + "' where ogretmenProID='" + (i + 3) + "'");
                            boolean bjk = s.st.execute("UPDATE ogretmendersprog SET Ogretmen='" + ogretmen + "' ,Pazartesi='" + pazartesi5 + "',Sali='" + sali5 + "',Carsamba='" + carsamba5 + "',Persembe='" + persembe5 + "',Cuma='" + cuma5 + "' where ogretmenProID='" + (i + 4) + "'");
                            JOptionPane.showMessageDialog(rootPane, "Güncelleme Başarılı");
                            break;
                        } catch (Exception e) {
                            JOptionPane.showMessageDialog(rootPane, "Özel Güncelleme Başarısiz");
                            break;
                        }
                    }
                }
            }
            else{
            JOptionPane.showMessageDialog(rootPane, "Bu Ögretmene ait kayıtlı ders programı bulunmamaktadır!!Lütfen önce kayıt yapınız");
            }
        
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(rootPane, "Genel Güncelleme Başarısiz");
        }
    }
    
    
    public void ArryListekle()
    {   
      
        try {
            ResultSet rs=s.st.executeQuery("select *from ogretmendersprog");
            while (rs.next()) {
               
               ls.add(rs.getString("Ogretmen"));
                
            }
         
        } catch (Exception e) {
        }
    
    }
    public static void main(String args[]) {
      
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new ogretmenDersProgrami().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton Sifirla;
    private javax.swing.JButton btnAnamenu;
    private javax.swing.JButton btnKaydet;
    private javax.swing.JButton btnkaydet;
    private javax.swing.JComboBox<String> carsamba09;
    private javax.swing.JComboBox<String> carsamba11;
    private javax.swing.JComboBox<String> carsamba13;
    private javax.swing.JComboBox<String> carsamba15;
    private javax.swing.JComboBox<String> combo;
    private javax.swing.JComboBox<String> cuma09;
    private javax.swing.JComboBox<String> cuma11;
    private javax.swing.JComboBox<String> cuma13;
    private javax.swing.JComboBox<String> cuma15;
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel11;
    private javax.swing.JLabel jLabel12;
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
    private javax.swing.JSeparator jSeparator1;
    private javax.swing.JSeparator jSeparator2;
    private javax.swing.JSeparator jSeparator3;
    private javax.swing.JSeparator jSeparator4;
    private javax.swing.JComboBox<String> pazartesi09;
    private javax.swing.JComboBox<String> pazartesi11;
    private javax.swing.JComboBox<String> pazartesi13;
    private javax.swing.JComboBox<String> pazartesi15;
    private javax.swing.JComboBox<String> persembe09;
    private javax.swing.JComboBox<String> persembe11;
    private javax.swing.JComboBox<String> persembe13;
    private javax.swing.JComboBox<String> persembe15;
    private javax.swing.JComboBox<String> sali09;
    private javax.swing.JComboBox<String> sali11;
    private javax.swing.JComboBox<String> sali13;
    private javax.swing.JComboBox<String> sali15;
    // End of variables declaration//GEN-END:variables
}
