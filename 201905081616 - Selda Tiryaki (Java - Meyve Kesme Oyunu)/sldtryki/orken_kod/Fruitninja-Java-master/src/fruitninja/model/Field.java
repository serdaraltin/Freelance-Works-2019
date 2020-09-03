package fruitninja.model;

/**
 *
 * The field class is a model that contains the game object and the slashtrail
 * in the game.
 * 
 * @author: Dajo Hofman
 * @version 1.0
 * @since 2015-11-17
 * 
 */
public class Field {

	private GameObject object;
	private SlashTrail slash;

	/**
	 * Sets up a new SlashTrail.
	 */
	public Field() {
		slash = new SlashTrail();
	}

	/**
	 * Sets the GameObject in the field.
	 * 
	 * @param object
	 *            GameObject to be added to the field.
	 */
	public void setObject(GameObject object) {
		this.object = object;
	}

	/**
	 * Returns the GameObject in the field.
	 * 
	 * @return GameObject in the field.
	 */
	public GameObject getObject() {
		return object;
	}

	/**
	 * Returns the Slash object in the field.
	 * 
	 * @return Slash object in the field.
	 */
	public SlashTrail getSlash() {
		return slash;
	}

}
