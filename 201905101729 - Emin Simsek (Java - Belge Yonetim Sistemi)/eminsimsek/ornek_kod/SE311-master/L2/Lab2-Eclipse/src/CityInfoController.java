import java.awt.event.*;

/**
 * SE 311 Lab 2
 * <p>
 * The controller for the program.
 * </p>
 * 
 * @version 1.0
 * 
 */
public class CityInfoController {
	private CityModel model;
	private CityInfoInputWindow inputView;

	/**
	 * Creates new CityInfoController
	 */
	public CityInfoController() {
		// intentionally empty
	}

	/**
	 * AddCityListener provides a method to create a new city. The city
	 * should then be added to the city list of the model. The values for the
	 * new city come from the fields of the inputView. If the model is null
	 * when the method is called, it returns without taking any action.
	 */
	private class AddCityListener implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent event) {
			
			String name = inputView.jtfName.getText();
			String state = inputView.jtfState.getText();
			String population = inputView.jtfPopulation.getText();
			String year = inputView.jcbYear.getSelectedItem().toString();
			
			City city = new City(name, state, population, year);
			model.addToCitList(city);
			
			
		} 
		
		
	}

	/**
	 * ClearCityListListener provides a method to clear the city list of the
	 * model. If the model is null when the method is called, it returns without
	 * taking any action.
	 */
	private class ClearCityListListener implements ActionListener {

		// add method here
		@Override
		public void actionPerformed(ActionEvent event) {
			
			model.clearCityList();
		}

	}

	/**
	 * ClearInputFieldsListener provides a method to clear the input fields of
	 * the inputView.
	 */
	private class ClearInputFieldsListener implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent event) {
			inputView.clearInputFields();
			
		}
	
	}

	/**
	 * @param model
	 *            to set as the model
	 */
	public void setModel(CityModel model) {
		this.model = model;
	}

	/**
	 * @return CityModel: the model
	 */
	public CityModel getModel() { // future use
		return model;
	}

	/**
	 * @param theView
	 *            on which the listeners should be set
	 */
	public void setInputWindow(CityInfoInputWindow theView) {
		inputView = theView;

		// Register listeners
		inputView.getAddCityButton().addActionListener(new AddCityListener());

		/***
		 *** The first action listener has been added above. You need to add the
		 * others below. There needs to be at least one action listener for each
		 * component one which actions can occur.
		 ***/
		
		//register the two listeners
		inputView.getClearInputButton().addActionListener(new ClearInputFieldsListener());
		inputView.getClearCitysButton().addActionListener(new ClearCityListListener());

		System.out.println("listeners registered in controller for input window");
	}

	/**
	 * @return the window (in case it needs to be sent messages from elsewhere)
	 */
	public CityInfoInputWindow getInputWindow() { // future use
		return inputView;
	}
}