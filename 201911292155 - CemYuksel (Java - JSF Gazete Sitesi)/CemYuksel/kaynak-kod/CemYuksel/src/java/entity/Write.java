package entity;

import java.io.Serializable;
import javax.enterprise.context.SessionScoped;
import javax.inject.Named;


@Named
@SessionScoped
public class Write implements Serializable{
    private int Id=0;
    private String baslik;
    private String icerik;
    private String yazar;
    
    public int getId() {
        return Id;
    }

    public void setId(int Id) {
        this.Id = Id;
    }
  

    public Write(int Id, String baslik, String icerik, String yazar) {
        this.Id = Id;
        this.baslik = baslik;
        this.icerik = icerik;
        this.yazar = yazar;
    }


    public Write() {
    }

    public String getBaslik() {
        return baslik;
    }

    public void setBaslik(String baslik) {
        this.baslik = baslik;
    }

    public String getIcerik() {
        return icerik;
    }

    public void setIcerik(String icerik) {
        this.icerik = icerik;
    }

    public String getYazar() {
        return yazar;
    }

    public void setYazar(String yazar) {
        this.yazar = yazar;
    }

    @Override
    public String toString() {
        return "Write{" + "Id=" + Id + ", baslik=" + baslik + ", icerik=" + icerik + ", yazar=" + yazar + '}';
    }


    
    
    
    
}
