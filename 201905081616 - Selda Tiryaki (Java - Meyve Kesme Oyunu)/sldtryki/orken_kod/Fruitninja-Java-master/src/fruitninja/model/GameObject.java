package fruitninja.model;

/**
 * 
 * The GameObject class is a model class which contains the position, size,
 * worth and speed of a Game Object. The class itself is abstract and therefore
 * can not be instantiated. It merely provides a blueprint for all Game Objects.
 * 
 * @author: Dajo Hofman
 * @version 1.0
 * @since 2015-11-17
 * 
 */
public abstract class GameObject {
	protected int type;
	protected double positionX;
	protected double positionY;
	protected double velocityX;
	protected double velocityY;
	protected int size;
	protected int points;

	/**
	 * Sets default values for the instance variables.
	 */
	public GameObject() {
		size = 0;
		positionX = 0;
		positionY = 0;
		velocityX = 0;
		velocityY = 0;
	}

	/**
	 * Returns the size of the GameObject.
	 * 
	 * @return The size of the GameObject.
	 */
	public int getSize() {
		return size;
	}

	/**
	 * Returns the amount of points the GameObject is worth.
	 * 
	 * @return The amount of points te GameObject is worth.
	 */
	public int getPoints() {
		return points;
	}

	/**
	 * Sets the position of the GameObject.
	 * 
	 * @param x
	 *            The x position where to set the GameObject to.
	 * @param y
	 *            The y position where to set the GameObject to.
	 */
	public void setPosition(int x, int y) {
		positionX = (double) x;
		positionY = (double) y;
	}

	/**
	 * Sets the velocity of the GameObject. This determines the direction and
	 * speed at which the GameObject will move. If a velocity is set to a
	 * negative value the object will move in the opposite (negative) direction.
	 * 
	 * @param x
	 *            The velocity at which the GameObject will move on the x-axis.
	 * @param y
	 *            The velocity at which the GameObject will move on the y-axis.
	 */
	public void setVelocity(int x, int y) {
		velocityX = x;
		velocityY = y;
	}

	/**
	 * Returns the x position of the GameObject.
	 * 
	 * @return The x position of the GameObject as integer.
	 */
	public int getX() {
		return (int) positionX;
	}

	/**
	 * Returns the y position of the GameObject.
	 * 
	 * @return The y position of the GameObject as integer.
	 */
	public int getY() {
		return (int) positionY;
	}

	/**
	 * This method is used to update the position of the GameObject. The
	 * position is calculated with the velocity and the time since the last
	 * update.
	 * 
	 * @param time
	 *            Time passed since last update in milliseconds.
	 */
	public void update(double time) {
		velocityY += 9.81 * (time/1000);
		positionX += velocityX * time / 20;
		positionY += velocityY * time / 20;
	}

	/**
	 * Returns the type of the GameObject. This is used for easy and fast type
	 * determination.
	 * 
	 * <ul>
	 * <li>0 - Apple</li>
	 * <li>1 - Orange</li>
	 * <li>2 - Strawberry</li>
	 * <li>3 - Bomb</li>
	 * </ul>
	 * 
	 * @return The type of the GameObject as integer.
	 */
	public int getType() {
		return type;
	}

	/**
	 * This method is used to determine if a position is inside the bounds of
	 * the GameObject.
	 * 
	 * @param x
	 *            The x position to check.
	 * @param y
	 *            The y position to check.
	 * @return Whether the position is inside the bounds of the GameObject.
	 */
	public boolean insideBounds(int x, int y) {
		if ((x >= (int) positionX) && (x <= (int) (positionX + size)) && (y >= (int) positionY)
				&& (y <= (int) (positionY + size))) {
			return true;
		} else {
			return false;
		}
	}

}
