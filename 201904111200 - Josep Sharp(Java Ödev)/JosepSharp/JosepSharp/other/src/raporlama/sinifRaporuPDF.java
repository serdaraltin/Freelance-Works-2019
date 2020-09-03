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
import tablolar.ogrenci;
import veritabani.sinifRaporlama;

/**
 *
 * @author Java2
 */
public class sinifRaporuPDF {

    public static String dosyaAdi = "";

    public String sinifRapor(String grupNo) throws DocumentException, FileNotFoundException, IOException {
        sinifRaporlama sr = new sinifRaporlama();
        ArrayList<ogrenci> ogrenciliste = sr.listeGetir(grupNo);
       
        PdfReader pdfTemplate = new PdfReader("gruptemplate.pdf");
        dosyaAdi = "test.pdf";
        FileOutputStream fileOutputStream = new FileOutputStream(dosyaAdi);
        ByteArrayOutputStream out = new ByteArrayOutputStream();
        PdfStamper stamper = new PdfStamper(pdfTemplate, fileOutputStream);
        stamper.setFormFlattening(true);

        stamper.getAcroFields().setField("grupNo", ogrenciliste.get(0).getGrupNo());

        String ogrencilistesi = "";
        for (ogrenci item : ogrenciliste) {
            ogrencilistesi += item.getOgrenciId() + " --"+item.getOgrenciAdi() +" " +item.getOgrenciSoyadi() + "\n\n";
       ogrencilistesi+="________________________________";
        }
        stamper.getAcroFields().setField("ogrenciadsoyad", ogrencilistesi);

        stamper.close();
        pdfTemplate.close();
        return "Raporunuz Yazdırılmaya Hazır Şekilde PDF olarak Kaydedildi.";
    }
}
