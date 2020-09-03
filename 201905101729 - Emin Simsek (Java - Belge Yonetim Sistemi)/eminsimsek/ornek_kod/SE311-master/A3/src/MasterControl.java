
import java.util.*;
import java.io.*;

/**
 * 
 */
public class MasterControl {

    /**
     * 
     */
    public static void main(String[] args) {
        // TODO implement here

    System.out.println("****************");
    System.out.println("    Welcome");
    System.out.println("****************");


    //Master controller object
    MasterControl master = new MasterControl();

    //get input and output methods
    Input input = master.getInputmethod();
    if(input == null) return;

    Output output = master.getOutputMethod();

    //build program using methods
    master.build(input, output);

    }

    public Output getOutputMethod() {
    
        //return output method
        Output outmethod = null;
        Scanner keyboard = new Scanner(System.in);
 
        //provide user input
        System.out.println("\nDo you want to output to a text file or console?");
        System.out.println("1) Text File");
        System.out.println("2) Console Output");

        String option = keyboard.nextLine();


        switch(option){
            case "1":
                Output fileout = new FileOutput(); //file output option
                outmethod = fileout;
                break;

            case "2":
                ConsoleOutput consoleout = new ConsoleOutput(); //console output option
                outmethod = consoleout;
                break;

            //recall on error
            default:
                return getOutputMethod();
            }

        return outmethod; //return the output method
    }


    public void interactive(){
        //interactive method

        //create class objects
        LineStorage lineStorage = new LineStorage();
        CircularShift circularShift = new CircularShift();
        Alphabetizer alphabetizer = new Alphabetizer();
        Output consoleoutput = new ConsoleOutput();

        //add the observer
        lineStorage.addObserver(circularShift);
        Scanner keyboard = new Scanner(System.in);
        boolean isTrue = true;
        while(isTrue){
            System.out.print("\nAdd, Delete, Print, Quit: ");
            String choice = keyboard.nextLine();
            String line;
                switch(choice){

                    case "a":
                    case "add":
                        System.out.print("> ");
                        line = keyboard.nextLine();
                        lineStorage.attach(line);
                        //dont know if add to total or just keep the same
                        break;

                    case "d":
                    case "delete":
                        System.out.print("> ");
                        line = keyboard.nextLine();
                        lineStorage.detach(line);
                        break;
                    case "p":
                    case "print":

                        circularShift.shifts();

                        alphabetizer.Alphabetizer(circularShift);   //sort the data
                        alphabetizer.sort();

                        consoleoutput.setSorted(alphabetizer);
                        consoleoutput.print();

                        break;
                    case "q":
                    case "quit":
                        isTrue=false;
                        break;
                    default:
                        System.out.println("Invalid input");
                        interactive();
                }

            }




    }


    public Input getInputmethod(){
        //input method

        Scanner keyboard = new Scanner(System.in);

        //display input options
        System.out.println("\nDo you want to read from text file or console?");
        System.out.println("1) Text File");
        System.out.println("2) Console Input");
        System.out.println("3) Interactive Console");

        String choice = keyboard.nextLine();



        Input inputmethod = null;

        switch(choice){

            case "1":
            //get Text file input
            Input fileinput = new FileInput(); //input file option
            fileinput.getInput();
            inputmethod = fileinput;

            break;

            case "2":
            //console input
            Input consoleinput = new ConsoleInput(); //console input option
            consoleinput.getInput();
            inputmethod = consoleinput;

            break;

            case "3":
                interactive();
                inputmethod = null;
                break;

            //default recall input method
            default:
                return getInputmethod();


        }

        return inputmethod; //return the input method selected
    }

    public void build(Input inputmethod, Output outmethod){
        //build function using input and output methods selected
        Scanner keyboard = new Scanner(System.in);
        String choice;

            LineStorage lineStorage = new LineStorage();
            CircularShift circularShift = new CircularShift();
            Alphabetizer alphabetizer = new Alphabetizer();

            lineStorage.LineStorage(inputmethod);  

            circularShift.CircularShift(lineStorage);   //shift the data
            circularShift.shifts();

            alphabetizer.Alphabetizer(circularShift);   //sort the data
            alphabetizer.sort();

            outmethod.setSorted(alphabetizer);
            outmethod.print();      //print data
        }

}