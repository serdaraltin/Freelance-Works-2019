package dao;

import entity.Write;
import java.io.Serializable;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import util.ConnectionDB;
import javax.enterprise.context.SessionScoped;
import javax.faces.bean.ManagedBean;
//import javax.inject.Named;

@ManagedBean(name = "writeDAO")
@SessionScoped
public class WriteDAO implements Serializable {

    public List<Write> getWrites() {

        List<Write> writeList = new ArrayList();
        try {
            ConnectionDB db = new ConnectionDB();
            Connection connection = db.connect();

            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("select * from yazi");

            while (resultSet.next()) {
                Write w = new Write(
                        resultSet.getInt("id"),
                        resultSet.getString("baslik"),
                        resultSet.getString("icerik"),
                        resultSet.getString("yazar"));
                writeList.add(w);
            }

            return writeList;
        } catch (SQLException ex) {
            Logger.getLogger(WriteDAO.class.getName()).log(Level.SEVERE, null, ex);
        }
        return null;
    }

    public void insert(Write write) throws ClassNotFoundException, SQLException {
        ConnectionDB db = new ConnectionDB();
        Connection connection = db.connect();
        Statement statement = connection.createStatement();
        if (write.getId() == 0) {
            statement.executeUpdate("insert into yazi(id,baslik,icerik,yazar) values(DEFAULT,'" + write.getBaslik() + "','" + write.getIcerik() + "','" + write.getYazar() + "')");
        } else {
            statement.executeUpdate("insert into yazi(id,baslik,icerik,yazar) values('" + write.getId() + "','" + write.getBaslik() + "','" + write.getIcerik() + "','" + write.getYazar() + "')");
        }
        return;
    }

    public void update(Write write) throws ClassNotFoundException, SQLException {
        ConnectionDB db = new ConnectionDB();
        Connection connection = db.connect();
        Statement statement = connection.createStatement();
        statement.executeUpdate("update yazi set baslik='" + write.getBaslik() + "',icerik='" + write.getIcerik() + "',yazar='" + write.getYazar() + "' where id=" + write.getId());
    }

    public void delete(int Id) throws ClassNotFoundException, SQLException {
        ConnectionDB db = new ConnectionDB();
        Connection connection = db.connect();
        Statement statement = connection.createStatement();
        statement.executeUpdate("delete from yazi where id=" + Id);
    }

}
