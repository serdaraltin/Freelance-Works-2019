//TAMAMLANDI

import java.util.*;


public class ConsoleInput extends Input {

    private int numlines;

    public ConsoleInput() {
    }

    @Override
    public void getInput(){
        //input function

        System.out.print("Satir sayisi : ");
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
            System.out.println("Hata : " + e); //handle errors
            getInput();
        }

    }

}