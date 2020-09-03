package frontend;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;

import dal.BildirgeDal;
import dal.HakemDal;
import types.BildirgeContract;
import types.HakemContract;

public class BildirgeListe extends JFrame {

	private JPanel contentPane;
	private JTable table;
	private DefaultTableModel model;

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					BildirgeListe frame = new BildirgeListe();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	private void listele() {
		for(int i = 0; i < model.getRowCount(); i++) {
			model.removeRow(i);
		}
		
		for(BildirgeContract contract : new BildirgeDal().GetAll()) {
			model.addRow(contract.Listele());
		}
		
	}
	
	public BildirgeListe() {
		setTitle("Bildirge Liste");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 590, 349);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 11, 554, 288);
		contentPane.add(scrollPane);
		
		model = new DefaultTableModel(new Object[][] {,},new String[] {"Id", "Baslik", "Metin", "Anahtar"});
		
		table = new JTable();
		table.setModel(model);
		scrollPane.setViewportView(table);
		
		listele();
	}
}
