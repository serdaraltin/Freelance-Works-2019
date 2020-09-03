package controller;

import dao.WriteDAO;
import entity.Write;
import java.io.Serializable;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import javax.enterprise.context.SessionScoped;
import javax.faces.bean.ManagedBean;
import javax.inject.Named;
import util.ConnectionDB;


@ManagedBean(name="writecontroller")
@SessionScoped
public class WriteController implements Serializable{   
    private static final long serialVersionUID = 1L;
    private List<Write> wlist;
    private WriteDAO wdao;
    
     public WriteController() {
        this.wlist = new ArrayList();
        wdao = new WriteDAO();
    }

    public List<Write> getwList() {
        this.wlist = this.getWdao().getWrites();
        return wlist;
    }

    public void setwList(List<Write> wList) {
        this.wlist = wList;
    }

    public WriteDAO getWdao() {
        return wdao;
    }

    public void setWdao(WriteDAO wdao) {
        this.wdao = wdao;
    }

  

}
