/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package raporlama;

import com.lowagie.text.DocumentException;
import com.lowagie.text.pdf.PdfReader;
import com.lowagie.text.pdf.PdfStamper;
import java.io.ByteArrayOutputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.ArrayList;
import static raporlama.islemRaporuPDF.dosyaAdi;
import tablolar.islem;
import tablolar.senet;
import veritabani.kasaRaporlama;

/**
 *
 * @author Java2
 */
public class senetRaporuPDF {

    public static String dosyaAdi = "";

    public String senetRaporu(int senet_ogrenci_id) throws DocumentException, FileNotFoundException, IOException {
        kasaRaporlama kr = new kasaRaporlama();
        ArrayList<senet> senetliste = kr.senetGetir(senet_ogrenci_id);
        PdfReader pdfTemplate = new PdfReader("senetislemtemplate.pdf");
        dosyaAdi = senetliste.get(0).getSenet_ogrenci_id() + "_" + senetliste.get(0).getOdeme_miktari() + "_odeme.pdf";
        FileOutputStream fileOutputStream = new FileOutputStream(dosyaAdi);
        ByteArrayOutputStream out = new ByteArrayOutputStream();
        PdfStamper stamper = new PdfStamper(pdfTemplate, fileOutputStream);
        stamper.setFormFlattening(true);

        stamper.getAcroFields().setField("senet_ogrenci_id", String.valueOf(senetliste.get(0).getSenet_ogrenci_id()));
        stamper.getAcroFields().setField("taksit_sayisi", String.valueOf(senetliste.get(0).getToplam_taksit()));

        String taksitliste = "";
        for (senet item : senetliste) {
            taksitliste += item.getSenet_id() + " Taksit no: " + item.getTaksit_id() + " Odeme Miktari: " + item.getOdeme_miktari() + " Senet Ödeme Durumu: " + ((item.getOdenme_bilgisi()==0)?"Ödenmedi":"Ödendi") + " Ödeme Tarihi: " + item.getOdeme_tarihi() + "\n";
        }
        stamper.getAcroFields().setField("listesenet", taksitliste);

        stamper.close();
        pdfTemplate.close();
        return "Raporunuz Yazdırılmaya Hazır Şekilde PDF olarak Kaydedildi.";
    }
}
