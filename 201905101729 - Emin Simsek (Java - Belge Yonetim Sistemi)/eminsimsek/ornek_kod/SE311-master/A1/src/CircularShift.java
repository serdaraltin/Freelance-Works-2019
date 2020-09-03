
import java.util.*;
import java.io.*;

/**
 * 
 */
public class CircularShift {


    private LineStorage shifts;
    private ArrayList<String> allshifts = new ArrayList<String>();
    private ArrayList<String> data = new ArrayList<String>();

    /**
     * Default constructor
     */
    public void CircularShift() {
    }


    public void CircularShift(LineStorage lines){
         this.shifts = lines;
         this.data = lines.getData();   //declaring attributes
    }

    public void insert(String line) {
        allshifts.add(line); //insert line into final array of lines

    }


    public void shifts(){
        //function to shift array and build new output

        for (String line : this.data){


                StringTokenizer tokens = new StringTokenizer(line, " ");
                String[] words = new String[tokens.countTokens()];
                int index = 0;
                while(tokens.hasMoreTokens()){
                    words[index] = tokens.nextToken();
                    ++index;
                }

                //convert array into arraylist
                ArrayList<String> wordsArray = new ArrayList<String>(Arrays.asList(words));

                for(int pos =0; pos< wordsArray.size(); pos++){

                    //shift array positions
                    String temp = "";
                    temp = wordsArray.get(0);
                    wordsArray.remove(0);
                    wordsArray.add(temp);
                    

                    //build string to add to array
                    String finalstring = "";
                    for(String word1: wordsArray){
                        finalstring += word1 + " ";
                    }

                    insert(finalstring);    //insert the final string
                }

        }


    }

    public ArrayList<String> getLists(){
        return this.allshifts;  //return the unsorted shifts
    }

}