package entity;

import java.io.Serializable;
//import javax.faces.bean.SessionScoped;
import javax.enterprise.context.SessionScoped;
import javax.inject.Named;

@Named
@SessionScoped
public class futbolcu implements Serializable{
    private int id = 0;
    private String ad;
    private String soyad;
    private int yas;
    private String milliyet;
    private String takim;
    private int mac_sayi;
    private int gol_sayi;
    private int asist_sayi;

    public futbolcu(String ad, String soyad, int yas, String milliyet, String takim, int mac_sayi, int gol_sayi, int asist_sayi) {
        this.ad = ad;
        this.soyad = soyad;
        this.yas = yas;
        this.milliyet = milliyet;
        this.takim = takim;
        this.mac_sayi = mac_sayi;
        this.gol_sayi = gol_sayi;
        this.asist_sayi = asist_sayi;
    }

    public futbolcu() {
    }

    
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getAd() {
        return ad;
    }

    public void setAd(String ad) {
        this.ad = ad;
    }

    public String getSoyad() {
        return soyad;
    }

    public void setSoyad(String soyad) {
        this.soyad = soyad;
    }

    public int getYas() {
        return yas;
    }

    public void setYas(int yas) {
        this.yas = yas;
    }

    public String getMilliyet() {
        return milliyet;
    }

    public void setMilliyet(String milliyet) {
        this.milliyet = milliyet;
    }

    public String getTakim() {
        return takim;
    }

    public void setTakim(String takim) {
        this.takim = takim;
    }

    public int getMac_sayi() {
        return mac_sayi;
    }

    public void setMac_sayi(int mac_sayi) {
        this.mac_sayi = mac_sayi;
    }

    public int getGol_sayi() {
        return gol_sayi;
    }

    public void setGol_sayi(int gol_sayi) {
        this.gol_sayi = gol_sayi;
    }

    public int getAsist_sayi() {
        return asist_sayi;
    }

    public void setAsist_sayi(int asist_sayi) {
        this.asist_sayi = asist_sayi;
    }

    @Override
    public String toString() {
        return "futbolcu{" + "id=" + id + ", ad=" + ad + ", soyad=" + soyad + ", yas=" + yas + ", milliyet=" + milliyet + ", takim=" + takim + ", mac_sayi=" + mac_sayi + ", gol_sayi=" + gol_sayi + ", asist_sayi=" + asist_sayi + '}';
    }
    
    
    
}
