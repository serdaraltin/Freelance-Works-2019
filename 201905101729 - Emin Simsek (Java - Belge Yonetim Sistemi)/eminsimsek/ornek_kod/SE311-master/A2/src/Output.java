
import java.util.*;
import java.io.*;

/**
 * 
 */
public class Output extends Filter {

    private String outstream;
    ArrayList<String> data = new ArrayList<String>();

	public Output(Pipe input_ , Pipe output_){
        super(input_, null);
	}

protected void setFile(String file){
	
	this.outstream = file;
}


@Override
protected void transform()
{
	
	try {
		
    String line;
    while((line = (String)input_.get()) != null){
 
    		data.add(line);
	
	}
	}
	catch(Exception e){System.out.println("Error: "+ e) ;}
	

    }


public void print(){
	
	try {
		
		FileOutputStream fileStream = new FileOutputStream(outstream);
		OutputStreamWriter outputStream = new OutputStreamWriter(fileStream);
		
		
		for(String line: data) {
		
		outputStream.write(line + "\n");
		outputStream.flush();
		}
		outputStream.close();
		
		}
		catch(Exception e){System.out.println("Error: "+ e) ;}
	
	
	
}

}
