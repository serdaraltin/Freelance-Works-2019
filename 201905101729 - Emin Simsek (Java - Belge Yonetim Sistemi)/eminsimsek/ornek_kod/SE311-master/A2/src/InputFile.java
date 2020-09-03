import java.util.*;
import java.io.*;


public class InputFile extends Filter{

	protected File file;
	ArrayList<String> data;

    public InputFile(File input_, Pipe output_){
        super(null, output_);
        file = input_;
    }

    
public void setData(ArrayList<String> data) {
	this.data = data;
}
    
    
@Override
protected void transform(){

	
	if(this.file != null) {
	
	try{

	BufferedReader reader = new BufferedReader(new FileReader(file));

	String line;
	while((line = reader.readLine()) != null){
			line = line.replaceAll("[?,.!]", "");
			output_.put(line);

		}

		reader.close();

	}
	catch(Exception e){
		System.out.println("Error: " + e);

		}
	
	return;
	}
	
	else {
		
	    try{
        	for(String line: this.data){
        		output_.put(line);
        	}

        	output_.put(null);

        }
        catch(Exception e){
            System.out.println("Error: " + e); //handle errors
        }
	    
	    return;
		
	}
	
	
	
}

}