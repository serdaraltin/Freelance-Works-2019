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
import tablolar.islem;
import veritabani.kasaRaporlama;

/**
 *
 * @author Java2
 */
public class islemRaporuPDF {

    public static String dosyaAdi = "";

    public String islemRaporu() throws DocumentException, FileNotFoundException, IOException {
        kasaRaporlama kr = new kasaRaporlama();
        islem i = kr.islemGetir();
        PdfReader pdfTemplate = new PdfReader("kasaislemtemplate.pdf");
        dosyaAdi = i.getIslem_tipi() + i.getKasa_ogrenci_id() + "ISLEM.pdf";
        FileOutputStream fileOutputStream = new FileOutputStream(dosyaAdi);
        ByteArrayOutputStream out = new ByteArrayOutputStream();
        PdfStamper stamper = new PdfStamper(pdfTemplate, fileOutputStream);
        stamper.setFormFlattening(true);

        stamper.getAcroFields().setField("tarih", i.getIslem_tarihi());
        stamper.getAcroFields().setField("islemtipi", i.getIslem_tipi());
        stamper.getAcroFields().setField("odemesekli", i.getOdeme_sekli());
        stamper.getAcroFields().setField("miktar", String.valueOf(i.getMiktar()));
        stamper.getAcroFields().setField("aciklama", i.getAciklama());

        stamper.close();
        pdfTemplate.close();
        return "Raporunuz Yazdırılmaya Hazır Şekilde PDF olarak Kaydedildi.";
    }
}
