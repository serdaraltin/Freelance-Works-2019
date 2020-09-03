/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tablolar;

import java.sql.Date;

/**
 *
 * @author Java2
 */
public class ogrenci {

    private int ogrenciId;
    private String ogrenciAdi;
    private String ogrenciSoyadi;
    private Date ogrenciDogumTarihi;
    private String grupNo;
    private String ogrenciTc;
    private String ogrenciTel;
    private String ogrenciMail;
    private String ogrenciAdres;
    private String veliAdSoyad;

    public int getOgrenciId() {
        return ogrenciId;
    }

    public void setOgrenciId(int ogrenciId) {
        this.ogrenciId = ogrenciId;
    }

    public String getOgrenciAdi() {
        return ogrenciAdi;
    }

    public void setOgrenciAdi(String ogrenciAdi) {
        this.ogrenciAdi = ogrenciAdi;
    }

    public String getOgrenciSoyadi() {
        return ogrenciSoyadi;
    }

    public void setOgrenciSoyadi(String ogrenciSoyadi) {
        this.ogrenciSoyadi = ogrenciSoyadi;
    }

    public Date getOgrenciDogumTarihi() {
        return ogrenciDogumTarihi;
    }

    public void setOgrenciDogumTarihi(Date ogrenciDogumTarihi) {
        this.ogrenciDogumTarihi = ogrenciDogumTarihi;
    }

    public String getGrupNo() {
        return grupNo;
    }

    public void setGrupNo(String grupNo) {
        this.grupNo = grupNo;
    }

    public String getOgrenciTc() {
        return ogrenciTc;
    }

    public void setOgrenciTc(String ogrenciTc) {
        this.ogrenciTc = ogrenciTc;
    }

    public String getOgrenciTel() {
        return ogrenciTel;
    }

    public void setOgrenciTel(String ogrenciTel) {
        this.ogrenciTel = ogrenciTel;
    }

    public String getOgrenciMail() {
        return ogrenciMail;
    }

    public void setOgrenciMail(String ogrenciMail) {
        this.ogrenciMail = ogrenciMail;
    }

    public String getOgrenciAdres() {
        return ogrenciAdres;
    }

    public void setOgrenciAdres(String ogrenciAdres) {
        this.ogrenciAdres = ogrenciAdres;
    }

    public String getVeliAdSoyad() {
        return veliAdSoyad;
    }

    public void setVeliAdSoyad(String veliAdSoyad) {
        this.veliAdSoyad = veliAdSoyad;
    }

    public ogrenci(int ogrenciId, String ogrenciAdi, String ogrenciSoyadi, Date ogrenciDogumTarihi, String grupNo, String ogrenciTc, String ogrenciTel, String ogrenciMail, String ogrenciAdres, String veliAdSoyad) {
        this.ogrenciId = ogrenciId;
        this.ogrenciAdi = ogrenciAdi;
        this.ogrenciSoyadi = ogrenciSoyadi;
        this.ogrenciDogumTarihi = ogrenciDogumTarihi;
        this.grupNo = grupNo;
        this.ogrenciTc = ogrenciTc;
        this.ogrenciTel = ogrenciTel;
        this.ogrenciMail = ogrenciMail;
        this.ogrenciAdres = ogrenciAdres;
        this.veliAdSoyad = veliAdSoyad;
    }

    
    

}
