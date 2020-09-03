package fruitninja;

import java.awt.Dimension;
import java.awt.Toolkit;

import fruitninja.controller.GameController;

/**
 *
 * The main class only holds the main method which starts the application.
 * 
 * @author: Dajo Hofman
 * @version 1.0
 * @since 2015-11-17
 * 
 */
public class Main {

	/**
	 * This is the main method which sets up the application and runs the game.
	 * 
	 * @param args
	 *            Unused.
	 */
	public static void main(String[] args) {
		GameController controller = new GameController();

		// Center the frame on monitor
		Dimension screenSize = Toolkit.getDefaultToolkit().getScreenSize();
		Dimension frameSize = controller.getSize();
		controller.setLocation((screenSize.width - frameSize.width) / 2, (screenSize.height - frameSize.height) / 2);
		// Show the application on screen
		controller.setVisible(true);
		// Run the game
		controller.run();
	}

}
