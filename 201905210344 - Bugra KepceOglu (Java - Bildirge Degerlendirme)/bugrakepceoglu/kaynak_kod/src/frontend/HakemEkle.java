package frontend;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import dal.HakemDal;
import types.HakemContract;

import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextPane;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class HakemEkle extends JFrame {

	private JPanel contentPane;


	public HakemEkle() {
		setResizable(false);
		setTitle("Hakem Ekle");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 300, 250);
		setLocationRelativeTo(null);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblKullaniciAdi = new JLabel("Kullanici Adi");
		lblKullaniciAdi.setBounds(24, 46, 79, 20);
		contentPane.add(lblKullaniciAdi);
		
		JTextPane txtKullaniciAd = new JTextPane();
		txtKullaniciAd.setBounds(104, 46, 130, 20);
		contentPane.add(txtKullaniciAd);
		
		JTextPane txtParola = new JTextPane();
		txtParola.setBounds(104, 77, 130, 20);
		contentPane.add(txtParola);
		
		JLabel lblParola = new JLabel("Parola");
		lblParola.setBounds(24, 77, 79, 20);
		contentPane.add(lblParola);
		
		JTextPane txtAnahtar = new JTextPane();
		txtAnahtar.setBounds(104, 108, 130, 20);
		contentPane.add(txtAnahtar);
		
		JLabel lblAnahtar = new JLabel("Anahtar");
		lblAnahtar.setBounds(24, 108, 79, 20);
		contentPane.add(lblAnahtar);
		
		JButton btnKaydet = new JButton("KAYDET");
		btnKaydet.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				HakemContract contract = new HakemContract();
				contract.setKullaniciAd(txtKullaniciAd.getText());
				contract.setParola(txtParola.getText());
				contract.setAnahtar(txtAnahtar.getText());
				new HakemDal().Insert(contract);
				JOptionPane.showMessageDialog(null, "Hakem kaydi eklendi");
				
			}
		});
		btnKaydet.setBounds(104, 146, 99, 34);
		contentPane.add(btnKaydet);
	
	}
}
