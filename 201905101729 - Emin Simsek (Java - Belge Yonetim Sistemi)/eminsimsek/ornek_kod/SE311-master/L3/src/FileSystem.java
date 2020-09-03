import java.util.*;
import java.io.*;

public abstract class FileSystem{
	public abstract void operation();	
	public abstract void accept(Visitor visit);
	public abstract ArrayList<FileSystem> getChildren();
	public abstract String getName();
	public abstract Date getDate();

}