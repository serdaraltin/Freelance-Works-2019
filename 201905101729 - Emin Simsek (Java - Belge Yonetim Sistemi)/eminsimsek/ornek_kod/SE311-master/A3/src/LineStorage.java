
import java.util.*;

/**
 * 
 */
public class LineStorage extends Observable{

    private ArrayList<String> lines = new ArrayList<String>();
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


    public ArrayList<String> getLines(){
        // return arraylist of lines
        return this.lines;  
    }


    public void attach(String line){
        this.lines.add(line);
        setChanged();
        notifyObservers();
    }

    public void detach(String line){
        Iterator<String> ite = this.lines.iterator();
         while(ite.hasNext()) {
            String value = ite.next();
                 if(value.equals(line)){
                    ite.remove();
                    break;
                 }
        }

        setChanged();
        notifyObservers();
    }


}