package edabalaban;

import javax.swing.JPanel;
import java.awt.Color;

public class Panel extends JPanel {
	
	public static final long serialVersionUID = 1L;
	
	public Panel(Color renk) {
		this.setBackground(renk);
	}
	
	public void RenkDegistir(Color renk) {
		this.setBackground(renk);
		this.repaint();
	}
}
