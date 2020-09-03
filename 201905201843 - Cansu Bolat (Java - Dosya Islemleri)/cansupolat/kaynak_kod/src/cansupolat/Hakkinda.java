package cansupolat;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import java.awt.Font;

public class Hakkinda extends JFrame {

	private JPanel contentPane;


	public Hakkinda() {
		setTitle("Hakkinda");
		setBounds(100, 100, 389, 187);
		setLocationRelativeTo(null);
		setResizable(false);
		setDefaultCloseOperation(HIDE_ON_CLOSE);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblCansuPolatVe = new JLabel("CANSU BOLAT VE GRUP ARKADASLARI");
		lblCansuPolatVe.setBounds(48, 34, 293, 28);
		contentPane.add(lblCansuPolatVe);
		
		JLabel lblTarafndanKodlanmstr = new JLabel("TARAFINDAN KODLANMISTIR");
		lblTarafndanKodlanmstr.setBounds(48, 63, 293, 28);
		contentPane.add(lblTarafndanKodlanmstr);
	}

}
