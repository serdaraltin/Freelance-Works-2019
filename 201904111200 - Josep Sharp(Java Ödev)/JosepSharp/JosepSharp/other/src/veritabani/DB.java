package veritabani;


import java.io.IOException;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

public final class DB {

    String driver = "com.mysql.jdbc.Driver";
    String dbName = "kurs";

    public Connection conn = null;
    public Statement st = null;
    public ResultSet rs = null;

    public DB() {
        baglan();
    }

    public DB(String dbName) {
        if (kontrol()) {
        this.dbName = dbName;
        baglan();
        }else {
            JOptionPane.showMessageDialog(null, "Lütfen Bağlantınızı Kontrol Ediniz");
        }
    }

    public void baglan() {
        try {
            if (kontrol()) {
                // bağlantı nesnesi kontrol ediliyor
                Class.forName(driver);
                /*encoding*/
                conn = DriverManager.getConnection("jdbc:mysql://localhost/" + dbName + "?useUnicode=yes&characterEncoding=UTF-8", "root", "");
                st = conn.createStatement();
            } else {
                JOptionPane.showMessageDialog(null, "Lütfen Bağlantınızı Kontrol Ediniz");
                System.exit(0);
            }
        } catch (ClassNotFoundException | SQLException e) {
            System.err.println("Bağlantı Hatası : " + e);
        }
    }

    public static boolean kontrol() {
        boolean durum = false;
        try {
        URL url = new URL("http://www.google.com");
        HttpURLConnection urlConnect = (HttpURLConnection) url.openConnection();
        // trying to retrieve data from the source. If offline, this line will fail:
        Object objData = urlConnect.getContent();
        durum = true;
        } catch (MalformedURLException ex) {
            //Logger.getLogger(DB.class.getName()).log(Level.SEVERE, null, ex);
        } catch (IOException ex) {
           // Logger.getLogger(DB.class.getName()).log(Level.SEVERE, null, ex);
        }
        
        return durum;
    }

    /*genelQuery*/
    public void genel(String s) {
        try {
            st.executeQuery(s);
            JOptionPane.showMessageDialog(null, "İşlem başarılı.");
        } catch (Exception ex) {
            System.err.println("SQL Okuma Hatası: " + ex);
            JOptionPane.showMessageDialog(null, "İşlem sırasında database bağlantısı sağlanırken bir hata gerçekleşti lütfen tekrar deneyiniz.");
        }
    }

    /*gerekli*/
    public DefaultTableModel muhaSenetAra(int ogrenci) {
        DefaultTableModel tb = new DefaultTableModel();
        try {
            CallableStatement cb = conn.prepareCall("call proSenetGetir(?)");
            cb.setInt(1, ogrenci);
            ResultSet rs = cb.executeQuery();

            tb.addColumn("Öğrenci ID");
            tb.addColumn("Taksit");
            tb.addColumn("Toplam Miktar");
            tb.addColumn("Taksit Miktarı");
            tb.addColumn("Vade Tarihi");
            tb.addColumn("Ödeme Bilgisi");
            tb.addColumn("Ödeme Tarihi");
            while (rs.next()) {
                String sonuc = (rs.getInt("odenme_bilgisi")) == 0 ? "Ödenmedi" : "Ödendi";
                tb.addRow(new Object[]{rs.getInt("senet_ogrenci_id"), rs.getString("taksit_id") + "/" + rs.getString("toplam_taksit"), rs.getInt("toplam_miktar"), rs.getInt("odeme_miktari"), rs.getString("vade_tarihi"), sonuc, rs.getString("odeme_tarihi")});
            }
        } catch (SQLException ex) {
            System.err.println("SQL Arama Hatası: " + ex);
        }

        return tb;
    }

    /*gerekli*/
    public ResultSet muhasebeTipOku() {
        try {
            rs = st.executeQuery("call proTipOku()");
        } catch (Exception ex) {
            System.err.println("SQL Okuma Hatası: " + ex);
            JOptionPane.showMessageDialog(null, "SQL Okuma Hatası Database bağlantınızı kontrol edin.");
        }
        return rs;
    }

    public void kapat() {
        try {
            conn.close();
            st.close();
        } catch (Exception e) {
            System.err.println("Bağlantı Kapatma Hatası : " + e);
        }
    }
    
    
    // data getirme fonksiyonu
    public ResultSet dataGetir(String tableName) {
        try {
            rs = st.executeQuery("select *from " + tableName);
        } catch (Exception e) {
            System.err.println("Data Getirme Hatası : " + e);
        }
        return rs;
    }

    // genel query fonksiyonu
    public boolean genelQuery(String query) {
        boolean durum = false;
        try {
            durum = st.execute(query);
            durum=true;
        } catch (Exception e) {
            System.err.println("genelQuery Hatası : " + e);
        }
        return durum;
    }
    
}
