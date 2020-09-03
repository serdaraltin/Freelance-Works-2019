package meyvekesme.view;

import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.RenderingHints;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.SQLException;
import java.sql.Statement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

import javax.swing.JButton;
import javax.swing.JPanel;

import meyvekesme.Giris;
import meyvekesme.model.Player;




public class EndGameView extends JPanel  {

	
	private static final long serialVersionUID = 6784705580187233104L;

	private Player player;
	private Font mainFont;
	private RenderingHints rh;
	private String KullaniciAdi;

	private String userName="root"; // veritabani kullanici adi
	private String password = ""; // veritabani parolasi
	private String url="jdbc:mysql://localhost/meyvekesme"; // veritabani yolu
	
	public EndGameView(Player player,String KullaniciAdi) {
		super();
		this.KullaniciAdi = KullaniciAdi;
		Dimension dim = new Dimension(500, 550);
		setMaximumSize(dim);
		setMinimumSize(dim);
		setPreferredSize(dim);
		setSize(dim);
	
	
		
		this.player = player;
	
		mainFont = new Font("TimesNew", 0, 60);
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
		g.drawString("Oyun Bitti", 80, getHeight() / 3);
		g.drawString("Puan : " + player.getScore(), 80, (getHeight() / 3) * 2);
		
		try {
			Class.forName("com.mysql.jdbc.Driver");
		} catch (ClassNotFoundException e) {

			e.printStackTrace();
		}
		
		
		Connection connection = null;
		
		try {
			
			connection = (Connection)DriverManager.getConnection(url,userName,password);
		} catch (SQLException e) {
		
			e.printStackTrace();
		}
		
		
		try {
			Statement statement = connection.createStatement();
			statement.executeUpdate("INSERT INTO puanlar(KullaniciAdi,Puan) VALUES('"+this.KullaniciAdi+"','"+player.getScore()+"')");
			statement.close();
			connection.close();
		} catch (SQLException e) {
		
			e.printStackTrace();
		}
		
		
		
		
		
		
	}


	public String getKullaniciAdi() {
		return KullaniciAdi;
	}


	public void setKullaniciAdi(String kullaniciAdi) {
		KullaniciAdi = kullaniciAdi;
	}

}
