package cansupolat;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;

public abstract class Islemler {
	
	private int Toplama(int Sayi1, int Sayi2, int Sayi3, int Sayi4) {
		
		return 0;
	}
	
	private int Cikarma(int Sayi1, int Sayi2, int Sayi3, int Sayi4) {
		
		return 0;
	}
	
	private int Ortalama(int Sayi1, int Sayi2, int Sayi3, int Sayi4) {
		
		return 0;
	}
	
    private static void DosyayaEkle(String metin){
        try{
              File dosya = new File("dosya.txt");
              FileWriter yazici = new FileWriter(dosya,true);
              BufferedWriter yaz = new BufferedWriter(yazici);
              yaz.write(metin);
              yaz.close();
             // System.out.println("Ekleme Ýþlemi Baþarýlý");
        }
        catch (Exception hata){
              hata.printStackTrace();
        }
    }

}
