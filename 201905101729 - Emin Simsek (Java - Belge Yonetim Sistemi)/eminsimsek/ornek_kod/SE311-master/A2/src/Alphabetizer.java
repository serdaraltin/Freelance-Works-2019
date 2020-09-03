import java.util.*;
import java.io.*;
public class Alphabetizer extends Filter
{

	public Alphabetizer(Pipe input_, Pipe output_) {
		super(input_, output_);
		// TODO Auto-generated constructor stub
	}


	@Override
	protected void transform()
	{
		List<String> lines = new ArrayList<String>();
		
		try {
		String line;
		while((line = (String) input_.get()) != null) {
			lines.add(line);
		}
		
		}
		catch(Exception e) {}

		java.util.Collections.sort(lines, String.CASE_INSENSITIVE_ORDER);

		for (String outputline : lines) {
			output_.put(outputline);
		}
		output_.put(null);

	}
	
}
