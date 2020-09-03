package frontend;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import dal.BildirgeDal;
import types.BildirgeContract;

import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class BildirgeEkle extends JFrame {

	private JPanel contentPane;
	private JTextField txtBaslik;
	private JTextField txtMetin;
	private JTextField txtAnahtar;


	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					BildirgeEkle frame = new BildirgeEkle();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}


	public BildirgeEkle() {
		setTitle("Bildirge Ekle");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 350, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblBaslik = new JLabel("Baslik");
		lblBaslik.setBounds(36, 21, 75, 20);
		contentPane.add(lblBaslik);
		
		txtBaslik = new JTextField();
		txtBaslik.setBounds(111, 21, 178, 20);
		contentPane.add(txtBaslik);
		txtBaslik.setColumns(10);
		
		JLabel lblMetin = new JLabel("Metin");
		lblMetin.setBounds(36, 52, 75, 20);
		contentPane.add(lblMetin);
		
		txtMetin = new JTextField();
		txtMetin.setColumns(10);
		txtMetin.setBounds(111, 52, 178, 99);
		contentPane.add(txtMetin);
		
		JLabel lblAnahtar = new JLabel("Anahtar");
		lblAnahtar.setBounds(36, 162, 75, 20);
		contentPane.add(lblAnahtar);
		
		txtAnahtar = new JTextField();
		txtAnahtar.setColumns(10);
		txtAnahtar.setBounds(111, 162, 178, 20);
		contentPane.add(txtAnahtar);
		
		JButton btnKaydet = new JButton("KAYDET");
		btnKaydet.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				BildirgeContract contract = new BildirgeContract();
				contract.setBaslik(txtBaslik.getText());
				contract.setMetin(txtMetin.getText());
				contract.setAnahtar(txtAnahtar.getText());
				
				new BildirgeDal().Insert(contract);
				JOptionPane.showMessageDialog(null, "Bildirge kaydi eklendi");
			}
		});
		btnKaydet.setBounds(111, 199, 120, 40);
		contentPane.add(btnKaydet);
	}
}
