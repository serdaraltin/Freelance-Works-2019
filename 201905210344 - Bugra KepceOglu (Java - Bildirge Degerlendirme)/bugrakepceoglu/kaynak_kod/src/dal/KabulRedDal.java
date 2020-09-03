package dal;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

import core.ObjectHelper;
import interfaces.DAlInterfaces;
import types.KabulRedContract;

public class KabulRedDal extends ObjectHelper implements DAlInterfaces<KabulRedContract>{

	@Override
	public void Insert(KabulRedContract entity) {
		Connection connection = getConnection();
		
		Statement statement;
		try {
			statement = connection.createStatement();
			statement.executeUpdate("Insert Into kabulred(BildirgeId,Durum) Values('"+entity.getBildirgeId()+"','"+entity.getDurum()+"')");
			statement.close();
			connection.close();
			
		} catch (SQLException e) {
			
			e.printStackTrace();
		}	
	}

	@Override
	public List<KabulRedContract> GetAll() {
		List<KabulRedContract> dataContract = new ArrayList<KabulRedContract>();
		
		KabulRedContract contract;
		
		Connection connection = getConnection();
		
		Statement statement;
		try {
			statement = connection.createStatement();
			ResultSet resultSet = statement.executeQuery("Select * From kabulred");
			while(resultSet.next()) {
				contract = new KabulRedContract();
				contract.setId(resultSet.getInt("Id"));
				contract.setBildirgeId(resultSet.getInt("BildirgeId"));
				contract.setDurum(resultSet.getString("Durum"));
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
	public KabulRedContract Delete(KabulRedContract entity) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public void Update(KabulRedContract entity) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public List<KabulRedContract> GetById(int id) {
		// TODO Auto-generated method stub
		return null;
	}

}
