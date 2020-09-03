package cansupolat;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.JButton;
import javax.swing.JTextArea;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JToggleButton;

public class AnaPencere extends JFrame {

	private JPanel contentPane;

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					AnaPencere frame = new AnaPencere();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}


	public AnaPencere() {
		setTitle("CansuBolat");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 359, 197);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JToggleButton tglbtnDosyaKontrol = new JToggleButton("Dosya Kontrol");
		tglbtnDosyaKontrol.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				DosyaKontrol frame = new DosyaKontrol();
				frame.setVisible(true);
			}
		});
		tglbtnDosyaKontrol.setBounds(39, 28, 130, 38);
		contentPane.add(tglbtnDosyaKontrol);
		
		JToggleButton tglbtnKayitEkle = new JToggleButton("Kayit Ekle");
		tglbtnKayitEkle.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Ekle frame = new Ekle();
				frame.setVisible(true);
			}
		});
		tglbtnKayitEkle.setBounds(179, 28, 130, 38);
		contentPane.add(tglbtnKayitEkle);
		
		JToggleButton tglbtnKayitGoruntule = new JToggleButton("Kayit Goruntule");
		tglbtnKayitGoruntule.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Kayitlar frame = new Kayitlar();
				frame.setVisible(true);
			}
		});
		tglbtnKayitGoruntule.setBounds(39, 77, 130, 38);
		contentPane.add(tglbtnKayitGoruntule);
		
		JToggleButton tglbtnHakkinda = new JToggleButton("Hakkinda");
		tglbtnHakkinda.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Hakkinda frame = new Hakkinda();
				frame.setVisible(true);
			}
		});
		tglbtnHakkinda.setBounds(179, 77, 130, 38);
		contentPane.add(tglbtnHakkinda);
	}
}
