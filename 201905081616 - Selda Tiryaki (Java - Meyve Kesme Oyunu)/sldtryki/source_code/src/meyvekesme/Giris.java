package meyvekesme;

import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.EventQueue;
import java.awt.Toolkit;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import meyvekesme.controller.GameController;
import meyvekesme.view.EndGameView;

import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JMenuBar;
import javax.swing.JMenu;
import javax.swing.JMenuItem;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Giris extends JFrame {

	private JPanel contentPane;
	private JTextField textField;

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Giris frame = new Giris();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	
	public Giris() {
		setResizable(false);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 359, 197);
		setLocationRelativeTo(null);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblKullaniciAdi = new JLabel("Kullanici Adi");
		lblKullaniciAdi.setBounds(45, 57, 77, 14);
		contentPane.add(lblKullaniciAdi);
		
		textField = new JTextField();
		textField.setBounds(121, 53, 144, 22);
		contentPane.add(textField);
		textField.setColumns(10);
		
		JButton btnBaslat = new JButton("Baslat");
		btnBaslat.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				GameController controller = new GameController(textField.getText());
				
				
				Dimension screenSize = Toolkit.getDefaultToolkit().getScreenSize();
				Dimension frameSize = controller.getSize();
				controller.setLocation((screenSize.width - frameSize.width) / 2, (screenSize.height - frameSize.height) / 2);
				
				controller.setVisible(true);
			
				controller.run();
				
				setVisible(false);
			}
		});
	
		btnBaslat.setBounds(176, 86, 89, 37);
		contentPane.add(btnBaslat);
		
		JMenuBar menuBar = new JMenuBar();
		menuBar.setBounds(0, 0, 367, 22);
		contentPane.add(menuBar);
		
		JMenu mnPuanlar = new JMenu("Puanlar Tablosu");
		menuBar.add(mnPuanlar);
		
		JMenuItem mnýtmGoster = new JMenuItem("Goster");
		mnýtmGoster.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				PuanTablosu puan = new PuanTablosu();
				puan.setVisible(true);
			}
		});
		mnPuanlar.add(mnýtmGoster);
	}
}
