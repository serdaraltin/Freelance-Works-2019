/**
 * SE 311 Lab 
 * 
 * <p>
 * This program allows information on cities to be entered through a GUI window and
 * adds it to a list, and displays the city list in a second GUI window.
 * </p>
 * @version 1.0
 *
 */

public class Driver {
	static CityModel theCityListModel = new CityModel("USA");
	static CityInfoInputWindow theInputWindow = new CityInfoInputWindow();
	static CityInfoDisplayWindow theDisplayWindow = new CityInfoDisplayWindow();
	static CityInfoController theController = new CityInfoController();	
	
	/**
	 * @param args
	 */
	public static void main(String[] args) {
		theDisplayWindow.setModel(theCityListModel);
		theController.setModel(theCityListModel);
		theController.setInputWindow(theInputWindow);
	}
}
