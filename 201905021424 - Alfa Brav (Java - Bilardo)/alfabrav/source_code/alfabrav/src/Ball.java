//TAMAMLANDI

import java.awt.*;
import java.awt.event.*;
import java.awt.geom.*;
import javax.swing.*;
import java.util.*;

public class Ball {
	public String isim = "";
	public Color renk;
	public int boyut,sayi;
	public Point merkez;
	public double x,y, dx,dy,ddx,ddy;
	public boolean gezici = false, faresurukle = false;

	public Ball(int qiusayi, String isim, Color color, double x, double y, int speed, double direction, int daxia) {
		this.sayi = qiusayi;
		this.isim = isim;
		this.renk = color;
		this.boyut = daxia;
		this.merkez = new Point();
		this.merkez.setLocation(x, y);
		this.x = x;
		this.y = y;

		System.out.println("Olusturulan > " + isim );
	}
}