
import java.util.*;

/**
 * 
 */
public class Alphabetizer {

    private CircularShift shift; //shifting component
    private ArrayList<String> sorted = new ArrayList<String>(); //non sorted data
 
    /**
     * Default constructor
     */
    public Alphabetizer() {}

    public void Alphabetizer(CircularShift shift){
    //declaring attributes
       this.shift = shift;
       this.sorted = shift.getLists();

    }


    public void sort(){
        //sorting method
        Collections.sort(this.sorted, String.CASE_INSENSITIVE_ORDER); //case order does not matter
    }

    public ArrayList<String> getSorted(){
        return this.sorted; //return the sorted array
    }

}