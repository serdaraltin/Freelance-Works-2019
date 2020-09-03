package Lab1;
import java.io.*;

public class Converter extends Filter{

	public Converter(Pipe input_, Pipe output_) {
		super(input_, output_);
		// TODO Auto-generated constructor stub
	}


	@Override
	protected void transform() {
		try {
			
		String line;
		
		while((line = (String) input_.get()) != null) {
			
			output(line.toUpperCase());
		}
			
		}
		catch(Exception e){
			System.out.println("Error: " + e );
		}
		
	}



private void output(String line) {
		
    try{
    	System.out.println(line);
    	
    	FileWriter outputFile = new FileWriter("src/Lab1/output.txt", true);
    outputFile.write(line + System.getProperty("line.separator"));
    outputFile.close();

    	
    }
    catch(Exception e){
        System.out.println("Error: " + e); //handle errors
    }


}
	

}
