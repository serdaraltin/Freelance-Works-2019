package edabalaban;

import java.awt.Color;
import java.util.ArrayList;

public class KareBilgiler {
	
	ArrayList<Color> Renkler = new ArrayList<Color>();
	
	int renk;
	Panel alan;
	
	public KareBilgiler(int renk)
	{
		Renkler.add(Color.black);
		Renkler.add(Color.red);
		Renkler.add(Color.gray);
		this.renk = renk;
		alan = new Panel(Renkler.get(renk));
	}
	
	public void Renklendir(int renk){
		alan.RenkDegistir(Renkler.get(renk));
	}
}
