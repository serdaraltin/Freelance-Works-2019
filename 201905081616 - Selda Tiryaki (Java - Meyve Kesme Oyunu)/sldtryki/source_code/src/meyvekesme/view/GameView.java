package meyvekesme.view;

import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.image.BufferedImage;

import javax.imageio.ImageIO;
import javax.swing.ImageIcon;
import javax.swing.JPanel;

import meyvekesme.model.Field;
import meyvekesme.model.GameObject;

import java.io.IOException;


public class GameView extends JPanel {
	private static final long serialVersionUID = -7837067837641826234L;

	private Field field;
	private BufferedImage bg;
	private ImageIcon[] images;
	private String KullaniciAdi;

	public GameView(Field field,String KullaniciAdi) {
		super();

		Dimension dim = new Dimension(500, 500);
		setMaximumSize(dim);
		setMinimumSize(dim);
		setPreferredSize(dim);
		setSize(dim);
	
		this.field = field;
		
		try {
			bg = ImageIO.read(getClass().getResource("/meyvekesme/resources/background.png"));
		} catch (IOException e) {
			e.printStackTrace();
		}
	
		images = new ImageIcon[4];
		images[0] = createIcon("/meyvekesme/resources/apple.png", "apple");
		images[1] = createIcon("/meyvekesme/resources/orange.png", "orange");
		images[2] = createIcon("/meyvekesme/resources/strawberry.png", "strawberry");
		images[3] = createIcon("/meyvekesme/resources/bomb.png", "bomb");
	}


	private ImageIcon createIcon(String path, String description) {
		java.net.URL imgURL = getClass().getResource(path);
		if (imgURL != null) {
			return new ImageIcon(imgURL, description);
		} else {
			System.err.println("Dosya bulunamadi: " + path);
			return null;
		}
	}


	public void paintComponent(Graphics g) {
		super.paintComponent(g);
	
		g.drawImage(bg, 0, 0, this);
		
		GameObject obect = field.getObject();
		images[obect.getType()].paintIcon(this, g, obect.getX(), obect.getY());
	}

}
