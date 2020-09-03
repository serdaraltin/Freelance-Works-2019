package meyvekesme.model;


public class SlashTrail {

	private int startX;
	private int startY;
	private int endX;
	private int endY;
	private boolean slashed;

	
	public SlashTrail() {
		setStartPosition(0, 0);
		setEndPosition(0, 0);
	}


	public void setStartPosition(int startX, int startY) {
		this.startX = startX;
		this.startY = startY;
	}

	public void setEndPosition(int endX, int endY) {
		this.endX = endX;
		this.endY = endY;
	}

	
	public boolean isSlashed() {
		if ((startX != endX) && (startY != endY)) {
			return slashed;
		} else {
			return false;
		}
	}

	
	public void setSlashed(boolean slashed) {
		this.slashed = slashed;
	}

}
