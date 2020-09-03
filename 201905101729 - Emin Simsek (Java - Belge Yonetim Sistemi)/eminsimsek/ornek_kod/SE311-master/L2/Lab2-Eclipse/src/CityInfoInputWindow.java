import java.awt.GridLayout;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

/**
 * SE 311 Lab 2
 * <p>
 * Each object of this class represents a GUI input window.
 * </p>
 * @version 1.0
 *
 */
public class CityInfoInputWindow extends JFrame {
	private static final long serialVersionUID = 21305503976948004L;

	/** Button to click to add new city to the city list based on filled text fields. */
	JButton jbtAddCity = new JButton("Add City");

	/** Button to clear text fields of city info. */
	JButton jbtClearInput = new JButton("Clear Input Fields");

	/** Button to clear city list. */
	JButton jbtClearCities = new JButton("Clear City List");

	/** TextField to input new city name. */
	JTextField jtfName = new JTextField(20);
	JLabel lblName = new JLabel("City Name", JLabel.RIGHT);
	
	/** TextField to input state for new city. */
	JTextField jtfState = new JTextField(20);
	JLabel lblState = new JLabel("State", JLabel.RIGHT);

	/** TextField to input city's population. */
	JTextField jtfPopulation = new JTextField(20);
	JLabel lblPopulation = new JLabel("Population", JLabel.RIGHT);

	/** JComboBox to input census year. (The census only takes city every 10 years.) */
	JComboBox jcbYear = new JComboBox(new String[] { "2010", "2000", "1990", "1980", "1970", "1960", "1950", "1940"});
	JLabel lblYear = new JLabel("Census Year", JLabel.RIGHT);

	CityInfoInputWindow() {
		setTitle("Add New Cities to Your City List");
		// Create panels for names, populations, years, and command buttons
		
		JPanel jplName = new JPanel(new GridLayout(1, 0, 5, 5));
		jplName.add(lblName);
		jplName.add(jtfName);
		
		JPanel jplState = new JPanel(new GridLayout(1, 0, 5, 5));
		jplState.add(lblState);
		jplState.add(jtfState);

		JPanel jplPopulation = new JPanel(new GridLayout(1, 0, 5, 5));
		jplPopulation.add(lblPopulation);
		jplPopulation.add(jtfPopulation);

		JPanel jplYear = new JPanel(new GridLayout(1, 0, 5, 5));
		jplYear.add(lblYear);
		jplYear.add(jcbYear);

		JPanel jplButton = new JPanel(new GridLayout(1, 0, 5, 5));
		jplButton.add(jbtAddCity);
		jplButton.add(jbtClearInput);
		jplButton.add(jbtClearCities);

		// Set up the content pane and add all the panels to it.
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setLayout(new GridLayout(0, 1, 5, 5));
		add(jplName);
		add(jplState);
		add(jplPopulation);
		add(jplYear);
		add(jplButton);
		pack();
		setVisible(true);
	}
	
	public JButton getAddCityButton() {
		return jbtAddCity;
	}
	
	public JButton getClearInputButton() {
		return jbtClearInput;
	}
	
	public JButton getClearCitysButton() {
		return jbtClearCities;
	}

	public void clearInputFields() {
		jtfName.setText("");
		jtfState.setText("");
		jtfPopulation.setText("");
		jcbYear.setSelectedIndex(0);
	}
}