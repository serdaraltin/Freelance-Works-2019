/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package veritabani;

import com.lowagie.text.DocumentException;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import tablolar.islem;
import tablolar.senet;

/**
 *
 * @author Java2
 */
public class kasaRaporlama {

    public islem islemGetir() throws DocumentException, FileNotFoundException, IOException {
        islem i = null;
        try {
            Statement statement = new ConnectionManager().connect().createStatement();
            ResultSet rs = statement.executeQuery("SELECT * FROM kasa ORDER BY islem_id DESC LIMIT 1");
            while (rs.next()) {
                i = new islem(rs.getInt("islem_id"), rs.getInt("islem_id"), rs.getString("islem_tarihi"), rs.getInt("miktar"),
                        rs.getString("odeme_sekli"), rs.getString("islem_tipi"), rs.getString("aciklama"), rs.getInt("islem_id"));
            }
            
        } catch (SQLException ex) {
            Logger.getLogger(kasaRaporlama.class.getName()).log(Level.SEVERE, null, ex);
        }
        return i;
    }
    public  ArrayList<senet> senetGetir(int senet_ogrenci_id){
   
        ArrayList<senet> listesenet= new ArrayList<>();
        try {
             Statement statement = new ConnectionManager().connect().createStatement();
            ResultSet rs = statement.executeQuery("SELECT * FROM senet where senet_ogrenci_id='"+senet_ogrenci_id+"'");
            while (rs.next()) {
                senet s = new senet(rs.getInt("senet_id"),rs.getInt("senet_ogrenci_id"), rs.getInt("toplam_taksit"),rs.getInt("taksit_id"), rs.getInt("toplam_miktar"),
                       rs.getInt("odeme_miktari"),rs.getString("vade_tarihi"),rs.getInt("odenme_bilgisi"),rs.getString("odeme_tarihi"));
            listesenet.add(s);
            }
        } catch (SQLException e) {
            
        }
    return listesenet;
    }
}
