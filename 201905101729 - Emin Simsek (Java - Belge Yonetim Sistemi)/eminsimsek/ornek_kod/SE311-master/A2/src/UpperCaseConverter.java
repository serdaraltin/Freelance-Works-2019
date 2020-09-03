import java.util.*;
import java.io.*;

public class UpperCaseConverter extends Filter{


		public UpperCaseConverter(Pipe input_ , Pipe output_){
        super(input_, output_);

	}

	@Override
	public void transform(){
 
		try{

		String line;
		while((line = (String) input_.get()) != null){
			
			line = line.toUpperCase();
			System.out.println(line);
			output_.put(line);

		}


		}
		catch(Exception e){
			System.out.println("Error: " + e);
		}
	}

}