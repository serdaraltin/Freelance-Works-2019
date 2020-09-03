
import java.util.*;
import java.io.*;

/**
 * 
 */
public abstract class Output {

    //output attributes
    protected ArrayList<String> outArray = new ArrayList<String>();
    protected Alphabetizer sorted;

    public Output(){}

    //abstract methods
    public abstract void print();
    public abstract void setSorted(Alphabetizer sorted);


}