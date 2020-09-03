
import java.util.*;
import java.io.*;

/**
 * 
 */
public class CircularShift implements Observer{


    private LineStorage shifts;
    private ArrayList<String> allshifts;
    private ArrayList<String> data = new ArrayList<String>();

    /**
     * Default constructor
     */
    public void CircularShift() {
    }


    public void CircularShift(LineStorage lines){
         this.shifts = lines;
         this.data = this.shifts.getLines();   //declaring attributes
    }

    public void shifts()
    {   
        this.allshifts = new ArrayList<String>();
        List<String> sentences = null;
         sentences = build(this.data);

            for(String finalline: sentences)
                allshifts.add(finalline);
    }
    

    private List<String> build(ArrayList<String> lines)
    {   
        ArrayList<String> finalstrings = new ArrayList<String>();

        for(String line : lines){

        String wordslist[] = line.split(" ");

        for (int index = 0; index < wordslist.length; index++)
        {
        int temp = index;
        String toline = "";
        do {
            if (toline.length() > 0)
                    toline = toline + " ";

            toline = toline + wordslist[temp];
            temp = ((temp+1) % wordslist.length);
            } while (temp != index);
            // returnString.add(toline);
            finalstrings.add(toline);
        }

        }
        return finalstrings;
    } 



    public ArrayList<String> getLines(){
        return this.allshifts;  //return the unsorted shifts
    }


    @Override
    public void update(Observable observer, Object arg){

        this.shifts = (LineStorage) observer;
        this.data = this.shifts.getLines();
    }
}