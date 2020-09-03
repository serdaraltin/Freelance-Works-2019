package controller;

import dao.futbolcuDao;
import entity.futbolcu;
import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;
import javax.enterprise.context.SessionScoped;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.RequestScoped;

@ManagedBean
@SessionScoped
@RequestScoped
public class futbolcuController implements Serializable {

    private static final long serialVersionUID = 6081417964063918994L;

    private futbolcuDao futbolculardao;
    private ArrayList<futbolcu> futbolcular;

    public futbolcuController() {
        this.futbolcular = new ArrayList();
        this.futbolculardao = new futbolcuDao();
    }

    public ArrayList<futbolcu> listele() {
        ArrayList<futbolcu> ful = new ArrayList<>();
        futbolcu f = new futbolcu("ad", "soyad", 0, "milliyet", "takim", 0, 0, 0);
        ful.add(f);
        return ful;
    }

    public void Ekle(futbolcu f) {
        boolean sonuc = futbolculardao.Ekle(f);
        if (!sonuc) {
            System.out.println("ekleme islemi basarisiz !!!");
        }
    }

    public void Guncelle(futbolcu f) {
        boolean sonuc = futbolculardao.Guncelle(f);
        if (!sonuc) {
            System.out.println("guncelleme islemi basarisiz !!!");
        }
    }

    public ArrayList<futbolcu> Bul(String ad) {
        return futbolculardao.Sorgula(ad);
    }

    public List<futbolcu> getFutbolcular() {
        return futbolcular;
    }

    public void setFutbolcular(ArrayList<futbolcu> futbolcular) {
        this.futbolcular = futbolcular;
    }

    public futbolcuDao getFutbolculardao() {
        return futbolculardao;
    }

    public void setFutbolculardao(futbolcuDao futbolculardao) {
        this.futbolculardao = futbolculardao;
    }

}
