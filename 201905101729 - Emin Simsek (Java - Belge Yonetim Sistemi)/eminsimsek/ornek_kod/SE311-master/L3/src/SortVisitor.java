import java.util.*;
import java.io.*;


public class SortVisitor implements Visitor{

	ArrayList<FileSystem> files = new ArrayList<FileSystem>();

	public void visit(FileSystem system){
		getAllFiles(system);
		Collections.sort(files, Comparator.comparing(s -> s.getDate()));

		System.out.println("Files ordered by Date:");
		for(FileSystem file : files)
			System.out.println(file);

	}

	private void getAllFiles(FileSystem system){

		ArrayList<FileSystem> children = system.getChildren();

		for(FileSystem child: children){
			if(child.getChildren() != null)
				getAllFiles(child);
			else
				files.add(child);

		}

	}



}