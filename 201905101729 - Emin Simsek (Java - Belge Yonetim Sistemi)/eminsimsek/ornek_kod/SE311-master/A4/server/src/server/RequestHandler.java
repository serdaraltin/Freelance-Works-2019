package server;

import java.io.*;
import java.net.*;
import java.util.*;

public class RequestHandler extends Server{
	private Socket clientSocket = null;
	private ArrayList<ArrayList<String>> alloperations = new ArrayList<ArrayList<String>>();
	public RequestHandler(Socket _clientSocket, ArrayList<ArrayList<String>> _alloperations) {
		
		clientSocket = _clientSocket;
		alloperations = _alloperations;
		
	}
	
	
	public void run() {
		
		
		try {
			
			InputStream is = clientSocket.getInputStream();
			ObjectInputStream ois = new ObjectInputStream(is);
			ArrayList<String> operations = (ArrayList<String>) ois.readObject();
			this.alloperations.add(operations);
			
			
			System.out.println("Total Number of Successful Math Equations: " + this.alloperations.size());
			
			for(ArrayList<String> operate : this.alloperations){
				for(String op : operate)
					System.out.print(" " + op );
				
				System.out.println("");
			}
			
		}
		catch(Exception e) { e.printStackTrace();}
		
	}	
	
	
}