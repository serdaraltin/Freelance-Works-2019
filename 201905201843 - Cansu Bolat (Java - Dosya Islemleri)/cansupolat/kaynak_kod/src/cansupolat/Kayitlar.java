package cansupolat;

import java.awt.BorderLayout;
import java.awt.EventQueue;
import java.io.*;

import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;
import javax.swing.JButton;
import javax.swing.JTextField;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Kayitlar extends JFrame {

	private JPanel contentPane;
	private JTable table;
	private JTextField textField;
	DefaultTableModel model;


	

	private void DosyaOku(){ //Belirlenen dosyadan veriyi okuyup tabloya ekleme
		 File file = new File("veri.txt");
	        BufferedReader reader = null;
	        try {
				reader = new BufferedReader(new FileReader(file)); // dosyayi okuma modunda aciyoruz
			} catch (FileNotFoundException e) {
				e.printStackTrace();
			}
	        String satir;
			try {
				satir = reader.readLine();
				while (model.getRowCount() > 0)
					model.removeRow(0); // modeli temizliyoruz
				while (satir!=null) {
			       String[] veriler = satir.split("\\|"); // "|" ile gelen satirdaki veriyi parcalara bolmek icin split fonksiyonunu kullaniyoruz
			       
			       model.insertRow(0, veriler); // gelen verileri tabloya aktarmak icin model icerisine ekliyoruz
			       
			       satir = reader.readLine(); // yeni satira geciyoruzz
			    }
			} catch (IOException e) {
			
				e.printStackTrace();
			}
	}
	 static void VeriSil(String DosyaYolu, String veri) //Belirlenen dosyadan veriyi okuyup daha sonra silme
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
	            String yeniIcerik = eskiIcerik.replace(veri,"Silindi|Silindi|Silindi|Silindi|Silindi|Silindi|"); // Silinecek olan veriyi yenisiyle degistiriyoruz
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
	     
	public Kayitlar() {
		setResizable(false);
		setTitle("Kayitlar");
		setBounds(100, 100, 450, 343);
		setDefaultCloseOperation(HIDE_ON_CLOSE);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(0, 45, 434, 219);
		contentPane.add(scrollPane);
		
		table = new JTable();
		table.setFillsViewportHeight(true);
		model = new DefaultTableModel(
				new Object[][] {},
				new String[] {
					"Islem", "1. Sayi", "2. Sayi", "3. Sayi", "4. Sayi", "Sonuc"
				}
			);
		table.setModel(model);
		scrollPane.setViewportView(table);
		DosyaOku();
		JButton btnYenle = new JButton("YENILE");
		btnYenle.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				DosyaOku();
			}
		});
		btnYenle.setBounds(10, 275, 89, 23);
		contentPane.add(btnYenle);
		
		JButton btnGuncelle = new JButton("GUNCELLE");
		btnGuncelle.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				//JOptionPane.showMessageDialog(null, model.getValueAt(table.getSelectedRow(), 0));
				String Islem = model.getValueAt(table.getSelectedRow(), 0).toString(); // secilen satirdaki 0 inci index verisini String tipindeki degiskene atama
				String Sayi1 = model.getValueAt(table.getSelectedRow(), 1).toString(); // secilen satirdaki 1 inci index verisini String tipindeki degiskene atama
				String Sayi2 = model.getValueAt(table.getSelectedRow(), 2).toString(); // secilen satirdaki 2 inci index verisini String tipindeki degiskene atama
				String Sayi3 = model.getValueAt(table.getSelectedRow(), 3).toString(); // secilen satirdaki 3 inci index verisini String tipindeki degiskene atama
				String Sayi4 = model.getValueAt(table.getSelectedRow(), 4).toString(); // secilen satirdaki 4 inci index verisini String tipindeki degiskene atama
				String Sonuc = model.getValueAt(table.getSelectedRow(), 5).toString(); // secilen satirdaki 5 inci index verisini String tipindeki degiskene atama
				
				Guncelle frame = new Guncelle(Islem,Sayi1,Sayi2,Sayi3,Sayi4,Sonuc);
				frame.setVisible(true);
			}
		});
		btnGuncelle.setBounds(109, 275, 117, 23);
		contentPane.add(btnGuncelle);
		
		JButton btnSl = new JButton("SIL");
		btnSl.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String Islem = model.getValueAt(table.getSelectedRow(), 0).toString();
				String Sayi1 = model.getValueAt(table.getSelectedRow(), 1).toString();
				String Sayi2 = model.getValueAt(table.getSelectedRow(), 2).toString();
				String Sayi3 = model.getValueAt(table.getSelectedRow(), 3).toString();
				String Sayi4 = model.getValueAt(table.getSelectedRow(), 4).toString();
				String Sonuc = model.getValueAt(table.getSelectedRow(), 5).toString();
				
				String Veri = Islem+"|"+Sayi1+"|"+Sayi2+"|"+Sayi3+"|"+Sayi4+"|"+Sonuc+"|";
				
				VeriSil("veri.txt", Veri);
				DosyaOku();
			}
		});
		btnSl.setBounds(236, 275, 100, 23);
		contentPane.add(btnSl);
		
		JButton btnAra = new JButton("ARA");
		btnAra.setBounds(335, 11, 89, 23);
		contentPane.add(btnAra);
		
		textField = new JTextField();
		textField.setBounds(217, 11, 108, 23);
		contentPane.add(textField);
		textField.setColumns(10);
	}
}
