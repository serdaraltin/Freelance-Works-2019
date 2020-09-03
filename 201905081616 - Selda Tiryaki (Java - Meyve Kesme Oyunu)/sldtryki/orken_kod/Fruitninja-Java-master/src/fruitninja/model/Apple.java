package fruitninja.model;

import fruitninja.model.GameObject;

/**
 * 
 * The Apple class is an extension of the GameObject class. It's constructor
 * sets the values that are specific for this type of GameObject.
 * 
 * @author: Dajo Hofman
 * @version 1.0
 * @since 2015-11-17
 * 
 */
public class Apple extends GameObject {

	/**
	 * Sets the default values for this type of GameObject.
	 */
	public Apple() {
		super();
		type = 0;
		size = 75;
		points = 50;
	}

}
