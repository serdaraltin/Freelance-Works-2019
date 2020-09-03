package fruitninja.view;

import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.RenderingHints;

import javax.swing.JPanel;
import fruitninja.model.Player;

/**
 * 
 * The BarView class renders the player's score and lives on a bar.
 * 
 * @author: Dajo Hofman
 * @version 1.0
 * @since 2015-11-17
 * 
 */
public class BarView extends JPanel {
	private static final long serialVersionUID = -1967037164135464108L;

	private Player player;
	private Font mainFont;
	RenderingHints rh;

	/**
	 * Sets up the rendering options and dimensions of the panel.
	 * 
	 * @param player
	 *            The player that plays the game.
	 */
	public BarView(Player player) {
		super();
		// Set dimensions for the view
		Dimension dim = new Dimension(500, 50);
		setMaximumSize(dim);
		setMinimumSize(dim);
		setPreferredSize(dim);
		setSize(dim);
		// Load player
		this.player = player;
		// Setup rendering options
		mainFont = new Font("TimesNew", 0, 20);
		rh = new RenderingHints(RenderingHints.KEY_TEXT_ANTIALIASING, RenderingHints.VALUE_TEXT_ANTIALIAS_ON);
	}

	/**
	 * This method is overridden from JPanel, it is used by swing to paint the
	 * view. It renders the player's score and lives in a bar.
	 */
	public void paintComponent(Graphics g) {
		super.paintComponent(g);
		Graphics2D g2 = (Graphics2D) g;
		g2.setRenderingHints(rh);
		// Fill with gray color
		g2.setColor(Color.gray);
		g2.fillRect(0, 0, getWidth(), getHeight());
		// Draw score and remaining lives in white
		g2.setColor(Color.white);
		g2.setFont(mainFont);
		g2.drawString("Score: " + player.getScore(), 40, (getHeight() / 2) + (mainFont.getSize() / 2));
		g2.drawString("Lives: " + player.getLives(), 350, (getHeight() / 2) + (mainFont.getSize() / 2));
	}

}
