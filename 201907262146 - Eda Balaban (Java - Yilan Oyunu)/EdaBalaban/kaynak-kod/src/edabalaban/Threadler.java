package edabalaban;

import java.util.ArrayList;

import javax.swing.JDialog;


public class Threadler extends Thread {
	
	ArrayList<ArrayList<KareBilgiler>> Kareler = new ArrayList<ArrayList<KareBilgiler>>();
	
	Kordinat yilankafaKordinat;
	int yilanBoyut = 5;
	int yemBoyut = 1;
	long hiz = 300;
	int puan = 0;
	int sure = 0;
	int say = 0;
	public static int yilanYon;
	
	
	ArrayList<Kordinat> Kordinatlar = new ArrayList<Kordinat>();
	Kordinat yemKordinat;
	
	
	
	public Threadler(Kordinat baslangicKordinat) {
		Kareler = Pencere.Grid;
		
		yilankafaKordinat = new Kordinat(baslangicKordinat.x, baslangicKordinat.y);
		yilanYon = 3;
		
		Kordinat kafaKordinat = new Kordinat(yilankafaKordinat.getX(), yilankafaKordinat.getY());
		Kordinatlar.add(kafaKordinat);
		
		yemKordinat = RastgeleKordinatOlustur();
		YemOlustur(yemKordinat);
	}
	
	public void run() {
		
		while(true) {
			YilanHareket(yilanYon);
			CarpmaKontrol();
			DisaTasi();
			KuyrukSil();
			Durdur();
			if(say % 2 == 0) {
				sure++;	
			}
			say++;
			
		}
	}
	
	private void YemHareket() {
		Kareler.get(yemKordinat.x).get(yemKordinat.y).Renklendir(2);
		int sallaYon = 1+ (int)(Math.random()*5);
		
		if(sallaYon == 1) {
			yemKordinat.Degistir(Math.abs(yemKordinat.x+1)%20, yemKordinat.y);
			
		}
		else if(sallaYon == 2) {
			if(yemKordinat.x-1 < 0) {
				yemKordinat.Degistir(19, yemKordinat.y);
			}else {
				yemKordinat.Degistir(Math.abs(yemKordinat.x-1)%20, yemKordinat.y);
			}
			
		}
		else if(sallaYon == 3) {
			if(yemKordinat.y-1 < 0) {
				yemKordinat.Degistir(yemKordinat.x, 19);
			}else {
				yemKordinat.Degistir(yemKordinat.x, Math.abs(yemKordinat.y-1)%20);
			}
			
		}
		else if(sallaYon == 4) {
			yemKordinat.Degistir(yemKordinat.x, (yemKordinat.y+1)%20);;
			
		}
		Kareler.get(yemKordinat.x).get(yemKordinat.y).Renklendir(1);
		System.out.println("Yilan Kordinat : x="+ yilankafaKordinat.getX() +", y="+yilankafaKordinat.getY());
	}
	
	private void Durdur() {
		try {
			sleep(hiz);
		}catch (Exception e) {
			System.out.println(e.getMessage().toString());
		}
	}
	
	private void CarpmaKontrol() {
		Kordinat yilanKordinat = Kordinatlar.get(Kordinatlar.size()-1);
		
		for(int i=0; i<=Kordinatlar.size()-2; i++) {
			boolean kendiniIsirma = yilanKordinat.getX() == Kordinatlar.get(i).getX() && yilanKordinat.getY() == Kordinatlar.get(i).getY();
			
			if(kendiniIsirma && yilanBoyut > 2) {
				OyunBitti();
			}
		}
		
		boolean yemYeme = yilanKordinat.getX() == yemKordinat.y && yilanKordinat.getY() == yemKordinat.x;
		
		if(yemYeme) {
			puan += 100;
			yilanBoyut +=1;
			
			yemKordinat = RastgeleKordinatOlustur();
			YemOlustur(yemKordinat);
			System.out.println("Yilan Boyut : "+yilanBoyut);
		}else {
			if(say % 2 == 0) {
				YemHareket();
				System.out.println("Yem Kordinat : x="+ yemKordinat.getX() +", y="+yemKordinat.getY());
			}
		
		}
	
	}
	
