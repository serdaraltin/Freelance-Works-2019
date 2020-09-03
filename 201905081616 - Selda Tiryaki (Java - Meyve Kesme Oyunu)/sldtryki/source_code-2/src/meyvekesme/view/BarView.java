package meyvekesme.view;

import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.RenderingHints;

import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTabbedPane;

import meyvekesme.model.Player;


public class BarView extends JPanel {
	private static final long serialVersionUID = -1967037164135464108L;

	private Player player;
	private Font mainFont;
	RenderingHints rh;
	private String kullaniciAdi;

	public BarView(Player player,String KullaniciAdi) {
		super();
		//JOptionPane.showMessageDialog(null, KullaniciAdi);
		this.kullaniciAdi = KullaniciAdi;
		Dimension dim = new Dimension(500, 50);
		setMaximumSize(dim);
		setMinimumSize(dim);
		setPreferredSize(dim);
		setSize(dim);

		this.player = player;

		mainFont = new Font("TimesNew", 0, 20);
		rh = new RenderingHints(RenderingHints.KEY_TEXT_ANTIALIASING, RenderingHints.VALUE_TEXT_ANTIALIAS_ON);
	}

	public void paintComponent(Graphics g) {
		
		super.paintComponent(g);
		Graphics2D g2 = (Graphics2D) g;
		g2.setRenderingHints(rh);
	
		g2.setColor(Color.gray);
		g2.fillRect(0, 0, getWidth(), getHeight());
	
		g2.setColor(Color.white);
		g2.setFont(mainFont);
		
		
		g2.drawString("Puan : " + player.getScore(), 40, (getHeight() / 2) + (mainFont.getSize() / 2));
		g2.drawString(this.kullaniciAdi +" : " + player.getLives(), 350, (getHeight() / 2) + (mainFont.getSize() / 2));
	}

	public String getKullaniciAdi() {
		return kullaniciAdi;
	}

	public void setKullaniciAdi(String kullaniciAdi) {
		this.kullaniciAdi = kullaniciAdi;
	}

}
