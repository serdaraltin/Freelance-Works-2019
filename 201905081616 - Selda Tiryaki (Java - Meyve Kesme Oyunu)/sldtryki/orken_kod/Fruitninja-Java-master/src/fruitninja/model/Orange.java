package fruitninja.model;

/**
 * 
 * The Orange class is an extension of the GameObject class. It's constructor
 * sets the values that are specific for this type of GameObject.
 * 
 * @author: Dajo Hofman
 * @version 1.0
 * @since 2015-11-17
 * 
 */
public class Orange extends GameObject {

	/**
	 * Sets the default values for this type of GameObject.
	 */
	public Orange() {
		super();
		size = 50;
		points = 50;
		type = 1;
	}

}
