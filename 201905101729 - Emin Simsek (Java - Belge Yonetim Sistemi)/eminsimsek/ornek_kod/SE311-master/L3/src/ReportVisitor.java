import java.util.*;
import java.io.*;

public class ReportVisitor implements Visitor{
	private int files=0;

	public void visit(FileSystem system){

		count(system);
		System.out.println("Total number of files: " + files + "\n");
	}



	private void count(FileSystem system){
		

		ArrayList<FileSystem> children = system.getChildren();

		for(FileSystem child: children){
			if(child.getChildren() != null){
				count(child);
			}
			else{
				files++;
			}

		}


	}

}