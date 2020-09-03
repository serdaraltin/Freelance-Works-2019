import java.util.*;
import java.io.*;

public class Folder extends FileSystem{
	Date date;
	ArrayList<FileSystem> systems = new ArrayList<FileSystem>();
	String name;

	public void operation(){}


	public Folder(String foldername, Date date){
		this.name = foldername;
		this.date = date;
	}


	public void add(FileSystem comp){
		systems.add(comp);
	}

	public void remove(FileSystem comp){
		systems.remove(systems.indexOf(comp));
	}

	public void accept(Visitor visitor) {

	visitor.visit(this);
		for (FileSystem system: systems) {
			system.accept(visitor);
		}
	}


	public ArrayList<FileSystem> getChildren(){
		return this.systems;
	}

	@Override
	public String toString(){
		return String.format("Folder Name: " + this.name  +
		"\nCreation Date: " + this.date + "\n");
	}


	public String getName(){ return this.name;}
	public Date getDate(){return this.date;}

}