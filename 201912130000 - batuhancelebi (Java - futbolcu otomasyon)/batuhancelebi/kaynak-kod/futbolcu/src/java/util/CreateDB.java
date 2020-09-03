package util;

import util.ConnectionDB;
import java.io.Serializable;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import javax.faces.bean.SessionScoped;
import javax.inject.Named;

@Named
@SessionScoped
public class CreateDB implements Serializable {

    public static final String JDBC_URL = "jdbc:derby:database";

    public static void main(String[] args) throws ClassNotFoundException, SQLException {
        Class.forName(ConnectionDB.DRIVER);
        try {
            Connection connection  = DriverManager.getConnection(JDBC_URL + ";create=true");
            connection.createStatement().execute("create table futbolcu ("
                    + "id int generated by default as identity (START WITH 2, INCREMENT BY 1),"
                    + "ad varchar(20),"
                    + "soyad varchar(20),"
                    + "yas int,"
                    + "milliyet varchar(20),"
                    + "takim varchar(20),"
                    + "mac_sayi int,"
                    + "gol_sayi int,"
                    + "asist_sayi int)");
            connection.createStatement().execute("insert into futbolcu values(DEFAULT,'necmi','balan',23,'turk','galatasaray',3,5,2)");
        } catch (SQLException ex) {
            System.err.println(ex.getMessage());
        }

    }

}
