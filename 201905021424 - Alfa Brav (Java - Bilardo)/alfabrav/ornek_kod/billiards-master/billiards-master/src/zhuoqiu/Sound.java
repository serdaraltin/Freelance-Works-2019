package zhuoqiu;

import java.net.URL;
import javax.sound.sampled.*;

public enum Sound {
	HIT("sounds/clash.wav"), SINK("sounds/fall.wav"), CLASH("sounds/hit.wav");

	private Clip clip;
	Sound(String s) {
		try {
			URL url = this.getClass().getResource(s);
			AudioInputStream audioInputStream = AudioSystem.getAudioInputStream(url);
			clip = AudioSystem.getClip();
			clip.open(audioInputStream);

		} catch (Exception e) {
			System.out.println(e.getMessage());
			e.printStackTrace();
			System.exit(0);
		}
	}

	public void sound() {
		if (clip.isRunning())
			clip.stop();
		clip.setFramePosition(0);
		clip.start();
	}
}
