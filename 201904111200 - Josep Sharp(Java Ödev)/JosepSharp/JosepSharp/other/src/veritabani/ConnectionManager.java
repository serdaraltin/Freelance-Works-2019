/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package veritabani;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

/**
 *
 * @author Java2
 */
public class ConnectionManager {

//    Connection con = null;
//    String url = "jdbc:mysql://localhost/kurs?useUnicode=yes&characterEncoding=UTF-8";
//
//    String kullaniciad = "root";
//
//    String sifre = "";

    public Connection connect() {
        
//        try {
//
//            Class.forName("com.mysql.jdbc.Driver");
//
//            con = DriverManager.getConnection(url, kullaniciad, sifre);
//
//            System.out.println("Baglandi");
//
//        } catch (ClassNotFoundException ex) {
//
//            ex.printStackTrace();
//
//            System.out.println("Sürücü projeye eklenmemiş!");
//
//        } catch (SQLException ex) {
//
//            ex.printStackTrace();
//
//            System.out.println("Veritabanına bağlantı sağlanamadı!");
//
//        }
        DB db = new DB();
        return db.conn;
    }
}
