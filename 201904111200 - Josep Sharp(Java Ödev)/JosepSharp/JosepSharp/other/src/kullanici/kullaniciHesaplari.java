package kullanici;

import AnaMenu.Menu;
import java.awt.Component;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import javax.swing.JCheckBox;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import veritabani.DB;

public class kullaniciHesaplari extends javax.swing.JFrame {

    DefaultTableModel dt = new DefaultTableModel();
    DefaultTableModel dt2 = new DefaultTableModel();
    kontrol kontrol = new kontrol();
    private String sifreAcik = null;
    private String sifreKapali = null;
    private String yetki1 = null;
    private String yetki = null;
    private String kul_isim = null;
    private String per_id = null;
    ArrayList<String> arrID = new ArrayList<>();
    ArrayList<String> arrGorev = new ArrayList<>();

    public kullaniciHesaplari() {
        initComponents();
        dt.addColumn("Kullanıcı Adı");
        dt.addColumn("Şifre");
        dt2.addColumn("Adı");
        dt2.addColumn("Soyadı");
        dt2.addColumn("Görevi");
 
        jTable1.setModel(dt);
        jTable2.setModel(dt2);
        jTable1.setModel(dt);
        jTable2.setModel(dt2);
        tableYaz();
        table2Yaz();
    }

    private void table2Yaz() {
        dt2.setRowCount(0);

        DB db = new DB();
        db.baglan();
        try {
            ResultSet rs = db.dataGetir("personel");
            while (rs.next()) {
                dt2.addRow(new String[]{rs.getString("personelAdi"), rs.getString("personelSoyadi"),rs.getString("personelGorev")});
                arrID.add(rs.getString("personelID"));
                arrGorev.add(rs.getString("personelID"));
                
            }
            jTable2.setModel(dt2);
        } catch (Exception e) {
            System.out.println("table2yaz hatası:" + e);
        } finally {
            db.kapat();
        }
    }

