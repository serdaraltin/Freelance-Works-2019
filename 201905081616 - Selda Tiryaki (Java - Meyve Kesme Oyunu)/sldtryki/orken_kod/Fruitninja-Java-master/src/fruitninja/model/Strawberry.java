package fruitninja.model;

/**
 * 
 * The Strawberry class is an extension of the GameObject class. It's
 * constructor sets the values that are specific for this type of GameObject.
 * 
 * @author: Dajo Hofman
 * @version 1.0
 * @since 2015-11-17
 * 
 */
public class Strawberry extends GameObject {

	/**
	 * Sets the default values for this type of GameObject.
	 */
	public Strawberry() {
		super();
		points = 100;
		size = 30;
		type = 2;
	}

}
