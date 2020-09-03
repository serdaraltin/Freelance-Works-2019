package MailGonderme;

import AnaMenu.Menu;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Properties;
import javax.mail.Message;
import javax.mail.MessagingException;
import javax.mail.Session;
import javax.mail.PasswordAuthentication;
import javax.mail.Transport;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeMessage;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import veritabani.DB;

public class MailForm extends javax.swing.JFrame {

    DefaultTableModel tm = new DefaultTableModel();
    DB db = new DB();
    int secim = -1;

    public MailForm() {
        initComponents();
        tm.addColumn("Adı");
        tm.addColumn("Soyadı");
        tm.addColumn("Tc");
        tm.addColumn("Yoklama Tarihi");
        tm.addColumn("Devamsızlık");
        tm.addColumn("1.Sınav");
        tm.addColumn("2.Sınav");
        tm.addColumn("Veli Mail");
        jTable1.setModel(tm);
        tabloGetir();

        db.baglan();

    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        topluGndr = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        txtMesaj = new javax.swing.JTextArea();
        lblsonuc = new javax.swing.JLabel();
        jLabel1 = new javax.swing.JLabel();
        txtAdi = new javax.swing.JTextField();
        jLabel2 = new javax.swing.JLabel();
        jScrollPane2 = new javax.swing.JScrollPane();
        jTable1 = new javax.swing.JTable();
        tekGndr = new javax.swing.JButton();
        jScrollPane3 = new javax.swing.JScrollPane();
        txtMail = new javax.swing.JTextArea();
        jLabel3 = new javax.swing.JLabel();
        jButton1 = new javax.swing.JButton();
        jLabel9 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Mail Gönderme Paneli");
        setMaximumSize(new java.awt.Dimension(850, 568));
        setMinimumSize(new java.awt.Dimension(850, 568));
        setResizable(false);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        topluGndr.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        topluGndr.setForeground(new java.awt.Color(0, 51, 102));
        topluGndr.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/toplumail.png"))); // NOI18N
        topluGndr.setText("Toplu Gönder");
        topluGndr.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                topluGndrActionPerformed(evt);
            }
        });
        getContentPane().add(topluGndr, new org.netbeans.lib.awtextra.AbsoluteConstraints(510, 490, -1, -1));

        txtMesaj.setColumns(20);
        txtMesaj.setRows(5);
        jScrollPane1.setViewportView(txtMesaj);

        getContentPane().add(jScrollPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(140, 160, 173, 310));
        getContentPane().add(lblsonuc, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 540, 522, 23));

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 51, 102));
        jLabel1.setText("Öğrenci Ara :");
        getContentPane().add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 60, -1, -1));

        txtAdi.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                txtAdiKeyReleased(evt);
            }
        });
        getContentPane().add(txtAdi, new org.netbeans.lib.awtextra.AbsoluteConstraints(140, 60, 173, -1));

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(0, 51, 102));
        jLabel2.setText("Veli Mail :");
        getContentPane().add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 110, -1, -1));

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
        jTable1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jTable1MouseClicked(evt);
            }
        });
        jScrollPane2.setViewportView(jTable1);

        getContentPane().add(jScrollPane2, new org.netbeans.lib.awtextra.AbsoluteConstraints(370, 60, 444, 410));

        tekGndr.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        tekGndr.setForeground(new java.awt.Color(0, 51, 102));
        tekGndr.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/mail (1).png"))); // NOI18N
        tekGndr.setText("Tek Gönder");
        tekGndr.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                tekGndrActionPerformed(evt);
            }
        });
        getContentPane().add(tekGndr, new org.netbeans.lib.awtextra.AbsoluteConstraints(140, 490, 170, -1));

        txtMail.setColumns(20);
        txtMail.setRows(5);
        jScrollPane3.setViewportView(txtMail);

        getContentPane().add(jScrollPane3, new org.netbeans.lib.awtextra.AbsoluteConstraints(140, 90, 173, -1));

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(0, 51, 102));
        jLabel3.setText("Bilgiler :");
        getContentPane().add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 170, -1, -1));

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

        jLabel9.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel9.setForeground(new java.awt.Color(153, 0, 51));
        jLabel9.setText("Mail Gönderme Paneli");
        getContentPane().add(jLabel9, new org.netbeans.lib.awtextra.AbsoluteConstraints(340, 20, -1, -1));

        jLabel4.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        jLabel4.setMaximumSize(new java.awt.Dimension(850, 568));
        jLabel4.setMinimumSize(new java.awt.Dimension(850, 568));
        jLabel4.setPreferredSize(new java.awt.Dimension(850, 568));
        getContentPane().add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 850, 568));

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    int i = 0;
    private void topluGndrActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_topluGndrActionPerformed

        int secenek = JOptionPane.showConfirmDialog(rootPane, "Tüm Velilere Bilgilendirme Maili Göndermek İstediğinizden Emin misiniz?", "Toplu Mail Gönderme", JOptionPane.YES_NO_OPTION);
        if (secenek == 0) {
            // Lambda Runnable
            Properties pro = new Properties();
            pro.put("mail.smtp.host", "smtp-mail.outlook.com");
            pro.put("mail.smtp.socketFactory.port", "465");
            pro.put("mail.smtp.socketFactory.class", "javax.net.ssl.SSLSocketFactory");
            pro.put("mail.smtp.auth", "true");
            pro.put("mail.smtp.starttls.enable", "true");
            pro.put("mail.smtp.port", "587");

            Session session = Session.getDefaultInstance(pro,
                    new javax.mail.Authenticator() {
                protected PasswordAuthentication getPasswordAuthentication() {
                    return new PasswordAuthentication("xx@hotmail.com", "xx");
                }
            });

            Runnable task2 = () -> {

                while (jTable1.getRowCount() > i) {
                    System.out.println(i);
                    try {
                        Message mesaj = new MimeMessage(session);
                        mesaj.setFrom(new InternetAddress("xx@hotmail.com"));
                        mesaj.setRecipients(Message.RecipientType.TO, InternetAddress.parse("" + jTable1.getValueAt(i, 5)));
                        mesaj.setSubject("Deneme mail uygulaması");
                        mesaj.setText("Öğrenci Adı Soyadı: " + jTable1.getValueAt(i, 0) + "Yoklama Tarihi: " + jTable1.getValueAt(i, 3) + "Günlük Devamsızlık Durumu: " + jTable1.getValueAt(i, 4) + "1.Sınav Notu :" + jTable1.getValueAt(i, 5) + " 2.Sınav Notu :" + jTable1.getValueAt(i, 6) + "");
                        Transport.send(mesaj);
                        lblsonuc.setText("mesaj gonderildi");
                        i++;
                    } catch (MessagingException eex) {
                        System.err.println("mesaj gonderiminde hata : " + eex.toString());
                    }

                }

            };

            // start the thread
            new Thread(task2).start();
        }
    }//GEN-LAST:event_topluGndrActionPerformed

    private void jTable1MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jTable1MouseClicked

        secim = jTable1.getSelectedRow();
        String merhaba = "LAMBDA AKADEMİE \n";
        String adi = tm.getValueAt(secim, 0) + " " + tm.getValueAt(secim, 1) + " adlı öğrencimizin  \n";
        String yoklama = tm.getValueAt(secim, 3) + " tarihindeki devamsızlık durumu : ";
        String durum = (String) tm.getValueAt(secim, 4) + "\n";
        String sinavNotu1 = "1.Sınav Notu : " + (String) tm.getValueAt(secim, 5) + "\n";
        String sinavNotu2 = "2.Sınav Notu : " + (String) tm.getValueAt(secim, 6) + "\n";
        String son = "İyi Günler Dileriz.";
        String mesaj = merhaba + adi + yoklama + durum + sinavNotu1 + sinavNotu2 + son;
        //String mesaj = adi + yoklama + durum;
        String mail = (String) tm.getValueAt(secim, 7);
        txtMail.setText(mail);
        txtMesaj.setText(mesaj);


    }//GEN-LAST:event_jTable1MouseClicked

    @SuppressWarnings("empty-statement")
    private void txtAdiKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtAdiKeyReleased

        try {
            //         ResultSet rss = db.st.executeQuery("select *from viewmail where MATCH(ogrenciAdi) AGAINST ('" + txtAdi.getText() + "' IN BOOLEAN MODE)");
            ResultSet rss = db.st.executeQuery("call proMailArama('" + txtAdi.getText().trim() + "')");
            tm.setRowCount(0);
            while (rss.next()) {
                tm.addRow(new Object[]{rss.getString("ogrenciAdi"), rss.getString("ogrenciSoyadi"), rss.getString("ogrenciTc"), rss.getString("yoklamaTarihi"), rss.getString("durum"), rss.getString("1_notu"), rss.getString("2_notu"), rss.getString("veliMail")});
            }
            jTable1.setModel(tm);
            if (txtAdi.getText().trim().equals("")) {
                tabloGetir();
            }
        } catch (Exception e) {
            System.err.println("Hata :" + e);
        }


    }//GEN-LAST:event_txtAdiKeyReleased

    private void tekGndrActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_tekGndrActionPerformed

        if (secim > 0) {
            Properties pro = new Properties();
            pro.put("mail.smtp.host", "smtp-mail.outlook.com");
            pro.put("mail.smtp.socketFactory.port", "465");
            pro.put("mail.smtp.socketFactory.class", "javax.net.ssl.SSLSocketFactory");
            pro.put("mail.smtp.auth", "true");
            pro.put("mail.smtp.starttls.enable", "true");
            pro.put("mail.smtp.port", "587");

            Session session = Session.getDefaultInstance(pro,
                    new javax.mail.Authenticator() {
                protected PasswordAuthentication getPasswordAuthentication() {
                    return new PasswordAuthentication("xx@hotmail.com", "xx");
                }
            });

            Runnable task2 = () -> {

                System.out.println(i);
                try {
                    Message mesaj = new MimeMessage(session);
                    mesaj.setFrom(new InternetAddress("xx@hotmail.com"));
                    //String ab = (String) jTable1.getValueAt(i, 5);
                    mesaj.setRecipients(Message.RecipientType.TO, InternetAddress.parse(txtMail.getText().trim()));

                    mesaj.setSubject("Deneme mail uygulaması");
                    mesaj.setText(txtMesaj.getText());
                    Transport.send(mesaj);
                    lblsonuc.setText("mesaj gonderildi");
                    i++;
                } catch (MessagingException eex) {
                    System.err.println("mesaj gonderiminde hata : " + eex.toString());
                }

            };

            new Thread(task2).start();

        } else JOptionPane.showMessageDialog(rootPane, "Lütfen Önce Öğrenci Seçimi Yapınız !");
    }//GEN-LAST:event_tekGndrActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
            db.kapat();
            Menu menu=new Menu();
            menu.setVisible(true);
            this.setVisible(false);
            
    }//GEN-LAST:event_jButton1ActionPerformed

    public void tabloGetir() {
        try {
//      ResultSet rs = db.st.executeQuery("select o.ogrenciAdi,o.ogrenciSoyadi,o.ogrenciTc,y.yoklamaTarihi,y.durum,o.veliMail from ogrenci as o LEFT JOIN yoklama as y on o.ogrenciId=y.ogrenciID");
            ResultSet rs = db.st.executeQuery("call proViewMail");
            while (rs.next()) {
                tm.addRow(new Object[]{rs.getString("ogrenciAdi"), rs.getString("ogrenciSoyadi"), rs.getString("ogrenciTc"), rs.getString("yoklamaTarihi"), rs.getString("durum"), rs.getString("1_notu"), rs.getString("2_notu"), rs.getString("veliMail")});
                jTable1.setModel(tm);
            }

        } catch (SQLException ex) {
            System.err.println("Öğrenci Bilgi Getirme Hatası :" + ex);
        }
    }

    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
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
            java.util.logging.Logger.getLogger(MailForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(MailForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(MailForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(MailForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new MailForm().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JScrollPane jScrollPane3;
    private javax.swing.JTable jTable1;
    private javax.swing.JLabel lblsonuc;
    private javax.swing.JButton tekGndr;
    private javax.swing.JButton topluGndr;
    private javax.swing.JTextField txtAdi;
    private javax.swing.JTextArea txtMail;
    private javax.swing.JTextArea txtMesaj;
    // End of variables declaration//GEN-END:variables
}
