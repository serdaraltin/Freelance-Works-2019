package Rehberlik;


import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import veritabani.DB;


public class ogretmenprogramlar extends javax.swing.JFrame {
    DB s= new DB();
DefaultComboBoxModel<String> df=new DefaultComboBoxModel<>();
   DefaultTableModel dt = new DefaultTableModel();
   Connection conn = null;
    Statement st = null;
 
    public ogretmenprogramlar() {
        initComponents();
       
        dt.addColumn("Saatler");
        dt.addColumn("Ogretmen");
        dt.addColumn("Pazartesi");
        dt.addColumn("Sali");
        dt.addColumn("Çarşamba");
        dt.addColumn("Perşembe");
        dt.addColumn("Cuma");
        jTable1.setModel(dt);
        df.setSelectedItem("Lütfen Öğretmen Seçiniz");
        jComboBox1.setModel(df);
        HocaGetir();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jComboBox1 = new javax.swing.JComboBox<>();
        jLabel1 = new javax.swing.JLabel();
        jScrollPane1 = new javax.swing.JScrollPane();
        jTable1 = new javax.swing.JTable();
        jButton1 = new javax.swing.JButton();
        jLabel13 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Öğretmen Ders Programları Paneli");
        setResizable(false);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jPanel1.setPreferredSize(new java.awt.Dimension(700, 400));
        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jComboBox1.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                jComboBox1ItemStateChanged(evt);
            }
        });
        jPanel1.add(jComboBox1, new org.netbeans.lib.awtextra.AbsoluteConstraints(260, 110, 280, -1));

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 51, 102));
        jLabel1.setText("Öğretmenler :");
        jPanel1.add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(160, 110, -1, -1));

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

        jPanel1.add(jScrollPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(50, 150, 600, 234));

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
        jPanel1.add(jButton1, new org.netbeans.lib.awtextra.AbsoluteConstraints(590, 10, 100, -1));

        jLabel13.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel13.setForeground(new java.awt.Color(153, 0, 51));
        jLabel13.setText("Öğretmen Ders Programları Paneli");
        jPanel1.add(jLabel13, new org.netbeans.lib.awtextra.AbsoluteConstraints(220, 50, -1, -1));

        jLabel2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/700-500.jpg"))); // NOI18N
        jLabel2.setPreferredSize(new java.awt.Dimension(700, 400));
        jPanel1.add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, -1, -1));

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, -1, -1));

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents
    int hoca=-1;
    private void jComboBox1ItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_jComboBox1ItemStateChanged
        dt.setRowCount(0);
        hoca = jComboBox1.getSelectedIndex()+1;
        String aga=jComboBox1.getSelectedItem().toString();
        try {
            
         ResultSet rs=s.st.executeQuery("select *from ogretmendersprog where Ogretmen='"+aga+"'");
            
          while (rs.next()) {
                
                dt.addRow(new String[]{rs.getString("Saatler"), rs.getString("Ogretmen"), rs.getString("Pazartesi"), rs.getString("Sali"), rs.getString("Carsamba"), rs.getString("Persembe"), rs.getString("Cuma")});
          }
          
          }
         
         catch (Exception e) {
        }
    }//GEN-LAST:event_jComboBox1ItemStateChanged

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
       ogretmenDersProgrami mt=new ogretmenDersProgrami();
        mt.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_jButton1ActionPerformed

    public static void main(String args[]) {
       
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new ogretmenprogramlar().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JComboBox<String> jComboBox1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable jTable1;
    // End of variables declaration//GEN-END:variables

    private void HocaGetir() {
        try {
           
            ResultSet rs=s.st.executeQuery("select *from ogretmen");
          while (rs.next()) {
                String adi=rs.getString("ogretmenAdi");
                String soyadi=rs.getString("ogretmenSoyadi");
                adi+=" "+soyadi;
                jComboBox1.addItem(adi);
                adi="";
                soyadi="";
            }
       } catch (Exception ex) {
            JOptionPane.showMessageDialog(rootPane, "MySql Sinif Getirme Hatasi");
        }
    }
}
