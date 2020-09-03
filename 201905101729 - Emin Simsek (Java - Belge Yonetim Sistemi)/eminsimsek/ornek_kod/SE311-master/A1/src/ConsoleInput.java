
import java.util.*;

/**
 * 
 */
public class ConsoleInput extends Input {

    private int numlines;

    /**
     * Default constructor
     */
    public ConsoleInput() {
    }

    @Override
    public void getInput(){
        //input function

        System.out.print("How many lines would you like to type? : ");
        Scanner keyboard = new Scanner(System.in);

        try{
            this.numlines = keyboard.nextInt(); //get number of inputs 

            for(int index =0; index <= this.numlines; index++){ 
                String line = keyboard.nextLine();
                line = line.replaceAll("[?,.!]", "");
                this.data.add(line);
            }

        }
        catch(Exception e){
            System.out.println("Error: " + e); //handle errors
            getInput();
        }

    }

}