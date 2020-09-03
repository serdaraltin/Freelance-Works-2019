package Rehberlik;



import java.sql.ResultSet;
import java.sql.SQLException;


import javax.swing.DefaultComboBoxModel;

import javax.swing.table.DefaultTableModel;
import veritabani.DB;


public class etutProgramlari extends javax.swing.JFrame {

    DefaultTableModel dt = new DefaultTableModel();
    DefaultComboBoxModel<String> df=new DefaultComboBoxModel<>();
    DB s=new DB();
    public etutProgramlari() {
        initComponents();
        dt.addColumn("Saatler");
        dt.addColumn("Cumartesi sinif");
        dt.addColumn("Cumartesi ogretmen");
        dt.addColumn("Cumartesi Ders");
        dt.addColumn("pazar sinif");
        dt.addColumn("pazar ogretmen");
        dt.addColumn("pazar Ders");
        
        
        jTable1.setModel(dt);
       getir();
    }


    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jButton1 = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        jTable1 = new javax.swing.JTable();
        jLabel13 = new javax.swing.JLabel();
        jLabel1 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

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
        jScrollPane1.setViewportView(jTable1);

        getContentPane().add(jScrollPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 90, 790, 350));

        jLabel13.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel13.setForeground(new java.awt.Color(153, 0, 51));
        jLabel13.setText("Etüt Programları Paneli");
        getContentPane().add(jLabel13, new org.netbeans.lib.awtextra.AbsoluteConstraints(320, 40, -1, -1));

        jLabel1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        getContentPane().add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 850, 470));

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        etutProgrami mt=new etutProgrami();
        mt.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_jButton1ActionPerformed
int secim =-1;   
public void getir()
   { 
       
        try {
            ResultSet rs=s.st.executeQuery("select *from etut");
            
            while (rs.next()) {    
                dt.addRow(new String[]{rs.getString("Saatler"), rs.getString("cumartesiSinif"), rs.getString("cumartesiOgretmen"), rs.getString("cumartesiDers"),rs.getString("pazarSinif"), rs.getString("pazarOgretmen"), rs.getString("pazarDers")});
          
                
            }
        } catch (SQLException ex) {
            
        }
       
   
   
   }
   
    public static void main(String args[]) {
       
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new etutProgramlari().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable jTable1;
    // End of variables declaration//GEN-END:variables
}
