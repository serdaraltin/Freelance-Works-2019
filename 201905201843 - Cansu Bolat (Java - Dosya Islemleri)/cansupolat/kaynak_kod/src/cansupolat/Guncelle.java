package cansupolat;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.DefaultComboBoxModel;
import java.awt.event.ActionListener;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.util.Scanner;
import java.awt.event.ActionEvent;

public class Guncelle extends JFrame {

	private JPanel contentPane;
	private JTextField txtSayi1;
	private JTextField txtSayi2;
	private JTextField txtSayi3;
	private JTextField txtSayi4;
	private JTextField txtSonuc;
	
	
	private int Toplama(int Sayi1, int Sayi2, int Sayi3, int Sayi4) {
		int toplam = Sayi1+ Sayi2+ Sayi3+ Sayi4;
		return toplam;
	}
	
	private int Cikarma(int Sayi1, int Sayi2, int Sayi3, int Sayi4) {
		int fark = Sayi1- Sayi2- Sayi3- Sayi4;
		return fark;
	}
	
	private int Ortalama(int Sayi1, int Sayi2, int Sayi3, int Sayi4) {
		int ortalama = Sayi1+ Sayi2+ Sayi3+ Sayi4;
		return ortalama/4;
	}
	
    static void DosyaGuncelle(String DosyaYolu, String eski, String yeni)
    {
        File fileToBeModified = new File(DosyaYolu);
        String eskiIcerik = "";
        BufferedReader reader = null;
        FileWriter writer = null;
        try
        {
            reader = new BufferedReader(new FileReader(fileToBeModified));
            String line = reader.readLine();
            while (line != null) 
            {
            	eskiIcerik = eskiIcerik + line + System.lineSeparator();
                line = reader.readLine();
            }
            String yeniIcerik = eskiIcerik.replace(eski, yeni);
            writer = new FileWriter(fileToBeModified);
            writer.write(yeniIcerik);
            JOptionPane.showMessageDialog(null, "Guncellendi");
            
        }
        
        catch (Exception e){
            e.printStackTrace();
        }
        finally{
            try{
                reader.close();
                writer.close();
            } 
            catch (Exception e) {
                e.printStackTrace();
            }
        }
    }
     
     


