package cansupolat;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JComboBox;
import javax.swing.JButton;
import javax.swing.DefaultComboBoxModel;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

import java.io.*;
import java.awt.Window.Type;

public class Ekle extends JFrame  {

	private JPanel contentPane;
	private JTextField txtSayi1;
	private JTextField txtSayi2;
	private JTextField txtSayi3;
	private JTextField txtSayi4;



	private int Toplama(int Sayi1, int Sayi2, int Sayi3, int Sayi4) { // Parametre olarak gonderilen verilerin toplamini geri donduren fonksiyon
		int toplam = Sayi1+ Sayi2+ Sayi3+ Sayi4;
		return toplam;
	}
	
	private int Cikarma(int Sayi1, int Sayi2, int Sayi3, int Sayi4) { // Parametre olarak gonderilen verilerin farkini geri donduren fonksiyon
		int fark = Sayi1- Sayi2- Sayi3- Sayi4;
		return fark;
	}
	
	private int Ortalama(int Sayi1, int Sayi2, int Sayi3, int Sayi4) { // Parametre olarak gonderilen verilerin ortalamasini geri donduren fonksiyon
		int ortalama = Sayi1+ Sayi2+ Sayi3+ Sayi4;
		return ortalama/4;
	}
	
    private static void DosyayaEkle(String metin){//Parametre olarak gonderilen veriyi belirlenen dosyaya yazan fonksiyon
        try{
              File dosya = new File("veri.txt"); // File tipindeki degiskene uzerinde islem yapmak istedigimin dosyanin yolunu giriyoruz
              FileWriter yazici = new FileWriter(dosya,true); // Dosyaya veri yazmak icin FileWriter objesi olusturuyor ve icerisine parametre olarak islem yapilacak dosyayi ve yeniden dosya yaratmamasi icin "true" degerini veriyoruz
              BufferedWriter yaz = new BufferedWriter(yazici);
              yaz.write(metin); // parametre olarak gelen veriyi dosyaya ekliyoruz
              yaz.close();
             // System.out.println("Ekleme Ýþlemi Baþarýlý");
        }
        catch (Exception hata){
              hata.printStackTrace();
        }
    }
    
	public Ekle() {
		setResizable(false);
		setTitle("Ekle");
		setDefaultCloseOperation(HIDE_ON_CLOSE);
		setBounds(93, 39, 294, 320);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JComboBox cbIslem = new JComboBox();
		cbIslem.setModel(new DefaultComboBoxModel(new String[] {"Toplama", "Cikarma", "Ortalama"}));
		cbIslem.setSelectedIndex(0);
		cbIslem.setBounds(94, 33, 130, 22);
		contentPane.add(cbIslem);
		
		JLabel lblIslemTuru = new JLabel("Islem Turu");
		lblIslemTuru.setBounds(33, 33, 62, 22);
		contentPane.add(lblIslemTuru);
		
		JLabel lblSayi = new JLabel("1. Sayi");
		lblSayi.setBounds(33, 66, 48, 20);
		contentPane.add(lblSayi);
		
		txtSayi1 = new JTextField();
		txtSayi1.setBounds(94, 66, 130, 20);
		contentPane.add(txtSayi1);
		txtSayi1.setColumns(10);
		
		txtSayi2 = new JTextField();
		txtSayi2.setColumns(10);
		txtSayi2.setBounds(94, 97, 130, 20);
		contentPane.add(txtSayi2);
		
		JLabel lblSayi_1 = new JLabel("2. Sayi");
		lblSayi_1.setBounds(33, 97, 48, 20);
		contentPane.add(lblSayi_1);
		
		txtSayi3 = new JTextField();
		txtSayi3.setColumns(10);
		txtSayi3.setBounds(94, 128, 130, 20);
		contentPane.add(txtSayi3);
		
		JLabel lblSayi_2 = new JLabel("3. Sayi");
		lblSayi_2.setBounds(33, 128, 48, 20);
		contentPane.add(lblSayi_2);
		
		txtSayi4 = new JTextField();
		txtSayi4.setColumns(10);
		txtSayi4.setBounds(94, 159, 130, 20);
		contentPane.add(txtSayi4);
		
		JLabel lblSayi_3 = new JLabel("4. Sayi");
		lblSayi_3.setBounds(33, 159, 48, 20);
		contentPane.add(lblSayi_3);
		
		JButton btnHesapla = new JButton("HESAPLA");
		btnHesapla.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String[] veriler = new String[6];
				veriler[1] = txtSayi1.getText();
				veriler[2] = txtSayi2.getText();
				veriler[3] = txtSayi3.getText();
				veriler[4] = txtSayi4.getText();
				switch(cbIslem.getSelectedItem().toString()) {
					case "Toplama":
						
							int toplam = Toplama(Integer.parseInt(txtSayi1.getText()), Integer.parseInt(txtSayi2.getText()), Integer.parseInt(txtSayi3.getText()), Integer.parseInt(txtSayi4.getText()));
							
							veriler[0] = "Toplama";
							veriler[5] = Integer.toString(toplam);
							
							for(String veri : veriler)
								DosyayaEkle(veri+"|");
							DosyayaEkle("\n");					
						break;
					case "Cikarma":
							int cikarma = Cikarma(Integer.parseInt(txtSayi1.getText()), Integer.parseInt(txtSayi2.getText()), Integer.parseInt(txtSayi3.getText()), Integer.parseInt(txtSayi4.getText()));
							
							veriler[0] = "Cikarma";
							veriler[5] = Integer.toString(cikarma);
							
							for(String veri : veriler)
								DosyayaEkle(veri+"|");
							DosyayaEkle("\n");		
						break;
					case "Ortalama":
							int ortalama = Ortalama(Integer.parseInt(txtSayi1.getText()), Integer.parseInt(txtSayi2.getText()), Integer.parseInt(txtSayi3.getText()), Integer.parseInt(txtSayi4.getText()));
							
							veriler[0] = "Ortalama";
							veriler[5] = Integer.toString(ortalama);
							
							for(String veri : veriler)
								DosyayaEkle(veri+"|");
							DosyayaEkle("\n");	
						break;
				}
			}


		});
		btnHesapla.setBounds(94, 190, 130, 31);
		contentPane.add(btnHesapla);
	}
}
