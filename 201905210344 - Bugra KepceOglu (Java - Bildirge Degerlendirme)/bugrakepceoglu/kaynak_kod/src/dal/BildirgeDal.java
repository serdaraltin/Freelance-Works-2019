package dal;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

import core.ObjectHelper;
import interfaces.DAlInterfaces;
import types.BildirgeContract;

public class BildirgeDal extends ObjectHelper implements DAlInterfaces<BildirgeContract>{

	@Override
	public void Insert(BildirgeContract entity) {
		Connection connection = getConnection();
		
		Statement statement;
		try {
			statement = connection.createStatement();
			statement.executeUpdate("Insert Into bildirge(Baslik,Metin,Anahtar) Values('"+entity.getBaslik()+"','"+entity.getMetin()+"','"+entity.getAnahtar()+"')");
			statement.close();
			connection.close();
			
		} catch (SQLException e) {
			
			e.printStackTrace();
		}	
	}

	@Override
	public List<BildirgeContract> GetAll() {
		
		List<BildirgeContract> dataContract = new ArrayList<BildirgeContract>();
		
		BildirgeContract contract;
		
		Connection connection = getConnection();
		
		Statement statement;
		try {
			statement = connection.createStatement();
			ResultSet resultSet = statement.executeQuery("Select * From bildirge");
			while(resultSet.next()) {
				contract = new BildirgeContract();
				contract.setId(resultSet.getInt("Id"));
				contract.setBaslik(resultSet.getString("Baslik"));
				contract.setMetin(resultSet.getString("Metin"));
				contract.setAnahtar(resultSet.getString("Anahtar"));
				dataContract.add(contract);
			}
			
			statement.close();
			connection.close();
			
		} catch (SQLException e) {
			e.printStackTrace();
		}
		
		return dataContract;
	}

	@Override
	public BildirgeContract Delete(BildirgeContract entity) {
		return null;
	}

	@Override
	public void Update(BildirgeContract entity) {
		
	}

	@Override
	public List<BildirgeContract> GetById(int id) {
		return null;
	}
	
	public int GetId(String Baslik) {
		
		Connection connection = getConnection();
		
		try {
			Statement statement = connection.createStatement();
			ResultSet resultSet = statement.executeQuery("Select *From bildirge Where Baslik='"+Baslik+"'");
			int Id = 0;
			while(resultSet.next()) {
				Id = resultSet.getInt("Id");
			}
			statement.close();
			connection.close();
			
			return Id;
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return 0;
	}

}
