import java.util.*;
import java.io.*;

public class Client{

	public static void main(String[] args){




		File f1 = new File("File1.txt", 128, new Date(100,12,15));
		File f2 = new File("File2.txt", 128, new Date(101,7,15));
		File f3 = new File("File3.txt", 128, new Date(105,12,15));
		File f4 = new File("File4.txt", 128, new Date(103,2,15));
		File f5 = new File("File5.txt", 128, new Date(102,6,15));
		File f6 = new File("File6.txt", 128, new Date(100,11,15));
		File f7 = new File("File7.txt", 128, new Date(105,1,10));
		File f8 = new File("File8.txt", 128, new Date(103,2,10));
		File f9 = new File("File9.txt", 128, new Date(106,5,10));


		Folder root = new Folder("root", new Date());
		Folder fold1 = new Folder("Folder 1", new Date());
		Folder fold2 = new Folder("Folder 2", new Date());
		Folder fold3 = new Folder("Folder 3", new Date());

		fold1.add(f1);
		fold1.add(f2);
		fold1.add(f3);

		fold2.add(f5);
		fold2.add(f6);
		fold2.add(f7);
		fold2.add(f8);

		fold2.add(fold3);
		fold1.add(fold2);

		root.add(f9);
		root.add(fold1);
		root.add(f4);


		Visitor pvisit = new PrintVisitor();
		Visitor rvisit = new ReportVisitor();
		Visitor svisit = new SortVisitor();

		System.out.println("*** Print out file System ***");
		pvisit.visit(root);

		System.out.println("\n\n*** Report total number of files within system ***");
		rvisit.visit(root);

		System.out.println("\n\n*** Report files that were created the earliest ***");
		svisit.visit(root);

	}

}