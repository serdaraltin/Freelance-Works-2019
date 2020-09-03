package meyvekesme.controller;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.awt.event.MouseMotionAdapter;
import java.io.BufferedInputStream;
import java.util.Random;

import javax.sound.sampled.Clip;
import javax.sound.sampled.AudioSystem;
import javax.swing.JFrame;
import javax.swing.Timer;

import meyvekesme.model.*;
import meyvekesme.view.ApplicationView;
import meyvekesme.view.EndGameView;


public class GameController extends JFrame {
	private static final long serialVersionUID = 2630860985789507730L;

	
	private Field field;
	private Player player;


	private ApplicationView appView;
	private EndGameView endGameView;

	
	private Timer timer;
	private int time;
	private int maxTime;
	private Clip bgSound;
	private Clip slashSound;
	Random rg;


	public GameController(String KullaniciAdi) {
		super("Selda Tiryaki Meyve Kesme");
		maxTime = 180000;
		time = 0;
	
		rg = new Random();
		player = new Player();
		field = new Field();
		loadAudio();
	
		appView = new ApplicationView(field, player,KullaniciAdi);
		endGameView = new EndGameView(player,KullaniciAdi);
	
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setResizable(false);
		add(appView);
		pack();
	}

	/**
	 * Loads the audio resources into the audio clips.
	 */
	private void loadAudio() {
		try {
			bgSound = AudioSystem.getClip();
			bgSound.open(AudioSystem.getAudioInputStream(
					new BufferedInputStream(getClass().getResourceAsStream("/meyvekesme/resources/game_music.wav"))));
		} catch (Exception e) {
			e.printStackTrace();
		}
		try {
			slashSound = AudioSystem.getClip();
			slashSound.open(AudioSystem.getAudioInputStream(
					new BufferedInputStream(getClass().getResourceAsStream("/meyvekesme/resources/slash.wav"))));
		} catch (Exception e) {
			e.printStackTrace();
		}
	}


	private GameObject newObject() {

		int rand = rg.nextInt(4);
		GameObject object;
		switch (rand) {
		case 0:
			object = new Apple();
			break;
		case 1:
			object = new Orange();
			break;
		case 2:
			object = new Strawberry();
			break;
		default:
			object = new Bomb();
			break;
		}
	
		rand = rg.nextInt(4);
		int maxPos = 250 - object.getSize();
		int pos = rg.nextInt(maxPos);
		int velX = rg.nextInt(3) + 1;
		int velY = rg.nextInt(5) + 2;
		switch (rand) {
		case 0:
			object.setPosition(pos, 250 + maxPos);
			object.setVelocity(velX, -velY - 7);
			break;
		case 1:
			object.setPosition(pos + maxPos, 250 + maxPos);
			object.setVelocity(-velX, -velY - 7);
			break;
		case 2:
			object.setPosition(0, maxPos + pos);
			object.setVelocity(velX, -velY - (pos / 30));
			break;
		default:
			object.setPosition(maxPos + 250, maxPos + pos);
			object.setVelocity(-velX, -velY - (pos / 30));
			break;
		}
		return object;
	}

	
	private void gameOver() {
	
		timer.stop();
		
		remove(appView);
		add(endGameView);
		repaint();
	}


	public void run() {
		
		bgSound.loop(Clip.LOOP_CONTINUOUSLY);
		
		field.setObject(newObject());

	
		appView.getComponent(1).addMouseMotionListener(new MouseMotionAdapter() {

			@Override
			public void mouseDragged(MouseEvent e) {
				
				if (field.getObject().insideBounds(e.getX(), e.getY())) {
					field.getSlash().setSlashed(true);
				}
			}

		});

		appView.getComponent(1).addMouseListener(new MouseListener() {

			@Override
			public void mouseClicked(MouseEvent e) {
			}

			@Override
			public void mousePressed(MouseEvent e) {
				
				field.getSlash().setStartPosition(e.getX(), e.getY());
				field.getSlash().setSlashed(false);
			}

			@Override
			public void mouseReleased(MouseEvent e) {
			
				field.getSlash().setEndPosition(e.getX(), e.getY());
				if (field.getSlash().isSlashed()) {
					
					slashSound.stop();
					slashSound.setFramePosition(0);
					slashSound.start();
					
					if (field.getObject().getType() == 3) {
						player.subtractLife();
						if (player.getLives() <= 0)
							
							gameOver();
					} else {
						player.addScore(field.getObject().getPoints());
					}
					field.setObject(newObject());
				}
			}

			@Override
			public void mouseEntered(MouseEvent e) {
			}

			@Override
			public void mouseExited(MouseEvent e) {
			}

		});

		timer = new Timer(16, new ActionListener() {
			long lastTime = System.currentTimeMillis();
			long delta = 0L;

			@Override
			public void actionPerformed(ActionEvent e) {
			
				delta = System.currentTimeMillis() - lastTime;
				lastTime = System.currentTimeMillis();
				
				field.getObject().update(delta);
				
				int x = field.getObject().getX();
				int y = field.getObject().getY();
				int size = field.getObject().getSize();
				
				if ((x < 0) || (y < 0) || (x + size >= 500) || (y + size >= 500)) {
					field.setObject(newObject());
				}
				repaint();
				
				time += delta;
				
				if (time >= maxTime) {
					gameOver();
				}
			}

		});
		timer.start();

	}


}
