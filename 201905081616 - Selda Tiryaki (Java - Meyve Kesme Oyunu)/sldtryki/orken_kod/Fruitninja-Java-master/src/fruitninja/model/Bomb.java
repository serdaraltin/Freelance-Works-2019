package fruitninja.model;

/**
 * 
 * The Bomb class is an extension of the GameObject class. It's constructor sets
 * the values that are specific for this type of GameObject.
 * 
 * @author: Dajo Hofman
 * @version 1.0
 * @since 2015-11-17
 * 
 */
public class Bomb extends GameObject {

	/**
	 * Sets the default values for this type of GameObject.
	 */
	public Bomb() {
		super();
		points = 0;
		size = 75;
		type = 3;
	}

}
