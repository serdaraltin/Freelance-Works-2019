
import java.util.*;

/**
 * 
 */
public abstract class Input {

	protected ArrayList<String> data = new ArrayList<String>();
	protected String inputNumber;
	Alphabetizer sorted;	//input attributes

	public Input(){
	}

	//abstract methods
    public abstract void getInput();

    public ArrayList<String> getLines(){
    	return this.data;	//return input data
    } 

    public String getInfo(){
    	return this.inputNumber;	//return input number
    }

}