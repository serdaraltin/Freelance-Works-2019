package Lab1;
import java.util.*;
import java.io.*;


public class Generator extends Filter{

	
	public Generator(Pipe input_, Pipe output_) {
		super(input_, output_);
		// TODO Auto-generated constructor stub
	}

	@Override
	protected void transform() {
		
		
		try {
			 File file = new File("src/Lab1/TestFile.txt");			 
			 BufferedReader br = new BufferedReader(new FileReader(file));
			  String line;
			  while ((line = br.readLine()) != null)
			    output_.put(line);
		     
			  
			  br.close();
			}
			catch(Exception e) {
				System.out.println("Error: " + e);
			}
		
		
	}
}
