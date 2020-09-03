package test;

import controller.WriteController;
import dao.WriteDAO;
import entity.Write;
import java.sql.SQLException;

public class run {

    public static void main(String[] args) throws ClassNotFoundException, SQLException {
        WriteController writeController = new WriteController();
        WriteDAO writeDAO = new WriteDAO();

        Write write = new Write();
        write.setBaslik("insert1baslik");
        write.setIcerik("insert1icerik");
        write.setYazar("insert1yazar");
        writeDAO.insert(write);

        writeDAO.delete(2);

        Write write2 = new Write();
        write2.setId(3);
        write2.setBaslik("update1baslik");
        write2.setIcerik("update1icerik");
        write2.setYazar("update1yazar");

        writeDAO.update(write2);

        for (Write w : writeController.getwList()) {
            System.out.println(w);
        }

    }
}
