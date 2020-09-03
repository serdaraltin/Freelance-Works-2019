//TAMAMLANDI

import java.util.*;
import java.io.*;


public class FileOutput extends Output {

    private String filename;


    public FileOutput() {
    }

    @Override
    public void setSorted(Alphabetizer sorted){
        this.sorted = sorted;
        this.outArray = sorted.getSorted(); //variable declaration
    }


    @Override
    public void print() {
        
        //prompt file name
        Scanner keyboard = new Scanner(System.in);
        System.out.print("Dosya ismi : ");
        this.filename = keyboard.nextLine();

        try{
        //write to file
        PrintWriter outputFile = new PrintWriter(this.filename);
        for(String line : this.outArray){
            outputFile.println(line);
            }
        
        outputFile.close();
        }
        catch(Exception e){
            System.out.println("Hata : " + e); //handle errors
            print();
        }
    }

}