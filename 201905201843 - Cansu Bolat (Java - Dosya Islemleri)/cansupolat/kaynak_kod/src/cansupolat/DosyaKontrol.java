package cansupolat;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;


import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

import java.io.File;
import java.io.IOException;
public class DosyaKontrol extends JFrame {

	private JPanel contentPane;
	private JTextField txtYol;

	

	public DosyaKontrol() {
		setTitle("Dosya Kontrol");
		setBounds(100, 100, 355, 232);
		setLocationRelativeTo(null);
		setResizable(false);

		setDefaultCloseOperation(HIDE_ON_CLOSE);
		
		
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		
		JLabel lblDosyaYolu = new JLabel("Dosya Yolu");
		lblDosyaYolu.setBounds(36, 41, 65, 19);
		contentPane.add(lblDosyaYolu);
		
		txtYol = new JTextField();
		txtYol.setText("veri.txt");
		txtYol.setBounds(104, 40, 150, 20);
		contentPane.add(txtYol);
		txtYol.setColumns(10);
		
		JButton btnKontrolEt = new JButton("KONTROL ET");
		btnKontrolEt.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				File dosya = new java.io.File(txtYol.getText());
				if(dosya.exists()) {
					JOptionPane.showMessageDialog(null, "Dosya mevcut");
				}else {
					JOptionPane.showMessageDialog(null, "Dosya bulunamadi");
				}
			}
		});
		btnKontrolEt.setBounds(104, 71, 150, 28);
		contentPane.add(btnKontrolEt);
		
		JButton btnEkle = new JButton("OLUSTUR");
		btnEkle.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				File dosya = new java.io.File(txtYol.getText()); //txtYol adli TextField objesine girilen dosya yolunu File tipindeki degiskene atiyoruz.
				if(dosya.exists()) {// Dosyanin varligini kontrol ediyoruz
					JOptionPane.showMessageDialog(null, "Dosya zaten mevcut");
				}else {
					try {
						dosya.createNewFile();
						JOptionPane.showMessageDialog(null, "Dosya basariyla olusturuldu.");
					} catch (IOException e1) {
						JOptionPane.showMessageDialog(null, "Dosya olusturulamadi");
						e1.printStackTrace();
					}
				}
			}
		});
		btnEkle.setBounds(104, 103, 150, 28);
		contentPane.add(btnEkle);
	}

}
