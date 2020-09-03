package edabalaban;

import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;

 public class Yonlendirme extends KeyAdapter{
 	
 		public void keyPressed(KeyEvent e){
 		    switch(e.getKeyCode()){
		    	case 39:	//sag
		    				if(Threadler.yilanYon !=2) 
		    					Threadler.yilanYon=1;
		    			  	break;
		    	case 38:	//yukari
							if(Threadler.yilanYon!=4) 
								Threadler.yilanYon=3;
		    				break;
		    				
		    	case 37: 	//sol
							if(Threadler.yilanYon!=1)
								Threadler.yilanYon=2;
		    				break;
		    				
		    	case 40:	//asagi
							if(Threadler.yilanYon!=3)
								Threadler.yilanYon=4;
		    				break;
		    	
		    	default: 	break;
 		    }
 		
 		}
 	
 }
