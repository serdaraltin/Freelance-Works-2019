/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package veritabani;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import tablolar.ogrenci;

/**
 *
 * @author Java2
 */
public class sinifRaporlama {
ArrayList<ogrenci> listeogrenci=null;
    public ArrayList<ogrenci> listeGetir(String grupNo) {

     listeogrenci = new ArrayList<ogrenci>();
        try {
            Statement statement = new ConnectionManager().connect().createStatement();
            ResultSet rs = statement.executeQuery("select * from ogrenci where grupNo='"+grupNo+"'");
            while (rs.next()) {
                ogrenci o = new ogrenci(rs.getInt("ogrenciId"), rs.getString("ogrenciAdi"),
                        rs.getString("ogrenciSoyadi"), rs.getDate("ogrenciDogumTarihi"),
                        rs.getString("grupNo"), rs.getString("ogrenciTc"), rs.getString("ogrenciTel"),
                        rs.getString("ogrenciMail"), 
                        rs.getString("ogrenciAdres"), rs.getString("veliAdSoyad"));
                System.out.println(o.toString());
                listeogrenci.add(o);
            }
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
        return listeogrenci;
    }
}
