package server;

import java.util.*;
import java.net.*;

public class Server{
	
	public static void main(String [] args) throws Exception{
		
		ServerSocket server = new ServerSocket(8080);
		ArrayList<ArrayList<String>> _alloperations = new ArrayList<ArrayList<String>>();
		
		while(true) {
			Socket client = server.accept();
			RequestHandler rh = new RequestHandler(client, _alloperations);
			rh.run();
		}
		
	}
}
