package frontend;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import dal.HakemDal;

import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class GirisYap extends JFrame {

	private JPanel contentPane;
	private JTextField txtKullaniciAd;
	private JTextField txtParola;

	public GirisYap() {
		setTitle("Giris Yap");
		setResizable(false);
		setBounds(100, 100, 324, 199);
		setLocationRelativeTo(null);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		txtKullaniciAd = new JTextField();
		txtKullaniciAd.setBounds(117, 30, 130, 20);
		contentPane.add(txtKullaniciAd);
		txtKullaniciAd.setColumns(10);
		
		JLabel lblKullaniciAdi = new JLabel("Kullanici Adi");
		lblKullaniciAdi.setBounds(42, 30, 74, 20);
		contentPane.add(lblKullaniciAdi);
		
		txtParola = new JTextField();
		txtParola.setColumns(10);
		txtParola.setBounds(117, 61, 130, 20);
		contentPane.add(txtParola);
		
		JLabel lblParola = new JLabel("Parola");
		lblParola.setBounds(42, 61, 74, 20);
		contentPane.add(lblParola);
		
		JButton btnGirisYap = new JButton("GIRIS YAP");
		btnGirisYap.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				if(new HakemDal().Kontrol(txtKullaniciAd.getText(), txtParola.getText())) {
					JOptionPane.showMessageDialog(null, "Giris Basarili");
				}else {
					JOptionPane.showMessageDialog(null, "Kullanici Adi veya Parola hatali");
				}
				
			}
		});
		btnGirisYap.setBounds(117, 92, 130, 33);
		contentPane.add(btnGirisYap);
	}
}
