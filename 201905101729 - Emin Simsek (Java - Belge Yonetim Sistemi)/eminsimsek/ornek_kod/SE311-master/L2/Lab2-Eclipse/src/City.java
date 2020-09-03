/**
 * SE 311 Lab
 * <p>
 * Each object of this class represents the information of a city.
 * </p>
 * @version 1.0
 *
 */
public class City {
	public String name;
	public String state;
	public String population;
	public String year;
	
	/**
	 * @param name
	 * @param population
	 * @param year
	 */
	public City(String name, String state, String population, String year) {
		this.name = name;		
		this.state = state;
		this.population = population;
		this.year = year;
	}

		
	/**
	 * @return city info as a String
	 */
	public String toString() {
		return name + ", " + state + " (" + population + ", " + year + ")";
	}
}
