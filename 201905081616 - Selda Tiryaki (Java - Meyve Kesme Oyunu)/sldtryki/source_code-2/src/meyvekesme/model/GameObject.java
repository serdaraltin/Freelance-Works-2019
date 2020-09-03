package meyvekesme.model;


public abstract class GameObject {
	protected int type;
	protected double positionX;
	protected double positionY;
	protected double velocityX;
	protected double velocityY;
	protected int size;
	protected int points;

	
	public GameObject() {
		size = 0;
		positionX = 0;
		positionY = 0;
		velocityX = 0;
		velocityY = 0;
	}

	
	public int getSize() {
		return size;
	}

	public int getPoints() {
		return points;
	}


	public void setPosition(int x, int y) {
		positionX = (double) x;
		positionY = (double) y;
	}

	
	public void setVelocity(int x, int y) {
		velocityX = x;
		velocityY = y;
	}

	
	public int getX() {
		return (int) positionX;
	}

	
	public int getY() {
		return (int) positionY;
	}

	
	public void update(double time) {
		velocityY += 9.81 * (time/1000);
		positionX += velocityX * time / 20;
		positionY += velocityY * time / 20;
	}


	public int getType() {
		return type;
	}

	
	public boolean insideBounds(int x, int y) {
		if ((x >= (int) positionX) && (x <= (int) (positionX + size)) && (y >= (int) positionY)
				&& (y <= (int) (positionY + size))) {
			return true;
		} else {
			return false;
		}
	}

}
