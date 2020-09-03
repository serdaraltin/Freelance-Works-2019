package core;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

import interfaces.CoreInterface;

public class ObjectHelper extends CoreFields implements CoreInterface{
	
	static {
		try {
			Class.forName("com.mysql.jdbc.Driver");
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
	}
	

	@Override
	public Connection getConnection() {
		
		Connection connection = null;
		
		try {
			connection = (Connection)DriverManager.getConnection(getUrl(),getUserName(),getPassword());
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return connection;
	}

}
