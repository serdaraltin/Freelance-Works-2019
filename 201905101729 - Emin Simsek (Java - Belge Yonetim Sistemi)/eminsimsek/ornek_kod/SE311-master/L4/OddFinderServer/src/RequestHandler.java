import java.io.*;
import java.net.*;
import java.util.*;

public class RequestHandler extends Thread{
	private Socket clientSocket = null;
	
	public RequestHandler(Socket _clientSocket) { clientSocket = _clientSocket;}
	
	public void run() {
		try {
			
			
			InputStream is = clientSocket.getInputStream();
			ObjectInputStream ois = new ObjectInputStream(is);
			ArrayList<Integer> digits = (ArrayList<Integer>) ois.readObject();
			
			ArrayList<Integer> list = new ArrayList<Integer>();
			
			for(Integer number : digits) {
				if(number % 2  != 0) {
					list.add(number);
				}
			}
			
			OutputStream os = clientSocket.getOutputStream();
			ObjectOutputStream oos = new ObjectOutputStream(os);
			
			oos.writeObject(list);
			
		}
		catch(Exception e) { e.printStackTrace();}
		
	}	
	
	
}
