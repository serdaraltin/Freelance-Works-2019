package frontend;

import java.awt.BorderLayout;
import java.awt.EventQueue;
import java.net.http.WebSocket.Listener;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;

import dal.HakemDal;
import types.HakemContract;

public class HakemListe extends JFrame {

	private JPanel contentPane;
	private JTable table;
	private DefaultTableModel model;


	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					HakemListe frame = new HakemListe();
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
		
		for(HakemContract contract : new HakemDal().GetAll()) {
			model.addRow(contract.Listele());
		}
		
	}

	public HakemListe() {
		setResizable(false);
		setTitle("Hakem Liste");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 485, 300);
		setLocationRelativeTo(null);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 11, 459, 239);
		contentPane.add(scrollPane);
		
		model = new DefaultTableModel(new Object[][] {,},new String[] {"Id", "Kullanici Adi", "Parola","Anahtar"});
		
		table = new JTable();
		table.setModel(model);
		scrollPane.setViewportView(table);
		
		listele();
	}
}
