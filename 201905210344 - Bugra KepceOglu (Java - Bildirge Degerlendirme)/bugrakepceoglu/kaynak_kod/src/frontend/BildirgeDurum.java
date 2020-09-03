package frontend;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.table.DefaultTableModel;

import dal.HakemDal;
import types.HakemContract;

public class BildirgeDurum extends JFrame {

	private JPanel contentPane;
	private DefaultTableModel model;



	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					BildirgeDurum frame = new BildirgeDurum();
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
	
	public BildirgeDurum() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		contentPane.setLayout(new BorderLayout(0, 0));
		setContentPane(contentPane);
	}

}
