package dal;

import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;
import java.sql.SQLException;
import java.sql.Statement;


import core.ObjectHelper;
import interfaces.DAlInterfaces;
import types.HakemContract;

public class HakemDal extends ObjectHelper implements DAlInterfaces<HakemContract>{

	@Override
	public void Insert(HakemContract entity) {
		Connection connection = getConnection();
		
		Statement statement;
		try {
			statement = connection.createStatement();
			statement.executeUpdate("Insert Into hakem(KullaniciAd,Parola,Anahtar) Values('"+entity.getKullaniciAd()+"','"+entity.getParola()+"','"+entity.getAnahtar()+"')");
			statement.close();
			connection.close();
			
		} catch (SQLException e) {
			
			e.printStackTrace();
		}	
	}

	@Override
	public List<HakemContract> GetAll() {
		List<HakemContract> dataContract = new ArrayList<HakemContract>();
		
		HakemContract contract;
		
		Connection connection = getConnection();
		
		Statement statement;
		try {
			statement = connection.createStatement();
			ResultSet resultSet = statement.executeQuery("Select * From hakem");
			while(resultSet.next()) {
				contract = new HakemContract();
				contract.setId(resultSet.getInt("Id"));
				contract.setKullaniciAd(resultSet.getString("KullaniciAd"));
				contract.setParola(resultSet.getString("Parola"));
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
	public HakemContract Delete(HakemContract entity) {
		
		
		return null;
	}

	@Override
	public void Update(HakemContract entity) {
		
		
	}

	@Override
	public List<HakemContract> GetById(int id) {
	
		
		return null;
	}

	public boolean Kontrol(String KullaniciAd, String Parola) {
		Connection connection = getConnection();
		
		Statement statement;
		try {
			statement = connection.createStatement();
			ResultSet resultSet = statement.executeQuery("Select * From hakem Where KullaniciAd='"+KullaniciAd+"' AND Parola='"+Parola+"'");
			if(resultSet.next())
				return true;
			else
				return false;
			
		} catch (SQLException e) {
			e.printStackTrace();
		}
		
		return false;
	}
}
