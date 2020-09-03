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
public class islem {

    private int islem_id;
    private int hareket;
    private String islem_tarihi;
    private int miktar;
    private String odeme_sekli;

    public int getIslem_id() {
        return islem_id;
    }

    public void setIslem_id(int islem_id) {
        this.islem_id = islem_id;
    }

    public int getHareket() {
        return hareket;
    }

    public void setHareket(int hareket) {
        this.hareket = hareket;
    }

    public String getIslem_tarihi() {
        return islem_tarihi;
    }

    public void setIslem_tarihi(String islem_tarihi) {
        this.islem_tarihi = islem_tarihi;
    }

    public int getMiktar() {
        return miktar;
    }

    public void setMiktar(int miktar) {
        this.miktar = miktar;
    }

    public String getOdeme_sekli() {
        return odeme_sekli;
    }

    public void setOdeme_sekli(String odeme_sekli) {
        this.odeme_sekli = odeme_sekli;
    }

    public String getIslem_tipi() {
        return islem_tipi;
    }

    public void setIslem_tipi(String islem_tipi) {
        this.islem_tipi = islem_tipi;
    }

    public String getAciklama() {
        return aciklama;
    }

    public void setAciklama(String aciklama) {
        this.aciklama = aciklama;
    }

    public int getKasa_ogrenci_id() {
        return kasa_ogrenci_id;
    }

    public void setKasa_ogrenci_id(int kasa_ogrenci_id) {
        this.kasa_ogrenci_id = kasa_ogrenci_id;
    }
    private String islem_tipi;
    private String aciklama;
    private int kasa_ogrenci_id;

    public islem(int islem_id, int hareket, String islem_tarihi, int miktar, String odeme_sekli, String islem_tipi, String aciklama, int kasa_ogrenci_id) {
        this.islem_id = islem_id;
        this.hareket = hareket;
        this.islem_tarihi = islem_tarihi;
        this.miktar = miktar;
        this.odeme_sekli = odeme_sekli;
        this.islem_tipi = islem_tipi;
        this.aciklama = aciklama;
        this.kasa_ogrenci_id = kasa_ogrenci_id;
    }

    public islem() {
    }

}