	private void OyunBitti() {
	
		Skor dialog = new Skor(sure/2, puan);
		dialog.setLocationRelativeTo(null);
		dialog.setDefaultCloseOperation(JDialog.DISPOSE_ON_CLOSE);
		//dialog.setVisible(true);
		Durdur();
		while(true) {
			Durdur();
		}
	}
	
	private void YemOlustur(Kordinat yem_Kordinat) {
		Kareler.get(yem_Kordinat.x).get(yem_Kordinat.y).Renklendir(1);
	}
	
	
	private Kordinat RastgeleKordinatOlustur() {
		Kordinat kordinat;
		
		int sallaX = 0 + (int)(Math.random()*19);
		int sallaY = 0 + (int)(Math.random()*19);
		kordinat = new Kordinat(sallaX, sallaY);
		
		for(int i=0; i<=Kordinatlar.size()-1; i++) {
			boolean farkliMi = kordinat.getY() == Kordinatlar.get(i).getX() && kordinat.getY() == Kordinatlar.get(i).getY();
			if(farkliMi){
				sallaX = 0 + (int)(Math.random()*19);
				sallaY = 0 + (int)(Math.random()*19);
				kordinat = new Kordinat(sallaX, sallaY);
				i = 0;
			}
		}
		return kordinat;
	}
	
	private void YilanHareket(int kordinat) {
		
		boolean kenaraCarpmax = yilankafaKordinat.getX() == 0 || yilankafaKordinat.getX() == 19;
		boolean kenaraCarpmay = yilankafaKordinat.getY() == 0 || yilankafaKordinat.getY() == 19;
		
		if(kenaraCarpmax || kenaraCarpmay) {
			OyunBitti();
		}
		
		if(kordinat == 1) {
			yilankafaKordinat.Degistir(Math.abs(yilankafaKordinat.x+1)%20, yilankafaKordinat.y);
			Kordinatlar.add(new Kordinat(yilankafaKordinat.x, yilankafaKordinat.y));
		}
		else if(kordinat == 2) {
			if(yilankafaKordinat.x-1 < 0) {
				yilankafaKordinat.Degistir(19, yilankafaKordinat.y);
			}else {
				yilankafaKordinat.Degistir(Math.abs(yilankafaKordinat.x-1)%20, yilankafaKordinat.y);
			}
			Kordinatlar.add(new Kordinat(yilankafaKordinat.x, yilankafaKordinat.y));
		}
		else if(kordinat == 3) {
			if(yilankafaKordinat.y-1 < 0) {
				yilankafaKordinat.Degistir(yilankafaKordinat.x, 19);
			}else {
				yilankafaKordinat.Degistir(yilankafaKordinat.x, Math.abs(yilankafaKordinat.y-1)%20);
			}
			Kordinatlar.add(new Kordinat(yilankafaKordinat.x, yilankafaKordinat.y));
		}
		else if(kordinat == 4) {
			yilankafaKordinat.Degistir(yilankafaKordinat.x, (yilankafaKordinat.y+1)%20);;
			Kordinatlar.add(new Kordinat(yilankafaKordinat.x, yilankafaKordinat.y));
		}
	}
	
	private void DisaTasi() {
		for(Kordinat kordinat : Kordinatlar) {
			int x = kordinat.getY();
			int y = kordinat.getX();
			Kareler.get(x).get(y).Renklendir(0);
		}
	}
	
	private void KuyrukSil() {
		int yilanUzunluk = yilanBoyut;
		
		for(int i= Kordinatlar.size()-1; i>=0; i--) {
			if(yilanUzunluk == 0) {
				Kordinat kordinat = Kordinatlar.get(i);
				Kareler.get(kordinat.y).get(kordinat.x).Renklendir(2);
			}else {
				yilanUzunluk--;
			}
		}
		yilanUzunluk = yilanBoyut;
		
		for(int i= Kordinatlar.size()-1; i>=0; i--) {
			if(yilanUzunluk == 0) {
				Kordinatlar.remove(i);
			}else {
				yilanUzunluk--;
			}
		}
	}
	
	
	
	
}







