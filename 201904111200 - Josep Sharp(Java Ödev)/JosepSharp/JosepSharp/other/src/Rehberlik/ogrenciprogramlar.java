package Rehberlik;


import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import veritabani.DB;


public class ogrenciprogramlar extends javax.swing.JFrame {
    DB s= new DB();
    DefaultComboBoxModel<String> df=new DefaultComboBoxModel<>();
   DefaultTableModel dt = new DefaultTableModel();
   Connection conn = null;
    Statement st = null;

   
    public ogrenciprogramlar() {
        initComponents();
       
        dt.addColumn("Saatler");
        dt.addColumn("Siniflar");
        dt.addColumn("Pazartesi");
        dt.addColumn("Sali");
        dt.addColumn("Çarşamba");
        dt.addColumn("Perşembe");
        dt.addColumn("Cuma");
        tablo.setModel(dt);
        df.setSelectedItem("Lütfen Sınıf Seç");
        combo.setModel(df);
        sinifGetir();
        
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        tablo = new javax.swing.JTable();
        combo = new javax.swing.JComboBox<>();
        jLabel1 = new javax.swing.JLabel();
        jButton1 = new javax.swing.JButton();
        jLabel13 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Öğrenci Programlar Paneli");
        setResizable(false);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        tablo.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {},
                {},
                {},
                {}
            },
            new String [] {

            }
        ));
        jScrollPane1.setViewportView(tablo);

        getContentPane().add(jScrollPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(35, 184, 680, 280));

        combo.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                comboItemStateChanged(evt);
            }
        });
        getContentPane().add(combo, new org.netbeans.lib.awtextra.AbsoluteConstraints(160, 120, 356, -1));

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 51, 102));
        jLabel1.setText("Sınıf Seçiniz :");
        getContentPane().add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(51, 123, -1, -1));

        jButton1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton1.setForeground(new java.awt.Color(0, 51, 102));
        jButton1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1466161311_agt_back.png"))); // NOI18N
        jButton1.setText("Geri ");
        jButton1.setBorder(null);
        jButton1.setBorderPainted(false);
        jButton1.setContentAreaFilled(false);
        jButton1.setFocusable(false);
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton1, new org.netbeans.lib.awtextra.AbsoluteConstraints(640, 10, 100, -1));

        jLabel13.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel13.setForeground(new java.awt.Color(153, 0, 51));
        jLabel13.setText("Öğrenci Programları Paneli");
        getContentPane().add(jLabel13, new org.netbeans.lib.awtextra.AbsoluteConstraints(260, 50, -1, -1));

        jLabel2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        getContentPane().add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 750, 500));

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents
     int comboSecim=-1;
    private void comboItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_comboItemStateChanged
       dt.setRowCount(0);
        comboSecim = combo.getSelectedIndex()+1;
        String aga=combo.getSelectedItem().toString();
        try {
            
         ResultSet rs=s.st.executeQuery("select *from ogrencidersprog where sinifGrupAciklama='"+aga+"'");
            
          while (rs.next()) {
                
                dt.addRow(new String[]{rs.getString("Saatler"), rs.getString("sinifGrupAciklama"), rs.getString("Pazartesi"), rs.getString("Sali"), rs.getString("Carsamba"), rs.getString("Persembe"), rs.getString("Cuma")});
          }
          
          }
         
         catch (Exception e) {
        } 
    }//GEN-LAST:event_comboItemStateChanged

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        OgrenciDersProgramiOlustur mt=new OgrenciDersProgramiOlustur();
        mt.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_jButton1ActionPerformed
          public void sinifGetir()
    {
        try {
           
            ResultSet rs=s.st.executeQuery("select *from grup");
          while (rs.next()) {
                
                combo.addItem(rs.getString("grupNo"));
                
            }
       } catch (Exception ex) {
            JOptionPane.showMessageDialog(rootPane, "MySql Sinif Getirme Hatasi");
        }
    
    }
     
    public static void main(String args[]) {
    
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new ogrenciprogramlar().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JComboBox<String> combo;
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable tablo;
    // End of variables declaration//GEN-END:variables
}
