package dao;

import entity.futbolcu;
import java.io.Serializable;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.enterprise.context.SessionScoped;
import javax.faces.bean.ManagedBean;
import util.ConnectionDB;

@ManagedBean
public class futbolcuDao {

    public ArrayList<futbolcu> listele() {
        ArrayList<futbolcu> futbolcular = new ArrayList();
        try {

            ConnectionDB db = new ConnectionDB();
            Connection connection = db.connect();

            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("Select *From futbolcu");

            while (resultSet.next()) {
                futbolcu f = new futbolcu();
                f.setId(resultSet.getInt("id"));
                f.setAd(resultSet.getString("ad"));
                f.setSoyad(resultSet.getString("soyad"));
                f.setYas(resultSet.getInt("yas"));
                f.setMilliyet(resultSet.getString("milliyet"));
                f.setTakim(resultSet.getString("takim"));
                f.setMac_sayi(resultSet.getInt("mac_sayi"));
                f.setGol_sayi(resultSet.getInt("gol_sayi"));
                f.setAsist_sayi(resultSet.getInt("asist_sayi"));
                futbolcular.add(f);
            }

            return futbolcular;
        } catch (SQLException ex) {
            Logger.getLogger(futbolcuDao.class.getName()).log(Level.SEVERE, null, ex);
        }
        return null;
    }

    public boolean Ekle(futbolcu f) {

        try {
            ConnectionDB db = new ConnectionDB();
            Connection connection = db.connect();

            Statement statement = connection.createStatement();

            statement.executeUpdate("Insert Into futbolcu "
                    + "(id,ad,soyad,yas,milliyet,takim,mac_sayi,gol_sayi,asist_sayi) "
                    + "values(DEFAULT,'" + f.getAd() + "','" + f.getSoyad() + "'," + f.getYas() + ", '" + f.getMilliyet() + "','" + f.getTakim() + "'," + f.getMac_sayi() + "," + f.getGol_sayi() + "," + f.getAsist_sayi() + ")");

            return true;
        } catch (SQLException ex) {
            Logger.getLogger(futbolcuDao.class.getName()).log(Level.SEVERE, null, ex);
        }
        return false;
    }

    public boolean Guncelle(futbolcu f) {
        try {
            ConnectionDB db = new ConnectionDB();
            Connection connection = db.connect();
            Statement statement = connection.createStatement();
            statement.executeUpdate("Update futbolcu set "
                    + "ad='" + f.getAd() + "',"
                    + "soyad='" + f.getSoyad() + "',"
                    + "yas=" + f.getYas() + ","
                    + "milliyet='" + f.getMilliyet() + "',"
                    + "takim='" + f.getTakim() + "',"
                    + "mac_sayi=" + f.getMac_sayi() + ","
                    + "gol_sayi=" + f.getGol_sayi() + ","
                    + "asist_sayi=" + f.getAsist_sayi() + ")");
            return true;
        } catch (SQLException ex) {
            Logger.getLogger(futbolcuDao.class.getName()).log(Level.SEVERE, null, ex);
        }
        return false;
    }

    public boolean Sil(futbolcu f) {
        try {
            ConnectionDB db = new ConnectionDB();
            Connection connection = db.connect();
            Statement statement = connection.createStatement();
            statement.executeUpdate("Delete From futbolcu where Id=" + f.getId());
            return true;
        } catch (SQLException ex) {
            Logger.getLogger(futbolcuDao.class.getName()).log(Level.SEVERE, null, ex);
        }
        return false;
    }

    public ArrayList<futbolcu> Sorgula(String ad) {
        ArrayList<futbolcu> futbolcular = new ArrayList();
        try {

            ConnectionDB db = new ConnectionDB();
            Connection connection = db.connect();

            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("Select *From futbolcu where ad='" + ad + "'");

            while (resultSet.next()) {
                futbolcu f = new futbolcu();
                f.setId(resultSet.getInt("id"));
                f.setAd(resultSet.getString("ad"));
                f.setSoyad(resultSet.getString("soyad"));
                f.setYas(resultSet.getInt("yas"));
                f.setMilliyet(resultSet.getString("milliyet"));
                f.setTakim(resultSet.getString("takim"));
                f.setMac_sayi(resultSet.getInt("mac_sayi"));
                f.setGol_sayi(resultSet.getInt("gol_sayi"));
                f.setAsist_sayi(resultSet.getInt("asist_sayi"));
                futbolcular.add(f);
            }
            return futbolcular;
        } catch (SQLException ex) {
            Logger.getLogger(futbolcuDao.class.getName()).log(Level.SEVERE, null, ex);
        }
        return null;
    }
}
