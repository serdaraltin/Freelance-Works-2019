
import java.util.*;

/**
 * 
 */
public class LineStorage {

    private ArrayList<String> lines;
    private Input input;    //variables


    /**
     * Default constructor
     */
    public LineStorage() {
    }


    public void LineStorage(Input input){
        //variable declaration
        this.input = input;
        this.lines = input.getLines();
    }


    public ArrayList<String> getData(){
        // return arraylist of lines
        return this.lines;  
    }

}