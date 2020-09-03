import java.util.*;
import java.net.*;
import java.io.*;


public class Client {

	
	static ArrayList<Integer> digits = new ArrayList<Integer>();
	
	public static void main(String [] args)throws IOException{
		
		
		
		Socket socket = new Socket("localhost", 8080);	
		OutputStream os = socket.getOutputStream();
		ObjectOutputStream oos = new ObjectOutputStream(os);

		System.out.println("Please enter a digit, q to exit:");
		Scanner keyboard = new Scanner(System.in);
		String resp = "";
		
		while(!resp.equals("q")) {

			System.out.print("> ");
			resp = keyboard.next();
			
			try { digits.add(Integer.parseInt(resp));}
			catch(Exception e) {}

		}
		
		oos.writeObject(digits);
		
		try {
			
		InputStream is = socket.getInputStream();
		ObjectInputStream socketois = new ObjectInputStream(is);
		ArrayList<Integer> list = (ArrayList<Integer>) socketois.readObject();
		System.out.println("Size: " + list.size());
		System.out.println(list);
		
		}catch(Exception e){}
		
		os.close();
		oos.close();
		socket.close();
			
	}
	
	
}
