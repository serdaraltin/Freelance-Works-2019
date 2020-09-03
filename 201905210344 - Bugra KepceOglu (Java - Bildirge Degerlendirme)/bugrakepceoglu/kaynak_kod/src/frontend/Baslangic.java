package frontend;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JToggleButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Baslangic extends JFrame {

	private JPanel contentPane;

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Baslangic frame = new Baslangic();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}


	public Baslangic() {
		setResizable(false);
		setTitle("Baslangic");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 380, 173);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JToggleButton btnKayitOl = new JToggleButton("KAYIT OL");
		btnKayitOl.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				HakemEkle frame = new HakemEkle();
				frame.setVisible(true);
			}
		});
		btnKayitOl.setBounds(31, 26, 150, 73);
		contentPane.add(btnKayitOl);
		
		JToggleButton btnGirisYap = new JToggleButton("GIRIS YAP");
		btnGirisYap.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				GirisYap frame = new GirisYap();
				frame.setVisible(true);
			}
		});
		btnGirisYap.setBounds(191, 26, 150, 73);
		contentPane.add(btnGirisYap);
	}
}
