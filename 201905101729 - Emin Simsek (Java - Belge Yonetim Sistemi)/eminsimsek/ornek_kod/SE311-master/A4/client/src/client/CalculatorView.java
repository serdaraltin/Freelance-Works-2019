package client;

import java.awt.*;
import javax.swing.*;
import java.awt.event.ActionListener;

public class CalculatorView extends JFrame{

	private static final long serialVersionUID = 1L;
	private JLabel resultDisplay;
	private JPanel buttonGroup;

	public CalculatorView(){
		super("Simple Calculator");

		JPanel displayPanel = new JPanel();
		add(displayPanel, BorderLayout.NORTH);
		
		resultDisplay = new JLabel(" ");
		displayPanel.add(resultDisplay);

		//create the buttons

		buttonGroup = new JPanel();
		add(buttonGroup, BorderLayout.CENTER);
		buttonGroup.setLayout(new GridLayout(4,4,0,0));

		String [] buttonStrings = {
				"1", "2", "3", "+",
				"4", "5", "6", "-",
				"7", "8", "9", "*",
				"0", "C", "=", "/"
		};

		for(String s: buttonStrings){
			buttonGroup.add(new JButton(s));	
		}
		
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setSize(300,400);
		setVisible(true);

	}
	
	public void attachListener(ActionListener  listener) {
		for(Component b: buttonGroup.getComponents()) {
			 ((JButton)b).addActionListener(listener);
		}
	}
	
	public void updateResult(String value) {
		resultDisplay.setText(value);
	}

}