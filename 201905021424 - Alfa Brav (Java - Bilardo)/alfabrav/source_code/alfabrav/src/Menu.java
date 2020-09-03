//TAMAMLANDI

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.border.*;

public class Menu extends JFrame implements ActionListener {

	Game game;

	public Menu() {
		super();
		try {
			UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}
		setTitle("alfabrav");
		setLocationRelativeTo(null);
		

		setDefaultCloseOperation(EXIT_ON_CLOSE);
		setLayout(new BorderLayout());

		setSize(1050, 700);

		setResizable(false);
		setLocationByPlatform(true);

		game = new Game(this);
		add(game, BorderLayout.CENTER);

		JMenuBar menu = new JMenuBar();

		JMenu file = new JMenu("Oyun"), opts = new JMenu("Secenekler"), help = new JMenu("Yardim");

		menu.add(file);
		menu.add(opts);
		menu.add(help);

		addMenuItems(file, "xYeni-Oyun xOyundan-Cik");
		addMenuItems(opts, "xSurtunmeyi-Dusur xYardimci");
		addMenuItems(help, "Hakkinda");

		setJMenuBar(menu);
		
		
		
		
		
		setVisible(true);
	
		requestFocus();
		
		
	}

	private void addMenuItems(JMenu menu, String items) {
		JMenuItem i;

		for (String str : items.split(" ")) {
			if (str.substring(0, 1).equals("x"))
				i = new JCheckBoxMenuItem(str.substring(1), true);
			else
				i = new JMenuItem(str);

			i.addActionListener(this);
			menu.add(i);
		}
	}

	public void actionPerformed(ActionEvent e) {
		
		if (e.getActionCommand().equals("Oyundan-Cik"))
			System.exit(0);

		else if (e.getActionCommand().equals("Yeni-Oyun")) {
			System.out.println("Yeni-Oyun.");
			game.newGame();
		}

		else if (e.getActionCommand().equals("Surtunmeyi-Dusur"))
			game.yinqing.f = !game.yinqing.f;

		else if (e.getActionCommand().equals("Yardimci"))
			game.yinqing.miaozhun = !game.yinqing.miaozhun;

		else if (e.getActionCommand().equals("Hakkinda"))
			JOptionPane.showMessageDialog(this, "alfabrav tarafindan yapilmistir");
	}

}
