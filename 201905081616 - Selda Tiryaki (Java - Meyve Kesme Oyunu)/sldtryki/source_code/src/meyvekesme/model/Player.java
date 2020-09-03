package meyvekesme.model;



public class Player {

	private int score;
	private int lives;

	
	public Player() {
		score = 0;
		lives = 3;
	}

	
	public int getScore() {
		return score;
	}

	
	public void addScore(int score) {
		this.score += score;
	}


	public void subtractLife() {
		lives--;
	}

	
	public int getLives() {
		return lives;
	}

}
