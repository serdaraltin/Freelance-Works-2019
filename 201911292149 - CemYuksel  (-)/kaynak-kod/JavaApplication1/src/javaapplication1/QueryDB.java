package javaapplication1;


import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.SQLException;
import java.sql.Statement;


public class QueryDB {
    
    public static final String DRIVER = "org.apache.derby.jdbc.EmbeddedDriver";
    public static final String JDBC_URL = "jdbc:derby:database;create=true";
    
    public static final String SQL_STATEMENT = "select *from yazi";
    public static void main(String[] args) throws SQLException{
        Connection connection = DriverManager.getConnection(JDBC_URL);
        Statement statement = connection.createStatement();
        ResultSet resultSet = statement.executeQuery(SQL_STATEMENT);
        ResultSetMetaData resultSetMetaData = resultSet.getMetaData();
        while(resultSet.next())
        {
           System.out.println(resultSet.getString("baslik")+"\n"+resultSet.getString("icerik")+"\n"+
                   resultSet.getString("yazar"));
        }
    }
}
