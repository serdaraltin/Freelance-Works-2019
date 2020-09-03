import java.util.*;
import java.io.*;

public class File extends FileSystem{

	String name;
	double size;
	Date date;

	public File(String filename, double size, Date date){
		this.name = filename;
		this.size = size;
		this.date = date;
	}

	@Override
	public void operation(){}


	public void accept(Visitor visitor) {
		visitor.visit(this);
	}

	public ArrayList<FileSystem> getChildren(){
		return null;
	}

	@Override
	public String toString(){
		return String.format("Filename: " + this.name  +
			"\nSize: " + this.size + "\nCreation Date: " + this.date + "\n");
	}

	public String getName(){ return this.name;}
	public Date getDate(){return this.date;}



}