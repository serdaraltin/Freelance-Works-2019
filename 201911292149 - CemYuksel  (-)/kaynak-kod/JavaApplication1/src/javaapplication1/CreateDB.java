package javaapplication1;


import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;


public class CreateDB {
    
    public static final String DRIVER = "org.apache.derby.jdbc.EmbeddedDriver";
    public static final String JDBC_URL = "jdbc:derby:database;create=true";
    
    public static void main(String[] args) throws ClassNotFoundException, SQLException{
        Class.forName(DRIVER);
        Connection connection = DriverManager.getConnection(JDBC_URL);
        connection.createStatement().execute("create table yazi(baslik varchar(20), icerik varchar(250), yazar varchar(20))");
        connection.createStatement().execute("insert into yazi values('haber basligi','haber icerigi','serdar eyup altin')");
    }
    
}
