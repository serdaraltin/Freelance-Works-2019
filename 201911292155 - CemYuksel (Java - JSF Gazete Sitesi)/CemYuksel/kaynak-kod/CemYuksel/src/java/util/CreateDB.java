package util;

import controller.WriteController;
import entity.Write;
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
            connection.createStatement().execute("create table yazi("
                    + "id int generated by default as identity (START WITH 2, INCREMENT BY 1),"
                    + "baslik varchar(20),"
                    + "icerik varchar(250),"
                    + "yazar varchar(20))");
            connection.createStatement().execute("insert into yazi values(DEFAULT,'haber basligi1','haber icerigi1','yazar1')");
            connection.createStatement().execute("insert into yazi values(DEFAULT,'haber basligi2','haber icerigi2','yazar2')");
            connection.createStatement().execute("insert into yazi values(DEFAULT,'haber basligi3','haber icerigi3','yazar3')");
            connection.createStatement().execute("insert into yazi values(DEFAULT,'haber basligi4','haber icerigi4','yazar4')");
        } catch (SQLException ex) {
            System.err.println(ex.getMessage());
        }

    }

}
