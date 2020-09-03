package meyvekesme.view;

import javax.swing.BoxLayout;
import javax.swing.JPanel;

import meyvekesme.model.*;

public class ApplicationView extends JPanel {
	private static final long serialVersionUID = 4658940699710341752L;

	private GameView gameView;
	private BarView barView;
	private BoxLayout layout;


	public ApplicationView(Field field, Player player,String KullaniciAdi) {
		
		super();
	
	
		layout = new BoxLayout(this, BoxLayout.PAGE_AXIS);
		setLayout(layout);

		gameView = new GameView(field,KullaniciAdi);
		
		barView = new BarView(player,KullaniciAdi);
	
		setSize(500, gameView.getHeight() + barView.getHeight());
		
		
		
		add(barView);
		add(gameView);
		
		
		
	}



}
