/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tablolar;

/**
 *
 * @author Java2
 */
public class senet {
    private int senet_id;
    private int senet_ogrenci_id;
    private int toplam_taksit ;
    private int taksit_id;
    private int toplam_miktar;
    private int odeme_miktari;
    private String vade_tarihi;
    private int odenme_bilgisi;
    private String odeme_tarihi;

    public int getSenet_id() {
        return senet_id;
    }

    public void setSenet_id(int senet_id) {
        this.senet_id = senet_id;
    }

    public int getSenet_ogrenci_id() {
        return senet_ogrenci_id;
    }

    public void setSenet_ogrenci_id(int senet_ogrenci_id) {
        this.senet_ogrenci_id = senet_ogrenci_id;
    }

    public int getToplam_taksit() {
        return toplam_taksit;
    }

    public void setToplam_taksit(int toplam_taksit) {
        this.toplam_taksit = toplam_taksit;
    }

    public int getTaksit_id() {
        return taksit_id;
    }

    public void setTaksit_id(int taksit_id) {
        this.taksit_id = taksit_id;
    }

    public int getToplam_miktar() {
        return toplam_miktar;
    }

    public void setToplam_miktar(int toplam_miktar) {
        this.toplam_miktar = toplam_miktar;
    }

    public int getOdeme_miktari() {
        return odeme_miktari;
    }

    public void setOdeme_miktari(int odeme_miktari) {
        this.odeme_miktari = odeme_miktari;
    }

    public String getVade_tarihi() {
        return vade_tarihi;
    }

    public void setVade_tarihi(String vade_tarihi) {
        this.vade_tarihi = vade_tarihi;
    }

    public int getOdenme_bilgisi() {
        return odenme_bilgisi;
    }

    public void setOdenme_bilgisi(int odenme_bilgisi) {
        this.odenme_bilgisi = odenme_bilgisi;
    }

    public String getOdeme_tarihi() {
        return odeme_tarihi;
    }

    public void setOdeme_tarihi(String odeme_tarihi) {
        this.odeme_tarihi = odeme_tarihi;
    }

    public senet(int senet_id, int senet_ogrenci_id, int toplam_taksit, int taksit_id, int toplam_miktar, int odeme_miktari, String vade_tarihi, int odenme_bilgisi, String odeme_tarihi) {
        this.senet_id = senet_id;
        this.senet_ogrenci_id = senet_ogrenci_id;
        this.toplam_taksit = toplam_taksit;
        this.taksit_id = taksit_id;
        this.toplam_miktar = toplam_miktar;
        this.odeme_miktari = odeme_miktari;
        this.vade_tarihi = vade_tarihi;
        this.odenme_bilgisi = odenme_bilgisi;
        this.odeme_tarihi = odeme_tarihi;
    }
    
}
