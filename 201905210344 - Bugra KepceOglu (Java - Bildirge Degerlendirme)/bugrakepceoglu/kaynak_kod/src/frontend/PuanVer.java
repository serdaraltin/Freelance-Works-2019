package frontend;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import dal.BildirgeDal;
import dal.PuanDal;
import types.BildirgeContract;
import types.PuanContract;

import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JComboBox;
import javax.swing.JButton;
import javax.swing.DefaultComboBoxModel;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class PuanVer extends JFrame {

	private JPanel contentPane;
	public int HakemId;
	
	JComboBox cbBildirge ;

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					PuanVer frame = new PuanVer();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	public void listele() {
		cbBildirge.removeAllItems();
		for (BildirgeContract contract : new BildirgeDal().GetAll()) {
			cbBildirge.addItem(contract.getBaslik());
		}
	}
	

	public PuanVer() {
		setResizable(false);
		setTitle("Puan Ver");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 290, 201);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblBildirge = new JLabel("Bildirge");
		lblBildirge.setBounds(20, 32, 61, 14);
		contentPane.add(lblBildirge);
		
		cbBildirge = new JComboBox();
		cbBildirge.setBounds(85, 28, 130, 22);
		contentPane.add(cbBildirge);
		
		JLabel lblPuan = new JLabel("Puan");
		lblPuan.setBounds(20, 61, 61, 14);
		contentPane.add(lblPuan);
		
		JComboBox cbPuan = new JComboBox();
		cbPuan.setModel(new DefaultComboBoxModel(new String[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"}));
		cbPuan.setSelectedIndex(4);
		cbPuan.setBounds(85, 57, 130, 22);
		contentPane.add(cbPuan);
		
		JButton btnNewButton = new JButton("KAYDET");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				PuanContract contract = new PuanContract();
				contract.setHakemId(HakemId);
				contract.setPuan(Integer.parseInt(cbPuan.getSelectedItem().toString()));
				contract.setBildirgeId(new BildirgeDal().GetId(cbBildirge.getSelectedItem().toString()));
				
				new PuanDal().Insert(contract);
				JOptionPane.showMessageDialog(null, "Puanlama kaydi eklendi");
			}
		});
		btnNewButton.setBounds(85, 90, 130, 43);
		contentPane.add(btnNewButton);
		
		listele();
	}
	

}
