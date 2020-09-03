package edabalaban;

import java.awt.GridLayout;
import java.util.ArrayList;
import java.awt.event.KeyListener;
import javax.swing.JFrame;

public class Pencere extends JFrame {
	private static final long serialVersionUID = -2542001418764869760L;
	
	public static ArrayList<ArrayList<KareBilgiler>> Grid;
	public static int genislik = 20;
	public static int yukseklik = 20;
	
	public Pencere() {
		
		Grid = new ArrayList<ArrayList<KareBilgiler>>();
		ArrayList<KareBilgiler> veri;
		
		for(int i=0; i<genislik;i++) {
			veri = new ArrayList<KareBilgiler>();
			for(int j=0; j<yukseklik;j++) {
				KareBilgiler yeni = new KareBilgiler(2);
				veri.add(yeni);
			}
			Grid.add(veri);
		}
	
		
		getContentPane().setLayout(new GridLayout(20,20,0,0));
		
		for(int i=0;i<genislik;i++) {
			for(int j=0;j<yukseklik;j++) {
				getContentPane().add(Grid.get(i).get(j).alan);
			}
		}
		
		//baslangic kordinatlari
		Kordinat kordinat = new Kordinat(10, 10);
		
		Threadler thread = new Threadler(kordinat);
		thread.start(); //oyunu baslatma

		this.addKeyListener((KeyListener) new Yonlendirme());
	
	
	
	}
	
}
