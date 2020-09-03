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
 * The EndGameView class renders the player's end score together with the words
 * "Game Over".
 * 
 * @author: Dajo Hofman
 * @version 1.0
 * @since 2015-11-17
 * 
 */
public class EndGameView extends JPanel {
	private static final long serialVersionUID = 6784705580187233104L;

	private Player player;
	private Font mainFont;
	private RenderingHints rh;

	/**
	 * Sets up the dimensions and rendering options for the panel.
	 * 
	 * @param player
	 *            The player that plays the game.
	 */
	public EndGameView(Player player) {
		super();
		// Set dimensions for the view
		Dimension dim = new Dimension(500, 550);
		setMaximumSize(dim);
		setMinimumSize(dim);
		setPreferredSize(dim);
		setSize(dim);
		// Load player
		this.player = player;
		// Setup rendering options
		mainFont = new Font("TimesNew", 0, 60);
		rh = new RenderingHints(RenderingHints.KEY_TEXT_ANTIALIASING, RenderingHints.VALUE_TEXT_ANTIALIAS_ON);
	}

	/**
	 * This method is overridden from JPanel, it is used by swing to paint the
	 * view. It renders the player's score and the phrase "Game Over" on screen.
	 */
	public void paintComponent(Graphics g) {
		super.paintComponent(g);
		Graphics2D g2 = (Graphics2D) g;
		g2.setRenderingHints(rh);
		// Fill the screen with gray
		g2.setColor(Color.gray);
		g2.fillRect(0, 0, getWidth(), getHeight());
		// Show Game over and end score in white
		g2.setColor(Color.white);
		g2.setFont(mainFont);
		g.drawString("Game Over", 80, getHeight() / 3);
		g.drawString("Score: " + player.getScore(), 80, (getHeight() / 3) * 2);
	}

}
