package meyvekesme;

import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import javax.swing.JButton;
import javax.swing.JDialog;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.table.DefaultTableModel;


import javax.swing.JTable;
import javax.swing.JScrollPane;

public class PuanTablosu extends JDialog {
	private String userName="root"; // veritabani kullanici adi
	private String password = ""; // veritabani parolasi
	private String url="jdbc:mysql://localhost/meyvekesme"; // veritabani yolu
	private DefaultTableModel model1;

	public void Listele() {
		while (model1.getRowCount() > 0)
			model1.removeRow(0);

		try {
			Class.forName("com.mysql.jdbc.Driver");
		} catch (ClassNotFoundException e) {

			e.printStackTrace();
		}
		
		
		Connection connection = null;
		
		try {
			
			connection = (Connection)DriverManager.getConnection(url,userName,password);
		} catch (SQLException e) {
		
			e.printStackTrace();
		}
		
		try {
			Statement statement = connection.createStatement();
			ResultSet resultSet = statement.executeQuery("SELECT * FROM puanlar");
			while(resultSet.next()) {
				//JOptionPane.showMessageDialog(null, resultSet.getObject("KullaniciAdi"));
			Object[] veri = {resultSet.getInt("Id"),resultSet.getString("KullaniciAdi"), resultSet.getInt("Puan")};
			model1.addRow(veri);
				
			}
			statement.close();
			connection.close();
		} catch (SQLException e) {
			
			e.printStackTrace();
		}
		
	}
	
	public static void main(String[] args) {
		try {
			PuanTablosu dialog = new PuanTablosu();
			dialog.setDefaultCloseOperation(JDialog.DISPOSE_ON_CLOSE);
			dialog.setVisible(true);
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	public PuanTablosu() {
		
		setTitle("Puan Tablosu");
		setBounds(100, 100, 481, 354);
		getContentPane().setLayout(null);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 11, 447, 291);
		getContentPane().add(scrollPane);
		
		model1 = new DefaultTableModel(null, new String[] { "Id", "Kullanici", "Puan" }) {
			boolean[] columnEditables = new boolean[] { false, false, false };

			public boolean isCellEditable(int row, int column) {
				return columnEditables[column];
			}
		};

		JTable table_1 = new JTable();
		
		table_1.setModel(model1);
		
		scrollPane.setViewportView(table_1);


		Listele();


		


	}
}
