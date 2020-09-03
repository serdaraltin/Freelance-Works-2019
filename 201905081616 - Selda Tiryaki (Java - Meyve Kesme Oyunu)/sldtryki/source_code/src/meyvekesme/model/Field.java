package meyvekesme.model;


public class Field {

	private GameObject object;
	private SlashTrail slash;

	
	public Field() {
		slash = new SlashTrail();
	}


	public void setObject(GameObject object) {
		this.object = object;
	}

	
	public GameObject getObject() {
		return object;
	}

	
	public SlashTrail getSlash() {
		return slash;
	}

}
