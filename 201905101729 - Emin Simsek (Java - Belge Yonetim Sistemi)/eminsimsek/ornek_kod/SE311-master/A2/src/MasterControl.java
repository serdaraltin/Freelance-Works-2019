
import java.util.*;
import java.io.*;

/**
 * 
 */
public class MasterControl {

    /**
     * 
     */
    public static void main(String[] args) throws InterruptedException, IOException{

    //Master controller object
    MasterControl master = new MasterControl();

    //get input and output methods

    String inputstream = master.getInputmethod();
    Pipe upper_case_pipe = new PipeImpl();
    Pipe cs_to_alpha = new PipeImpl();
    Pipe alpha_to_output = new PipeImpl();
    
    Pipe input_to_cs = new PipeImpl(); //input pipe
    InputFile inputmethod;


    if(inputstream.equals("1")){

        Scanner keyboard = new Scanner(System.in);
        System.out.print("Enter file location: ");
        String location = keyboard.nextLine();

        File file = new File(location);
       inputmethod = new InputFile(file, input_to_cs);
        
        
    }
    else{
        ArrayList<String> list = new ArrayList<String>();

        try{

        Scanner keyboard = new Scanner(System.in);
        System.out.print("How many lines would you like to type? : ");

        int numlines = keyboard.nextInt(); //get number of inputs 


        for(int index =0; index <= numlines; index++){ 
                String line = keyboard.nextLine();
                line = line.replaceAll("[?,.!]", "");
                list.add(line);
            }

        }
        catch(Exception e){
            System.out.println("Error:" + e);
        }

        inputmethod = new InputFile(null, input_to_cs);
        inputmethod.setData(list);
        
    }
    

    String upperstream = master.getUpperCase();
    String file = master.getOutputMethod();
   
 
     
    if(upperstream.equals("1")) {
    	
    UpperCaseConverter uppercase = new UpperCaseConverter(input_to_cs, upper_case_pipe);
    Output output = new Output(upper_case_pipe, null);
    output.setFile(file);
    
    		inputmethod.start();
    		uppercase.start();
    		output.start();
    		output.print();
    
    }
    else if(upperstream.equals("2")){
    	
        CircularShift shift = new CircularShift(input_to_cs, cs_to_alpha);
        UpperCaseConverter uppercase = new UpperCaseConverter(cs_to_alpha, upper_case_pipe);
        Output output = new Output(upper_case_pipe, null);
        output.setFile(file);
        
        inputmethod.start();
        shift.start();
        uppercase.start();
        output.start();
        output.print();
    	
    }
    else {
    
        CircularShift shift = new CircularShift(input_to_cs, cs_to_alpha);
        Alphabetizer alpha = new Alphabetizer(cs_to_alpha, alpha_to_output);
        UpperCaseConverter uppercase = new UpperCaseConverter(alpha_to_output, upper_case_pipe);
        Output output = new Output(upper_case_pipe, null);
        output.setFile(file);
        
        inputmethod.start();
   
        
       shift.start();
       alpha.start();
 
	   uppercase.start();
	   
       String temp;
	    while((temp = (String) alpha_to_output.get()) != null){
	    	
   		System.out.println("alpha_to_output: "+ temp);
	    }
	   
	   
       output.start();
       output.print();
    }
    
    

    System.exit(0);

    }


    public String getUpperCase(){
        
        Scanner keyboard = new Scanner(System.in);

        System.out.println("\nLocation for Upper Case Converter");
        System.out.println("1) After Input");
        System.out.println("2) After CircularShift");
        System.out.println("3) After Alphabetizer");
        System.out.print("choice >");

        String choice = keyboard.nextLine();

        switch(choice){

            case "1":
                return "1";

            case "2":
                return "2";

            case "3":
                return "3";

            default:
            System.out.println("Invalid Choice");
            return getUpperCase();
        }


    }

    public String getOutputMethod() {
    
        Scanner keyboard = new Scanner(System.in);
        System.out.print("File location for output: ");
        String filename = keyboard.nextLine();

        return filename;

    }

    
    public String getInputmethod(){
        //input method

        Scanner keyboard = new Scanner(System.in);

        //display input options
        System.out.println("\nDo you want to input from text file or console?");
        System.out.println("1) Text File");
        System.out.println("2) Console Input");
        System.out.print("choice > ");

        String choice = keyboard.nextLine();
        
        switch(choice){

            case "1":
                return "1";

            case "2":
                return "2";
          
            default:
                System.out.println("Invalid Option");
                return getInputmethod();
        }

    }

 
}