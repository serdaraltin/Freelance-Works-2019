package fruitninja.view;

import javax.swing.BoxLayout;
import javax.swing.JPanel;
import fruitninja.model.*;

/**
 *
 * The AppView class combines the BarView and GameView to create a view with a
 * score bar on top and a playing field underneath.
 * 
 * @author: Dajo Hofman
 * @version 1.0
 * @since 2015-11-17
 * 
 */
public class ApplicationView extends JPanel {
	private static final long serialVersionUID = 4658940699710341752L;

	private GameView gameView;
	private BarView barView;
	private BoxLayout layout;

	/**
	 * Sets up the BarView and Gameview, then adds them to the Application view
	 * using a BoxLayout to layout the panel.
	 * 
	 * @param field
	 *            The field used as game field.
	 * @param player
	 *            The player that plays the game.
	 */
	public ApplicationView(Field field, Player player) {
		super();
		// Set a layout for the panel
		layout = new BoxLayout(this, BoxLayout.PAGE_AXIS);
		setLayout(layout);
		// Load the views
		gameView = new GameView(field);
		barView = new BarView(player);
		// Setup view
		setSize(500, gameView.getHeight() + barView.getHeight());
		add(barView);
		add(gameView);
	}

}
