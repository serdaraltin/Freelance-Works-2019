package edabalaban;

import javax.swing.JDialog;
import javax.swing.JLabel;
import java.awt.Font;

public class Skor extends JDialog {

	private static final long serialVersionUID = 1L;

	public Skor(int sure,int skor) {
		
		setTitle("Oyun Bitti");
		setType(Type.POPUP);
		setResizable(false);
		setModal(true);
		setBounds(100, 100, 259, 143);
		getContentPane().setLayout(null);
		
		JLabel lbSure = new JLabel("Sure : 0 saniye");
		lbSure.setFont(new Font("Tahoma", Font.PLAIN, 16));
		lbSure.setBounds(22, 18, 174, 20);
		getContentPane().add(lbSure);
		
		JLabel lbSkor = new JLabel("Skor : "+ skor);
		lbSkor.setFont(new Font("Tahoma", Font.PLAIN, 16));
		lbSkor.setBounds(22, 49, 174, 20);
		getContentPane().add(lbSkor);
	}
}
