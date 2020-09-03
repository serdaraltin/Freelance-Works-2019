
import java.util.*;

/**
 * 
 */
public class ConsoleOutput extends Output {

    /**
     * Default constructor
     */
    public void ConsoleOuput() {
    }

    @Override
    public void setSorted(Alphabetizer sorted){
        this.sorted = sorted;   //variable declaration
        this.outArray = sorted.getSorted();
    }

    @Override
    public void print() {
        System.out.println("");
        for(String line: this.outArray){
            System.out.println(line);   //print the output to console
        }

    }



}