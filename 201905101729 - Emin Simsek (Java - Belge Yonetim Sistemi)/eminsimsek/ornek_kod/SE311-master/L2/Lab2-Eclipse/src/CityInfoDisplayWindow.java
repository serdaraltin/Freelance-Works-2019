import java.awt.BorderLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.*;

/**
 * SE 311 Lab 2
 * <p>
 * Each object of this class represents a GUI display window.
 * </p>
 * @version 1.0
 *
 */
public class CityInfoDisplayWindow extends JFrame implements ActionListener {
	private static final long serialVersionUID = -7544472247240102278L;
	
	private JList displayCityList;
	private CityModel model;
	
	public CityInfoDisplayWindow() {
		setTitle("Your List of Cities");
	}

	public void actionPerformed(ActionEvent e) {
		displayCityList.setListData(model.getCityInfo().values().toArray());
		pack();
	}
	
	public void setModel(CityModel model) {
		this.model = model;
		
		if (model != null) {
			model.addActionListener(this);
			add(new JLabel("City NAME, STATE (POPULATION, YEAR)"), BorderLayout.NORTH);
			displayCityList = new JList(model.getCityInfo().values().toArray());
			add(displayCityList, BorderLayout.CENTER);
			pack();
			setVisible(true);
		}
	}

	public CityModel getModel() {
		return model;
	}
}