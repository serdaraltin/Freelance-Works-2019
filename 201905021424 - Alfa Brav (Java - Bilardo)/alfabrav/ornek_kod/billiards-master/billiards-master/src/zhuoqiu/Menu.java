package zhuoqiu;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.border.*;

/**
 * 加载菜单
 */
public class Menu extends JFrame implements ActionListener {

	Game game;

	public Menu() {
		super();
		try {
			UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}
		setTitle("桌球游戏");

		setDefaultCloseOperation(EXIT_ON_CLOSE);
		setLayout(new BorderLayout());

		setSize(1100, 725);

		setResizable(true);
		setLocationByPlatform(true);

		game = new Game(this);
		add(game, BorderLayout.CENTER);

		JMenuBar menu = new JMenuBar();

		JMenu file = new JMenu("游戏"), opts = new JMenu("选项"), help = new JMenu("帮助");

		menu.add(file);
		menu.add(opts);
		menu.add(help);

		addMenuItems(file, "新游戏 退出游戏");
		addMenuItems(opts, "c考虑摩擦 c辅助瞄准");
		addMenuItems(help, "关于");

		setJMenuBar(menu);
		setVisible(true);
		requestFocus();
	}

	private void addMenuItems(JMenu menu, String items) {
		JMenuItem i;

		for (String str : items.split(" ")) {
			if (str.substring(0, 1).equals("c"))
				i = new JCheckBoxMenuItem(str.substring(1), true);
			else
				i = new JMenuItem(str);

			i.addActionListener(this);
			menu.add(i);
		}
	}

	public void actionPerformed(ActionEvent e) {

		if (e.getActionCommand().equals("退出游戏"))
			System.exit(0);

		else if (e.getActionCommand().equals("新游戏")) {
			System.out.println("新游戏.");
			game.newGame();
		}

		else if (e.getActionCommand().equals("考虑摩擦"))
			game.yinqing.f = !game.yinqing.f;

		else if (e.getActionCommand().equals("辅助瞄准"))
			game.yinqing.miaozhun = !game.yinqing.miaozhun;

		else if (e.getActionCommand().equals("关于"))
			JOptionPane.showMessageDialog(this, "课程：Java技术与应用\n" + "何宜晖 计算机46 \n" + "谢茹吉 自动化46 \n", "关于作者",
					JOptionPane.DEFAULT_OPTION);
	}

}
