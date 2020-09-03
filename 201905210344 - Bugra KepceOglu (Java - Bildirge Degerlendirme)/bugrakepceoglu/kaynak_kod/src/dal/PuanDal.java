package dal;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

import core.ObjectHelper;
import interfaces.DAlInterfaces;
import types.PuanContract;

public class PuanDal extends ObjectHelper implements DAlInterfaces<PuanContract>{

	@Override
	public void Insert(PuanContract entity) {
		Connection connection = getConnection();
		
		Statement statement;
		try {
			statement = connection.createStatement();
			statement.executeUpdate("Insert Into puan(BildirgeId,HakemId,Puan) Values('"+entity.getBildirgeId()+"','"+entity.getHakemId()+"','"+entity.getPuan()+"')");
			statement.close();
			connection.close();
			
		} catch (SQLException e) {
			
			e.printStackTrace();
		}	
	}

	@Override
	public List<PuanContract> GetAll() {
		
		List<PuanContract> dataContract = new ArrayList<PuanContract>();
		
		PuanContract contract;
		
		Connection connection = getConnection();
		
		Statement statement;
		try {
			statement = connection.createStatement();
			ResultSet resultSet = statement.executeQuery("Select * From bildirge");
			while(resultSet.next()) {
				contract = new PuanContract();
				contract.setId(resultSet.getInt("Id"));
				contract.setBildirgeId(resultSet.getInt("BildirgeId"));
				contract.setHakemId(resultSet.getInt("HakemId"));
				contract.setPuan(resultSet.getInt("Puan"));
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
	public PuanContract Delete(PuanContract entity) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public void Update(PuanContract entity) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public List<PuanContract> GetById(int id) {
		// TODO Auto-generated method stub
		return null;
	}

}
