package yedekleme;

import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;
import javax.swing.JOptionPane;
import veritabani.DB;

public class yedekleme {

    public void backup(String hedefKlasor) throws ClassNotFoundException, SQLException, InterruptedException {

        DateFormat dateFormat = new SimpleDateFormat("dd-MM-yyyy---HH_mm_ss");

        Date date = new Date();
        String dt = hedefKlasor + "\\yedekleme-" + dateFormat.format(date) + ".sql";

        Class.forName("com.mysql.jdbc.Driver");

        try {
            
            String mysqldumpPath = "c:\\xampp\\mysql\\bin\\mysqldump";
            String host = "192.168.39.96";
            String port = "3306";
            String kullanici = "root";
            String sifre = "12345";
            String veritabaniAdi = "kurs";

            Connection con = DriverManager.getConnection("jdbc:mysql://" + host + ":" + port + "/" + veritabaniAdi + "?useUnicode=true&characterEncoding=UTF-8", kullanici, sifre);

            String komut = mysqldumpPath + " -h " + host + " -P " + port + " -u" + kullanici + " -p" + sifre + " " + veritabaniAdi + " -r  " + dt;

            Process runtimeProcess = Runtime.getRuntime().exec(komut);

            int processComplete = runtimeProcess.waitFor();

            if (processComplete == 0) {
                System.out.println("Yedekleme Başarılı");
                JOptionPane.showMessageDialog(null, dt, "Yedekleme İşlemi Yapılmıştır!", 1);
            } else {
                System.out.println("Yedekleme Başarısız");
                JOptionPane.showMessageDialog(null, "Yedekleme İşlemi Başarısız!", "Uyarı !", 0);
            }

        } catch (SQLException ex) {

            System.err.println("Bağlantı Hatası : " + ex);
            JOptionPane.showMessageDialog(null, "Bağlantı Hatası !!!");

        } catch (IOException e) {

            System.err.println("Kod Hatası : " + e);
            JOptionPane.showMessageDialog(null, "Kod Hatası !!!");

        }

    }

}
