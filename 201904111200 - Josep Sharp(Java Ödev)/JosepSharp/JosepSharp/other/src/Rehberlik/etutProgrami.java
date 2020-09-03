package Rehberlik;



import java.sql.ResultSet;
import java.sql.SQLException;

import java.util.ArrayList;

import javax.security.auth.callback.ConfirmationCallback;
import javax.swing.DefaultComboBoxModel;

import javax.swing.JOptionPane;
import veritabani.DB;


public class etutProgrami extends javax.swing.JFrame {

    ArrayList<String> ls = new ArrayList<>();
    DefaultComboBoxModel<String> df = null;
    DB s=new DB();
    

    public etutProgrami() {
        initComponents();
        sinifGetir();
        dersGetir();
        hocaGetir();
        
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        pazarSinif11 = new javax.swing.JComboBox<>();
        pazarHoca11 = new javax.swing.JComboBox<>();
        pazarDers11 = new javax.swing.JComboBox<>();
        jLabel8 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        pazarSinif13 = new javax.swing.JComboBox<>();
        pazarHoca13 = new javax.swing.JComboBox<>();
        pazarDers13 = new javax.swing.JComboBox<>();
        pazarSinif15 = new javax.swing.JComboBox<>();
        pazarHoca15 = new javax.swing.JComboBox<>();
        pazarDers15 = new javax.swing.JComboBox<>();
        jPanel2 = new javax.swing.JPanel();
        jLabel9 = new javax.swing.JLabel();
        jLabel10 = new javax.swing.JLabel();
        jLabel11 = new javax.swing.JLabel();
        cumSinif11 = new javax.swing.JComboBox<>();
        cumhoca11 = new javax.swing.JComboBox<>();
        cumders11 = new javax.swing.JComboBox<>();
        jLabel12 = new javax.swing.JLabel();
        jLabel13 = new javax.swing.JLabel();
        jLabel14 = new javax.swing.JLabel();
        cumders13 = new javax.swing.JComboBox<>();
        cumSinif13 = new javax.swing.JComboBox<>();
        cumhoca13 = new javax.swing.JComboBox<>();
        cumders15 = new javax.swing.JComboBox<>();
        cumSinif15 = new javax.swing.JComboBox<>();
        cumhoca15 = new javax.swing.JComboBox<>();
        btnKaydet = new javax.swing.JButton();
        btnAnamenu = new javax.swing.JButton();
        jButton1 = new javax.swing.JButton();
        jButton2 = new javax.swing.JButton();
        jButton3 = new javax.swing.JButton();
        jLabel15 = new javax.swing.JLabel();
        jLabel1 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Etüt Programı Belirleme Paneli");
        setPreferredSize(new java.awt.Dimension(1023, 568));
        setResizable(false);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jPanel1.setBorder(javax.swing.BorderFactory.createTitledBorder(null, "Pazar", javax.swing.border.TitledBorder.DEFAULT_JUSTIFICATION, javax.swing.border.TitledBorder.DEFAULT_POSITION, new java.awt.Font("Tahoma", 1, 14), new java.awt.Color(153, 0, 51))); // NOI18N
        jPanel1.setOpaque(false);
        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(0, 51, 102));
        jLabel3.setText("11.00-12.30");
        jPanel1.add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 50, -1, -1));

        jLabel4.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(0, 51, 102));
        jLabel4.setText("13.00-14.30");
        jPanel1.add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 100, -1, -1));

        jLabel5.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(0, 51, 102));
        jLabel5.setText("15.00-16.30");
        jPanel1.add(jLabel5, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 150, -1, -1));

        jPanel1.add(pazarSinif11, new org.netbeans.lib.awtextra.AbsoluteConstraints(160, 50, 230, -1));

        jPanel1.add(pazarHoca11, new org.netbeans.lib.awtextra.AbsoluteConstraints(450, 50, 230, -1));

        jPanel1.add(pazarDers11, new org.netbeans.lib.awtextra.AbsoluteConstraints(730, 50, 230, -1));

        jLabel8.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel8.setForeground(new java.awt.Color(0, 51, 102));
        jLabel8.setText("Dersler");
        jPanel1.add(jLabel8, new org.netbeans.lib.awtextra.AbsoluteConstraints(820, 10, -1, -1));

        jLabel7.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel7.setForeground(new java.awt.Color(0, 51, 102));
        jLabel7.setText("Öğretmenler");
        jPanel1.add(jLabel7, new org.netbeans.lib.awtextra.AbsoluteConstraints(500, 10, -1, -1));

        jLabel6.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel6.setForeground(new java.awt.Color(0, 51, 102));
        jLabel6.setText("Sınıflar");
        jPanel1.add(jLabel6, new org.netbeans.lib.awtextra.AbsoluteConstraints(250, 10, -1, -1));

        jPanel1.add(pazarSinif13, new org.netbeans.lib.awtextra.AbsoluteConstraints(160, 100, 230, -1));

        jPanel1.add(pazarHoca13, new org.netbeans.lib.awtextra.AbsoluteConstraints(450, 100, 230, -1));

        jPanel1.add(pazarDers13, new org.netbeans.lib.awtextra.AbsoluteConstraints(730, 100, 230, -1));

        jPanel1.add(pazarSinif15, new org.netbeans.lib.awtextra.AbsoluteConstraints(160, 150, 230, -1));

        jPanel1.add(pazarHoca15, new org.netbeans.lib.awtextra.AbsoluteConstraints(450, 150, 230, -1));

        jPanel1.add(pazarDers15, new org.netbeans.lib.awtextra.AbsoluteConstraints(730, 150, 230, -1));

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 280, 980, 180));

        jPanel2.setBorder(javax.swing.BorderFactory.createTitledBorder(null, "Cumartesi", javax.swing.border.TitledBorder.DEFAULT_JUSTIFICATION, javax.swing.border.TitledBorder.DEFAULT_POSITION, new java.awt.Font("Tahoma", 1, 14), new java.awt.Color(153, 0, 51))); // NOI18N
        jPanel2.setOpaque(false);
        jPanel2.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jLabel9.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel9.setForeground(new java.awt.Color(0, 51, 102));
        jLabel9.setText("11.00-12.30");
        jPanel2.add(jLabel9, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 50, -1, -1));

        jLabel10.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel10.setForeground(new java.awt.Color(0, 51, 102));
        jLabel10.setText("13.00-14.30");
        jPanel2.add(jLabel10, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 100, -1, -1));

        jLabel11.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel11.setForeground(new java.awt.Color(0, 51, 102));
        jLabel11.setText("15.00-16.30");
        jPanel2.add(jLabel11, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 150, -1, -1));

        jPanel2.add(cumSinif11, new org.netbeans.lib.awtextra.AbsoluteConstraints(160, 50, 230, -1));

        jPanel2.add(cumhoca11, new org.netbeans.lib.awtextra.AbsoluteConstraints(450, 50, 230, -1));

        jPanel2.add(cumders11, new org.netbeans.lib.awtextra.AbsoluteConstraints(730, 50, 230, -1));

        jLabel12.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel12.setForeground(new java.awt.Color(0, 51, 102));
        jLabel12.setText("Dersler");
        jPanel2.add(jLabel12, new org.netbeans.lib.awtextra.AbsoluteConstraints(820, 10, -1, -1));

        jLabel13.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel13.setForeground(new java.awt.Color(0, 51, 102));
        jLabel13.setText("Öğretmenler");
        jPanel2.add(jLabel13, new org.netbeans.lib.awtextra.AbsoluteConstraints(500, 10, -1, -1));

        jLabel14.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel14.setForeground(new java.awt.Color(0, 51, 102));
        jLabel14.setText("Sınıflar");
        jPanel2.add(jLabel14, new org.netbeans.lib.awtextra.AbsoluteConstraints(250, 10, -1, -1));

        jPanel2.add(cumders13, new org.netbeans.lib.awtextra.AbsoluteConstraints(730, 100, 230, -1));

        jPanel2.add(cumSinif13, new org.netbeans.lib.awtextra.AbsoluteConstraints(160, 100, 230, -1));

        jPanel2.add(cumhoca13, new org.netbeans.lib.awtextra.AbsoluteConstraints(450, 100, 230, -1));

        jPanel2.add(cumders15, new org.netbeans.lib.awtextra.AbsoluteConstraints(730, 150, 230, -1));

        jPanel2.add(cumSinif15, new org.netbeans.lib.awtextra.AbsoluteConstraints(160, 150, 230, -1));

        jPanel2.add(cumhoca15, new org.netbeans.lib.awtextra.AbsoluteConstraints(450, 150, 230, -1));

        getContentPane().add(jPanel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 80, 980, 180));

        btnKaydet.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnKaydet.setForeground(new java.awt.Color(0, 51, 102));
        btnKaydet.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/kaydet.png"))); // NOI18N
        btnKaydet.setText("Kaydet");
        btnKaydet.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnKaydetActionPerformed(evt);
            }
        });
        getContentPane().add(btnKaydet, new org.netbeans.lib.awtextra.AbsoluteConstraints(330, 480, 147, 41));

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
        getContentPane().add(btnAnamenu, new org.netbeans.lib.awtextra.AbsoluteConstraints(910, 10, 100, -1));

        jButton1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton1.setForeground(new java.awt.Color(0, 51, 102));
        jButton1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/guncelle.png"))); // NOI18N
        jButton1.setText("Güncelle");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton1, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 480, 147, 41));

        jButton2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton2.setForeground(new java.awt.Color(0, 51, 102));
        jButton2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/dersprogram.png"))); // NOI18N
        jButton2.setText("Etüt Programları");
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton2, new org.netbeans.lib.awtextra.AbsoluteConstraints(720, 480, 190, 41));

        jButton3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton3.setForeground(new java.awt.Color(0, 51, 102));
        jButton3.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/verileri sıfırla.png"))); // NOI18N
        jButton3.setText("Verileri Sıfırla");
        jButton3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton3ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton3, new org.netbeans.lib.awtextra.AbsoluteConstraints(510, 480, 170, 41));

        jLabel15.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel15.setForeground(new java.awt.Color(153, 0, 51));
        jLabel15.setText("Etüt Programı Belirleme Paneli");
        getContentPane().add(jLabel15, new org.netbeans.lib.awtextra.AbsoluteConstraints(380, 40, -1, -1));

        jLabel1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        getContentPane().add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 1020, 570));

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void btnAnamenuActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAnamenuActionPerformed
        Rehberlik mt=new Rehberlik();
        mt.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_btnAnamenuActionPerformed

    private void btnKaydetActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnKaydetActionPerformed
        
        String ders2 = "11.00-12.30";
        String ders3 = "13.00-14.30";
        String ders4 = "15.00-16.30";
        
        String cumsinif11=cumSinif11.getSelectedItem().toString();
        String cumsinif13=cumSinif13.getSelectedItem().toString();
        String cumsinif15=cumSinif15.getSelectedItem().toString();
        
        String cumderss11=cumders11.getSelectedItem().toString();
        String cumderss13=cumders13.getSelectedItem().toString();
        String cumderss15=cumders15.getSelectedItem().toString();
          
        String cumhocaa11=cumhoca11.getSelectedItem().toString();
        String cumhocaa13=cumhoca13.getSelectedItem().toString();
        String cumhocaa15=cumhoca15.getSelectedItem().toString();  
        
        String pazarsinif11=pazarSinif11.getSelectedItem().toString();
        String pazarsinif13=pazarSinif13.getSelectedItem().toString();
        String pazarsinif15=pazarSinif15.getSelectedItem().toString();
        
        String pazarderss11=pazarDers11.getSelectedItem().toString();
        String pazarderss13=pazarDers13.getSelectedItem().toString();
        String pazarderss15=pazarDers15.getSelectedItem().toString();
          
        String pazarhocaa11=pazarHoca11.getSelectedItem().toString();
        String pazarhocaa13=pazarHoca13.getSelectedItem().toString();
        String pazarhocaa15=pazarHoca15.getSelectedItem().toString();
        
       
        
         int ali=-1;
        try {
            ResultSet rs=s.st.executeQuery("select *from etut");
            while (rs.next()) {                
                ali=Integer.valueOf(rs.getString("etutID"));
            }
        } catch (SQLException ex) {
            
        }
        if(ali!=3){
        try {
            boolean rs = s.st.execute("call etutprog1 (null,'" + ders2 + "','" + cumsinif11 + "', '" + cumhocaa11 + "', '" + cumderss11 + "','" + pazarsinif11 + "', '" + pazarhocaa11 + "', '" + pazarderss11 + "')");
            boolean ts = s.st.execute("call etutprog1 (null,'" + ders3 + "','" + cumsinif13 + "', '" + cumhocaa13+ "', '" + cumderss13 + "','" + pazarsinif13 + "', '" + pazarhocaa13 + "', '" + pazarderss13 + "')");
            boolean fs = s.st.execute("call etutprog1 (null,'" + ders4 + "','" + cumsinif15+ "', '" + cumhocaa15 + "', '" + cumderss15 + "','" + pazarsinif15 + "', '" + pazarhocaa15 + "', '" + pazarderss15 + "')");
            JOptionPane.showMessageDialog(rootPane, "Ekleme Başarılı");
        } catch (Exception e) {
            JOptionPane.showMessageDialog(rootPane, "Ekleme Başarısız");
        }
        } else{
        
        JOptionPane.showMessageDialog(rootPane, "Kayıt mevcut lütfen güncelleme yapınız ");
        }
        
        
        
    }//GEN-LAST:event_btnKaydetActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
       String ders2 = "11.00-12.30";
        String ders3 = "13.00-14.30";
        String ders4 = "15.00-16.30";
        
        String cumsinif11=cumSinif11.getSelectedItem().toString();
        String cumsinif13=cumSinif13.getSelectedItem().toString();
        String cumsinif15=cumSinif15.getSelectedItem().toString();
        
        String cumderss11=cumders11.getSelectedItem().toString();
        String cumderss13=cumders13.getSelectedItem().toString();
        String cumderss15=cumders15.getSelectedItem().toString();
          
        String cumhocaa11=cumhoca11.getSelectedItem().toString();
        String cumhocaa13=cumhoca13.getSelectedItem().toString();
        String cumhocaa15=cumhoca15.getSelectedItem().toString();  
        
        String pazarsinif11=pazarSinif11.getSelectedItem().toString();
        String pazarsinif13=pazarSinif13.getSelectedItem().toString();
        String pazarsinif15=pazarSinif15.getSelectedItem().toString();
        
        String pazarderss11=pazarDers11.getSelectedItem().toString();
        String pazarderss13=pazarDers13.getSelectedItem().toString();
        String pazarderss15=pazarDers15.getSelectedItem().toString();
          
        String pazarhocaa11=pazarHoca11.getSelectedItem().toString();
        String pazarhocaa13=pazarHoca13.getSelectedItem().toString();
        String pazarhocaa15=pazarHoca15.getSelectedItem().toString();
        
        
        int ali=-1;
        try {
            ResultSet rs=s.st.executeQuery("select *from etut");
            while (rs.next()) {                
                ali=Integer.valueOf(rs.getString("etutID"));
            }
        } catch (SQLException ex) {
            
        }
        if(ali==3){
        
        
         
               try {  
                   
            boolean rs = s.st.execute("update  etut set cumartesiSinif='"+cumsinif11+"',cumartesiOgretmen='"+cumhocaa11+"',cumartesiDers='"+cumderss11+"',pazarSinif='"+pazarsinif11+"',pazarOgretmen='"+pazarhocaa11+"',pazarDers='"+pazarderss11+"' where etutID=1");
          boolean ss = s.st.execute("update  etut set cumartesiSinif='"+cumsinif13+"',cumartesiOgretmen='"+cumhocaa13+"',cumartesiDers='"+cumderss13+"',pazarSinif='"+pazarsinif13+"',pazarOgretmen='"+pazarhocaa13+"',pazarDers='"+pazarderss13+"' where etutID=2");
          boolean fs = s.st.execute("update  etut set cumartesiSinif='"+cumsinif15+"',cumartesiOgretmen='"+cumhocaa15+"',cumartesiDers='"+cumderss15+"',pazarSinif='"+pazarsinif15+"',pazarOgretmen='"+pazarhocaa15+"',pazarDers='"+pazarderss15+"' where etutID=3");
                   
            JOptionPane.showMessageDialog(rootPane, "Güncelleme Başarılı");
            
        } catch (Exception e) {
            JOptionPane.showMessageDialog(rootPane, "Güncelleme Başarısız");
        }

            
        }
        else{
            JOptionPane.showMessageDialog(rootPane, "Lütfen Kayıt Ediniz");
        
        }
        
    }//GEN-LAST:event_jButton1ActionPerformed

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
       etutProgramlari mt = new etutProgramlari();
        mt.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_jButton2ActionPerformed

    private void jButton3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton3ActionPerformed
        
        int cevap=JOptionPane.showConfirmDialog(rootPane,"Silmek İstediğinize Eminmisiniz","Verileri Sıfırlama Uyarısı",ConfirmationCallback.YES_NO_OPTION);
        if(cevap==0)
        {
        
        try {
            boolean bjk=s.st.execute("Truncate etut");
            JOptionPane.showMessageDialog(rootPane,"Etüt Programı Sifirlandi");
        } catch (Exception e) {
        }
        }
    }//GEN-LAST:event_jButton3ActionPerformed
 public void sinifGetir() {
        
        try {
            ResultSet rs = s.st.executeQuery("select *from grup");

            while (rs.next()) {
                cumSinif11.addItem(rs.getString("grupNo"));
                cumSinif13.addItem(rs.getString("grupNo"));
                cumSinif15.addItem(rs.getString("grupNo"));
                
                pazarSinif11.addItem(rs.getString("grupNo"));
                pazarSinif13.addItem(rs.getString("grupNo"));
                pazarSinif15.addItem(rs.getString("grupNo"));

            }

        } catch (Exception e) {
        }

    }
 
  public void dersGetir() {
       
        try {
            ResultSet rs = s.st.executeQuery("select *from grup");

            while (rs.next()) {
                cumders11.addItem(rs.getString("grupAciklama"));
                cumders13.addItem(rs.getString("grupAciklama"));
                cumders15.addItem(rs.getString("grupAciklama"));
                
                pazarDers11.addItem(rs.getString("grupAciklama"));
                pazarDers13.addItem(rs.getString("grupAciklama"));
                pazarDers15.addItem(rs.getString("grupAciklama"));

            }

        } catch (Exception e) {
        }

    }
 
 
  public void hocaGetir() {
        
        try {
            ResultSet rs =s.st.executeQuery("select *from ogretmen");

            while (rs.next()) {
                
                String adi=rs.getString("ogretmenAdi");
                String soyadi= rs.getString("ogretmenSoyadi");
               adi+=" "+soyadi;
               cumhoca11.addItem(adi);
               cumhoca13.addItem(adi);
               cumhoca15.addItem(adi);
               
               pazarHoca11.addItem(adi);
               pazarHoca13.addItem(adi);
               pazarHoca15.addItem(adi);
               
               adi="";
               soyadi="";

            }

        } catch (Exception e) {
        }

    }
    
    
    
    
    
    
    public static void main(String args[]) {
     
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new etutProgrami().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnAnamenu;
    private javax.swing.JButton btnKaydet;
    private javax.swing.JComboBox<String> cumSinif11;
    private javax.swing.JComboBox<String> cumSinif13;
    private javax.swing.JComboBox<String> cumSinif15;
    private javax.swing.JComboBox<String> cumders11;
    private javax.swing.JComboBox<String> cumders13;
    private javax.swing.JComboBox<String> cumders15;
    private javax.swing.JComboBox<String> cumhoca11;
    private javax.swing.JComboBox<String> cumhoca13;
    private javax.swing.JComboBox<String> cumhoca15;
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JButton jButton3;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel11;
    private javax.swing.JLabel jLabel12;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JLabel jLabel14;
    private javax.swing.JLabel jLabel15;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JComboBox<String> pazarDers11;
    private javax.swing.JComboBox<String> pazarDers13;
    private javax.swing.JComboBox<String> pazarDers15;
    private javax.swing.JComboBox<String> pazarHoca11;
    private javax.swing.JComboBox<String> pazarHoca13;
    private javax.swing.JComboBox<String> pazarHoca15;
    private javax.swing.JComboBox<String> pazarSinif11;
    private javax.swing.JComboBox<String> pazarSinif13;
    private javax.swing.JComboBox<String> pazarSinif15;
    // End of variables declaration//GEN-END:variables
}
