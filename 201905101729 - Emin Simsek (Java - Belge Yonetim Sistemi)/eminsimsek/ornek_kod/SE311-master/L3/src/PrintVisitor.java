import java.util.*;
import java.io.*;

public class PrintVisitor implements Visitor{

	public void visit(FileSystem system){

		ArrayList<FileSystem> children = system.getChildren();

		for(FileSystem sys : children){
			
			System.out.println(sys);

			if(sys.getChildren() != null && !sys.getChildren().isEmpty()){
				System.out.println("-----------------------------------");
				System.out.println("Within " + sys.getName() + ":");
				visit(sys);
				System.out.println("-----------------------------------");
			}

		}

	}

}