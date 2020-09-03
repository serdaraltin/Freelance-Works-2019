
import java.util.*;
import java.io.*;

/**
 * 
 */
public class FileInput extends Input {

    
    private String filename;
  
    @Override 
    public void getInput(){
        //function to get input from file

    Scanner keyboard = new Scanner(System.in);
    System.out.print("Enter file name: ");  //prompt file name
    this.filename = keyboard.nextLine();

        try{
                //scanner to open file and read each line
               File file = new File(this.filename);
               Scanner scanner = new Scanner(file);

               while (scanner.hasNextLine()) {

                String line = scanner.nextLine();
                line = line.replaceAll("[?,.!]", ""); //format all lines to remove characters
                this.data.add(line);
            }

            scanner.close();

        }
        catch(Exception e){
            System.out.println("Could not read file: " + e); //handle errors
            getInput();
        }
    }

}