	public Guncelle(String Islem, String Sayi1,String Sayi2,String Sayi3,String Sayi4,String Sonuc) {
		
		setTitle("Guncelle");
		setBounds(100, 100, 280, 300);
		setLocationRelativeTo(null);
		setResizable(false);
		
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JComboBox cbIslem = new JComboBox();
		cbIslem.setModel(new DefaultComboBoxModel(new String[] {"Toplama", "Cikarma", "Ortalama"}));
		cbIslem.setSelectedIndex(0);
		cbIslem.setBounds(91, 11, 130, 22);
		contentPane.add(cbIslem);
		
		JLabel label = new JLabel("Islem Turu");
		label.setBounds(30, 11, 62, 22);
		contentPane.add(label);
		
		JLabel label_1 = new JLabel("1. Sayi");
		label_1.setBounds(30, 44, 48, 20);
		contentPane.add(label_1);
		
		txtSayi1 = new JTextField();
		txtSayi1.setColumns(10);
		txtSayi1.setBounds(91, 44, 130, 20);
		contentPane.add(txtSayi1);
		
		txtSayi2 = new JTextField();
		txtSayi2.setColumns(10);
		txtSayi2.setBounds(91, 75, 130, 20);
		contentPane.add(txtSayi2);
		
		JLabel label_2 = new JLabel("2. Sayi");
		label_2.setBounds(30, 75, 48, 20);
		contentPane.add(label_2);
		
		txtSayi3 = new JTextField();
		txtSayi3.setColumns(10);
		txtSayi3.setBounds(91, 106, 130, 20);
		contentPane.add(txtSayi3);
		
		JLabel label_3 = new JLabel("3. Sayi");
		label_3.setBounds(30, 106, 48, 20);
		contentPane.add(label_3);
		
		txtSayi4 = new JTextField();
		txtSayi4.setColumns(10);
		txtSayi4.setBounds(91, 137, 130, 20);
		contentPane.add(txtSayi4);
		
		JLabel label_4 = new JLabel("4. Sayi");
		label_4.setBounds(30, 137, 48, 20);
		contentPane.add(label_4);
		
		JButton btnHesapla = new JButton("HESAPLA");
		btnHesapla.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String[] veriler = new String[6]; // String tipinde bir dizi olusturuyoruz
				veriler[1] = txtSayi1.getText(); // Olusturulan dizinin icerisine veri atiyoruz
				veriler[2] = txtSayi2.getText();
				veriler[3] = txtSayi3.getText();
				veriler[4] = txtSayi4.getText();
				switch(cbIslem.getSelectedItem().toString()) {
					case "Toplama":
						
							int toplam = Toplama(Integer.parseInt(txtSayi1.getText()), Integer.parseInt(txtSayi2.getText()), Integer.parseInt(txtSayi3.getText()), Integer.parseInt(txtSayi4.getText()));
							
							veriler[0] = "Toplama";
							veriler[5] = Integer.toString(toplam);
							
							String yeni="";
							for(String veri : veriler)// Dizinin her bir elemanini donup ayristirici sembolu ekliyoruz
								yeni +=  veri+"|";
							String eski = Islem+"|"+Sayi1+"|"+Sayi2+"|"+Sayi3+"|"+Sayi4+"|"+Sonuc+"|"; // Eski verideki parcalari birlestirip String bir degiskene atiyoruz
							
							
							DosyaGuncelle("veri.txt", eski, yeni);				
						break;
					case "Cikarma":
							int cikarma = Cikarma(Integer.parseInt(txtSayi1.getText()), Integer.parseInt(txtSayi2.getText()), Integer.parseInt(txtSayi3.getText()), Integer.parseInt(txtSayi4.getText()));
							
							veriler[0] = "Cikarma";
							veriler[5] = Integer.toString(cikarma);
							
							String yeni1="";
							for(String veri : veriler)
								yeni1 +=  veri+"|";
							String eski1 = Islem+"|"+Sayi1+"|"+Sayi2+"|"+Sayi3+"|"+Sayi4+"|"+Sonuc+"|";
							
							
							DosyaGuncelle("veri.txt", eski1, yeni1);				
						break;
					case "Ortalama":
							int ortalama = Ortalama(Integer.parseInt(txtSayi1.getText()), Integer.parseInt(txtSayi2.getText()), Integer.parseInt(txtSayi3.getText()), Integer.parseInt(txtSayi4.getText()));
							
							veriler[0] = "Ortalama";
							veriler[5] = Integer.toString(ortalama);
							
							String yeni11="";
							for(String veri : veriler)
								yeni11 +=  veri+"|";
							String eski11 = Islem+"|"+Sayi1+"|"+Sayi2+"|"+Sayi3+"|"+Sayi4+"|"+Sonuc+"|";
							
							
							DosyaGuncelle("veri.txt", eski11, yeni11);			
						break;
				}
			}
		});
		btnHesapla.setBounds(91, 201, 130, 31);
		contentPane.add(btnHesapla);
		
		txtSonuc = new JTextField();
		txtSonuc.setEnabled(false);
		txtSonuc.setColumns(10);
		txtSonuc.setBounds(91, 170, 130, 20);
		contentPane.add(txtSonuc);
		
		JLabel lblSonuc = new JLabel("Sonuc");
		lblSonuc.setBounds(30, 170, 48, 20);
		contentPane.add(lblSonuc);
		
		cbIslem.setSelectedItem(Islem);
		txtSayi1.setText(Sayi1);
		txtSayi2.setText(Sayi2);
		txtSayi3.setText(Sayi3);
		txtSayi4.setText(Sayi4);
		txtSonuc.setText(Sonuc);
		
	}
}
