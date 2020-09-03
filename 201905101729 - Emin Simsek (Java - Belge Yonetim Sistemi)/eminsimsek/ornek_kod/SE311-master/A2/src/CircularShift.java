
import java.util.*;
import java.io.*;


public class CircularShift extends Filter{

	public CircularShift(Pipe input_, Pipe output_) {
		super(input_, output_);
		// TODO Auto-generated constructor stub
	}

	@Override
	protected void transform()
	{
		String line="";
		do
		{
			try
			{
				line = (String)input_.get();
			} catch (Exception e) {
				System.out.println("Error: " + e);
			}
			List<String> finalString;
			
			if (line != null)
			{	
				//get the final string from the arraylist
				finalString = shifts(line);

				//for each line in the finalstring array add to output objectr
				for (String lines : finalString) {
					output_.put(lines);

				}
			}

		} while (line != null);

	}
	

	private List<String> shifts(String line)
	{
		String wordslist[] = line.split(" ");


		List<String> returnString = new ArrayList<String>();

		for (int index = 0; index < wordslist.length; index++)
		{
		int temp = index;
		String toline = "";
		do {
			
			if (toline.length() > 0)
					toline = toline + " ";

			toline = toline + wordslist[temp];

			temp = ((temp+1) % wordslist.length);

			} while (temp != index);

			returnString.add(toline);

		}

		return returnString;
	} 


}