    private void tableYaz() {
        dt.setRowCount(0);
        DB db = new DB();
        db.baglan();

        try {
            ResultSet rs = db.dataGetir("kullanicilar");
            if (rs.next()) {
                if (jCheckBox_sifreGoster.isSelected()) {
                    while (rs.next()) {
                        dt.addRow(new String[]{rs.getString("kullanici_isim"), rs.getString("kullanici_sifre")});
                        sifreKapali = "";
                    }
                } else {
                    while (rs.next()) {
                        sifreAcik = rs.getString("kullanici_sifre");
                        for (int j = 0; j < sifreAcik.length(); j++) {
                            sifreKapali += "*";
                        }
                        dt.addRow(new String[]{rs.getString("kullanici_isim"), sifreKapali});
                        sifreKapali = "";
                    }
                }
            }
        } catch (SQLException ex) {
            System.out.println("tablo yazma hatası:" + ex);
        } finally {
            db.kapat();
        }
        jTable1.setModel(dt);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        txtKullaniciAdi = new javax.swing.JTextField();
        jLabel2 = new javax.swing.JLabel();
        jPasswordField1 = new javax.swing.JPasswordField();
        jLabel9 = new javax.swing.JLabel();
        txt_personal_id = new javax.swing.JTextField();
        jScrollPane1 = new javax.swing.JScrollPane();
        jTable1 = new javax.swing.JTable();
        jCheckBox_sifreGoster = new javax.swing.JCheckBox();
        jPanel2 = new javax.swing.JPanel();
        jCheckBox_ekle = new javax.swing.JCheckBox();
        jCheckBox_ekle1 = new javax.swing.JCheckBox();
        jCheckBox_ekle10 = new javax.swing.JCheckBox();
        jCheckBox_ekle11 = new javax.swing.JCheckBox();
        jCheckBox_ekle12 = new javax.swing.JCheckBox();
        jCheckBox_ekle13 = new javax.swing.JCheckBox();
        jCheckBox_ekle14 = new javax.swing.JCheckBox();
        jCheckBox_ekle15 = new javax.swing.JCheckBox();
        jLabel5 = new javax.swing.JLabel();
        jLabel10 = new javax.swing.JLabel();
        jLabel12 = new javax.swing.JLabel();
        jLabel11 = new javax.swing.JLabel();
        jLabel14 = new javax.swing.JLabel();
        jLabel13 = new javax.swing.JLabel();
        jLabel17 = new javax.swing.JLabel();
        jLabel16 = new javax.swing.JLabel();
        jLabel19 = new javax.swing.JLabel();
        jLabel18 = new javax.swing.JLabel();
        jCheckBox_ekle16 = new javax.swing.JCheckBox();
        jCheckBox_ekle17 = new javax.swing.JCheckBox();
        jCheckBox_ekle2 = new javax.swing.JCheckBox();
        jCheckBox_ekle3 = new javax.swing.JCheckBox();
        jCheckBox_ekle18 = new javax.swing.JCheckBox();
        jCheckBox_ekle19 = new javax.swing.JCheckBox();
        jCheckBox_ekle20 = new javax.swing.JCheckBox();
        jCheckBox_ekle21 = new javax.swing.JCheckBox();
        jCheckBox_ekle22 = new javax.swing.JCheckBox();
        jCheckBox_ekle23 = new javax.swing.JCheckBox();
        jCheckBox_ekle24 = new javax.swing.JCheckBox();
        jCheckBox_ekle25 = new javax.swing.JCheckBox();
        jCheckBox_ekle26 = new javax.swing.JCheckBox();
        jCheckBox_ekle4 = new javax.swing.JCheckBox();
        jCheckBox_ekle27 = new javax.swing.JCheckBox();
        jCheckBox_ekle28 = new javax.swing.JCheckBox();
        jCheckBox_ekle29 = new javax.swing.JCheckBox();
        jCheckBox_ekle5 = new javax.swing.JCheckBox();
        jCheckBox_ekle30 = new javax.swing.JCheckBox();
        jCheckBox_ekle31 = new javax.swing.JCheckBox();
        jCheckBox_ekle32 = new javax.swing.JCheckBox();
        jCheckBox_ekle33 = new javax.swing.JCheckBox();
        jCheckBox_ekle34 = new javax.swing.JCheckBox();
        jCheckBox_ekle35 = new javax.swing.JCheckBox();
        jCheckBox_ekle36 = new javax.swing.JCheckBox();
        jCheckBox_ekle37 = new javax.swing.JCheckBox();
        jCheckBox_ekle6 = new javax.swing.JCheckBox();
        jCheckBox_ekle38 = new javax.swing.JCheckBox();
        jCheckBox_ekle39 = new javax.swing.JCheckBox();
        jCheckBox_ekle40 = new javax.swing.JCheckBox();
        jCheckBox_ekle41 = new javax.swing.JCheckBox();
        jCheckBox_ekle7 = new javax.swing.JCheckBox();
        jScrollPane2 = new javax.swing.JScrollPane();
        jTable2 = new javax.swing.JTable();
        jButton1 = new javax.swing.JButton();
        btn_tumunuSec = new javax.swing.JButton();
        jButton_kaydet = new javax.swing.JButton();
        jButton_sil = new javax.swing.JButton();
        jButton_duzenle = new javax.swing.JButton();
        jButton_yeniKayit = new javax.swing.JButton();
        jLabel3 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        jLabel15 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Kullanıcı Hesapları Paneli");
        setMinimumSize(new java.awt.Dimension(800, 600));
        setResizable(false);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jPanel1.setOpaque(false);
        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 51, 102));
        jLabel1.setText("Kullanıcı Adı :");
        jPanel1.add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 10, -1, -1));
        jPanel1.add(txtKullaniciAdi, new org.netbeans.lib.awtextra.AbsoluteConstraints(120, 10, 218, -1));

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(0, 51, 102));
        jLabel2.setText("Şifre :");
        jPanel1.add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(60, 60, -1, -1));
        jPanel1.add(jPasswordField1, new org.netbeans.lib.awtextra.AbsoluteConstraints(120, 60, 218, -1));

        jLabel9.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel9.setForeground(new java.awt.Color(0, 51, 102));
        jLabel9.setText("Personal ID :");
        jPanel1.add(jLabel9, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 110, -1, -1));
        jPanel1.add(txt_personal_id, new org.netbeans.lib.awtextra.AbsoluteConstraints(120, 110, 218, -1));

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 80, 430, 140));

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
        jScrollPane1.setViewportView(jTable1);

        getContentPane().add(jScrollPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 230, 430, 100));

        jCheckBox_sifreGoster.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        jCheckBox_sifreGoster.setForeground(new java.awt.Color(153, 0, 0));
        jCheckBox_sifreGoster.setText("Şifreyi Göster");
        jCheckBox_sifreGoster.setOpaque(false);
        jCheckBox_sifreGoster.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jCheckBox_sifreGosterMouseClicked(evt);
            }
        });
        getContentPane().add(jCheckBox_sifreGoster, new org.netbeans.lib.awtextra.AbsoluteConstraints(340, 340, -1, -1));

        jPanel2.setOpaque(false);
        jPanel2.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jCheckBox_ekle.setText("Ekle");
        jCheckBox_ekle.setOpaque(false);
        jPanel2.add(jCheckBox_ekle, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 30, -1, -1));

        jCheckBox_ekle1.setText("Ekle");
        jCheckBox_ekle1.setOpaque(false);
        jPanel2.add(jCheckBox_ekle1, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 70, -1, -1));

        jCheckBox_ekle10.setText("Ekle");
        jCheckBox_ekle10.setOpaque(false);
        jPanel2.add(jCheckBox_ekle10, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 110, -1, -1));

        jCheckBox_ekle11.setText("Ekle");
        jCheckBox_ekle11.setOpaque(false);
        jPanel2.add(jCheckBox_ekle11, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 150, -1, -1));

        jCheckBox_ekle12.setText("Ekle");
        jCheckBox_ekle12.setOpaque(false);
        jCheckBox_ekle12.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jCheckBox_ekle12ActionPerformed(evt);
            }
        });
        jPanel2.add(jCheckBox_ekle12, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 230, -1, -1));

        jCheckBox_ekle13.setText("Ekle");
        jCheckBox_ekle13.setOpaque(false);
        jPanel2.add(jCheckBox_ekle13, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 190, -1, -1));

        jCheckBox_ekle14.setText("Ekle");
        jCheckBox_ekle14.setOpaque(false);
        jPanel2.add(jCheckBox_ekle14, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 310, -1, -1));

        jCheckBox_ekle15.setText("Ekle");
        jCheckBox_ekle15.setOpaque(false);
        jPanel2.add(jCheckBox_ekle15, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 270, -1, -1));

        jLabel5.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(0, 51, 102));
        jLabel5.setText("Grup İşlemleri :");
        jPanel2.add(jLabel5, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 30, -1, -1));

        jLabel10.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel10.setForeground(new java.awt.Color(0, 51, 102));
        jLabel10.setText("Personel İşlemleri :");
        jPanel2.add(jLabel10, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 70, -1, -1));

        jLabel12.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel12.setForeground(new java.awt.Color(0, 51, 102));
        jLabel12.setText("*Rehberlik İşlemleri :");
        jPanel2.add(jLabel12, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 110, -1, -1));

        jLabel11.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel11.setForeground(new java.awt.Color(0, 51, 102));
        jLabel11.setText(" Mail :");
        jPanel2.add(jLabel11, new org.netbeans.lib.awtextra.AbsoluteConstraints(100, 190, -1, -1));

        jLabel14.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel14.setForeground(new java.awt.Color(0, 51, 102));
        jLabel14.setText("Kullanıcı Hesapları :");
        jPanel2.add(jLabel14, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 150, -1, -1));

        jLabel13.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel13.setForeground(new java.awt.Color(0, 51, 102));
        jLabel13.setText("Tarayıcıdan Okuma :");
        jPanel2.add(jLabel13, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 230, -1, 19));

        jLabel17.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel17.setForeground(new java.awt.Color(0, 51, 102));
        jLabel17.setText("Kasa Kayıt :");
        jPanel2.add(jLabel17, new org.netbeans.lib.awtextra.AbsoluteConstraints(60, 270, -1, -1));

        jLabel16.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel16.setForeground(new java.awt.Color(0, 51, 102));
        jLabel16.setText("Senet Ödeme :");
        jPanel2.add(jLabel16, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 310, -1, -1));

        jLabel19.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel19.setForeground(new java.awt.Color(0, 51, 102));
        jLabel19.setText("Öğrenci kayıt :");
        jPanel2.add(jLabel19, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 350, -1, -1));

        jLabel18.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel18.setForeground(new java.awt.Color(0, 51, 102));
        jLabel18.setText("Öğretmen Ücretleri :");
        jPanel2.add(jLabel18, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 390, -1, -1));

        jCheckBox_ekle16.setText("Ekle");
        jCheckBox_ekle16.setOpaque(false);
        jPanel2.add(jCheckBox_ekle16, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 350, -1, -1));

        jCheckBox_ekle17.setText("Ekle");
        jCheckBox_ekle17.setOpaque(false);
        jPanel2.add(jCheckBox_ekle17, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 390, -1, -1));

        jCheckBox_ekle2.setText("Ekle");
        jCheckBox_ekle2.setOpaque(false);
        jPanel2.add(jCheckBox_ekle2, new org.netbeans.lib.awtextra.AbsoluteConstraints(220, 30, -1, -1));

        jCheckBox_ekle3.setText("Ekle");
        jCheckBox_ekle3.setOpaque(false);
        jPanel2.add(jCheckBox_ekle3, new org.netbeans.lib.awtextra.AbsoluteConstraints(220, 70, -1, -1));

        jCheckBox_ekle18.setText("Ekle");
        jCheckBox_ekle18.setOpaque(false);
        jPanel2.add(jCheckBox_ekle18, new org.netbeans.lib.awtextra.AbsoluteConstraints(220, 110, -1, -1));

        jCheckBox_ekle19.setText("Ekle");
        jCheckBox_ekle19.setOpaque(false);
        jPanel2.add(jCheckBox_ekle19, new org.netbeans.lib.awtextra.AbsoluteConstraints(220, 150, -1, -1));

        jCheckBox_ekle20.setText("Ekle");
        jCheckBox_ekle20.setOpaque(false);
        jPanel2.add(jCheckBox_ekle20, new org.netbeans.lib.awtextra.AbsoluteConstraints(220, 190, -1, -1));

        jCheckBox_ekle21.setText("Ekle");
        jCheckBox_ekle21.setOpaque(false);
        jCheckBox_ekle21.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jCheckBox_ekle21ActionPerformed(evt);
            }
        });
        jPanel2.add(jCheckBox_ekle21, new org.netbeans.lib.awtextra.AbsoluteConstraints(220, 230, -1, -1));

        jCheckBox_ekle22.setText("Ekle");
        jCheckBox_ekle22.setOpaque(false);
        jPanel2.add(jCheckBox_ekle22, new org.netbeans.lib.awtextra.AbsoluteConstraints(220, 270, -1, -1));

        jCheckBox_ekle23.setText("Ekle");
        jCheckBox_ekle23.setOpaque(false);
        jPanel2.add(jCheckBox_ekle23, new org.netbeans.lib.awtextra.AbsoluteConstraints(220, 310, -1, -1));

        jCheckBox_ekle24.setText("Ekle");
        jCheckBox_ekle24.setOpaque(false);
        jPanel2.add(jCheckBox_ekle24, new org.netbeans.lib.awtextra.AbsoluteConstraints(220, 350, -1, -1));

        jCheckBox_ekle25.setText("Ekle");
        jCheckBox_ekle25.setOpaque(false);
        jCheckBox_ekle25.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jCheckBox_ekle25ActionPerformed(evt);
            }
        });
        jPanel2.add(jCheckBox_ekle25, new org.netbeans.lib.awtextra.AbsoluteConstraints(220, 390, -1, -1));

        jCheckBox_ekle26.setText("Ekle");
        jCheckBox_ekle26.setOpaque(false);
        jPanel2.add(jCheckBox_ekle26, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 150, -1, -1));

        jCheckBox_ekle4.setText("Ekle");
        jCheckBox_ekle4.setOpaque(false);
        jPanel2.add(jCheckBox_ekle4, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 30, -1, -1));

        jCheckBox_ekle27.setText("Ekle");
        jCheckBox_ekle27.setOpaque(false);
        jPanel2.add(jCheckBox_ekle27, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 110, -1, -1));

        jCheckBox_ekle28.setText("Ekle");
        jCheckBox_ekle28.setOpaque(false);
        jPanel2.add(jCheckBox_ekle28, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 390, -1, -1));

        jCheckBox_ekle29.setText("Ekle");
        jCheckBox_ekle29.setOpaque(false);
        jPanel2.add(jCheckBox_ekle29, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 310, -1, -1));

        jCheckBox_ekle5.setText("Ekle");
        jCheckBox_ekle5.setOpaque(false);
        jPanel2.add(jCheckBox_ekle5, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 70, -1, -1));

        jCheckBox_ekle30.setText("Ekle");
        jCheckBox_ekle30.setOpaque(false);
        jPanel2.add(jCheckBox_ekle30, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 350, -1, -1));

        jCheckBox_ekle31.setText("Ekle");
        jCheckBox_ekle31.setOpaque(false);
        jPanel2.add(jCheckBox_ekle31, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 190, -1, -1));

        jCheckBox_ekle32.setText("Ekle");
        jCheckBox_ekle32.setOpaque(false);
        jPanel2.add(jCheckBox_ekle32, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 270, -1, -1));

        jCheckBox_ekle33.setText("Ekle");
        jCheckBox_ekle33.setOpaque(false);
        jCheckBox_ekle33.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jCheckBox_ekle33ActionPerformed(evt);
            }
        });
        jPanel2.add(jCheckBox_ekle33, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 230, -1, -1));

        jCheckBox_ekle34.setText("Ekle");
        jCheckBox_ekle34.setOpaque(false);
        jCheckBox_ekle34.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jCheckBox_ekle34ActionPerformed(evt);
            }
        });
        jPanel2.add(jCheckBox_ekle34, new org.netbeans.lib.awtextra.AbsoluteConstraints(350, 230, -1, -1));

        jCheckBox_ekle35.setText("Ekle");
        jCheckBox_ekle35.setOpaque(false);
        jPanel2.add(jCheckBox_ekle35, new org.netbeans.lib.awtextra.AbsoluteConstraints(350, 390, -1, -1));

        jCheckBox_ekle36.setText("Ekle");
        jCheckBox_ekle36.setOpaque(false);
        jPanel2.add(jCheckBox_ekle36, new org.netbeans.lib.awtextra.AbsoluteConstraints(350, 150, -1, -1));

        jCheckBox_ekle37.setText("Ekle");
        jCheckBox_ekle37.setOpaque(false);
        jPanel2.add(jCheckBox_ekle37, new org.netbeans.lib.awtextra.AbsoluteConstraints(350, 190, -1, -1));

        jCheckBox_ekle6.setText("Ekle");
        jCheckBox_ekle6.setOpaque(false);
        jPanel2.add(jCheckBox_ekle6, new org.netbeans.lib.awtextra.AbsoluteConstraints(350, 70, -1, -1));

        jCheckBox_ekle38.setText("Ekle");
        jCheckBox_ekle38.setOpaque(false);
        jPanel2.add(jCheckBox_ekle38, new org.netbeans.lib.awtextra.AbsoluteConstraints(350, 350, -1, -1));

        jCheckBox_ekle39.setText("Ekle");
        jCheckBox_ekle39.setOpaque(false);
        jPanel2.add(jCheckBox_ekle39, new org.netbeans.lib.awtextra.AbsoluteConstraints(350, 110, -1, -1));

        jCheckBox_ekle40.setText("Ekle");
        jCheckBox_ekle40.setOpaque(false);
        jPanel2.add(jCheckBox_ekle40, new org.netbeans.lib.awtextra.AbsoluteConstraints(350, 270, -1, -1));

        jCheckBox_ekle41.setText("Ekle");
        jCheckBox_ekle41.setOpaque(false);
        jPanel2.add(jCheckBox_ekle41, new org.netbeans.lib.awtextra.AbsoluteConstraints(350, 310, -1, -1));

        jCheckBox_ekle7.setText("Ekle");
        jCheckBox_ekle7.setOpaque(false);
        jPanel2.add(jCheckBox_ekle7, new org.netbeans.lib.awtextra.AbsoluteConstraints(350, 30, -1, -1));

        getContentPane().add(jPanel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(560, 80, 420, 420));

        jTable2.setModel(new javax.swing.table.DefaultTableModel(
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
        jTable2.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jTable2MouseClicked(evt);
            }
        });
        jScrollPane2.setViewportView(jTable2);

        getContentPane().add(jScrollPane2, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 370, 440, 100));

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
        getContentPane().add(jButton1, new org.netbeans.lib.awtextra.AbsoluteConstraints(870, 10, 100, -1));

        btn_tumunuSec.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btn_tumunuSec.setForeground(new java.awt.Color(0, 51, 102));
        btn_tumunuSec.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/tumunusec.png"))); // NOI18N
        btn_tumunuSec.setText("Tüm İzinleri Seç");
        btn_tumunuSec.setOpaque(false);
        btn_tumunuSec.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_tumunuSecActionPerformed(evt);
            }
        });
        getContentPane().add(btn_tumunuSec, new org.netbeans.lib.awtextra.AbsoluteConstraints(740, 520, -1, -1));

        jButton_kaydet.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton_kaydet.setForeground(new java.awt.Color(0, 51, 102));
        jButton_kaydet.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/kaydet.png"))); // NOI18N
        jButton_kaydet.setText("Kaydet");
        jButton_kaydet.setBorderPainted(false);
        jButton_kaydet.setOpaque(false);
        jButton_kaydet.setPreferredSize(new java.awt.Dimension(120, 40));
        jButton_kaydet.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton_kaydetActionPerformed(evt);
            }
        });
        getContentPane().add(jButton_kaydet, new org.netbeans.lib.awtextra.AbsoluteConstraints(70, 480, 140, -1));

        jButton_sil.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton_sil.setForeground(new java.awt.Color(0, 51, 102));
        jButton_sil.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/kayıtsil.png"))); // NOI18N
        jButton_sil.setText("Sil");
        jButton_sil.setOpaque(false);
        jButton_sil.setPreferredSize(new java.awt.Dimension(120, 40));
        jButton_sil.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton_silActionPerformed(evt);
            }
        });
        getContentPane().add(jButton_sil, new org.netbeans.lib.awtextra.AbsoluteConstraints(70, 530, 140, -1));

        jButton_duzenle.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton_duzenle.setForeground(new java.awt.Color(0, 51, 102));
        jButton_duzenle.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/duzenle.png"))); // NOI18N
        jButton_duzenle.setText("Düzenle");
        jButton_duzenle.setOpaque(false);
        jButton_duzenle.setPreferredSize(new java.awt.Dimension(121, 40));
        jButton_duzenle.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton_duzenleActionPerformed(evt);
            }
        });
        getContentPane().add(jButton_duzenle, new org.netbeans.lib.awtextra.AbsoluteConstraints(270, 480, 140, -1));

        jButton_yeniKayit.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton_yeniKayit.setForeground(new java.awt.Color(0, 51, 102));
        jButton_yeniKayit.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/kayıt ekle.png"))); // NOI18N
        jButton_yeniKayit.setText("Yeni Kayıt");
        jButton_yeniKayit.setOpaque(false);
        jButton_yeniKayit.setPreferredSize(new java.awt.Dimension(137, 40));
        jButton_yeniKayit.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton_yeniKayitActionPerformed(evt);
            }
        });
        getContentPane().add(jButton_yeniKayit, new org.netbeans.lib.awtextra.AbsoluteConstraints(270, 530, -1, -1));

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(0, 51, 102));
        jLabel3.setText("Kullanıcı  Hesapları");
        getContentPane().add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(160, 50, -1, -1));

        jLabel6.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel6.setForeground(new java.awt.Color(0, 51, 102));
        jLabel6.setText("İzinler");
        getContentPane().add(jLabel6, new org.netbeans.lib.awtextra.AbsoluteConstraints(770, 50, -1, 20));

        jLabel15.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel15.setForeground(new java.awt.Color(153, 0, 51));
        jLabel15.setText("Kullanıcı Hesapları Paneli");
        getContentPane().add(jLabel15, new org.netbeans.lib.awtextra.AbsoluteConstraints(350, 20, -1, -1));

        jLabel4.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/1024jpg.jpg"))); // NOI18N
        jLabel4.setPreferredSize(new java.awt.Dimension(988, 657));
        getContentPane().add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, -1, 580));

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents
boolean alanKontrol() {
        String isim = txtKullaniciAdi.getText().trim();
        String sifre = String.copyValueOf(jPasswordField1.getPassword());
        String personal_id = txt_personal_id.getText().trim();
        return !isim.isEmpty() && !sifre.isEmpty() && !personal_id.isEmpty();
    }
    private void jButton_kaydetActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton_kaydetActionPerformed
        String isim = txtKullaniciAdi.getText().trim();
        String sifre = String.copyValueOf(jPasswordField1.getPassword());
        String personal_id = txt_personal_id.getText().trim();

        if (alanKontrol()) {
            int button_id = 8; // yetki kontrolü için
            if (kontrol.kontrol(button_id)) {
                checkboxKontrol();
                DB db = new DB();
                db.baglan();
                try {
                    boolean durum = db.genelQuery("insert into kullanicilar values(null,'" + isim + "','" + sifre + "','" + yetki + "','" + personal_id + "')");
                    if (durum) {
                        JOptionPane.showMessageDialog(rootPane, "Kullanıcı kaydı başarılı.");
                    } else {
                        JOptionPane.showMessageDialog(rootPane, "Kullanıcı adı kayıtlı. Farklı bir kullanıcı adı kullanın.");
                    }
                } catch (Exception e) {
                    System.out.println("Kaydetme hatası" + e);
                } finally {
                    db.kapat();
                }
                yetki = "";
                tableYaz();
            }
        } else {
            JOptionPane.showMessageDialog(rootPane, "alanlar boş!");
        }

    }//GEN-LAST:event_jButton_kaydetActionPerformed


    private void jButton_silActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton_silActionPerformed
        int button_id = 9; // yetki kontrolü için
        if (jTable1.getSelectedRow() > -1) {
            if (kontrol.kontrol(button_id)) { //  yetki kontrolü
                int cevap = JOptionPane.showConfirmDialog(rootPane, "emin misiniz?", "Kullanıcı Sil", JOptionPane.YES_NO_OPTION);
                if (cevap == 0) {
                    DB db = new DB();
                    db.baglan();
                    try {
                        String isim = jTable1.getValueAt(jTable1.getSelectedRow(), 0).toString();
                        boolean durum = db.genelQuery("delete from kullanicilar where kullanici_isim='" + isim + "'");
                        if (durum) {
                            JOptionPane.showMessageDialog(rootPane, "silme işlemi başarılı.");
                        }
                        tableYaz();
                    } catch (Exception e) {
                        System.out.println("Silme işlemi hatası");
                    } finally {
                        db.kapat();
                    }
                }
            }
        } else {
            JOptionPane.showMessageDialog(rootPane, "seçim yapınız.");
        }
    }//GEN-LAST:event_jButton_silActionPerformed

    private void jCheckBox_sifreGosterMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jCheckBox_sifreGosterMouseClicked
        tableYaz();    }//GEN-LAST:event_jCheckBox_sifreGosterMouseClicked

    private void checkboxKontrol() {
        Component[] compo = jPanel2.getComponents();
        for (Component component : compo) {
            if (component instanceof JCheckBox) {
                if (((JCheckBox) component).isSelected()) {
                    yetki += "1";
                } else {
                    yetki += "0";
                }
            }
        }
    }

    private void jButton_yeniKayitActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton_yeniKayitActionPerformed
        int button_id = 11;

        if (kontrol.kontrol(button_id)) {

            txtKullaniciAdi.setText("");
            txt_personal_id.setText("");
            jPasswordField1.setText("");

            Component[] compo = jPanel2.getComponents();
            for (Component component : compo) {
                if (component instanceof JCheckBox) {
                    ((JCheckBox) component).setSelected(false);
                }
            }
        }
                     }//GEN-LAST:event_jButton_yeniKayitActionPerformed
    private void jTable1MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jTable1MouseClicked

        DB db = new DB();
        db.baglan();
        try {
            kul_isim = jTable1.getValueAt(jTable1.getSelectedRow(), 0).toString();
            ResultSet rs = db.dataGetir("kullanicilar where kullanici_isim='" + kul_isim + "'");
            if (rs.next()) {
                txtKullaniciAdi.setText(rs.getString("kullanici_isim"));
                jPasswordField1.setText(rs.getString("kullanici_sifre"));
                yetki1 = rs.getString("kullanici_yetki");
                txt_personal_id.setText(rs.getString("personalID"));
                per_id = rs.getString("personalID");
            }
        } catch (Exception e) {
            System.out.println("jtable1 clicked hatası:" + e);
        } finally {
            db.kapat();
        }
        checkBoxDoldur(yetki1);
    }//GEN-LAST:event_jTable1MouseClicked

    private void jButton_duzenleActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton_duzenleActionPerformed
        int button_id = 10;
        String isim = txtKullaniciAdi.getText().trim();
        String sifre = (String.copyValueOf(jPasswordField1.getPassword()));
        String personal_id = txt_personal_id.getText().trim();
        if (alanKontrol()) {
            if (kontrol.kontrol(button_id)) {
                if (jTable1.getSelectedRow() > -1) {
                    kul_isim = jTable1.getValueAt(jTable1.getSelectedRow(), 0).toString();
                    checkboxKontrol();
                    DB db = new DB();
                    db.baglan();
                    boolean durum = db.genelQuery("UPDATE kullanicilar SET kullanici_isim='" + isim + "',kullanici_sifre ='" + sifre + "',kullanici_yetki='" + yetki + "',personalID='" + personal_id + "' WHERE kullanici_isim='" + kul_isim + "'");
                    if (durum) {
                        JOptionPane.showMessageDialog(rootPane, "Düzenleme başarılı.");
                    } else {
                        JOptionPane.showMessageDialog(rootPane, "Düzenleme başarısız.");
                    }
                    db.kapat();
                    yetki = "";
                    tableYaz();
                } else {
                    JOptionPane.showMessageDialog(rootPane, "seçim yapınız.");
                }
            }
        } else {
            JOptionPane.showMessageDialog(rootPane, "alanlar boş!");
        }
    }//GEN-LAST:event_jButton_duzenleActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        Menu don = new Menu();
       don.setVisible(true);
        this.setVisible(false);

    }//GEN-LAST:event_jButton1ActionPerformed

    private void jTable2MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jTable2MouseClicked
        txt_personal_id.setText(arrID.get(jTable2.getSelectedRow()));
    }//GEN-LAST:event_jTable2MouseClicked

    private void btn_tumunuSecActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_tumunuSecActionPerformed
        Component[] compo = jPanel2.getComponents();
        for (Component component : compo) {
            if (component instanceof JCheckBox) {
                ((JCheckBox) component).setSelected(true);
            }
        }
    }//GEN-LAST:event_btn_tumunuSecActionPerformed

    private void jCheckBox_ekle12ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jCheckBox_ekle12ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jCheckBox_ekle12ActionPerformed

    private void jCheckBox_ekle21ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jCheckBox_ekle21ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jCheckBox_ekle21ActionPerformed

    private void jCheckBox_ekle33ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jCheckBox_ekle33ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jCheckBox_ekle33ActionPerformed

    private void jCheckBox_ekle34ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jCheckBox_ekle34ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jCheckBox_ekle34ActionPerformed

    private void jCheckBox_ekle25ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jCheckBox_ekle25ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jCheckBox_ekle25ActionPerformed
    private JCheckBox jCheckBoxd;

    private void checkBoxDoldur(String st) {
        try {
            Component[] compo = jPanel2.getComponents();
            char[] yetkiC = st.toCharArray();
            for (int j = 0; j < yetkiC.length; j++) {
                jCheckBoxd = (JCheckBox) compo[j];
                if (yetkiC[j] == '1') {
                    jCheckBoxd.setSelected(true);
                } else {
                    jCheckBoxd.setSelected(false);
                }
            }
        } catch (Exception e) {

            System.out.println("checkbox doldurma hatası:" + e);
        }

    }

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
        } catch (ClassNotFoundException | InstantiationException | IllegalAccessException | javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(kullaniciHesaplari.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        java.awt.EventQueue.invokeLater(() -> {
            new kullaniciHesaplari().setVisible(true);
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btn_tumunuSec;
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton_duzenle;
    private javax.swing.JButton jButton_kaydet;
    private javax.swing.JButton jButton_sil;
    private javax.swing.JButton jButton_yeniKayit;
    private javax.swing.JCheckBox jCheckBox_ekle;
    private javax.swing.JCheckBox jCheckBox_ekle1;
    private javax.swing.JCheckBox jCheckBox_ekle10;
    private javax.swing.JCheckBox jCheckBox_ekle11;
    private javax.swing.JCheckBox jCheckBox_ekle12;
    private javax.swing.JCheckBox jCheckBox_ekle13;
    private javax.swing.JCheckBox jCheckBox_ekle14;
    private javax.swing.JCheckBox jCheckBox_ekle15;
    private javax.swing.JCheckBox jCheckBox_ekle16;
    private javax.swing.JCheckBox jCheckBox_ekle17;
    private javax.swing.JCheckBox jCheckBox_ekle18;
    private javax.swing.JCheckBox jCheckBox_ekle19;
    private javax.swing.JCheckBox jCheckBox_ekle2;
    private javax.swing.JCheckBox jCheckBox_ekle20;
    private javax.swing.JCheckBox jCheckBox_ekle21;
    private javax.swing.JCheckBox jCheckBox_ekle22;
    private javax.swing.JCheckBox jCheckBox_ekle23;
    private javax.swing.JCheckBox jCheckBox_ekle24;
    private javax.swing.JCheckBox jCheckBox_ekle25;
    private javax.swing.JCheckBox jCheckBox_ekle26;
    private javax.swing.JCheckBox jCheckBox_ekle27;
    private javax.swing.JCheckBox jCheckBox_ekle28;
    private javax.swing.JCheckBox jCheckBox_ekle29;
    private javax.swing.JCheckBox jCheckBox_ekle3;
    private javax.swing.JCheckBox jCheckBox_ekle30;
    private javax.swing.JCheckBox jCheckBox_ekle31;
    private javax.swing.JCheckBox jCheckBox_ekle32;
    private javax.swing.JCheckBox jCheckBox_ekle33;
    private javax.swing.JCheckBox jCheckBox_ekle34;
    private javax.swing.JCheckBox jCheckBox_ekle35;
    private javax.swing.JCheckBox jCheckBox_ekle36;
    private javax.swing.JCheckBox jCheckBox_ekle37;
    private javax.swing.JCheckBox jCheckBox_ekle38;
    private javax.swing.JCheckBox jCheckBox_ekle39;
    private javax.swing.JCheckBox jCheckBox_ekle4;
    private javax.swing.JCheckBox jCheckBox_ekle40;
    private javax.swing.JCheckBox jCheckBox_ekle41;
    private javax.swing.JCheckBox jCheckBox_ekle5;
    private javax.swing.JCheckBox jCheckBox_ekle6;
    private javax.swing.JCheckBox jCheckBox_ekle7;
    private javax.swing.JCheckBox jCheckBox_sifreGoster;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel11;
    private javax.swing.JLabel jLabel12;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JLabel jLabel14;
    private javax.swing.JLabel jLabel15;
    private javax.swing.JLabel jLabel16;
    private javax.swing.JLabel jLabel17;
    private javax.swing.JLabel jLabel18;
    private javax.swing.JLabel jLabel19;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPasswordField jPasswordField1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JTable jTable1;
    private javax.swing.JTable jTable2;
    private javax.swing.JTextField txtKullaniciAdi;
    private javax.swing.JTextField txt_personal_id;
    // End of variables declaration//GEN-END:variables
}
